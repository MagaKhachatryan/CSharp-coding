namespace Chat
{
    partial class Chat
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
            this.listMessage = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textSendMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupMe = new System.Windows.Forms.GroupBox();
            this.textPortMe = new System.Windows.Forms.TextBox();
            this.textIpMe = new System.Windows.Forms.TextBox();
            this.labelPortMe = new System.Windows.Forms.Label();
            this.labelIpMe = new System.Windows.Forms.Label();
            this.groupFriend = new System.Windows.Forms.GroupBox();
            this.textPortFriend = new System.Windows.Forms.TextBox();
            this.textIpFriend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupMe.SuspendLayout();
            this.groupFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(11, 122);
            this.listMessage.Margin = new System.Windows.Forms.Padding(2);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(577, 238);
            this.listMessage.TabIndex = 18;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(379, -45);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(80, 37);
            this.buttonConnect.TabIndex = 17;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // textSendMessage
            // 
            this.textSendMessage.Location = new System.Drawing.Point(11, 380);
            this.textSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textSendMessage.Multiline = true;
            this.textSendMessage.Name = "textSendMessage";
            this.textSendMessage.Size = new System.Drawing.Size(480, 36);
            this.textSendMessage.TabIndex = 16;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.Location = new System.Drawing.Point(508, 380);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(80, 36);
            this.buttonSend.TabIndex = 14;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupMe
            // 
            this.groupMe.Controls.Add(this.textPortMe);
            this.groupMe.Controls.Add(this.textIpMe);
            this.groupMe.Controls.Add(this.labelPortMe);
            this.groupMe.Controls.Add(this.labelIpMe);
            this.groupMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupMe.Location = new System.Drawing.Point(11, 11);
            this.groupMe.Margin = new System.Windows.Forms.Padding(2);
            this.groupMe.Name = "groupMe";
            this.groupMe.Padding = new System.Windows.Forms.Padding(2);
            this.groupMe.Size = new System.Drawing.Size(202, 81);
            this.groupMe.TabIndex = 19;
            this.groupMe.TabStop = false;
            this.groupMe.Text = "Me";
            // 
            // textPortMe
            // 
            this.textPortMe.Location = new System.Drawing.Point(81, 46);
            this.textPortMe.Margin = new System.Windows.Forms.Padding(2);
            this.textPortMe.Multiline = true;
            this.textPortMe.Name = "textPortMe";
            this.textPortMe.Size = new System.Drawing.Size(118, 23);
            this.textPortMe.TabIndex = 6;
            // 
            // textIpMe
            // 
            this.textIpMe.Location = new System.Drawing.Point(80, 18);
            this.textIpMe.Margin = new System.Windows.Forms.Padding(2);
            this.textIpMe.Multiline = true;
            this.textIpMe.Name = "textIpMe";
            this.textIpMe.Size = new System.Drawing.Size(118, 24);
            this.textIpMe.TabIndex = 5;
            // 
            // labelPortMe
            // 
            this.labelPortMe.AutoSize = true;
            this.labelPortMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPortMe.Location = new System.Drawing.Point(4, 49);
            this.labelPortMe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPortMe.Name = "labelPortMe";
            this.labelPortMe.Size = new System.Drawing.Size(34, 17);
            this.labelPortMe.TabIndex = 1;
            this.labelPortMe.Text = "Port";
            // 
            // labelIpMe
            // 
            this.labelIpMe.AutoSize = true;
            this.labelIpMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIpMe.Location = new System.Drawing.Point(4, 19);
            this.labelIpMe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIpMe.Name = "labelIpMe";
            this.labelIpMe.Size = new System.Drawing.Size(18, 15);
            this.labelIpMe.TabIndex = 0;
            this.labelIpMe.Text = "IP";
            // 
            // groupFriend
            // 
            this.groupFriend.Controls.Add(this.textPortFriend);
            this.groupFriend.Controls.Add(this.textIpFriend);
            this.groupFriend.Controls.Add(this.label1);
            this.groupFriend.Controls.Add(this.label2);
            this.groupFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupFriend.Location = new System.Drawing.Point(232, 11);
            this.groupFriend.Margin = new System.Windows.Forms.Padding(2);
            this.groupFriend.Name = "groupFriend";
            this.groupFriend.Padding = new System.Windows.Forms.Padding(2);
            this.groupFriend.Size = new System.Drawing.Size(202, 81);
            this.groupFriend.TabIndex = 20;
            this.groupFriend.TabStop = false;
            this.groupFriend.Text = "Friend";
            // 
            // textPortFriend
            // 
            this.textPortFriend.Location = new System.Drawing.Point(81, 46);
            this.textPortFriend.Margin = new System.Windows.Forms.Padding(2);
            this.textPortFriend.Multiline = true;
            this.textPortFriend.Name = "textPortFriend";
            this.textPortFriend.Size = new System.Drawing.Size(118, 23);
            this.textPortFriend.TabIndex = 6;
            // 
            // textIpFriend
            // 
            this.textIpFriend.Location = new System.Drawing.Point(81, 19);
            this.textIpFriend.Margin = new System.Windows.Forms.Padding(2);
            this.textIpFriend.Multiline = true;
            this.textIpFriend.Name = "textIpFriend";
            this.textIpFriend.Size = new System.Drawing.Size(118, 24);
            this.textIpFriend.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(497, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupFriend);
            this.Controls.Add(this.groupMe);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textSendMessage);
            this.Controls.Add(this.buttonSend);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.groupMe.ResumeLayout(false);
            this.groupMe.PerformLayout();
            this.groupFriend.ResumeLayout(false);
            this.groupFriend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textSendMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupMe;
        private System.Windows.Forms.TextBox textPortMe;
        private System.Windows.Forms.TextBox textIpMe;
        private System.Windows.Forms.Label labelPortMe;
        private System.Windows.Forms.Label labelIpMe;
        private System.Windows.Forms.GroupBox groupFriend;
        private System.Windows.Forms.TextBox textPortFriend;
        private System.Windows.Forms.TextBox textIpFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

