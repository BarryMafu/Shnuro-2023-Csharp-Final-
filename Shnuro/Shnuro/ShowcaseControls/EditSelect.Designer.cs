namespace Shnuro.ShowcaseControls
{
    partial class EditSelect
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
            splitContainer1 = new SplitContainer();
            editSelectPackEntry1 = new CustomControls.EditSelectPackEntry();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbPackSearch = new TextBox();
            btnPackSearch = new Button();
            btnSongSearch = new Button();
            txbSongsSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(239, 70);
            btnBack.TabIndex = 10;
            btnBack.Text = "< BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(198, 275);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.Controls.Add(editSelectPackEntry1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Size = new Size(1700, 871);
            splitContainer1.SplitterDistance = 800;
            splitContainer1.TabIndex = 11;
            // 
            // editSelectPackEntry1
            // 
            editSelectPackEntry1.BackColor = Color.LightGray;
            editSelectPackEntry1.Location = new Point(27, 16);
            editSelectPackEntry1.Name = "editSelectPackEntry1";
            editSelectPackEntry1.Size = new Size(0, 0);
            editSelectPackEntry1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(660, 51);
            label1.Name = "label1";
            label1.Size = new Size(756, 72);
            label1.TabIndex = 12;
            label1.Text = "Please Select a Song to Edit";
            // 
            // label2
            // 
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Bell MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 152);
            label2.Name = "label2";
            label2.Size = new Size(800, 56);
            label2.TabIndex = 13;
            label2.Text = "Packs";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Bell MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1004, 152);
            label3.Name = "label3";
            label3.Size = new Size(894, 56);
            label3.TabIndex = 14;
            label3.Text = "Songs";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbPackSearch
            // 
            txbPackSearch.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbPackSearch.Location = new Point(198, 217);
            txbPackSearch.Name = "txbPackSearch";
            txbPackSearch.Size = new Size(615, 44);
            txbPackSearch.TabIndex = 15;
            // 
            // btnPackSearch
            // 
            btnPackSearch.Font = new Font("Bell MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPackSearch.Location = new Point(819, 215);
            btnPackSearch.Name = "btnPackSearch";
            btnPackSearch.Size = new Size(179, 49);
            btnPackSearch.TabIndex = 16;
            btnPackSearch.Text = "Search";
            btnPackSearch.UseVisualStyleBackColor = true;
            btnPackSearch.Click += btnPackSearch_Click;
            // 
            // btnSongSearch
            // 
            btnSongSearch.Font = new Font("Bell MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSongSearch.Location = new Point(1719, 215);
            btnSongSearch.Name = "btnSongSearch";
            btnSongSearch.Size = new Size(179, 49);
            btnSongSearch.TabIndex = 18;
            btnSongSearch.Text = "Search";
            btnSongSearch.UseVisualStyleBackColor = true;
            // 
            // txbSongsSearch
            // 
            txbSongsSearch.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbSongsSearch.Location = new Point(1004, 217);
            txbSongsSearch.Name = "txbSongsSearch";
            txbSongsSearch.Size = new Size(709, 44);
            txbSongsSearch.TabIndex = 17;
            // 
            // EditSelect
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSongSearch);
            Controls.Add(txbSongsSearch);
            Controls.Add(btnPackSearch);
            Controls.Add(txbPackSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(splitContainer1);
            Controls.Add(btnBack);
            Name = "EditSelect";
            Size = new Size(2000, 1200);
            Load += EditSelect_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CustomControls.EditSelectPackEntry editSelectPackEntry1;
        private TextBox txbPackSearch;
        private Button btnPackSearch;
        private Button btnSongSearch;
        private TextBox txbSongsSearch;
    }
}
