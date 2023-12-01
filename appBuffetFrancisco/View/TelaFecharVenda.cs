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
    public partial class TelaFecharVenda : Form
    {
        PDVTela tela;

        public TelaFecharVenda(PDVTela pDVTela)
        {
            InitializeComponent();

            tela = pDVTela;

            lbl_TotalFinal.Text = Convert.ToString(tela.totalfinal);

            for (int i = 0; i < tela.dataGridView_PDV.RowCount - 1; i++)
            {
                lbl_todos.Text += i + 1.ToString();
                lbl_todos.Text += "        " + tela.dataGridView_PDV.Rows[i].Cells[0].Value.ToString();
                lbl_todos.Text += "        " + tela.dataGridView_PDV.Rows[i].Cells[1].Value.ToString();
                lbl_todos.Text += "        " + tela.dataGridView_PDV.Rows[i].Cells[2].Value.ToString();
                lbl_todos.Text += "        " + tela.dataGridView_PDV.Rows[i].Cells[3].Value.ToString();
            }
            //listBox1.Items.Add(tela.dataGridView_PDV.Rows[0].Cells[0].Value.ToString());
        }

        private void TelaFecharVenda_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString();
        }
    }
}
