namespace unividades.View
{
    partial class TelaPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisa));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxsala = new TextBox();
            textBoxhorario = new TextBox();
            textBoxcod = new TextBox();
            label3 = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Square721 BT", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(238, 35);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 0, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(32, 243);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Sala :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 0, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(32, 272);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Horario :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 0, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(32, 214);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Código :";
            // 
            // textBoxsala
            // 
            textBoxsala.BackColor = Color.FromArgb(192, 0, 0);
            textBoxsala.Location = new Point(137, 235);
            textBoxsala.Name = "textBoxsala";
            textBoxsala.Size = new Size(100, 23);
            textBoxsala.TabIndex = 5;
            // 
            // textBoxhorario
            // 
            textBoxhorario.BackColor = Color.FromArgb(192, 0, 0);
            textBoxhorario.Location = new Point(137, 264);
            textBoxhorario.Name = "textBoxhorario";
            textBoxhorario.Size = new Size(100, 23);
            textBoxhorario.TabIndex = 6;
            // 
            // textBoxcod
            // 
            textBoxcod.BackColor = Color.FromArgb(192, 0, 0);
            textBoxcod.Location = new Point(137, 206);
            textBoxcod.Name = "textBoxcod";
            textBoxcod.Size = new Size(46, 23);
            textBoxcod.TabIndex = 7;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.facu;
            label3.Location = new Point(12, -1);
            label3.Name = "label3";
            label3.Size = new Size(189, 176);
            label3.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 128, 128);
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Image = Properties.Resources.lupa;
            btnBuscar.Location = new Point(286, 157);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(151, 139);
            btnBuscar.TabIndex = 9;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TelaPesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(496, 310);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(textBoxcod);
            Controls.Add(textBoxhorario);
            Controls.Add(textBoxsala);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "TelaPesquisa";
            Text = "TelaPesquisa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBoxsala;
        private TextBox textBoxhorario;
        private TextBox textBoxcod;
        private Label label3;
        private Button btnBuscar;
    }
}