using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQDashboard.Util;
using System.Text;

namespace RabbitMQDashboard
{
    public partial class ConsumerTopic : Form
    {
        private IModel channel;
        private string queueName;

        public ConsumerTopic()
        {
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                channel = RabbitMQManager.GetChannel();
                queueName = GetQueueName();

                channel.QueueDeclare(queue: queueName, durable: true, exclusive: false, autoDelete: false);
                channel.QueueBind(queue: queueName, exchange: txtExchangeName.Text, routingKey: txtRK.Text);

                GetTopicMsg();
            }
            catch
            {
                MessageBox.Show("Topico inexistente");
            }
        }

        private string GetQueueName()
        {
            return channel.QueueDeclare().QueueName.Substring(4);
        }

        public void GetTopicMsg()
        {
            IModel channel = RabbitMQManager.GetChannel();

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body.ToArray());

                ReceiveTextBox.Invoke((Action)(() =>
                {
                    ReceiveTextBox.Text += message + Environment.NewLine;
                }));

            };

            channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
        }
    }
}
