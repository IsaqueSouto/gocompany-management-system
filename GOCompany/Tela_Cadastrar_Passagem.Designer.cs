namespace GO
{
    partial class Tela_Cadastrar_Passagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cadastrar_Passagem));
            txtLocalPartida = new TextBox();
            label1 = new Label();
            pbImagemDestino = new PictureBox();
            label3 = new Label();
            nmrValorLuxoPassagem = new NumericUpDown();
            arquivo = new OpenFileDialog();
            btnCadastrar = new Button();
            dtpPartida = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtpChegada = new DateTimePicker();
            nmrValorEconomicaPassagem = new NumericUpDown();
            label7 = new Label();
            txtDestino = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImagemDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorLuxoPassagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorEconomicaPassagem).BeginInit();
            SuspendLayout();
            // 
            // txtLocalPartida
            // 
            txtLocalPartida.Location = new Point(12, 207);
            txtLocalPartida.Name = "txtLocalPartida";
            txtLocalPartida.Size = new Size(193, 23);
            txtLocalPartida.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 189);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 2;
            label1.Text = "Local de partida";
            // 
            // pbImagemDestino
            // 
            pbImagemDestino.BackColor = Color.White;
            pbImagemDestino.BackgroundImageLayout = ImageLayout.Stretch;
            pbImagemDestino.BorderStyle = BorderStyle.FixedSingle;
            pbImagemDestino.Cursor = Cursors.Hand;
            pbImagemDestino.Location = new Point(254, 28);
            pbImagemDestino.Name = "pbImagemDestino";
            pbImagemDestino.Size = new Size(372, 154);
            pbImagemDestino.TabIndex = 4;
            pbImagemDestino.TabStop = false;
            pbImagemDestino.Click += pbImagem_Click;
            pbImagemDestino.MouseHover += pbImagem_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(146, 19);
            label3.TabIndex = 6;
            label3.Text = "Valor da classe de luxo";
            // 
            // nmrValorLuxoPassagem
            // 
            nmrValorLuxoPassagem.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nmrValorLuxoPassagem.Location = new Point(12, 297);
            nmrValorLuxoPassagem.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrValorLuxoPassagem.Name = "nmrValorLuxoPassagem";
            nmrValorLuxoPassagem.Size = new Size(193, 23);
            nmrValorLuxoPassagem.TabIndex = 7;
            // 
            // arquivo
            // 
            arquivo.FileName = "arquivo1";
            arquivo.FileOk += arquivo_FileOk;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumTurquoise;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(398, 379);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(159, 38);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtpPartida
            // 
            dtpPartida.Font = new Font("Segoe UI", 10F);
            dtpPartida.Format = DateTimePickerFormat.Custom;
            dtpPartida.ImeMode = ImeMode.NoControl;
            dtpPartida.Location = new Point(632, 207);
            dtpPartida.MaxDate = new DateTime(2034, 12, 31, 0, 0, 0, 0);
            dtpPartida.MinDate = new DateTime(2024, 11, 3, 0, 0, 0, 0);
            dtpPartida.Name = "dtpPartida";
            dtpPartida.Size = new Size(183, 25);
            dtpPartida.TabIndex = 9;
            dtpPartida.ValueChanged += dtpPartida_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(632, 189);
            label4.Name = "label4";
            label4.Size = new Size(147, 19);
            label4.TabIndex = 10;
            label4.Text = "Data e hora da partida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(632, 242);
            label5.Name = "label5";
            label5.Size = new Size(155, 19);
            label5.TabIndex = 12;
            label5.Text = "Data e hora da chegada";
            // 
            // dtpChegada
            // 
            dtpChegada.Font = new Font("Segoe UI", 10F);
            dtpChegada.Format = DateTimePickerFormat.Custom;
            dtpChegada.Location = new Point(632, 264);
            dtpChegada.MaxDate = new DateTime(2034, 12, 31, 0, 0, 0, 0);
            dtpChegada.MinDate = new DateTime(2024, 11, 3, 0, 0, 0, 0);
            dtpChegada.Name = "dtpChegada";
            dtpChegada.Size = new Size(183, 25);
            dtpChegada.TabIndex = 11;
            // 
            // nmrValorEconomicaPassagem
            // 
            nmrValorEconomicaPassagem.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nmrValorEconomicaPassagem.Location = new Point(12, 250);
            nmrValorEconomicaPassagem.Margin = new Padding(3, 28, 3, 28);
            nmrValorEconomicaPassagem.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrValorEconomicaPassagem.Name = "nmrValorEconomicaPassagem";
            nmrValorEconomicaPassagem.Size = new Size(192, 23);
            nmrValorEconomicaPassagem.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(12, 231);
            label7.Name = "label7";
            label7.Size = new Size(167, 19);
            label7.TabIndex = 23;
            label7.Text = "Valor da classe econômica";
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 10F);
            txtDestino.Location = new Point(254, 205);
            txtDestino.Name = "txtDestino";
            txtDestino.PlaceholderText = "Insira aqui seu local de destino";
            txtDestino.Size = new Size(372, 25);
            txtDestino.TabIndex = 25;
            // 
            // Tela_Cadastrar_Passagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(899, 464);
            Controls.Add(txtDestino);
            Controls.Add(nmrValorEconomicaPassagem);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(dtpChegada);
            Controls.Add(label4);
            Controls.Add(dtpPartida);
            Controls.Add(btnCadastrar);
            Controls.Add(nmrValorLuxoPassagem);
            Controls.Add(label3);
            Controls.Add(pbImagemDestino);
            Controls.Add(label1);
            Controls.Add(txtLocalPartida);
            Name = "Tela_Cadastrar_Passagem";
            Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)pbImagemDestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorLuxoPassagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorEconomicaPassagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocalPartida;
        private Label label1;
        private PictureBox pbImagemDestino;
        private Label label3;
        private NumericUpDown nmrValorLuxoPassagem;
        private OpenFileDialog arquivo;
        private Button btnCadastrar;
        private DateTimePicker dtpPartida;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpChegada;
        private NumericUpDown nmrValorEconomicaPassagem;
        private Label label7;
        private TextBox txtDestino;
    }
}