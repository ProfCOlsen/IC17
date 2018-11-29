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
            this.jKellyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // referenceLbl
            // 
            this.referenceLbl.AutoSize = true;
            this.referenceLbl.Location = new System.Drawing.Point(567, 648);
            this.referenceLbl.Name = "referenceLbl";
            this.referenceLbl.Size = new System.Drawing.Size(132, 20);
            this.referenceLbl.TabIndex = 0;
            this.referenceLbl.Text = "Front of the room";
            // 
            // jKellyButton
            // 
            this.jKellyButton.Location = new System.Drawing.Point(535, 245);
            this.jKellyButton.Name = "jKellyButton";
            this.jKellyButton.Size = new System.Drawing.Size(35, 23);
            this.jKellyButton.TabIndex = 1;
            this.jKellyButton.Text = "Click Me!";
            this.jKellyButton.UseVisualStyleBackColor = true;
            this.jKellyButton.Click += new System.EventHandler(this.jKellyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 544);
            this.Controls.Add(this.jKellyButton);
            this.Controls.Add(this.referenceLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Launch Page - Bios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label referenceLbl;
        private System.Windows.Forms.Button jKellyButton;
    }
}

