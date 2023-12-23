namespace Shnuro.CustomControls
{
    partial class EditSelectPackEntry
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
            button1 = new Button();
            ptbCover = new PictureBox();
            lbSongsCount = new Label();
            lbName = new Label();
            lbDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbCover).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(750, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // ptbCover
            // 
            ptbCover.Location = new Point(36, 10);
            ptbCover.Name = "ptbCover";
            ptbCover.Size = new Size(80, 80);
            ptbCover.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCover.TabIndex = 1;
            ptbCover.TabStop = false;
            // 
            // lbSongsCount
            // 
            lbSongsCount.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbSongsCount.Location = new Point(635, 25);
            lbSongsCount.Name = "lbSongsCount";
            lbSongsCount.Size = new Size(95, 51);
            lbSongsCount.TabIndex = 2;
            lbSongsCount.Text = "3";
            lbSongsCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbName
            // 
            lbName.Font = new Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(155, 16);
            lbName.Name = "lbName";
            lbName.Size = new Size(474, 41);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            // 
            // lbDescription
            // 
            lbDescription.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescription.Location = new Point(159, 59);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(470, 24);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "this is description";
            // 
            // EditSelectPackEntry
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            Controls.Add(lbDescription);
            Controls.Add(lbName);
            Controls.Add(lbSongsCount);
            Controls.Add(ptbCover);
            Controls.Add(button1);
            Name = "EditSelectPackEntry";
            Size = new Size(750, 100);
            ((System.ComponentModel.ISupportInitialize)ptbCover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox ptbCover;
        private Label lbSongsCount;
        private Label lbName;
        private Label lbDescription;
    }
}
