namespace CadastroCliente
{
    partial class TelaCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            btnSalvar = new Button();
            Cancelar = new Button();
            LimparCampos = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 61);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 94);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 126);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 159);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 192);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(225, 27);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(80, 156);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(225, 27);
            txtTelefone.TabIndex = 7;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(80, 87);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(225, 27);
            txtCPF.TabIndex = 8;
            txtCPF.TextChanged += txtCPF_TextChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(80, 189);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(225, 27);
            txtEndereco.TabIndex = 9;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(145, 266);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(33, 266);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(94, 29);
            Cancelar.TabIndex = 11;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // LimparCampos
            // 
            LimparCampos.BackColor = Color.Transparent;
            LimparCampos.Location = new Point(265, 266);
            LimparCampos.Name = "LimparCampos";
            LimparCampos.Size = new Size(94, 29);
            LimparCampos.TabIndex = 12;
            LimparCampos.Text = "Limpar";
            LimparCampos.UseVisualStyleBackColor = false;
            LimparCampos.Click += LimparCampos_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GreenYellow;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LimparCampos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(Cancelar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(57, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 295);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro Cliente";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(499, 394);
            Controls.Add(groupBox1);
            ForeColor = Color.Red;
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeClientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Button btnSalvar;
        private Button Cancelar;
        private Button LimparCampos;
        private GroupBox groupBox1;
    }
}