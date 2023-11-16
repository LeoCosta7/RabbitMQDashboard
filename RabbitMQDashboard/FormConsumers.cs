using RabbitMQ.Client;
using RabbitMQDashboard.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQDashboard
{
    public partial class Consumer : Form
    {
        public string queueName = "AUX";

        public Consumer()
        {
            InitializeComponent();
        }

        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtQueueSelected.Text))
                    GetQueueMsg();
                else
                    MessageBox.Show("Escolha uma fila para consultar.");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetQueueMsg()
        {
            IModel channel = RabbitMQManager.GetChannel();

            BasicGetResult result = channel.BasicGet(txtQueueSelected.Text, true);

            if (result == null)
            {
                MessageBox.Show("Sem mensagens");
                return;
            }

            string message = Encoding.UTF8.GetString(result.Body.ToArray());

            ReceiveTextBox.Text += message + Environment.NewLine;
        }

        private void btnSubscribeTopic_Click(object sender, EventArgs e)
        {
            ConsumerTopic consumerTopic = new ConsumerTopic();
            consumerTopic.Show();
        }
    }
}
