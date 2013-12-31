namespace trayset
{
    partial class TrayControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayControl));
            this.TrayOpenButton = new System.Windows.Forms.Button();
            this.TrayCloseButton = new System.Windows.Forms.Button();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrayOpenButton
            // 
            this.TrayOpenButton.Location = new System.Drawing.Point(39, 110);
            this.TrayOpenButton.Name = "TrayOpenButton";
            this.TrayOpenButton.Size = new System.Drawing.Size(85, 59);
            this.TrayOpenButton.TabIndex = 0;
            this.TrayOpenButton.Text = "あける！";
            this.TrayOpenButton.UseVisualStyleBackColor = true;
            this.TrayOpenButton.Click += new System.EventHandler(this.TrayOpenButton_Click);
            // 
            // TrayCloseButton
            // 
            this.TrayCloseButton.Location = new System.Drawing.Point(236, 110);
            this.TrayCloseButton.Name = "TrayCloseButton";
            this.TrayCloseButton.Size = new System.Drawing.Size(81, 59);
            this.TrayCloseButton.TabIndex = 1;
            this.TrayCloseButton.Text = "しめる！";
            this.TrayCloseButton.UseVisualStyleBackColor = true;
            this.TrayCloseButton.Click += new System.EventHandler(this.TrayCloseButton_Click);
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IntroLabel.Location = new System.Drawing.Point(100, 40);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(159, 15);
            this.IntroLabel.TabIndex = 2;
            this.IntroLabel.Text = "CDトレイをいじっちゃうよ！";
            // 
            // TrayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 217);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.TrayCloseButton);
            this.Controls.Add(this.TrayOpenButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrayControl";
            this.Text = "とれいひらくかくしきのう";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrayOpenButton;
        private System.Windows.Forms.Button TrayCloseButton;
        private System.Windows.Forms.Label IntroLabel;
    }
}