using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.View
{
    public partial class PDVTela : Form
    {
        public PDVTela()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PDVTela_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pastel_Click(object sender, EventArgs e)
        {
            string registrosPastel = "12";

            txb_Codigo.Text = registrosPastel;
        }

        private void btn_Coxinha_Click(object sender, EventArgs e)
        {
            string registrosCoxinha = "13";
            txb_Codigo.Text = registrosCoxinha;
        }
    }
}
