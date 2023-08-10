namespace unividades.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxturno = new TextBox();
            textBoxduracao = new TextBox();
            comboBoxcurso = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Square721 BT", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(243, 68);
            label1.Name = "label1";
            label1.Size = new Size(187, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 0, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(55, 199);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Turno :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 0, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(55, 249);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Duração :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 0, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(64, 306);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Curso :";
            // 
            // textBoxturno
            // 
            textBoxturno.BackColor = Color.FromArgb(192, 0, 0);
            textBoxturno.Location = new Point(114, 191);
            textBoxturno.Name = "textBoxturno";
            textBoxturno.Size = new Size(100, 23);
            textBoxturno.TabIndex = 4;
            // 
            // textBoxduracao
            // 
            textBoxduracao.BackColor = Color.FromArgb(192, 0, 0);
            textBoxduracao.Location = new Point(114, 246);
            textBoxduracao.Name = "textBoxduracao";
            textBoxduracao.Size = new Size(100, 23);
            textBoxduracao.TabIndex = 5;
            // 
            // comboBoxcurso
            // 
            comboBoxcurso.BackColor = Color.FromArgb(192, 0, 0);
            comboBoxcurso.FormattingEnabled = true;
            comboBoxcurso.Items.AddRange(new object[] { "Introdução à Programação", "Desenvolvimento Web", "Programação Orientada a Objetos", "Bases de Dados e Sistemas de Informação", "Inteligência Artificial e Aprendizado de Máquina", "Redes de Computadore", "Segurança da Informação e Criptografia", "Desenvolvimento Mobile", "Engenharia de Software", "Design e Usabilidade de Interfaces", "Internet das Coisas (IoT)", "Realidade Virtual e Aumentada", "Robótica e Automação", "Big Data e Análise de Dados", "Sistemas Embarcados", "Computação em Nuvem e Serviços Online", "Engenharia Eletrônica e Circuitos Integrados", "Energias Renováveis e Sustentabilidade Tecnológica", "Gestão da Inovação e Empreendedorismo Tecnológico", "Ética e Responsabilidade Social na Tecnologia" });
            comboBoxcurso.Location = new Point(114, 303);
            comboBoxcurso.Name = "comboBoxcurso";
            comboBoxcurso.Size = new Size(335, 23);
            comboBoxcurso.TabIndex = 6;
            // 
            // label5
            // 
            label5.Image = Properties.Resources.facu;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(179, 158);
            label5.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(243, 191);
            button1.Name = "button1";
            button1.Size = new Size(206, 78);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(463, 338);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBoxcurso);
            Controls.Add(textBoxduracao);
            Controls.Add(textBoxturno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxturno;
        private TextBox textBoxduracao;
        private ComboBox comboBoxcurso;
        private Label label5;
        private Button button1;
    }
}