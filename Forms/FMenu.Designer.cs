namespace CrocodileGame
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.TextBoxIP = new System.Windows.Forms.TextBox();
            this.ButCreateServer = new System.Windows.Forms.Button();
            this.ButConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxServer = new System.Windows.Forms.PictureBox();
            this.PictureBoxConnection = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxIP.Location = new System.Drawing.Point(171, 44);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(193, 30);
            this.TextBoxIP.TabIndex = 0;
            this.TextBoxIP.TabStop = false;
            this.TextBoxIP.Text = "127.0.0.1";
            this.TextBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButCreateServer
            // 
            this.ButCreateServer.BackColor = System.Drawing.Color.MistyRose;
            this.ButCreateServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButCreateServer.Location = new System.Drawing.Point(40, 133);
            this.ButCreateServer.Name = "ButCreateServer";
            this.ButCreateServer.Size = new System.Drawing.Size(170, 61);
            this.ButCreateServer.TabIndex = 1;
            this.ButCreateServer.Text = "Create server";
            this.ButCreateServer.UseVisualStyleBackColor = false;
            this.ButCreateServer.Click += new System.EventHandler(this.ButCreateServer_Click);
            // 
            // ButConnect
            // 
            this.ButConnect.BackColor = System.Drawing.Color.MistyRose;
            this.ButConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButConnect.Location = new System.Drawing.Point(237, 255);
            this.ButConnect.Name = "ButConnect";
            this.ButConnect.Size = new System.Drawing.Size(170, 60);
            this.ButConnect.TabIndex = 2;
            this.ButConnect.Text = "Connect to server";
            this.ButConnect.UseVisualStyleBackColor = false;
            this.ButConnect.Click += new System.EventHandler(this.ButConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBoxServer
            // 
            this.PictureBoxServer.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxServer.Image")));
            this.PictureBoxServer.Location = new System.Drawing.Point(277, 107);
            this.PictureBoxServer.Name = "PictureBoxServer";
            this.PictureBoxServer.Size = new System.Drawing.Size(148, 104);
            this.PictureBoxServer.TabIndex = 4;
            this.PictureBoxServer.TabStop = false;
            // 
            // PictureBoxConnection
            // 
            this.PictureBoxConnection.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxConnection.Image")));
            this.PictureBoxConnection.Location = new System.Drawing.Point(40, 223);
            this.PictureBoxConnection.Name = "PictureBoxConnection";
            this.PictureBoxConnection.Size = new System.Drawing.Size(148, 112);
            this.PictureBoxConnection.TabIndex = 5;
            this.PictureBoxConnection.TabStop = false;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(437, 358);
            this.Controls.Add(this.PictureBoxConnection);
            this.Controls.Add(this.PictureBoxServer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButConnect);
            this.Controls.Add(this.ButCreateServer);
            this.Controls.Add(this.TextBoxIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIP;
        private System.Windows.Forms.Button ButCreateServer;
        private System.Windows.Forms.Button ButConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureBoxServer;
        private System.Windows.Forms.PictureBox PictureBoxConnection;
    }
}