using Shnuro.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shnuro.ShowcaseControls
{
    public partial class EditSelect : UserControl
    {
        public EditSelect()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchTo(Form1.ControlEnum.StartInterface);
        }

        private void EditSelect_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            int cnt = 0;
            string sql = "select * from SongPackGuide where 1=1";
            Helpers.SQLHelper.AddSqlWhere(ref sql, "PackName", "like", txbPackSearch.Text);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, Form1.Instance.connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            splitContainer1.Panel1.Controls.Clear();
            foreach (DataTable t in dataSet.Tables)
            {
                foreach (DataRow r in t.Rows)
                {
                    EditSelectPackEntry entry = new EditSelectPackEntry();
                    Rectangle rect = splitContainer1.Panel1.DisplayRectangle;
                    entry.Location = new Point(15 + rect.X, 15 + rect.Y + cnt * 110);
                    entry.SetInfos(r);
                    splitContainer1.Panel1.Controls.Add(entry);
                    cnt++;
                }
            }
        }

        private void btnPackSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
