﻿using System;
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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchTo(Form1.ControlEnum.StartInterface);
        }
    }
}
