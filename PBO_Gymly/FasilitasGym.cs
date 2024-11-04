using System;
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
    public partial class FasilitasGym : Form
    {
        public FasilitasGym()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();

            homepage.Show();

            this.Hide();
        }

        private void ButtonAddFasilitasGym_Click(object sender, EventArgs e)
        {
            AddFasilitasGym addfasilitasgym = new AddFasilitasGym();

            addfasilitasgym.Show();
        }
    }
}
