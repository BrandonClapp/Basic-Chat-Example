namespace ChatClient
{
    partial class ChatForm
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
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.HostLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(12, 50);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(326, 248);
            this.ChatTextBox.TabIndex = 10;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(12, 24);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(118, 24);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(100, 20);
            this.HostTextBox.TabIndex = 2;
            this.HostTextBox.Text = "127.0.0.1";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(9, 8);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(35, 13);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Name";
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Location = new System.Drawing.Point(115, 8);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(29, 13);
            this.HostLabel.TabIndex = 4;
            this.HostLabel.Text = "Host";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(221, 9);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 5;
            this.PortLabel.Text = "Port";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(224, 24);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(32, 20);
            this.PortTextBox.TabIndex = 4;
            this.PortTextBox.Text = "8888";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(263, 20);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(13, 305);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(325, 20);
            this.SendTextBox.TabIndex = 11;
            this.SendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 338);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.HostLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.Name = "ChatForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox SendTextBox;
    }
}

