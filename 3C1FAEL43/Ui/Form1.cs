using _3C1FAEL43.Code.BLL;
using _3C1FAEL43.Code.DTO;
using _3C1FAEL43.Ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1FAEL43
{
    public partial class Form1 : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                RI FRMRI = new RI();
                FRMRI.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
