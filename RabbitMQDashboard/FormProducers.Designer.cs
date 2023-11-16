namespace RabbitMQDashboard
{
    partial class FormProducers
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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 77);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 17;
            label2.Text = "Exchange Name";
            // 
            // txtExchangeName
            // 
            txtExchangeName.Location = new Point(20, 95);
            txtExchangeName.Name = "txtExchangeName";
            txtExchangeName.Size = new Size(135, 23);
            txtExchangeName.TabIndex = 16;
            // 
            // Key
            // 
            Key.AutoSize = true;
            Key.Location = new Point(20, 130);
            Key.Name = "Key";
            Key.Size = new Size(74, 15);
            Key.TabIndex = 15;
            Key.Text = "Routing Key ";
            // 
            // txtRK
            // 
            txtRK.Location = new Point(20, 148);
            txtRK.Name = "txtRK";
            txtRK.Size = new Size(135, 23);
            txtRK.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 13;
            label1.Text = "Choose Queue";
            // 
            // txtQueueSelected
            // 
            txtQueueSelected.Location = new Point(20, 32);
            txtQueueSelected.Multiline = true;
            txtQueueSelected.Name = "txtQueueSelected";
            txtQueueSelected.Size = new Size(135, 27);
            txtQueueSelected.TabIndex = 12;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(178, 32);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(177, 71);
            MessageTextBox.TabIndex = 19;
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location = new Point(178, 115);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(177, 56);
            btnSendMessage.TabIndex = 18;
            btnSendMessage.Text = "SendMessage";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // FormProducers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 200);
            Controls.Add(MessageTextBox);
            Controls.Add(btnSendMessage);
            Controls.Add(label2);
            Controls.Add(txtExchangeName);
            Controls.Add(Key);
            Controls.Add(txtRK);
            Controls.Add(label1);
            Controls.Add(txtQueueSelected);
            Name = "FormProducers";
            Text = "FormProducers";
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
    }
}