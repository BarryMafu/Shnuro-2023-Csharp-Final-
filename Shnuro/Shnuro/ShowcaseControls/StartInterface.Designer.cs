namespace Shnuro.ShowcaseControls
{
    partial class StartInterface
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle_eng = new Label();
            lbTitle_chn = new Label();
            btnLogin = new Button();
            btnEdit = new Button();
            btnPlay = new Button();
            btnSettings = new Button();
            lbVersion = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbTitle_eng
            // 
            lbTitle_eng.AutoSize = true;
            lbTitle_eng.Font = new Font("Baskerville Old Face", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle_eng.Location = new Point(250, 398);
            lbTitle_eng.Name = "lbTitle_eng";
            lbTitle_eng.Size = new Size(492, 164);
            lbTitle_eng.TabIndex = 0;
            lbTitle_eng.Text = "Shnuro";
            lbTitle_eng.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTitle_chn
            // 
            lbTitle_chn.AutoSize = true;
            lbTitle_chn.Font = new Font("华文中宋", 56F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle_chn.Location = new Point(300, 591);
            lbTitle_chn.Name = "lbTitle_chn";
            lbTitle_chn.Size = new Size(393, 127);
            lbTitle_chn.TabIndex = 1;
            lbTitle_chn.Text = "凝·弦";
            lbTitle_chn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(814, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(553, 108);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Italic, GraphicsUnit.Point);
            btnEdit.Location = new Point(977, 610);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(553, 108);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Italic, GraphicsUnit.Point);
            btnPlay.Location = new Point(977, 407);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(553, 108);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Italic, GraphicsUnit.Point);
            btnSettings.Location = new Point(814, 816);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(553, 108);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbVersion.ForeColor = Color.Gray;
            lbVersion.ImageAlign = ContentAlignment.BottomCenter;
            lbVersion.Location = new Point(1801, 1117);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(182, 64);
            lbVersion.TabIndex = 6;
            lbVersion.Text = "Version 0.0.0\r\nCopyright\r\n";
            lbVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.LightCyan;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Azure;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(0, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(239, 70);
            btnExit.TabIndex = 7;
            btnExit.Text = "< EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // StartInterface
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExit);
            Controls.Add(lbVersion);
            Controls.Add(btnSettings);
            Controls.Add(btnPlay);
            Controls.Add(btnEdit);
            Controls.Add(btnLogin);
            Controls.Add(lbTitle_chn);
            Controls.Add(lbTitle_eng);
            Name = "StartInterface";
            Size = new Size(2000, 1200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle_eng;
        private Label lbTitle_chn;
        private Button btnLogin;
        private Button btnEdit;
        private Button btnPlay;
        private Button btnSettings;
        private Label lbVersion;
        private Button btnExit;
    }
}
