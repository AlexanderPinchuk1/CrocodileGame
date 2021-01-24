namespace CrocodileGame.Forms
{
    partial class FWordСhoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWordСhoice));
            this.LabWordChoice = new System.Windows.Forms.Label();
            this.ButFirstVariant = new System.Windows.Forms.Button();
            this.ButSecondVariant = new System.Windows.Forms.Button();
            this.ButThirdVariant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabWordChoice
            // 
            this.LabWordChoice.AutoSize = true;
            this.LabWordChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabWordChoice.Location = new System.Drawing.Point(83, 36);
            this.LabWordChoice.Name = "LabWordChoice";
            this.LabWordChoice.Size = new System.Drawing.Size(281, 29);
            this.LabWordChoice.TabIndex = 0;
            this.LabWordChoice.Text = "Сhoose one of the words";
            // 
            // ButFirstVariant
            // 
            this.ButFirstVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButFirstVariant.Location = new System.Drawing.Point(147, 88);
            this.ButFirstVariant.Name = "ButFirstVariant";
            this.ButFirstVariant.Size = new System.Drawing.Size(150, 35);
            this.ButFirstVariant.TabIndex = 1;
            this.ButFirstVariant.UseVisualStyleBackColor = true;
            this.ButFirstVariant.Click += new System.EventHandler(this.ButFirstVariant_Click);
            // 
            // ButSecondVariant
            // 
            this.ButSecondVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSecondVariant.Location = new System.Drawing.Point(147, 149);
            this.ButSecondVariant.Name = "ButSecondVariant";
            this.ButSecondVariant.Size = new System.Drawing.Size(150, 35);
            this.ButSecondVariant.TabIndex = 2;
            this.ButSecondVariant.UseVisualStyleBackColor = true;
            this.ButSecondVariant.Click += new System.EventHandler(this.ButSecondVariant_Click);
            // 
            // ButThirdVariant
            // 
            this.ButThirdVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButThirdVariant.Location = new System.Drawing.Point(147, 211);
            this.ButThirdVariant.Name = "ButThirdVariant";
            this.ButThirdVariant.Size = new System.Drawing.Size(150, 35);
            this.ButThirdVariant.TabIndex = 3;
            this.ButThirdVariant.UseVisualStyleBackColor = true;
            this.ButThirdVariant.Click += new System.EventHandler(this.ButThirdVariant_Click);
            // 
            // FWordСhoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(464, 288);
            this.Controls.Add(this.ButThirdVariant);
            this.Controls.Add(this.ButSecondVariant);
            this.Controls.Add(this.ButFirstVariant);
            this.Controls.Add(this.LabWordChoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FWordСhoice";
            this.Text = "Word choice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FWordСhoice_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabWordChoice;
        private System.Windows.Forms.Button ButFirstVariant;
        private System.Windows.Forms.Button ButSecondVariant;
        private System.Windows.Forms.Button ButThirdVariant;
    }
}