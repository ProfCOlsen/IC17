namespace IC17
{
    partial class Form1
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
            this.referenceLbl = new System.Windows.Forms.Label();
            this.dieuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // referenceLbl
            // 
            this.referenceLbl.AutoSize = true;
            this.referenceLbl.Location = new System.Drawing.Point(390, 420);
            this.referenceLbl.Name = "referenceLbl";
            this.referenceLbl.Size = new System.Drawing.Size(69, 13);
            this.referenceLbl.TabIndex = 0;
            this.referenceLbl.Text = "Front of room";
            // 
            // dieuButton
            // 
            this.dieuButton.Location = new System.Drawing.Point(426, 377);
            this.dieuButton.Name = "dieuButton";
            this.dieuButton.Size = new System.Drawing.Size(75, 23);
            this.dieuButton.TabIndex = 1;
            this.dieuButton.Text = "Dieu Dang";
            this.dieuButton.UseVisualStyleBackColor = true;
            this.dieuButton.Click += new System.EventHandler(this.dieuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 442);
            this.Controls.Add(this.dieuButton);
            this.Controls.Add(this.referenceLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Launch Page - Bios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label referenceLbl;
        private System.Windows.Forms.Button dieuButton;
    }
}

