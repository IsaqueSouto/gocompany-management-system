namespace GO
{
    partial class Tela_Gerente
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
            btnInserirPassagem = new Button();
            btnCancelarPassagem = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInserirPassagem
            // 
            btnInserirPassagem.BackColor = Color.Azure;
            btnInserirPassagem.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserirPassagem.Location = new Point(98, 52);
            btnInserirPassagem.Name = "btnInserirPassagem";
            btnInserirPassagem.Size = new Size(169, 58);
            btnInserirPassagem.TabIndex = 0;
            btnInserirPassagem.Text = "Inserir Passagem Nova";
            btnInserirPassagem.UseVisualStyleBackColor = false;
            btnInserirPassagem.Click += btnInserirPassagem_Click;
            // 
            // btnCancelarPassagem
            // 
            btnCancelarPassagem.BackColor = Color.Azure;
            btnCancelarPassagem.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarPassagem.Location = new Point(98, 148);
            btnCancelarPassagem.Name = "btnCancelarPassagem";
            btnCancelarPassagem.Size = new Size(169, 58);
            btnCancelarPassagem.TabIndex = 1;
            btnCancelarPassagem.Text = "Cancelar viagem";
            btnCancelarPassagem.UseVisualStyleBackColor = false;
            btnCancelarPassagem.Click += btnCancelarPassagem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 18);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 2;
            label1.Text = "Voltar para cadastro/login";
            label1.Click += label1_Click;
            // 
            // Tela_Gerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(368, 260);
            Controls.Add(label1);
            Controls.Add(btnCancelarPassagem);
            Controls.Add(btnInserirPassagem);
            Name = "Tela_Gerente";
            Text = "Tela_Gerente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserirPassagem;
        private Button btnCancelarPassagem;
        private Label label1;
    }
}