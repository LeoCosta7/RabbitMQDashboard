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

            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 2000;
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
            List<QueueInfo> queueInfos = RabbitMQManager.GetQueueInfos();

            foreach (QueueInfo queueInfo in queueInfos)
            {
                dataGridView.Rows.Add(queueInfo.Name, queueInfo.Messages);
            }
        }

        private void btnCreateProducers_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateConsumers_Click(object sender, EventArgs e)
        {

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
    }
}