using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO
{
    public partial class Menu_Principal : Form
    {
        byte[] imagembyte;
        int totalPassagens;
        int passagensIdentificador = 0;
        ConsultasMySQL consultas;
        MemoryStream ms;

        public Menu_Principal()
        {
            InitializeComponent();
            consultas = new ConsultasMySQL(@"Server=localhost;Database=gocompany;User ID=root;Password=;");
            totalPassagens = consultas.Total_Passagens();

        }

        private void btnMostrarPassagens_Click(object sender, EventArgs e)
        {

            if (passagensIdentificador < totalPassagens)
            {
                passagensIdentificador++;

                Mostrar_Passagems();
                if (consultas.Passagens_Canceladas(passagensIdentificador))
                    lbPassagemCanceladaInfo.Visible = true;
                else
                    lbPassagemCanceladaInfo.Visible = false;

                if (passagensIdentificador > 1)
                {
                    btnMostrarPassagemAnterior.Visible = true;
                    btnMostrarPassagemAnterior.Enabled = true;
                }
                else
                {
                    btnMostrarPassagemAnterior.Visible = false;
                    btnMostrarPassagemAnterior.Enabled = false;
                }
            }
        }
        private void btnMostrarPassagemAnterior_Click(object sender, EventArgs e)
        {

            passagensIdentificador--;

            if (passagensIdentificador > 1)
            {
                btnMostrarPassagemAnterior.Visible = true;
                btnMostrarPassagemAnterior.Enabled = true;
            }
            else
            {
                btnMostrarPassagemAnterior.Visible = false;
                btnMostrarPassagemAnterior.Enabled = false;
            }
            Mostrar_Passagems();

            if (consultas.Passagens_Canceladas(passagensIdentificador))
                lbPassagemCanceladaInfo.Visible = true;
            else
                lbPassagemCanceladaInfo.Visible = false;

        }
        private void Mostrar_Passagems()
        {

            using (MySqlConnection conexao = new MySqlConnection(@"Server=localhost;Database=gocompany;User ID=root;Password=;"))
            {
                conexao.Open();
                using (MySqlCommand comando = new MySqlCommand("SELECT imagem_destino FROM passagens WHERE id = @id", conexao))
                {
                    comando.Parameters.AddWithValue("@id", passagensIdentificador);
                    byte[]? imagemByte = comando.ExecuteScalar() as byte[];
                    if (imagemByte != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemByte))
                        {
                            pbimgDestino1.Image = Image.FromStream(ms);
                        }
                    }

                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT destino,local_partida,valor_economica,valor_luxo,data_hora_partida," +
                    "data_hora_chegada FROM passagens where id=@id", conexao))
                {
                    cmd.Parameters.AddWithValue("@id", passagensIdentificador);
                    MySqlDataReader leitor = cmd.ExecuteReader();
                    if (leitor.Read())
                    {
                        lbDestino.Text = "Destino: " + leitor["destino"].ToString();
                        lbValorEconomica.Text = "Valor econômico: R$" + leitor["valor_economica"].ToString();
                        lbValorLuxo.Text = "Valor luxo: R$" + leitor["valor_luxo"].ToString();
                        lbLocalPartida.Text = "Local partida: " + leitor["local_partida"].ToString();
                        lbDataHoraPartida.Text = "Data e hora partida: " + Convert.ToDateTime(leitor["data_hora_partida"]).ToString("dd/MM/yyyy HH:mm");
                        lbDataHoraChegada.Text = "Data e hora chegada: " + Convert.ToDateTime(leitor["data_hora_chegada"]).ToString("dd/MM/yyyy HH:mm");

                    }
                    conexao.Close();
                    leitor.Close();
                }
            }
        }

        private void btnComprarPassagem_Click(object sender, EventArgs e)
        {
            decimal dinheiro = consultas.Dinheiro_Cliente(ClienteLogado.EmailClienteLogado);
            decimal valorPassagem=0;
            string email = ClienteLogado.EmailClienteLogado.Trim();
            if (radioButton1.Checked)
                valorPassagem = consultas.Valor_Passagem(radioButton1.Text, passagensIdentificador);
            else if
                (radioButton2.Checked)
                valorPassagem = consultas.Valor_Passagem(radioButton2.Text, passagensIdentificador);
            else
                MessageBox.Show("Selecione uma das classes");

            if (dinheiro > valorPassagem)
            {
                dinheiro -= valorPassagem;
                MessageBox.Show("Passagem comprada com sucesso");
            }



        }
    }
}

