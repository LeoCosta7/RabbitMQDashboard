namespace RabbitMQDashboard
{
    partial class Consumer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubscribeTopic = new Button();
            label1 = new Label();
            txtQueueSelected = new TextBox();
            ReceiveTextBox = new TextBox();
            btnReceiveMessage = new Button();
            SuspendLayout();
            // 
            // btnSubscribeTopic
            // 
            btnSubscribeTopic.Location = new Point(10, 187);
            btnSubscribeTopic.Name = "btnSubscribeTopic";
            btnSubscribeTopic.Size = new Size(161, 39);
            btnSubscribeTopic.TabIndex = 9;
            btnSubscribeTopic.Text = "Subscribe to a topic";
            btnSubscribeTopic.UseVisualStyleBackColor = true;
            btnSubscribeTopic.Click += btnSubscribeTopic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 8;
            label1.Text = "Choose a queue";
            // 
            // txtQueueSelected
            // 
            txtQueueSelected.Location = new Point(14, 33);
            txtQueueSelected.Multiline = true;
            txtQueueSelected.Name = "txtQueueSelected";
            txtQueueSelected.Size = new Size(157, 29);
            txtQueueSelected.TabIndex = 7;
            // 
            // ReceiveTextBox
            // 
            ReceiveTextBox.Location = new Point(199, 15);
            ReceiveTextBox.Multiline = true;
            ReceiveTextBox.Name = "ReceiveTextBox";
            ReceiveTextBox.Size = new Size(169, 211);
            ReceiveTextBox.TabIndex = 6;
            // 
            // btnReceiveMessage
            // 
            btnReceiveMessage.Location = new Point(10, 78);
            btnReceiveMessage.Name = "btnReceiveMessage";
            btnReceiveMessage.Size = new Size(161, 39);
            btnReceiveMessage.TabIndex = 5;
            btnReceiveMessage.Text = "ReceiveMessage";
            btnReceiveMessage.UseVisualStyleBackColor = true;
            btnReceiveMessage.Click += btnReceiveMessage_Click;
            // 
            // Consumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 238);
            Controls.Add(btnSubscribeTopic);
            Controls.Add(label1);
            Controls.Add(txtQueueSelected);
            Controls.Add(ReceiveTextBox);
            Controls.Add(btnReceiveMessage);
            Name = "Consumer";
            Text = "Consumers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubscribeTopic;
        private Label label1;
        private TextBox txtQueueSelected;
        private TextBox ReceiveTextBox;
        private Button btnReceiveMessage;
    }
}