namespace iTunesAutoMinimized
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.timer_iTunesMinimize = new System.Windows.Forms.Timer(this.components);
            this.timer_MainClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_iTunesMinimize
            // 
            this.timer_iTunesMinimize.Enabled = true;
            this.timer_iTunesMinimize.Interval = 1000;
            this.timer_iTunesMinimize.Tick += new System.EventHandler(this.timer_iTunesMinimize_Tick);
            // 
            // timer_MainClose
            // 
            this.timer_MainClose.Interval = 180000;
            this.timer_MainClose.Tick += new System.EventHandler(this.timer_MainClose_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "iTunesAutoMinimized";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_iTunesMinimize;
        private System.Windows.Forms.Timer timer_MainClose;
    }
}

