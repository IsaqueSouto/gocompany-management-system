using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO
{
    public partial class Tela_Entrar_Funcionario : Form
    {
        ConsultasMySQL consultas;
        Tela_Gerente tG = new Tela_Gerente();
        public Tela_Entrar_Funcionario()
        {
            InitializeComponent();
            consultas = new ConsultasMySQL(@"Server=localhost;Database=gocompany;User ID=root;Password=");
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string funcaoFuncionario = consultas.Acessar_Conta_Funcionario(Convert.ToInt32(nmrIdentificadorFuncionario.Value), txtSenhaFuncionario.Text);
            
            if (funcaoFuncionario == "Gerente")
            {
                tG.Show();
                this.Hide(); 
            }
          

        }
    }
}
