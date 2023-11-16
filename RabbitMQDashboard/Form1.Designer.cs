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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnDeleteQueue = new Button();
            btnCreateTopic = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            btnCreateQueue.Location = new Point(184, 79);
            btnCreateQueue.Name = "btnCreateQueue";
            btnCreateQueue.Size = new Size(122, 23);
            btnCreateQueue.TabIndex = 2;
            btnCreateQueue.Text = "Create";
            btnCreateQueue.UseVisualStyleBackColor = true;
            btnCreateQueue.Click += btnCreateQueue_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 28);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 45);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 28);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(460, 45);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 28);
            textBox3.TabIndex = 5;
            // 
            // btnDeleteQueue
            // 
            btnDeleteQueue.Location = new Point(321, 79);
            btnDeleteQueue.Name = "btnDeleteQueue";
            btnDeleteQueue.Size = new Size(122, 23);
            btnDeleteQueue.TabIndex = 6;
            btnDeleteQueue.Text = "Delete";
            btnDeleteQueue.UseVisualStyleBackColor = true;
            btnDeleteQueue.Click += btnDeleteQueue_Click;
            // 
            // btnCreateTopic
            // 
            btnCreateTopic.Location = new Point(460, 79);
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
            label1.Location = new Point(184, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Create Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 27);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 9;
            label2.Text = "Delete Queue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 27);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Create Topic";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 294);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateTopic);
            Controls.Add(btnDeleteQueue);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCreateQueue);
            Controls.Add(btnCreateConsumers);
            Controls.Add(btnCreateProducers);
            Name = "Form1";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateProducers;
        private Button btnCreateConsumers;
        private Button btnCreateQueue;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnDeleteQueue;
        private Button btnCreateTopic;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}