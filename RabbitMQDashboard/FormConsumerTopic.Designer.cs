namespace RabbitMQDashboard
{
    partial class ConsumerTopic
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
            btnSubscribe = new Button();
            label2 = new Label();
            txtExchangeName = new TextBox();
            Key = new Label();
            txtRK = new TextBox();
            ReceiveTextBox = new TextBox();
            SuspendLayout();
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(17, 135);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(157, 40);
            btnSubscribe.TabIndex = 19;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 18;
            label2.Text = "Exchange Name";
            // 
            // txtExchangeName
            // 
            txtExchangeName.Location = new Point(17, 36);
            txtExchangeName.Multiline = true;
            txtExchangeName.Name = "txtExchangeName";
            txtExchangeName.Size = new Size(157, 32);
            txtExchangeName.TabIndex = 17;
            // 
            // Key
            // 
            Key.AutoSize = true;
            Key.Location = new Point(17, 71);
            Key.Name = "Key";
            Key.Size = new Size(74, 15);
            Key.TabIndex = 16;
            Key.Text = "Routing Key ";
            // 
            // txtRK
            // 
            txtRK.Location = new Point(17, 89);
            txtRK.Multiline = true;
            txtRK.Name = "txtRK";
            txtRK.Size = new Size(157, 29);
            txtRK.TabIndex = 15;
            // 
            // ReceiveTextBox
            // 
            ReceiveTextBox.Location = new Point(195, 18);
            ReceiveTextBox.Multiline = true;
            ReceiveTextBox.Name = "ReceiveTextBox";
            ReceiveTextBox.Size = new Size(173, 165);
            ReceiveTextBox.TabIndex = 14;
            // 
            // ConsumerTopic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 202);
            Controls.Add(btnSubscribe);
            Controls.Add(label2);
            Controls.Add(txtExchangeName);
            Controls.Add(Key);
            Controls.Add(txtRK);
            Controls.Add(ReceiveTextBox);
            Name = "ConsumerTopic";
            Text = "ConsumerTopic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubscribe;
        private Label label2;
        private TextBox txtExchangeName;
        private Label Key;
        private TextBox txtRK;
        private TextBox ReceiveTextBox;
    }
}