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
            this.label1 = new System.Windows.Forms.Label();
            this.tylerSharpButton = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Front of the Class";
            // 
            // tylerSharpButton
            // 
            this.tylerSharpButton.Location = new System.Drawing.Point(656, 88);
            this.tylerSharpButton.Name = "tylerSharpButton";
            this.tylerSharpButton.Size = new System.Drawing.Size(111, 39);
            this.tylerSharpButton.TabIndex = 3;
            this.tylerSharpButton.Text = "Tyler Sharp";
            this.tylerSharpButton.UseVisualStyleBackColor = true;
            this.tylerSharpButton.Click += new System.EventHandler(this.tylerSharpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 717);
            this.Controls.Add(this.tylerSharpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AngelWongButton);
            this.Controls.Add(this.samVaccaroButton);
            this.Name = "Form1";
            this.Text = "Launch Page - Bios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button samVaccaroButton;
        private System.Windows.Forms.Button AngelWongButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tylerSharpButton;
    }
}

