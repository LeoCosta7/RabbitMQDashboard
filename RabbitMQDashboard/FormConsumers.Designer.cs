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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubscribeTopic
            // 
            btnSubscribeTopic.BackColor = SystemColors.Info;
            btnSubscribeTopic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubscribeTopic.ForeColor = SystemColors.ActiveCaptionText;
            btnSubscribeTopic.Location = new Point(25, 173);
            btnSubscribeTopic.Name = "btnSubscribeTopic";
            btnSubscribeTopic.Size = new Size(161, 39);
            btnSubscribeTopic.TabIndex = 9;
            btnSubscribeTopic.Text = "Subscribe to a topic";
            btnSubscribeTopic.UseVisualStyleBackColor = false;
            btnSubscribeTopic.Click += btnSubscribeTopic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 7);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 8;
            label1.Text = "Choose a queue";
            // 
            // txtQueueSelected
            // 
            txtQueueSelected.Location = new Point(15, 25);
            txtQueueSelected.Multiline = true;
            txtQueueSelected.Name = "txtQueueSelected";
            txtQueueSelected.Size = new Size(157, 29);
            txtQueueSelected.TabIndex = 7;
            // 
            // ReceiveTextBox
            // 
            ReceiveTextBox.Location = new Point(209, 21);
            ReceiveTextBox.Multiline = true;
            ReceiveTextBox.Name = "ReceiveTextBox";
            ReceiveTextBox.Size = new Size(169, 211);
            ReceiveTextBox.TabIndex = 6;
            // 
            // btnReceiveMessage
            // 
            btnReceiveMessage.BackColor = SystemColors.Info;
            btnReceiveMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReceiveMessage.ForeColor = SystemColors.ActiveCaptionText;
            btnReceiveMessage.Location = new Point(11, 70);
            btnReceiveMessage.Name = "btnReceiveMessage";
            btnReceiveMessage.Size = new Size(161, 39);
            btnReceiveMessage.TabIndex = 5;
            btnReceiveMessage.Text = "ReceiveMessage";
            btnReceiveMessage.UseVisualStyleBackColor = false;
            btnReceiveMessage.Click += btnReceiveMessage_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtQueueSelected);
            panel1.Controls.Add(btnReceiveMessage);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 120);
            panel1.TabIndex = 10;
            // 
            // Consumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(390, 244);
            Controls.Add(panel1);
            Controls.Add(btnSubscribeTopic);
            Controls.Add(ReceiveTextBox);
            Name = "Consumer";
            Text = "Consumers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubscribeTopic;
        private Label label1;
        private TextBox txtQueueSelected;
        private TextBox ReceiveTextBox;
        private Button btnReceiveMessage;
        private Panel panel1;
    }
}