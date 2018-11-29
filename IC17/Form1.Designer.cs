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
            this.showAndrewGBioBtn = new System.Windows.Forms.Button();
            this.dieuButton = new System.Windows.Forms.Button();
            this.ZhixinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // referenceLbl
            // 
            this.referenceLbl.AutoSize = true;
            this.referenceLbl.Location = new System.Drawing.Point(1040, 1002);
            this.referenceLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.referenceLbl.Name = "referenceLbl";
            this.referenceLbl.Size = new System.Drawing.Size(183, 32);
            this.referenceLbl.TabIndex = 0;
            this.referenceLbl.Text = "Front of room";
            // 
            // showAndrewGBioBtn
            // 
            this.showAndrewGBioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAndrewGBioBtn.Location = new System.Drawing.Point(24, 23);
            this.showAndrewGBioBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.showAndrewGBioBtn.Name = "showAndrewGBioBtn";
            this.showAndrewGBioBtn.Size = new System.Drawing.Size(238, 52);
            this.showAndrewGBioBtn.TabIndex = 1;
            this.showAndrewGBioBtn.Text = "Andrew G Bio";
            this.showAndrewGBioBtn.UseVisualStyleBackColor = true;
            this.showAndrewGBioBtn.Click += new System.EventHandler(this.andrewGBtn_Click);
            // 
            // dieuButton
            // 
            this.dieuButton.Location = new System.Drawing.Point(852, 730);
            this.dieuButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dieuButton.Name = "dieuButton";
            this.dieuButton.Size = new System.Drawing.Size(150, 45);
            this.dieuButton.TabIndex = 1;
            this.dieuButton.Text = "Dieu Dang";
            this.dieuButton.UseVisualStyleBackColor = true;
            this.dieuButton.Click += new System.EventHandler(this.dieuButton_Click);
            // 
            // ZhixinButton
            // 
            this.ZhixinButton.Location = new System.Drawing.Point(894, 35);
            this.ZhixinButton.Name = "ZhixinButton";
            this.ZhixinButton.Size = new System.Drawing.Size(141, 48);
            this.ZhixinButton.TabIndex = 2;
            this.ZhixinButton.Text = "Zhixin W";
            this.ZhixinButton.UseVisualStyleBackColor = true;
            this.ZhixinButton.Click += new System.EventHandler(this.ZhixinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 856);
            this.Controls.Add(this.ZhixinButton);
            this.Controls.Add(this.showAndrewGBioBtn);
            this.Controls.Add(this.dieuButton);
            this.Controls.Add(this.referenceLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Launch Page - Bios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label referenceLbl;
        private System.Windows.Forms.Button showAndrewGBioBtn;
        private System.Windows.Forms.Button dieuButton;
        private System.Windows.Forms.Button ZhixinButton;
    }
}

