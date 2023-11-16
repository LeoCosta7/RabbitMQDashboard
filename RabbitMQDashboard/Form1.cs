using RabbitMQDashboard.Data;
using RabbitMQDashboard.Util;

namespace RabbitMQDashboard
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer updateTimer;

        public Form1()
        {
            InitializeComponent();

            Infos();

            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 4000;
            updateTimer.Tick += new EventHandler(UpdateTimer_Tick);
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();      // Limpa
            Infos();                        // Atualiza
        }

        private void Infos()
        {
            List<QueueInfo> queueInfos = RabbitMQManager.GetInfos<QueueInfo>("http://localhost:15672/api/queues");
            List<ExchangeInfo> exchangeInfo = RabbitMQManager.GetInfos<ExchangeInfo>("http://localhost:15672/api/exchanges");

            var combinedList = queueInfos.Select(q => new ResourceInfo { Name = q.Name, Messages = q.Messages })
               .Concat(exchangeInfo.Select(e => new ResourceInfo { Name = e.Name }))
               .ToList();

            foreach (ResourceInfo Infos in combinedList)
            {
                dataGridView.Rows.Add(Infos.Name, Infos.Messages);
            }
        }

        private void btnCreateProducers_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.Show();
        }

        private void btnCreateConsumers_Click(object sender, EventArgs e)
        {
            Consumer consumer = new Consumer();
            consumer.Show();
        }

        private void btnCreateQueue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCreateQueueName.Text))
            {
                RabbitMQManager.CreateQueue(txtCreateQueueName.Text);
                txtCreateQueueName.Text = "";
            }
            else
                MessageBox.Show("Digite a fila a ser criada.");
        }

        private void btnDeleteQueue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDeleteQueueName.Text))
            {
                RabbitMQManager.DeleteQueue(txtDeleteQueueName.Text);
                txtDeleteQueueName.Text = "";
            }
            else
                MessageBox.Show("Escolha uma fila para deletar");
        }

        private void btnCreateTopic_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCreateExchangeName.Text))
            {
                RabbitMQManager.CreateExchange(txtCreateExchangeName.Text);
                txtCreateExchangeName.Text = "";
            }
            else
                MessageBox.Show("Digite um tópico a ser criado.");
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDeleteExchangeName.Text))
            {
                RabbitMQManager.DeleteExchange(txtDeleteExchangeName.Text);
                txtCreateExchangeName.Text = "";
            }
            else
                MessageBox.Show("Digite um tópico a ser deletador.");
        }
    }
}