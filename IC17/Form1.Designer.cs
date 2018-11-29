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
            this.jessicaSheldonButton = new System.Windows.Forms.Button();
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
            // jessicaSheldonButton
            // 
            this.jessicaSheldonButton.Location = new System.Drawing.Point(1031, 477);
            this.jessicaSheldonButton.Name = "jessicaSheldonButton";
            this.jessicaSheldonButton.Size = new System.Drawing.Size(125, 78);
            this.jessicaSheldonButton.TabIndex = 1;
            this.jessicaSheldonButton.Text = "Jessica Sheldon";
            this.jessicaSheldonButton.UseVisualStyleBackColor = true;
            this.jessicaSheldonButton.Click += new System.EventHandler(this.jessicaSheldonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 680);
            this.Controls.Add(this.jessicaSheldonButton);
            this.Controls.Add(this.referenceLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Launch Page - Bios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label referenceLbl;
        private System.Windows.Forms.Button jessicaSheldonButton;
    }
}

