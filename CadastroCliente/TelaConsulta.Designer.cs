namespace CadastroCliente
{
    partial class TelaConsulta
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
            label = new Label();
            dgvResultados = new DataGridView();
            txtPesquisa = new TextBox();
            btnBuscar = new Button();
            btnExcluir = new Button();
            Voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 66);
            label.Name = "label";
            label.Size = new Size(102, 20);
            label.TabIndex = 0;
            label.Text = "Nome ou CPF:";
            // 
            // dgvResultados
            // 
            dgvResultados.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 96);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(808, 188);
            dgvResultados.TabIndex = 1;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(117, 63);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(576, 27);
            txtPesquisa.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(236, 310);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(359, 310);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Voltar
            // 
            Voltar.Location = new Point(485, 310);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(105, 29);
            Voltar.TabIndex = 5;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;
            // 
            // TelaConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(834, 370);
            Controls.Add(Voltar);
            Controls.Add(btnExcluir);
            Controls.Add(btnBuscar);
            Controls.Add(txtPesquisa);
            Controls.Add(dgvResultados);
            Controls.Add(label);
            Name = "TelaConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaConsulta";
            Load += TelaConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private DataGridView dgvResultados;
        private TextBox txtPesquisa;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Gmail;
        private Button btnExcluir;
        private Button Voltar;
    }
}