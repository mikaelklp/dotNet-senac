namespace SistemaDeLogin
{
    partial class Form1
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
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            btnEnviar = new Button();
            label3 = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 38);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(10, 41);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 75);
            label2.Name = "label2";
            label2.Size = new Size(93, 38);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(10, 116);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 31);
            txtSenha.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(15, 170);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Entrar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 0);
            label3.Name = "label3";
            label3.Size = new Size(281, 38);
            label3.TabIndex = 6;
            label3.Text = "Nome a ser chamado";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(281, 31);
            txtNome.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(btnEnviar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtSenha;
        private Button btnEnviar;
        private Label label3;
        private TextBox txtNome;
    }
}
