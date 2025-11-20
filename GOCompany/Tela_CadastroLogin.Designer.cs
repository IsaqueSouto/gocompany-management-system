namespace WinFormsApp2
{
    partial class Tela_de_Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_de_Cadastro));
            pictureBox1 = new PictureBox();
            login = new Label();
            panel1 = new Panel();
            label12 = new Label();
            pais = new ComboBox();
            label10 = new Label();
            label6 = new Label();
            nome = new TextBox();
            label3 = new Label();
            repetirSenha = new TextBox();
            lbidade = new Label();
            outrosGeneros = new TextBox();
            generos = new ComboBox();
            label9 = new Label();
            dataNasc = new DateTimePicker();
            cpf = new TextBox();
            rg = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cadastrar = new Button();
            panel2 = new Panel();
            completarCPF = new Button();
            panel3 = new Panel();
            label5 = new Label();
            email = new TextBox();
            label4 = new Label();
            senha = new TextBox();
            cadastro = new Label();
            dataHoje = new DateTimePicker();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            lbEntrarTelaFuncionario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, -84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 275);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            login.AutoSize = true;
            login.BackColor = Color.Transparent;
            login.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            login.ForeColor = Color.FloralWhite;
            login.Location = new Point(643, 28);
            login.Name = "login";
            login.Size = new Size(72, 30);
            login.TabIndex = 5;
            login.Text = "Entrar";
            login.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pais);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(nome);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(repetirSenha);
            panel1.Location = new Point(184, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 200);
            panel1.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Cyan;
            label12.Location = new Point(7, 115);
            label12.Name = "label12";
            label12.Size = new Size(149, 20);
            label12.TabIndex = 28;
            label12.Text = "Estado de residência";
            // 
            // pais
            // 
            pais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pais.AutoCompleteSource = AutoCompleteSource.ListItems;
            pais.BackColor = Color.White;
            pais.FormattingEnabled = true;
            pais.Location = new Point(7, 139);
            pais.Name = "pais";
            pais.Size = new Size(267, 28);
            pais.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Cyan;
            label10.Location = new Point(329, 0);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 28;
            label10.Text = "genero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(7, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 14;
            label6.Text = "Repita a senha";
            // 
            // nome
            // 
            nome.Location = new Point(7, 85);
            nome.MaxLength = 100;
            nome.Name = "nome";
            nome.Size = new Size(267, 27);
            nome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(7, 61);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "Nome";
            // 
            // repetirSenha
            // 
            repetirSenha.Location = new Point(7, 23);
            repetirSenha.Name = "repetirSenha";
            repetirSenha.Size = new Size(267, 27);
            repetirSenha.TabIndex = 3;
            repetirSenha.UseSystemPasswordChar = true;
            // 
            // lbidade
            // 
            lbidade.AutoSize = true;
            lbidade.BackColor = Color.Transparent;
            lbidade.Location = new Point(25, 168);
            lbidade.Name = "lbidade";
            lbidade.Size = new Size(50, 20);
            lbidade.TabIndex = 39;
            lbidade.Text = "Idade:";
            // 
            // outrosGeneros
            // 
            outrosGeneros.Enabled = false;
            outrosGeneros.Location = new Point(27, 61);
            outrosGeneros.Margin = new Padding(3, 4, 3, 4);
            outrosGeneros.MaxLength = 20;
            outrosGeneros.Name = "outrosGeneros";
            outrosGeneros.PlaceholderText = "digite aqui seu gênero";
            outrosGeneros.Size = new Size(196, 27);
            outrosGeneros.TabIndex = 36;
            outrosGeneros.Visible = false;
            // 
            // generos
            // 
            generos.FormattingEnabled = true;
            generos.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros", "Não informar" });
            generos.Location = new Point(27, 23);
            generos.Margin = new Padding(3, 4, 3, 4);
            generos.Name = "generos";
            generos.Size = new Size(196, 28);
            generos.TabIndex = 8;
            generos.SelectedIndexChanged += generos_SelectedIndexChanged;
            generos.SelectedValueChanged += generos_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Cyan;
            label9.Location = new Point(23, 111);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 34;
            label9.Text = "Data de nascimento";
            // 
            // dataNasc
            // 
            dataNasc.Format = DateTimePickerFormat.Short;
            dataNasc.Location = new Point(25, 135);
            dataNasc.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dataNasc.MinDate = new DateTime(1908, 1, 1, 0, 0, 0, 0);
            dataNasc.Name = "dataNasc";
            dataNasc.Size = new Size(195, 27);
            dataNasc.TabIndex = 9;
            dataNasc.Value = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            dataNasc.Leave += dataNasc_Leave;
            // 
            // cpf
            // 
            cpf.Location = new Point(27, 21);
            cpf.MaxLength = 14;
            cpf.Name = "cpf";
            cpf.Size = new Size(195, 27);
            cpf.TabIndex = 6;
            cpf.KeyDown += cpf_Keydown;
            cpf.KeyPress += cpf_KeyPress;
            cpf.MouseHover += cpf_MouseHover;
            // 
            // rg
            // 
            rg.Location = new Point(27, 77);
            rg.MaxLength = 12;
            rg.Name = "rg";
            rg.Size = new Size(195, 27);
            rg.TabIndex = 7;
            rg.KeyDown += rg_Keydown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(25, 1);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 15;
            label7.Text = "CPF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Cyan;
            label8.Location = new Point(25, 53);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 16;
            label8.Text = "RG";
            // 
            // cadastrar
            // 
            cadastrar.BackColor = Color.Chartreuse;
            cadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cadastrar.Location = new Point(438, 467);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(97, 51);
            cadastrar.TabIndex = 10;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = false;
            cadastrar.Click += cadastrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(completarCPF);
            panel2.Controls.Add(cpf);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(rg);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(495, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 108);
            panel2.TabIndex = 3;
            // 
            // completarCPF
            // 
            completarCPF.BackColor = Color.Gainsboro;
            completarCPF.Location = new Point(226, 21);
            completarCPF.Margin = new Padding(3, 4, 3, 4);
            completarCPF.Name = "completarCPF";
            completarCPF.Size = new Size(35, 27);
            completarCPF.TabIndex = 17;
            completarCPF.Text = "OK";
            completarCPF.UseVisualStyleBackColor = false;
            completarCPF.Click += completarCPF_Click;
            completarCPF.MouseHover += completarCPF_MouseHover;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(email);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(senha);
            panel3.Location = new Point(184, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 107);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(9, 53);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 12;
            label5.Text = "Senha";
            // 
            // email
            // 
            email.Location = new Point(9, 20);
            email.MaxLength = 500;
            email.Name = "email";
            email.Size = new Size(267, 27);
            email.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(9, -3);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // senha
            // 
            senha.Location = new Point(9, 76);
            senha.Name = "senha";
            senha.Size = new Size(267, 27);
            senha.TabIndex = 2;
            senha.UseSystemPasswordChar = true;
            senha.Leave += senha_Leave;
            // 
            // cadastro
            // 
            cadastro.AutoSize = true;
            cadastro.BackColor = Color.Transparent;
            cadastro.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            cadastro.ForeColor = Color.FloralWhite;
            cadastro.Location = new Point(721, 28);
            cadastro.Name = "cadastro";
            cadastro.Size = new Size(106, 30);
            cadastro.TabIndex = 20;
            cadastro.Text = "Cadastrar";
            cadastro.Click += cadastro_Click;
            // 
            // dataHoje
            // 
            dataHoje.CalendarForeColor = Color.Transparent;
            dataHoje.CalendarMonthBackground = Color.Transparent;
            dataHoje.CalendarTitleBackColor = Color.Transparent;
            dataHoje.CalendarTitleForeColor = Color.Transparent;
            dataHoje.CalendarTrailingForeColor = Color.Transparent;
            dataHoje.Enabled = false;
            dataHoje.Format = DateTimePickerFormat.Short;
            dataHoje.Location = new Point(801, 572);
            dataHoje.MinDate = new DateTime(1945, 1, 1, 0, 0, 0, 0);
            dataHoje.Name = "dataHoje";
            dataHoje.Size = new Size(90, 27);
            dataHoje.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(683, 572);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 38;
            label1.Text = "Data de hoje";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dataNasc);
            panel4.Controls.Add(lbidade);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(generos);
            panel4.Controls.Add(outrosGeneros);
            panel4.Location = new Point(495, 261);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 196);
            panel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(27, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 18;
            label2.Text = "Gênero";
            // 
            // lbEntrarTelaFuncionario
            // 
            lbEntrarTelaFuncionario.AutoSize = true;
            lbEntrarTelaFuncionario.BackColor = Color.Transparent;
            lbEntrarTelaFuncionario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEntrarTelaFuncionario.ForeColor = SystemColors.ButtonFace;
            lbEntrarTelaFuncionario.Location = new Point(24, 12);
            lbEntrarTelaFuncionario.Name = "lbEntrarTelaFuncionario";
            lbEntrarTelaFuncionario.Size = new Size(159, 25);
            lbEntrarTelaFuncionario.TabIndex = 40;
            lbEntrarTelaFuncionario.Text = "Sou Funcionário";
            lbEntrarTelaFuncionario.Click += lbEntrarTelaFuncionario_Click;
            // 
            // Tela_de_Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 617);
            Controls.Add(lbEntrarTelaFuncionario);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(dataHoje);
            Controls.Add(cadastro);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(cadastrar);
            Controls.Add(panel1);
            Controls.Add(login);
            Controls.Add(pictureBox1);
            Name = "Tela_de_Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label login;
        private Panel panel1;
        private Label label6;
        private TextBox nome;
        private Label label3;
        private TextBox repetirSenha;
        private ComboBox pais;
        private TextBox cpf;
        private TextBox rg;
        private Label label7;
        private Label label8;
        private Button cadastrar;
        private Label label12;
        private Panel panel2;
        private Label label9;
        private DateTimePicker dataNasc;
        private Label label10;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private TextBox senha;
        private TextBox email;
        private Button completarCPF;
        private ComboBox generos;
        private TextBox outrosGeneros;
        private Label cadastro;
        private DateTimePicker dataHoje;
        private Label label1;
        private Label lbidade;
        private Panel panel4;
        private Label lbEntrarTelaFuncionario;
        private Label label2;
    }
}
