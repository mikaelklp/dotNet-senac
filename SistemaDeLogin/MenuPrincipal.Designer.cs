namespace SistemaDeLogin
{
    partial class MenuPrincipal
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
            lblSaudacao = new Label();
            SuspendLayout();
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaudacao.Location = new Point(22, 16);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(339, 54);
            lblSaudacao.TabIndex = 0;
            lblSaudacao.Text = "Bem vindo Mikael";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaudacao);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaudacao;
    }
}