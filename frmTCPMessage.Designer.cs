namespace TCPMessage
{
    partial class frmMessagTCP
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxSend = new System.Windows.Forms.TextBox();
            this.tbxReceived = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbxIpAdress = new System.Windows.Forms.TextBox();
            this.btnSetIp = new System.Windows.Forms.Button();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxSend
            // 
            this.tbxSend.Location = new System.Drawing.Point(12, 12);
            this.tbxSend.Multiline = true;
            this.tbxSend.Name = "tbxSend";
            this.tbxSend.Size = new System.Drawing.Size(629, 170);
            this.tbxSend.TabIndex = 0;
            // 
            // tbxReceived
            // 
            this.tbxReceived.Location = new System.Drawing.Point(12, 241);
            this.tbxReceived.Multiline = true;
            this.tbxReceived.Name = "tbxReceived";
            this.tbxReceived.ReadOnly = true;
            this.tbxReceived.Size = new System.Drawing.Size(629, 197);
            this.tbxReceived.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 188);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(629, 47);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbxIpAdress
            // 
            this.tbxIpAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIpAdress.Location = new System.Drawing.Point(647, 365);
            this.tbxIpAdress.Name = "tbxIpAdress";
            this.tbxIpAdress.Size = new System.Drawing.Size(404, 29);
            this.tbxIpAdress.TabIndex = 3;
            this.tbxIpAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetIp
            // 
            this.btnSetIp.Location = new System.Drawing.Point(647, 400);
            this.btnSetIp.Name = "btnSetIp";
            this.btnSetIp.Size = new System.Drawing.Size(404, 38);
            this.btnSetIp.TabIndex = 4;
            this.btnSetIp.Text = "Set Ip";
            this.btnSetIp.UseVisualStyleBackColor = true;
            this.btnSetIp.Click += new System.EventHandler(this.btnSetIp_Click);
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(647, 31);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(404, 328);
            this.tbxLog.TabIndex = 5;
            this.tbxLog.TextChanged += new System.EventHandler(this.tbxLog_TextChanged);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(644, 12);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(30, 16);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "Log";
            // 
            // frmMessagTCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.btnSetIp);
            this.Controls.Add(this.tbxIpAdress);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxReceived);
            this.Controls.Add(this.tbxSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMessagTCP";
            this.Text = "Message TCP";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbxSend;
        private System.Windows.Forms.TextBox tbxReceived;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbxIpAdress;
        private System.Windows.Forms.Button btnSetIp;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Label lblLog;
    }
}

