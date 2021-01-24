namespace CrocodileGame
{
    partial class FAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAuth));
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.ButNext = new System.Windows.Forms.Button();
            this.PictureBoxUserName = new System.Windows.Forms.PictureBox();
            this.LabEnterName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxUserName.Location = new System.Drawing.Point(169, 55);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(216, 30);
            this.TextBoxUserName.TabIndex = 3;
            // 
            // ButNext
            // 
            this.ButNext.BackColor = System.Drawing.Color.MistyRose;
            this.ButNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButNext.Location = new System.Drawing.Point(159, 121);
            this.ButNext.Name = "ButNext";
            this.ButNext.Size = new System.Drawing.Size(87, 38);
            this.ButNext.TabIndex = 4;
            this.ButNext.Text = "Next";
            this.ButNext.UseVisualStyleBackColor = false;
            this.ButNext.Click += new System.EventHandler(this.ButNext_Click);
            // 
            // PictureBoxUserName
            // 
            this.PictureBoxUserName.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxUserName.Image")));
            this.PictureBoxUserName.Location = new System.Drawing.Point(22, 12);
            this.PictureBoxUserName.Name = "PictureBoxUserName";
            this.PictureBoxUserName.Size = new System.Drawing.Size(112, 116);
            this.PictureBoxUserName.TabIndex = 5;
            this.PictureBoxUserName.TabStop = false;
            // 
            // LabEnterName
            // 
            this.LabEnterName.AutoSize = true;
            this.LabEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabEnterName.Location = new System.Drawing.Point(165, 21);
            this.LabEnterName.Name = "LabEnterName";
            this.LabEnterName.Size = new System.Drawing.Size(132, 20);
            this.LabEnterName.TabIndex = 6;
            this.LabEnterName.Text = "Enter your name";
            // 
            // FAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(411, 180);
            this.Controls.Add(this.LabEnterName);
            this.Controls.Add(this.PictureBoxUserName);
            this.Controls.Add(this.ButNext);
            this.Controls.Add(this.TextBoxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAuth";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Button ButNext;
        private System.Windows.Forms.PictureBox PictureBoxUserName;
        private System.Windows.Forms.Label LabEnterName;
    }
}

