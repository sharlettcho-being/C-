namespace Practice16_1_1 {
    partial class FForm {
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
            this.FButtonStart_Click = new System.Windows.Forms.Button();
            this.FTextBoxLoaded = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FButtonStart_Click
            // 
            this.FButtonStart_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FButtonStart_Click.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FButtonStart_Click.Location = new System.Drawing.Point(80, 47);
            this.FButtonStart_Click.Name = "FButtonStart_Click";
            this.FButtonStart_Click.Size = new System.Drawing.Size(152, 68);
            this.FButtonStart_Click.TabIndex = 0;
            this.FButtonStart_Click.Text = "クリック";
            this.FButtonStart_Click.UseVisualStyleBackColor = false;
            this.FButtonStart_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // FTextBoxLoaded
            // 
            this.FTextBoxLoaded.Location = new System.Drawing.Point(53, 145);
            this.FTextBoxLoaded.Multiline = true;
            this.FTextBoxLoaded.Name = "FTextBoxLoaded";
            this.FTextBoxLoaded.Size = new System.Drawing.Size(294, 354);
            this.FTextBoxLoaded.TabIndex = 1;
            // 
            // FForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 611);
            this.Controls.Add(this.FTextBoxLoaded);
            this.Controls.Add(this.FButtonStart_Click);
            this.Name = "FForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FButtonStart_Click;
        private System.Windows.Forms.TextBox FTextBoxLoaded;
    }
}

