﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly
{
    public partial class ChangeFasilitasGym : Form
    {
        public ChangeFasilitasGym()
        {
            InitializeComponent();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            //Edit ini nanti tambahin prosenya
            this.Hide();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
