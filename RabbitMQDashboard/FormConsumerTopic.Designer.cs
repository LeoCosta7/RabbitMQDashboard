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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubscribe
            // 
            btnSubscribe.BackColor = SystemColors.Info;
            btnSubscribe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubscribe.ForeColor = SystemColors.ActiveCaptionText;
            btnSubscribe.Location = new Point(10, 124);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(157, 40);
            btnSubscribe.TabIndex = 19;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = false;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 18;
            label2.Text = "Exchange Name";
            // 
            // txtExchangeName
            // 
            txtExchangeName.Location = new Point(10, 25);
            txtExchangeName.Multiline = true;
            txtExchangeName.Name = "txtExchangeName";
            txtExchangeName.Size = new Size(157, 32);
            txtExchangeName.TabIndex = 17;
            // 
            // Key
            // 
            Key.AutoSize = true;
            Key.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Key.Location = new Point(10, 60);
            Key.Name = "Key";
            Key.Size = new Size(78, 15);
            Key.TabIndex = 16;
            Key.Text = "Routing Key ";
            // 
            // txtRK
            // 
            txtRK.Location = new Point(10, 78);
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSubscribe);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtExchangeName);
            panel1.Controls.Add(Key);
            panel1.Controls.Add(txtRK);
            panel1.Location = new Point(7, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 181);
            panel1.TabIndex = 20;
            // 
            // ConsumerTopic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(388, 202);
            Controls.Add(panel1);
            Controls.Add(ReceiveTextBox);
            Name = "ConsumerTopic";
            Text = "ConsumerTopic";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}