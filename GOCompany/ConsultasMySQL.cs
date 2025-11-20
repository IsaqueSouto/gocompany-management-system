using MySql.Data.MySqlClient;


namespace GO
{
    internal class ConsultasMySQL
    {
        // Inserir_na_tabela_passagens há uma observação nessa função
        private MySqlConnection conn;
        public ConsultasMySQL(string stringDeConexao)
        {
            this.conn = new MySqlConnection(stringDeConexao);
        }
        public void Inserir_Na_Tabela_Clientes( string nome, string senha, string tipagem, string email, string cpf, string rg,string estado,
            string genero, DateTime dtnasc, int idade)
        {
            // string conectarAoBanco = @"Server=localhost;Database=go;User ID=root;Password=;";
            string cmdInserirNoBanco = @$"INSERT INTO clientes(nome,senha,tipagem,email,cpf,rg,estado,genero,data_nascimento,idade,dinheiro)" 
            + "VALUES(@nome,@senha,@tipagem,@email,@cpf,@rg,@estado,@genero,@dtnasc,@idade, 1000)";  
            using (MySqlCommand cmd = new MySqlCommand(cmdInserirNoBanco, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@tipagem", tipagem);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@dtnasc", dtnasc);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Inserir_na_tabela_passagens(byte[] imagemDestinoByte, decimal valorEconomica, decimal valorLuxo, string destino,
            string localPartida, DateTime datahoraPartida, DateTime datahoraChegada )
        {
            conn.Open();
                using (MySqlCommand consulta = new MySqlCommand(" INSERT INTO Passagens(imagem_destino," +
                    "  valor_economica, valor_luxo, destino, local_partida, data_hora_Partida, data_hora_Chegada) VALUES(@ImagemDestino," +
                    " @ValorEconomica, @ValorLuxo, @Destino, @LocalPartida, @horaPartida, @horaChegada)", conn))
                {
                    consulta.Parameters.AddWithValue("@ImagemDestino", imagemDestinoByte);
                    consulta.Parameters.AddWithValue("@ValorEconomica", valorEconomica);
                    consulta.Parameters.AddWithValue("@ValorLuxo", valorLuxo);
                    consulta.Parameters.AddWithValue("@Destino", destino);
                    consulta.Parameters.AddWithValue("@LocalPartida", localPartida);
                    consulta.Parameters.AddWithValue("@horaPartida", datahoraPartida);
                    consulta.Parameters.AddWithValue("@horaChegada", datahoraChegada);

                    consulta.ExecuteNonQuery();
                }
                conn.Close();
            
        }

        public bool Acessar_Conta_Cliente(string email, string senha)
        {
            bool contaAceita = false;
            conn.Open();
            //SELECT * FROM clientes
            MySqlCommand consulta = new MySqlCommand(@"SELECT email,senha FROM clientes WHERE email = @email AND senha = @senha",conn);
            MySqlDataReader leitor;

            consulta.Parameters.AddWithValue("@email",email);
            consulta.Parameters.AddWithValue("@senha",senha);

            leitor = consulta.ExecuteReader();
            
            if (leitor.Read())
                contaAceita = true;
            
            leitor.Close();
            conn.Close();
            return contaAceita;
        }
        public string Acessar_Conta_Funcionario(int id, string senha)
        {
            string funcaoFuncionario = string.Empty;

            MySqlCommand consulta = new MySqlCommand(@"SELECT funcao FROM funcionarios WHERE id = @id AND senha_login = @senha", conn);
            MySqlDataReader leitor;
           
            conn.Open();
            consulta.Parameters.AddWithValue("@id", id);
            consulta.Parameters.AddWithValue("@senha", senha);

            leitor = consulta.ExecuteReader();
           

            if (leitor.Read())
                funcaoFuncionario = leitor.GetString("funcao");

            else if (funcaoFuncionario != "Gerente" && !string.IsNullOrEmpty(funcaoFuncionario))

                MessageBox.Show(
              "Você faz parte da empresa, mas o acesso a este login é exclusivo para o gerente." +
              " Se precisar de algo relacionado a esta área, por favor, entre em contato com o gerente responsável.",
              "Houve algum erro",
              MessageBoxButtons.OK,
              MessageBoxIcon.Hand
              );

            else
                MessageBox.Show(
                "Funcionário não encontrado",
             "Houve algum erro",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error
                );
            MessageBox.Show("Valor de funcaoFuncionario: " + funcaoFuncionario);

            leitor.Close();
            conn.Close();
            return funcaoFuncionario;
        }
        public bool Verificar_redundancias_de_dados(string email)
        {
            bool dadoDuplo = false;
            conn.Open();
            MySqlCommand consulta = new MySqlCommand("SELECT count(email) FROM clientes WHERE email = @email", conn);
            consulta.Parameters.AddWithValue("@email", email);
            if(Convert.ToInt32(consulta.ExecuteScalar())>0)
                dadoDuplo = true;

            conn.Close();
            return dadoDuplo;
        }
        public string Deletar_Registro(decimal identificador)
        {
            string ?passagemCanceladaNome = string.Empty;
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT destino FROM passagens Where id = @id", conn);
                comando.Parameters.AddWithValue("@id", identificador);
                MySqlDataReader leitor = comando.ExecuteReader();
                leitor.Read();
                passagemCanceladaNome = leitor["destino"].ToString();
                leitor.Close();

                MySqlCommand comando2 = new MySqlCommand("INSERT INTO passagens_canceladas(id_passagens) values(@id)", conn);
                comando2.Parameters.AddWithValue("@id", identificador);
                comando2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Nenhum registro encontrado", "Houve algum problema",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            conn.Close();
            return passagemCanceladaNome;
        }
        public int Total_Passagens()
        {
            conn.Open();
            MySqlCommand comando = new MySqlCommand("SELECT count(*) FROM passagens",conn);
            int cont = Convert.ToInt32(comando.ExecuteScalar());

            conn.Close();
            return cont;
        }
        public bool Passagens_Canceladas(int identificador)
        {
            bool cancelada;
            conn.Open();
            MySqlCommand comando = new MySqlCommand("SELECT id FROM passagens_canceladas WHERE id = @id", conn);
            comando.Parameters.AddWithValue("@id",identificador);
            MySqlDataReader leitor = comando.ExecuteReader();
            if (leitor.Read())
                cancelada = true;
            else 
                cancelada = false;
            leitor.Close();
            conn.Close();
            return cancelada;
        }

        public decimal Dinheiro_Cliente(string email)
        {
            decimal money = 0;
            conn.Open();
            MySqlCommand comando = new MySqlCommand("SELECT dinheiro FROM clientes WHERE email = @email");
            
                comando.Parameters.AddWithValue("@email", email);
               using( MySqlDataReader leitor = comando.ExecuteReader())
                {
                    if (leitor.Read())
                        money = Convert.ToDecimal(leitor["dinheiro"]);
                    leitor.Close();
                }

            conn.Close();
            return money;
        }

        public decimal Valor_Passagem(string classe, int id)
        {
            decimal money = 0;
            conn.Open();
            using (MySqlCommand comando = new MySqlCommand($"SELECT valor_@classe FROM passagens WHERE id = @id"))
            {
                comando.Parameters.AddWithValue("@classe", classe);
                comando.Parameters.AddWithValue("@id", id);
                using(MySqlDataReader leitor = comando.ExecuteReader())
                {
                    money = Convert.ToInt32(leitor[$"valor_{classe}"]);
                    leitor.Close();
                }
            }
            conn.Close();
            return money;
        }

    }
}
