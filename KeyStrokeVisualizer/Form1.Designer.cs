namespace KeyStrokeVisualizer
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.ricktxt_log = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_key_per_sec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightCoral;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_exit.ForeColor = System.Drawing.Color.Snow;
            this.btn_exit.Location = new System.Drawing.Point(239, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 29);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "×";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ricktxt_log
            // 
            this.ricktxt_log.BackColor = System.Drawing.SystemColors.InfoText;
            this.ricktxt_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ricktxt_log.Font = new System.Drawing.Font("ノスタルドット（M+）", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ricktxt_log.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ricktxt_log.Location = new System.Drawing.Point(14, 12);
            this.ricktxt_log.Multiline = false;
            this.ricktxt_log.Name = "ricktxt_log";
            this.ricktxt_log.ReadOnly = true;
            this.ricktxt_log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ricktxt_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.ricktxt_log.Size = new System.Drawing.Size(206, 62);
            this.ricktxt_log.TabIndex = 3;
            this.ricktxt_log.Text = "";
            this.ricktxt_log.TextChanged += new System.EventHandler(this.ricktxt_log_TextChanged);
            this.ricktxt_log.Enter += new System.EventHandler(this.ricktxt_log_Enter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("ノスタルドット（M+）", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 4;
            // 
            // label_key_per_sec
            // 
            this.label_key_per_sec.AutoSize = true;
            this.label_key_per_sec.Font = new System.Drawing.Font("ノスタルドット（M+）", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_key_per_sec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_key_per_sec.Location = new System.Drawing.Point(195, 77);
            this.label_key_per_sec.Name = "label_key_per_sec";
            this.label_key_per_sec.Size = new System.Drawing.Size(59, 21);
            this.label_key_per_sec.TabIndex = 5;
            this.label_key_per_sec.Text = "0 KPS";
            this.label_key_per_sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(266, 134);
            this.ControlBox = false;
            this.Controls.Add(this.label_key_per_sec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ricktxt_log);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RichTextBox ricktxt_log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_key_per_sec;
    }
}

