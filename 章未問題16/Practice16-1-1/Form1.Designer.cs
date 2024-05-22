namespace Practice16_1_1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.FButtonStart = new System.Windows.Forms.Button();
            this.FTextBoxLoaded = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FButtonStart
            // 
            this.FButtonStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FButtonStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FButtonStart.Location = new System.Drawing.Point(80, 47);
            this.FButtonStart.Name = "FButtonStart";
            this.FButtonStart.Size = new System.Drawing.Size(152, 68);
            this.FButtonStart.TabIndex = 0;
            this.FButtonStart.Text = "クリック";
            this.FButtonStart.UseVisualStyleBackColor = false;
            this.FButtonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // FTextBoxLoaded
            // 
            this.FTextBoxLoaded.Location = new System.Drawing.Point(53, 145);
            this.FTextBoxLoaded.Multiline = true;
            this.FTextBoxLoaded.Name = "FTextBoxLoaded";
            this.FTextBoxLoaded.Size = new System.Drawing.Size(294, 354);
            this.FTextBoxLoaded.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 611);
            this.Controls.Add(this.FTextBoxLoaded);
            this.Controls.Add(this.FButtonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FButtonStart;
        private System.Windows.Forms.TextBox FTextBoxLoaded;
    }
}

