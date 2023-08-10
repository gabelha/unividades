namespace unividades.View
{
    partial class TelaAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterar));
            label1 = new Label();
            btnAlterar = new Button();
            btnBuscar = new Button();
            label4 = new Label();
            comboBoxcurso = new ComboBox();
            textBoxduracao = new TextBox();
            textBoxturno = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBoxCodigo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 0, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(180, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite o Codigo:";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(192, 0, 0);
            btnAlterar.ForeColor = Color.Silver;
            btnAlterar.Location = new Point(56, 352);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(391, 23);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(192, 0, 0);
            btnBuscar.ForeColor = Color.Silver;
            btnBuscar.Location = new Point(180, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(267, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.facu;
            label4.Location = new Point(-5, -2);
            label4.Name = "label4";
            label4.Size = new Size(179, 158);
            label4.TabIndex = 13;
            // 
            // comboBoxcurso
            // 
            comboBoxcurso.BackColor = Color.FromArgb(192, 0, 0);
            comboBoxcurso.FormattingEnabled = true;
            comboBoxcurso.Items.AddRange(new object[] { "Introdução à Programação", "Desenvolvimento Web", "Programação Orientada a Objetos", "Bases de Dados e Sistemas de Informação", "Inteligência Artificial e Aprendizado de Máquina", "Redes de Computadore", "Segurança da Informação e Criptografia", "Desenvolvimento Mobile", "Engenharia de Software", "Design e Usabilidade de Interfaces", "Internet das Coisas (IoT)", "Realidade Virtual e Aumentada", "Robótica e Automação", "Big Data e Análise de Dados", "Sistemas Embarcados", "Computação em Nuvem e Serviços Online", "Engenharia Eletrônica e Circuitos Integrados", "Energias Renováveis e Sustentabilidade Tecnológica", "Gestão da Inovação e Empreendedorismo Tecnológico", "Ética e Responsabilidade Social na Tecnologia" });
            comboBoxcurso.Location = new Point(115, 305);
            comboBoxcurso.Name = "comboBoxcurso";
            comboBoxcurso.Size = new Size(335, 23);
            comboBoxcurso.TabIndex = 19;
            // 
            // textBoxduracao
            // 
            textBoxduracao.BackColor = Color.FromArgb(192, 0, 0);
            textBoxduracao.Location = new Point(115, 248);
            textBoxduracao.Name = "textBoxduracao";
            textBoxduracao.Size = new Size(100, 23);
            textBoxduracao.TabIndex = 18;
            // 
            // textBoxturno
            // 
            textBoxturno.BackColor = Color.FromArgb(192, 0, 0);
            textBoxturno.Location = new Point(115, 193);
            textBoxturno.Name = "textBoxturno";
            textBoxturno.Size = new Size(100, 23);
            textBoxturno.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 0, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(65, 308);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 16;
            label2.Text = "Curso :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 0, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(56, 251);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Duração :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 0, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(56, 201);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 14;
            label5.Text = "Turno :";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BackColor = Color.FromArgb(192, 0, 0);
            textBoxCodigo.Location = new Point(279, 12);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 20;
            // 
            // TelaAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(482, 403);
            Controls.Add(textBoxCodigo);
            Controls.Add(comboBoxcurso);
            Controls.Add(textBoxduracao);
            Controls.Add(textBoxturno);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnAlterar);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "TelaAlterar";
            Text = "TelaAlterar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnAlterar;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnBuscar;
        private Label label4;
        private ComboBox comboBoxcurso;
        private TextBox textBoxduracao;
        private TextBox textBoxturno;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBoxCodigo;
    }
}