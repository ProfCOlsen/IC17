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
            this.samVaccaroButton = new System.Windows.Forms.Button();
            this.AngelWongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // samVaccaroButton
            // 
            this.samVaccaroButton.Location = new System.Drawing.Point(118, 251);
            this.samVaccaroButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.samVaccaroButton.Name = "samVaccaroButton";
            this.samVaccaroButton.Size = new System.Drawing.Size(132, 35);
            this.samVaccaroButton.TabIndex = 0;
            this.samVaccaroButton.Text = "Sam Vaccaro";
            this.samVaccaroButton.UseVisualStyleBackColor = true;
            this.samVaccaroButton.Click += new System.EventHandler(this.samVaccaroButton_Click);
            // 
            // AngelWongButton
            // 
            this.AngelWongButton.Location = new System.Drawing.Point(1104, 98);
            this.AngelWongButton.Name = "AngelWongButton";
            this.AngelWongButton.Size = new System.Drawing.Size(93, 34);
            this.AngelWongButton.TabIndex = 1;
            this.AngelWongButton.Text = "Angel";
            this.AngelWongButton.UseVisualStyleBackColor = true;
            this.AngelWongButton.Click += new System.EventHandler(this.AngelWongButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 680);
            this.Controls.Add(this.AngelWongButton);
            this.Controls.Add(this.samVaccaroButton);
            this.Name = "Form1";
            this.Text = "Launch Page - Bios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button samVaccaroButton;
        private System.Windows.Forms.Button AngelWongButton;
    }
}

