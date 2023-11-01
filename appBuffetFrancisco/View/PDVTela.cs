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
        int totalfinal = 0;

        public PDVTela()
        {
            InitializeComponent();
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

        private void btn_Esfiha_Click(object sender, EventArgs e)
        {
            string registrosEsfiha = "14";
            txb_Codigo.Text = registrosEsfiha;
        }

        private void btn_BolinhoQueijo_Click(object sender, EventArgs e)
        {
            string registrosBolinhaQueijo = "15";
            txb_Codigo.Text = registrosBolinhaQueijo;
        }

        private void btn_Sucos_Click(object sender, EventArgs e)
        {
            string registrosSucos = "16";
            txb_Codigo.Text = registrosSucos;
        }

        private void btn_Refri_Click(object sender, EventArgs e)
        {
            string registrosRefri = "17";
            txb_Codigo.Text = registrosRefri;
        }

        private void btn_cafe_Click(object sender, EventArgs e)
        {
            string registrosCafe = "18";
            txb_Codigo.Text = registrosCafe;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txb_Codigo.Text);
            int qtd = ((int)numUpDown_Qtd.Value);


            string[] itens = { "Pastel", "Coxinha", "Esfiha", "Bolinho de Queijo", "Sucos", "Refrigerante", "Café" };
            int[] valor = { 8, 8, 8, 8, 12, 10, 15 };

            int total = qtd * valor[codigo - 12];

            totalfinal += total;

            dataGridView_PDV.Rows.Add(itens[codigo - 12], qtd, valor[codigo - 11], total);

            lbl_ValorTotal.Text = "R$ " + totalfinal.ToString() + ",00";


        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_ValorTotal.Text = string.Empty;
            txb_Codigo.Text = string.Empty;
            numUpDown_Qtd.Value = 0;
            dataGridView_PDV.Rows.Clear();
            totalfinal = 0;
        }
    }
}
