using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shnuro.ShowcaseControls
{
    public partial class LoginInterface : UserControl
    {
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchTo(Form1.ControlEnum.StartInterface);
        }
    }
}
