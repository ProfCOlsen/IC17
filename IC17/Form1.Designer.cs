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
            this.sanjanaBtn = new System.Windows.Forms.Button();
            this.chrisGBioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // referenceLbl
            // 
            this.referenceLbl.AutoSize = true;
            this.referenceLbl.Location = new System.Drawing.Point(780, 808);
            this.referenceLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.referenceLbl.Name = "referenceLbl";
            this.referenceLbl.Size = new System.Drawing.Size(140, 25);
            this.referenceLbl.TabIndex = 0;
            this.referenceLbl.Text = "Front of room";
            // 
            // showAndrewGBioBtn
            // 
            this.showAndrewGBioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAndrewGBioBtn.Location = new System.Drawing.Point(18, 19);
            this.showAndrewGBioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAndrewGBioBtn.Name = "showAndrewGBioBtn";
            this.showAndrewGBioBtn.Size = new System.Drawing.Size(178, 42);
            this.showAndrewGBioBtn.TabIndex = 1;
            this.showAndrewGBioBtn.Text = "Andrew G Bio";
            this.showAndrewGBioBtn.UseVisualStyleBackColor = true;
            this.showAndrewGBioBtn.Click += new System.EventHandler(this.andrewGBtn_Click);
            // 
            // dieuButton
            // 
            this.dieuButton.Location = new System.Drawing.Point(639, 589);
            this.dieuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dieuButton.Name = "dieuButton";
            this.dieuButton.Size = new System.Drawing.Size(112, 36);
            this.dieuButton.TabIndex = 1;
            this.dieuButton.Text = "Dieu Dang";
            this.dieuButton.UseVisualStyleBackColor = true;
            this.dieuButton.Click += new System.EventHandler(this.dieuButton_Click);
            // 
            // ZhixinButton
            // 
            this.ZhixinButton.Location = new System.Drawing.Point(670, 28);
            this.ZhixinButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZhixinButton.Name = "ZhixinButton";
            this.ZhixinButton.Size = new System.Drawing.Size(106, 39);
            this.ZhixinButton.TabIndex = 2;
            this.ZhixinButton.Text = "Zhixin W";
            this.ZhixinButton.UseVisualStyleBackColor = true;
            this.ZhixinButton.Click += new System.EventHandler(this.ZhixinButton_Click);
            // 
            // sanjanaBtn
            // 
            this.sanjanaBtn.Location = new System.Drawing.Point(468, 327);
            this.sanjanaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sanjanaBtn.Name = "sanjanaBtn";
            this.sanjanaBtn.Size = new System.Drawing.Size(127, 38);
            this.sanjanaBtn.TabIndex = 3;
            this.sanjanaBtn.Text = "Sanjana";
            this.sanjanaBtn.UseVisualStyleBackColor = true;
            this.sanjanaBtn.Click += new System.EventHandler(this.sanjanaBtn_Click);
            // 
            // chrisGBioButton
            // 
            this.chrisGBioButton.Location = new System.Drawing.Point(928, 327);
            this.chrisGBioButton.Name = "chrisGBioButton";
            this.chrisGBioButton.Size = new System.Drawing.Size(136, 38);
            this.chrisGBioButton.TabIndex = 4;
            this.chrisGBioButton.Text = "Chris G Bio";
            this.chrisGBioButton.UseVisualStyleBackColor = true;
            this.chrisGBioButton.Click += new System.EventHandler(this.chrisGBioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 777);
            this.Controls.Add(this.chrisGBioButton);
            this.Controls.Add(this.sanjanaBtn);
            this.Controls.Add(this.ZhixinButton);
            this.Controls.Add(this.showAndrewGBioBtn);
            this.Controls.Add(this.dieuButton);
            this.Controls.Add(this.referenceLbl);
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
        private System.Windows.Forms.Button sanjanaBtn;
        private System.Windows.Forms.Button chrisGBioButton;
    }
}

