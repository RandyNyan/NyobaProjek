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
    public partial class AddFasilitasGym : Form
    {
        public AddFasilitasGym()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FasilitasGym fasilitas_gym = new FasilitasGym();

            this.Hide();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
