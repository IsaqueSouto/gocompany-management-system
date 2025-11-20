namespace GO
{
    partial class Tela_Gerente_Cancelar_Passagem
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
            nmrIdentificador = new NumericUpDown();
            label1 = new Label();
            btnCancelarViagem = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrIdentificador).BeginInit();
            SuspendLayout();
            // 
            // nmrIdentificador
            // 
            nmrIdentificador.Location = new Point(149, 86);
            nmrIdentificador.Margin = new Padding(3, 4, 3, 4);
            nmrIdentificador.Name = "nmrIdentificador";
            nmrIdentificador.Size = new Size(147, 27);
            nmrIdentificador.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(475, 22);
            label1.TabIndex = 1;
            label1.Text = "Insira o identificador da passagem que deseja cancelar";
            // 
            // btnCancelarViagem
            // 
            btnCancelarViagem.BackColor = Color.Azure;
            btnCancelarViagem.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarViagem.Location = new Point(149, 140);
            btnCancelarViagem.Margin = new Padding(3, 4, 3, 4);
            btnCancelarViagem.Name = "btnCancelarViagem";
            btnCancelarViagem.Size = new Size(147, 32);
            btnCancelarViagem.TabIndex = 2;
            btnCancelarViagem.Text = "Cancelar Viagem";
            btnCancelarViagem.UseVisualStyleBackColor = false;
            btnCancelarViagem.Click += btnCancelarViagem_Click;
            // 
            // Tela_Gerente_Cancelar_Passagem
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(492, 261);
            Controls.Add(btnCancelarViagem);
            Controls.Add(label1);
            Controls.Add(nmrIdentificador);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tela_Gerente_Cancelar_Passagem";
            Text = "Tela_Gerente_Cancelar_Passagem";
            ((System.ComponentModel.ISupportInitialize)nmrIdentificador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmrIdentificador;
        private Label label1;
        private Button btnCancelarViagem;
    }
}