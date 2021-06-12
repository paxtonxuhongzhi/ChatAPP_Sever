namespace TCPSever
{
    partial class TCPSever
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartTCPListen = new System.Windows.Forms.Button();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.SendBotton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartTCPListen
            // 
            this.StartTCPListen.Location = new System.Drawing.Point(3, 3);
            this.StartTCPListen.Name = "StartTCPListen";
            this.StartTCPListen.Size = new System.Drawing.Size(75, 23);
            this.StartTCPListen.TabIndex = 0;
            this.StartTCPListen.Text = "开始监听";
            this.StartTCPListen.UseVisualStyleBackColor = true;
            this.StartTCPListen.Click += new System.EventHandler(this.StartTCPListen_Click);
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.Location = new System.Drawing.Point(1, 32);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.Size = new System.Drawing.Size(800, 283);
            this.ReceiveTextBox.TabIndex = 1;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(122, 17);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(0, 12);
            this.State.TabIndex = 2;
            // 
            // SendBotton
            // 
            this.SendBotton.Location = new System.Drawing.Point(514, 321);
            this.SendBotton.Name = "SendBotton";
            this.SendBotton.Size = new System.Drawing.Size(75, 23);
            this.SendBotton.TabIndex = 3;
            this.SendBotton.Text = "发送";
            this.SendBotton.UseVisualStyleBackColor = true;
            this.SendBotton.Click += new System.EventHandler(this.SendBotton_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(1, 321);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(507, 130);
            this.SendTextBox.TabIndex = 4;
            this.SendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // TCPSever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.SendBotton);
            this.Controls.Add(this.State);
            this.Controls.Add(this.ReceiveTextBox);
            this.Controls.Add(this.StartTCPListen);
            this.Name = "TCPSever";
            this.Text = "TCPSever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartTCPListen;
        private System.Windows.Forms.TextBox ReceiveTextBox;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Button SendBotton;
        private System.Windows.Forms.TextBox SendTextBox;
    }
}

