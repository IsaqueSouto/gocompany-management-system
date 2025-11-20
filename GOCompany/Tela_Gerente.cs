using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace GO
{
    public partial class Tela_Gerente : Form
    {
        public Tela_Gerente()
        {
            InitializeComponent();
        }

        private void btnInserirPassagem_Click(object sender, EventArgs e)
        {
            Tela_Cadastrar_Passagem tCP = new Tela_Cadastrar_Passagem();
            tCP.ShowDialog();
            this.Hide();
        }

        private void btnCancelarPassagem_Click(object sender, EventArgs e)
        {
            Tela_Gerente_Cancelar_Passagem tGCP = new Tela_Gerente_Cancelar_Passagem();
            tGCP.ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Tela_de_Cadastro tC = new Tela_de_Cadastro();
            tC.Show();
            this.Close();
        }
    }
}
