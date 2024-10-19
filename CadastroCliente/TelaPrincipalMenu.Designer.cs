namespace CadastroCliente
{
    partial class TelaPrincipal
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
            groupBox1 = new GroupBox();
            btnSair = new Button();
            btnConsultar = new Button();
            btnCadastrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Location = new Point(37, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ActiveCaption;
            btnSair.Location = new Point(60, 191);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(218, 29);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.ActiveCaption;
            btnConsultar.Location = new Point(60, 106);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(218, 29);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar Cliente";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ActiveCaption;
            btnCadastrar.Location = new Point(60, 26);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(218, 29);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar Cliente";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(425, 400);
            Controls.Add(groupBox1);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipalMenu";
            TransparencyKey = Color.LightBlue;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSair;
        private Button btnConsultar;
        private Button btnCadastrar;
    }
}