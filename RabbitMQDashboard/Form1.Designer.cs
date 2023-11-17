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
            label4 = new Label();
            btnDeleteTopic = new Button();
            txtDeleteExchangeName = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            QueueName = new DataGridViewTextBoxColumn();
            Ready = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateProducers
            // 
            btnCreateProducers.BackColor = SystemColors.Info;
            btnCreateProducers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateProducers.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateProducers.Location = new Point(4, 9);
            btnCreateProducers.Name = "btnCreateProducers";
            btnCreateProducers.Size = new Size(119, 58);
            btnCreateProducers.TabIndex = 0;
            btnCreateProducers.Text = "Producers";
            btnCreateProducers.UseVisualStyleBackColor = false;
            btnCreateProducers.Click += btnCreateProducers_Click;
            // 
            // btnCreateConsumers
            // 
            btnCreateConsumers.BackColor = SystemColors.Info;
            btnCreateConsumers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateConsumers.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateConsumers.Location = new Point(4, 73);
            btnCreateConsumers.Name = "btnCreateConsumers";
            btnCreateConsumers.Size = new Size(119, 58);
            btnCreateConsumers.TabIndex = 1;
            btnCreateConsumers.Text = "Consumers ";
            btnCreateConsumers.UseVisualStyleBackColor = false;
            btnCreateConsumers.Click += btnCreateConsumers_Click;
            // 
            // btnCreateQueue
            // 
            btnCreateQueue.BackColor = SystemColors.Info;
            btnCreateQueue.Location = new Point(6, 57);
            btnCreateQueue.Name = "btnCreateQueue";
            btnCreateQueue.Size = new Size(122, 23);
            btnCreateQueue.TabIndex = 2;
            btnCreateQueue.Text = "Create";
            btnCreateQueue.UseVisualStyleBackColor = false;
            btnCreateQueue.Click += btnCreateQueue_Click;
            // 
            // txtCreateQueueName
            // 
            txtCreateQueueName.Location = new Point(6, 23);
            txtCreateQueueName.Multiline = true;
            txtCreateQueueName.Name = "txtCreateQueueName";
            txtCreateQueueName.Size = new Size(122, 28);
            txtCreateQueueName.TabIndex = 3;
            // 
            // txtDeleteQueueName
            // 
            txtDeleteQueueName.Location = new Point(143, 23);
            txtDeleteQueueName.Multiline = true;
            txtDeleteQueueName.Name = "txtDeleteQueueName";
            txtDeleteQueueName.Size = new Size(122, 28);
            txtDeleteQueueName.TabIndex = 4;
            // 
            // txtCreateExchangeName
            // 
            txtCreateExchangeName.Location = new Point(282, 23);
            txtCreateExchangeName.Multiline = true;
            txtCreateExchangeName.Name = "txtCreateExchangeName";
            txtCreateExchangeName.Size = new Size(122, 28);
            txtCreateExchangeName.TabIndex = 5;
            // 
            // btnDeleteQueue
            // 
            btnDeleteQueue.BackColor = SystemColors.Info;
            btnDeleteQueue.Location = new Point(143, 57);
            btnDeleteQueue.Name = "btnDeleteQueue";
            btnDeleteQueue.Size = new Size(122, 23);
            btnDeleteQueue.TabIndex = 6;
            btnDeleteQueue.Text = "Delete";
            btnDeleteQueue.UseVisualStyleBackColor = false;
            btnDeleteQueue.Click += btnDeleteQueue_Click;
            // 
            // btnCreateTopic
            // 
            btnCreateTopic.BackColor = SystemColors.Info;
            btnCreateTopic.Location = new Point(282, 57);
            btnCreateTopic.Name = "btnCreateTopic";
            btnCreateTopic.Size = new Size(122, 23);
            btnCreateTopic.TabIndex = 7;
            btnCreateTopic.Text = "Create";
            btnCreateTopic.UseVisualStyleBackColor = false;
            btnCreateTopic.Click += btnCreateTopic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "Create Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 5);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 9;
            label2.Text = "Delete Queue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(282, 5);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 10;
            label3.Text = "Create Topic";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { QueueName, Ready });
            dataGridView.Location = new Point(17, 113);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(539, 181);
            dataGridView.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(425, 5);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 14;
            label4.Text = "Delete Topic";
            // 
            // btnDeleteTopic
            // 
            btnDeleteTopic.BackColor = SystemColors.Info;
            btnDeleteTopic.Location = new Point(425, 57);
            btnDeleteTopic.Name = "btnDeleteTopic";
            btnDeleteTopic.Size = new Size(122, 23);
            btnDeleteTopic.TabIndex = 13;
            btnDeleteTopic.Text = "Delete";
            btnDeleteTopic.UseVisualStyleBackColor = false;
            btnDeleteTopic.Click += btnDeleteTopic_Click;
            // 
            // txtDeleteExchangeName
            // 
            txtDeleteExchangeName.Location = new Point(425, 23);
            txtDeleteExchangeName.Multiline = true;
            txtDeleteExchangeName.Name = "txtDeleteExchangeName";
            txtDeleteExchangeName.Size = new Size(122, 28);
            txtDeleteExchangeName.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(148, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 303);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnDeleteTopic);
            panel2.Controls.Add(txtDeleteExchangeName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCreateTopic);
            panel2.Controls.Add(btnDeleteQueue);
            panel2.Controls.Add(txtCreateExchangeName);
            panel2.Controls.Add(txtDeleteQueueName);
            panel2.Controls.Add(txtCreateQueueName);
            panel2.Controls.Add(btnCreateQueue);
            panel2.Location = new Point(9, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 87);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnCreateConsumers);
            panel3.Controls.Add(btnCreateProducers);
            panel3.Location = new Point(4, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 142);
            panel3.TabIndex = 16;
            // 
            // QueueName
            // 
            QueueName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QueueName.HeaderText = "Name";
            QueueName.Name = "QueueName";
            // 
            // Ready
            // 
            Ready.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ready.HeaderText = "Ready";
            Ready.Name = "Ready";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(726, 313);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label label4;
        private Button btnDeleteTopic;
        private TextBox txtDeleteExchangeName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn QueueName;
        private DataGridViewTextBoxColumn Ready;
    }
}