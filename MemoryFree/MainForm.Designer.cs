namespace MemoryFree
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FreeButton = new System.Windows.Forms.Button();
            this.TermBox = new System.Windows.Forms.TextBox();
            this.BeforeBox = new System.Windows.Forms.TextBox();
            this.AfterBox = new System.Windows.Forms.TextBox();
            this.ArrowLabel = new System.Windows.Forms.Label();
            this.ProcessIdButton = new System.Windows.Forms.Button();
            this.TaskNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FreeButton
            // 
            this.FreeButton.Location = new System.Drawing.Point(12, 145);
            this.FreeButton.Name = "FreeButton";
            this.FreeButton.Size = new System.Drawing.Size(91, 23);
            this.FreeButton.TabIndex = 0;
            this.FreeButton.Text = "ぜんかいほー！";
            this.FreeButton.UseVisualStyleBackColor = true;
            this.FreeButton.Click += new System.EventHandler(this.FreeButton_Click);
            // 
            // TermBox
            // 
            this.TermBox.BackColor = System.Drawing.Color.White;
            this.TermBox.Location = new System.Drawing.Point(-1, -1);
            this.TermBox.Multiline = true;
            this.TermBox.Name = "TermBox";
            this.TermBox.ReadOnly = true;
            this.TermBox.Size = new System.Drawing.Size(409, 79);
            this.TermBox.TabIndex = 1;
            // 
            // BeforeBox
            // 
            this.BeforeBox.BackColor = System.Drawing.Color.White;
            this.BeforeBox.Location = new System.Drawing.Point(124, 99);
            this.BeforeBox.Multiline = true;
            this.BeforeBox.Name = "BeforeBox";
            this.BeforeBox.ReadOnly = true;
            this.BeforeBox.Size = new System.Drawing.Size(100, 56);
            this.BeforeBox.TabIndex = 2;
            // 
            // AfterBox
            // 
            this.AfterBox.BackColor = System.Drawing.Color.White;
            this.AfterBox.Location = new System.Drawing.Point(270, 99);
            this.AfterBox.Multiline = true;
            this.AfterBox.Name = "AfterBox";
            this.AfterBox.ReadOnly = true;
            this.AfterBox.Size = new System.Drawing.Size(100, 56);
            this.AfterBox.TabIndex = 3;
            // 
            // ArrowLabel
            // 
            this.ArrowLabel.AutoSize = true;
            this.ArrowLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ArrowLabel.Location = new System.Drawing.Point(230, 131);
            this.ArrowLabel.Name = "ArrowLabel";
            this.ArrowLabel.Size = new System.Drawing.Size(34, 24);
            this.ArrowLabel.TabIndex = 4;
            this.ArrowLabel.Text = "→";
            // 
            // ProcessIdButton
            // 
            this.ProcessIdButton.Location = new System.Drawing.Point(12, 116);
            this.ProcessIdButton.Name = "ProcessIdButton";
            this.ProcessIdButton.Size = new System.Drawing.Size(91, 23);
            this.ProcessIdButton.TabIndex = 5;
            this.ProcessIdButton.Text = "ぷろせすあいでぃー";
            this.ProcessIdButton.UseVisualStyleBackColor = true;
            this.ProcessIdButton.Click += new System.EventHandler(this.ProcessIdButton_Click);
            // 
            // TaskNameButton
            // 
            this.TaskNameButton.Location = new System.Drawing.Point(12, 87);
            this.TaskNameButton.Name = "TaskNameButton";
            this.TaskNameButton.Size = new System.Drawing.Size(91, 23);
            this.TaskNameButton.TabIndex = 6;
            this.TaskNameButton.Text = "いめーじめい";
            this.TaskNameButton.UseVisualStyleBackColor = true;
            this.TaskNameButton.Click += new System.EventHandler(this.TaskNameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 180);
            this.Controls.Add(this.TaskNameButton);
            this.Controls.Add(this.ProcessIdButton);
            this.Controls.Add(this.ArrowLabel);
            this.Controls.Add(this.AfterBox);
            this.Controls.Add(this.BeforeBox);
            this.Controls.Add(this.TermBox);
            this.Controls.Add(this.FreeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "めもりかいほー！";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FreeButton;
        private System.Windows.Forms.TextBox TermBox;
        private System.Windows.Forms.TextBox BeforeBox;
        private System.Windows.Forms.TextBox AfterBox;
        private System.Windows.Forms.Label ArrowLabel;
        private System.Windows.Forms.Button ProcessIdButton;
        private System.Windows.Forms.Button TaskNameButton;

    }
}

