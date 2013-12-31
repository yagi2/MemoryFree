namespace emerge
{
    partial class TaskName
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskName));
            this.ReturnButton = new System.Windows.Forms.Button();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.TaskNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(134, 110);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "OK";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IntroLabel.Location = new System.Drawing.Point(78, 20);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(173, 15);
            this.IntroLabel.TabIndex = 1;
            this.IntroLabel.Text = "イメージ名を入力してください";
            // 
            // TaskNameBox
            // 
            this.TaskNameBox.Location = new System.Drawing.Point(64, 62);
            this.TaskNameBox.Name = "TaskNameBox";
            this.TaskNameBox.Size = new System.Drawing.Size(207, 19);
            this.TaskNameBox.TabIndex = 2;
            // 
            // TaskName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 145);
            this.Controls.Add(this.TaskNameBox);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.ReturnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskName";
            this.Text = "いめーじめいしてい";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label IntroLabel;
        public System.Windows.Forms.TextBox TaskNameBox;
    }
}