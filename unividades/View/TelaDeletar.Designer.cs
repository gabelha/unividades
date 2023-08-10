namespace unividades.View
{
    partial class TelaDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeletar));
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxcod = new TextBox();
            label5 = new Label();
            btnPesquisa = new Button();
            textBoxturno = new TextBox();
            label2 = new Label();
            comboBoxcurso = new ComboBox();
            textBoxduracao = new TextBox();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Image = Properties.Resources.facu;
            label3.Location = new Point(1, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 176);
            label3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Futura Bk BT", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(224, 60);
            label1.Name = "label1";
            label1.Size = new Size(117, 39);
            label1.TabIndex = 10;
            label1.Text = "Deletar";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(32, 353);
            button1.Name = "button1";
            button1.Size = new Size(438, 23);
            button1.TabIndex = 14;
            button1.Text = "Deletar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxcod
            // 
            textBoxcod.BackColor = Color.FromArgb(192, 0, 0);
            textBoxcod.Location = new Point(127, 203);
            textBoxcod.Name = "textBoxcod";
            textBoxcod.Size = new Size(100, 23);
            textBoxcod.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 0, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(69, 206);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 17;
            label5.Text = "Código :";
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.FromArgb(192, 0, 0);
            btnPesquisa.ForeColor = Color.Silver;
            btnPesquisa.Location = new Point(244, 203);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(76, 23);
            btnPesquisa.TabIndex = 19;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = false;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // textBoxturno
            // 
            textBoxturno.BackColor = Color.FromArgb(192, 0, 0);
            textBoxturno.Location = new Point(127, 241);
            textBoxturno.Name = "textBoxturno";
            textBoxturno.Size = new Size(100, 23);
            textBoxturno.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 0, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(77, 244);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 20;
            label2.Text = "Turno :";
            // 
            // comboBoxcurso
            // 
            comboBoxcurso.BackColor = Color.FromArgb(192, 0, 0);
            comboBoxcurso.FormattingEnabled = true;
            comboBoxcurso.Items.AddRange(new object[] { "Introdução à Programação", "Desenvolvimento Web", "Programação Orientada a Objetos", "Bases de Dados e Sistemas de Informação", "Inteligência Artificial e Aprendizado de Máquina", "Redes de Computadore", "Segurança da Informação e Criptografia", "Desenvolvimento Mobile", "Engenharia de Software", "Design e Usabilidade de Interfaces", "Internet das Coisas (IoT)", "Realidade Virtual e Aumentada", "Robótica e Automação", "Big Data e Análise de Dados", "Sistemas Embarcados", "Computação em Nuvem e Serviços Online", "Engenharia Eletrônica e Circuitos Integrados", "Energias Renováveis e Sustentabilidade Tecnológica", "Gestão da Inovação e Empreendedorismo Tecnológico", "Ética e Responsabilidade Social na Tecnologia" });
            comboBoxcurso.Location = new Point(127, 301);
            comboBoxcurso.Name = "comboBoxcurso";
            comboBoxcurso.Size = new Size(335, 23);
            comboBoxcurso.TabIndex = 25;
            // 
            // textBoxduracao
            // 
            textBoxduracao.BackColor = Color.FromArgb(192, 0, 0);
            textBoxduracao.Location = new Point(127, 272);
            textBoxduracao.Name = "textBoxduracao";
            textBoxduracao.Size = new Size(100, 23);
            textBoxduracao.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 0, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(77, 304);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 23;
            label4.Text = "Curso :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 0, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(64, 275);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 22;
            label6.Text = "Duração :";
            // 
            // TelaDeletar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(490, 388);
            Controls.Add(comboBoxcurso);
            Controls.Add(textBoxduracao);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(textBoxturno);
            Controls.Add(label2);
            Controls.Add(btnPesquisa);
            Controls.Add(textBoxcod);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "TelaDeletar";
            Text = "TelaDeletar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Button button1;
        private TextBox textBoxcod;
        private Label label5;
        private Button btnPesquisa;
        private TextBox textBoxturno;
        private Label label2;
        private ComboBox comboBoxcurso;
        private TextBox textBoxduracao;
        private Label label4;
        private Label label6;
    }
}