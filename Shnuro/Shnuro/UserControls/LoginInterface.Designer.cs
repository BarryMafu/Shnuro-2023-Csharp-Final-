namespace Shnuro.UserControls
{
    partial class LoginInterface
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
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.LightCyan;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Azure;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(239, 70);
            btnBack.TabIndex = 8;
            btnBack.Text = "< BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 70F, FontStyle.Regular, GraphicsUnit.Point);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(438, 78);
            label1.Name = "label1";
            label1.Size = new Size(1078, 181);
            label1.TabIndex = 9;
            label1.Text = "Login Interface";
            // 
            // LoginInterface
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "LoginInterface";
            Size = new Size(2000, 1200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
    }
}
