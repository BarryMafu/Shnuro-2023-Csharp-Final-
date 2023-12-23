using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shnuro.CustomControls
{
    public partial class EditSelectPackEntry : UserControl
    {
        public event EventHandler? DoubleSelect;
        public EditSelectPackEntry()
        {
            InitializeComponent();
        }

        public void SetInfos(DataRow r)
        {
            if (r == null) { return; }
            if (r["PackName"] != null)
            {
                lbName.Text = r["PackName"].ToString();
            }
            if (r["Description"] != null)
            {
                lbDescription.Text = r["Description"].ToString();
            }
            if (r["SongsCount"] != null)
            {
                lbSongsCount.Text = r["SongsCount"].ToString();
            }
        }
    }
}
