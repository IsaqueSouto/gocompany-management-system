namespace GO
{
    partial class Tela_Entrar_Funcionario
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
            txtSenhaFuncionario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nmrIdentificadorFuncionario = new NumericUpDown();
            btnAcessar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrIdentificadorFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtSenhaFuncionario
            // 
            txtSenhaFuncionario.Location = new Point(74, 160);
            txtSenhaFuncionario.Margin = new Padding(3, 4, 3, 4);
            txtSenhaFuncionario.MaxLength = 30;
            txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            txtSenhaFuncionario.Size = new Size(199, 27);
            txtSenhaFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 58);
            label1.Name = "label1";
            label1.Size = new Size(392, 23);
            label1.TabIndex = 2;
            label1.Text = "Insira seu dígito Identificador de funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 132);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // nmrIdentificadorFuncionario
            // 
            nmrIdentificadorFuncionario.Font = new Font("Segoe UI", 10F);
            nmrIdentificadorFuncionario.Location = new Point(74, 87);
            nmrIdentificadorFuncionario.Margin = new Padding(3, 5, 3, 5);
            nmrIdentificadorFuncionario.Name = "nmrIdentificadorFuncionario";
            nmrIdentificadorFuncionario.Size = new Size(199, 30);
            nmrIdentificadorFuncionario.TabIndex = 4;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.Azure;
            btnAcessar.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcessar.ForeColor = Color.Black;
            btnAcessar.Location = new Point(74, 215);
            btnAcessar.Margin = new Padding(3, 4, 3, 4);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(146, 52);
            btnAcessar.TabIndex = 5;
            btnAcessar.Text = "Acessar conta";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // Tela_Entrar_Funcionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(525, 341);
            Controls.Add(btnAcessar);
            Controls.Add(nmrIdentificadorFuncionario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenhaFuncionario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tela_Entrar_Funcionario";
            Text = "Tela_Entrar_Funcionario";
            ((System.ComponentModel.ISupportInitialize)nmrIdentificadorFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenhaFuncionario;
        private Label label1;
        private Label label2;
        private NumericUpDown nmrIdentificadorFuncionario;
        private Button btnAcessar;
    }
}