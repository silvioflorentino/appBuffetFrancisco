﻿using Microsoft.VisualBasic;
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
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            string usuario = txb_Usuario.Text;
            string senha = txb_Senha.Text;

            if (usuario == "admin" && senha == "123")
            {
                this.Hide();
                MenuTela Menu = new MenuTela();
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Senha ou usuario incorreto");

            }
        }
    }
}
