using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shnuro.UserControls
{
    public partial class StartInterface : UserControl
    {
        public StartInterface()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchTo(Form1.ControlEnum.LoginInterface);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchTo(Form1.ControlEnum.Settings);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchTo(Form1.ControlEnum.MusicPackSelect);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchTo(Form1.ControlEnum.EditSelect);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.Instance.Close();
        }
    }
}
