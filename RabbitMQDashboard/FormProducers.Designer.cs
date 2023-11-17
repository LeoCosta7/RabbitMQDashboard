namespace RabbitMQDashboard
{
    partial class Producer
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
            label2 = new Label();
            txtExchangeName = new TextBox();
            Key = new Label();
            txtRK = new TextBox();
            label1 = new Label();
            txtQueueSelected = new TextBox();
            MessageTextBox = new TextBox();
            btnSendMessage = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 70);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 17;
            label2.Text = "Exchange Name";
            // 
            // txtExchangeName
            // 
            txtExchangeName.Location = new Point(13, 88);
            txtExchangeName.Name = "txtExchangeName";
            txtExchangeName.Size = new Size(135, 23);
            txtExchangeName.TabIndex = 16;
            // 
            // Key
            // 
            Key.AutoSize = true;
            Key.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Key.Location = new Point(13, 123);
            Key.Name = "Key";
            Key.Size = new Size(78, 15);
            Key.TabIndex = 15;
            Key.Text = "Routing Key ";
            // 
            // txtRK
            // 
            txtRK.Location = new Point(13, 141);
            txtRK.Name = "txtRK";
            txtRK.Size = new Size(135, 23);
            txtRK.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 13;
            label1.Text = "Choose Queue";
            // 
            // txtQueueSelected
            // 
            txtQueueSelected.Location = new Point(13, 25);
            txtQueueSelected.Multiline = true;
            txtQueueSelected.Name = "txtQueueSelected";
            txtQueueSelected.Size = new Size(135, 27);
            txtQueueSelected.TabIndex = 12;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(190, 28);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(177, 71);
            MessageTextBox.TabIndex = 19;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = SystemColors.Info;
            btnSendMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendMessage.Location = new Point(190, 111);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(177, 56);
            btnSendMessage.TabIndex = 18;
            btnSendMessage.Text = "SendMessage";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtExchangeName);
            panel1.Controls.Add(Key);
            panel1.Controls.Add(txtRK);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtQueueSelected);
            panel1.Location = new Point(7, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 178);
            panel1.TabIndex = 20;
            // 
            // Producer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(379, 200);
            Controls.Add(panel1);
            Controls.Add(MessageTextBox);
            Controls.Add(btnSendMessage);
            Name = "Producer";
            Text = "Producers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtExchangeName;
        private Label Key;
        private TextBox txtRK;
        private Label label1;
        private TextBox txtQueueSelected;
        private TextBox MessageTextBox;
        private Button btnSendMessage;
        private Panel panel1;
    }
}