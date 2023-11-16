namespace RabbitMQDashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateProducers = new Button();
            btnCreateConsumers = new Button();
            btnCreateQueue = new Button();
            txtCreateQueueName = new TextBox();
            txtDeleteQueueName = new TextBox();
            txtCreateExchangeName = new TextBox();
            btnDeleteQueue = new Button();
            btnCreateTopic = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            QueueName = new DataGridViewTextBoxColumn();
            Ready = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnDeleteTopic = new Button();
            txtDeleteExchangeName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnCreateProducers
            // 
            btnCreateProducers.Location = new Point(8, 15);
            btnCreateProducers.Name = "btnCreateProducers";
            btnCreateProducers.Size = new Size(119, 58);
            btnCreateProducers.TabIndex = 0;
            btnCreateProducers.Text = "Producers";
            btnCreateProducers.UseVisualStyleBackColor = true;
            btnCreateProducers.Click += btnCreateProducers_Click;
            // 
            // btnCreateConsumers
            // 
            btnCreateConsumers.Location = new Point(8, 79);
            btnCreateConsumers.Name = "btnCreateConsumers";
            btnCreateConsumers.Size = new Size(119, 58);
            btnCreateConsumers.TabIndex = 1;
            btnCreateConsumers.Text = "Consumers ";
            btnCreateConsumers.UseVisualStyleBackColor = true;
            btnCreateConsumers.Click += btnCreateConsumers_Click;
            // 
            // btnCreateQueue
            // 
            btnCreateQueue.Location = new Point(163, 67);
            btnCreateQueue.Name = "btnCreateQueue";
            btnCreateQueue.Size = new Size(122, 23);
            btnCreateQueue.TabIndex = 2;
            btnCreateQueue.Text = "Create";
            btnCreateQueue.UseVisualStyleBackColor = true;
            btnCreateQueue.Click += btnCreateQueue_Click;
            // 
            // txtCreateQueueName
            // 
            txtCreateQueueName.Location = new Point(163, 33);
            txtCreateQueueName.Multiline = true;
            txtCreateQueueName.Name = "txtCreateQueueName";
            txtCreateQueueName.Size = new Size(122, 28);
            txtCreateQueueName.TabIndex = 3;
            // 
            // txtDeleteQueueName
            // 
            txtDeleteQueueName.Location = new Point(300, 33);
            txtDeleteQueueName.Multiline = true;
            txtDeleteQueueName.Name = "txtDeleteQueueName";
            txtDeleteQueueName.Size = new Size(122, 28);
            txtDeleteQueueName.TabIndex = 4;
            // 
            // txtCreateExchangeName
            // 
            txtCreateExchangeName.Location = new Point(439, 33);
            txtCreateExchangeName.Multiline = true;
            txtCreateExchangeName.Name = "txtCreateExchangeName";
            txtCreateExchangeName.Size = new Size(122, 28);
            txtCreateExchangeName.TabIndex = 5;
            // 
            // btnDeleteQueue
            // 
            btnDeleteQueue.Location = new Point(300, 67);
            btnDeleteQueue.Name = "btnDeleteQueue";
            btnDeleteQueue.Size = new Size(122, 23);
            btnDeleteQueue.TabIndex = 6;
            btnDeleteQueue.Text = "Delete";
            btnDeleteQueue.UseVisualStyleBackColor = true;
            btnDeleteQueue.Click += btnDeleteQueue_Click;
            // 
            // btnCreateTopic
            // 
            btnCreateTopic.Location = new Point(439, 67);
            btnCreateTopic.Name = "btnCreateTopic";
            btnCreateTopic.Size = new Size(122, 23);
            btnCreateTopic.TabIndex = 7;
            btnCreateTopic.Text = "Create";
            btnCreateTopic.UseVisualStyleBackColor = true;
            btnCreateTopic.Click += btnCreateTopic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Create Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 15);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 9;
            label2.Text = "Delete Queue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 15);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Create Topic";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { QueueName, Ready });
            dataGridView.Location = new Point(165, 120);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(524, 181);
            dataGridView.TabIndex = 11;
            // 
            // QueueName
            // 
            QueueName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QueueName.HeaderText = "QueueName";
            QueueName.Name = "QueueName";
            // 
            // Ready
            // 
            Ready.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ready.HeaderText = "Ready";
            Ready.Name = "Ready";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 15);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 14;
            label4.Text = "Delete Topic";
            // 
            // btnDeleteTopic
            // 
            btnDeleteTopic.Location = new Point(582, 67);
            btnDeleteTopic.Name = "btnDeleteTopic";
            btnDeleteTopic.Size = new Size(122, 23);
            btnDeleteTopic.TabIndex = 13;
            btnDeleteTopic.Text = "Delete";
            btnDeleteTopic.UseVisualStyleBackColor = true;
            btnDeleteTopic.Click += btnDeleteTopic_Click;
            // 
            // txtDeleteExchangeName
            // 
            txtDeleteExchangeName.Location = new Point(582, 33);
            txtDeleteExchangeName.Multiline = true;
            txtDeleteExchangeName.Name = "txtDeleteExchangeName";
            txtDeleteExchangeName.Size = new Size(122, 28);
            txtDeleteExchangeName.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 313);
            Controls.Add(label4);
            Controls.Add(btnDeleteTopic);
            Controls.Add(txtDeleteExchangeName);
            Controls.Add(dataGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateTopic);
            Controls.Add(btnDeleteQueue);
            Controls.Add(txtCreateExchangeName);
            Controls.Add(txtDeleteQueueName);
            Controls.Add(txtCreateQueueName);
            Controls.Add(btnCreateQueue);
            Controls.Add(btnCreateConsumers);
            Controls.Add(btnCreateProducers);
            Name = "Form1";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateProducers;
        private Button btnCreateConsumers;
        private Button btnCreateQueue;
        private TextBox txtCreateQueueName;
        private TextBox txtDeleteQueueName;
        private TextBox txtCreateExchangeName;
        private Button btnDeleteQueue;
        private Button btnCreateTopic;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn QueueName;
        private DataGridViewTextBoxColumn Ready;
        private Label label4;
        private Button btnDeleteTopic;
        private TextBox txtDeleteExchangeName;
    }
}