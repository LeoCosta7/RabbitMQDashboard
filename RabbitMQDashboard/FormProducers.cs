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
    public partial class Producer : Form
    {
        public string queueName = "AUX";

        public Producer()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MessageTextBox.Text))
                {
                    MessageBox.Show("Please enter a message.");
                    return;
                }

                IModel channel = RabbitMQManager.GetChannel();

                var message = MessageTextBox.Text;
                byte[] body = Encoding.UTF8.GetBytes(message);

                if (!string.IsNullOrEmpty(txtQueueSelected.Text))
                    SendMessageToQueue(channel, body);
                else if (!string.IsNullOrEmpty(txtExchangeName.Text) && !string.IsNullOrEmpty(txtRK.Text))
                    SendMessageToExchange(channel, body);
                else
                    MessageBox.Show("Choose a queue or a Topic to send.");

                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SendMessageToQueue(IModel channel, byte[] body)
        {
            channel.BasicPublish("", txtQueueSelected.Text, null, body);

        }

        private void SendMessageToExchange(IModel channel, byte[] body)
        {
            channel.BasicPublish(exchange: txtExchangeName.Text, routingKey: txtRK.Text, basicProperties: null, body: body);
        }
    }
}
