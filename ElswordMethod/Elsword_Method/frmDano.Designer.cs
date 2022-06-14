namespace Elsword_Method
{
    partial class frmDano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDano));
            this.Escolhas = new System.Windows.Forms.Panel();
            this.Rad_Hib = new System.Windows.Forms.RadioButton();
            this.Rad_Mag = new System.Windows.Forms.RadioButton();
            this.Rad_Fis = new System.Windows.Forms.RadioButton();
            this.Atributos = new System.Windows.Forms.Panel();
            this.Porce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Atq_Fis = new System.Windows.Forms.TextBox();
            this.Atq_Mag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.A_Ref = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.Panel();
            this.Qnt = new System.Windows.Forms.NumericUpDown();
            this.Cri = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Dan_Fin = new System.Windows.Forms.TextBox();
            this.Escolhas.SuspendLayout();
            this.Atributos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_Ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qnt)).BeginInit();
            this.Final.SuspendLayout();
            this.SuspendLayout();
            // 
            // Escolhas
            // 
            this.Escolhas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Escolhas.Controls.Add(this.Rad_Hib);
            this.Escolhas.Controls.Add(this.Rad_Mag);
            this.Escolhas.Controls.Add(this.Rad_Fis);
            this.Escolhas.Location = new System.Drawing.Point(12, 90);
            this.Escolhas.Name = "Escolhas";
            this.Escolhas.Size = new System.Drawing.Size(204, 214);
            this.Escolhas.TabIndex = 0;
            // 
            // Rad_Hib
            // 
            this.Rad_Hib.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rad_Hib.BackColor = System.Drawing.Color.White;
            this.Rad_Hib.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rad_Hib.BackgroundImage")));
            this.Rad_Hib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rad_Hib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_Hib.Location = new System.Drawing.Point(14, 151);
            this.Rad_Hib.Name = "Rad_Hib";
            this.Rad_Hib.Size = new System.Drawing.Size(177, 44);
            this.Rad_Hib.TabIndex = 2;
            this.Rad_Hib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rad_Hib.UseVisualStyleBackColor = false;
            // 
            // Rad_Mag
            // 
            this.Rad_Mag.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rad_Mag.BackColor = System.Drawing.Color.White;
            this.Rad_Mag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rad_Mag.BackgroundImage")));
            this.Rad_Mag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rad_Mag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_Mag.Location = new System.Drawing.Point(14, 85);
            this.Rad_Mag.Name = "Rad_Mag";
            this.Rad_Mag.Size = new System.Drawing.Size(177, 44);
            this.Rad_Mag.TabIndex = 1;
            this.Rad_Mag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rad_Mag.UseVisualStyleBackColor = false;
            // 
            // Rad_Fis
            // 
            this.Rad_Fis.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rad_Fis.BackColor = System.Drawing.Color.White;
            this.Rad_Fis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rad_Fis.BackgroundImage")));
            this.Rad_Fis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rad_Fis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_Fis.Location = new System.Drawing.Point(14, 19);
            this.Rad_Fis.Name = "Rad_Fis";
            this.Rad_Fis.Size = new System.Drawing.Size(177, 44);
            this.Rad_Fis.TabIndex = 0;
            this.Rad_Fis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rad_Fis.UseVisualStyleBackColor = false;
            this.Rad_Fis.CheckedChanged += new System.EventHandler(this.Rad_Fis_CheckedChanged);
            // 
            // Atributos
            // 
            this.Atributos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Atributos.Controls.Add(this.Porce);
            this.Atributos.Controls.Add(this.label3);
            this.Atributos.Controls.Add(this.Atq_Fis);
            this.Atributos.Controls.Add(this.Atq_Mag);
            this.Atributos.Controls.Add(this.label2);
            this.Atributos.Controls.Add(this.label1);
            this.Atributos.Enabled = false;
            this.Atributos.Location = new System.Drawing.Point(222, 90);
            this.Atributos.Name = "Atributos";
            this.Atributos.Size = new System.Drawing.Size(175, 175);
            this.Atributos.TabIndex = 1;
            // 
            // Porce
            // 
            this.Porce.Font = new System.Drawing.Font("Natura Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porce.Location = new System.Drawing.Point(19, 137);
            this.Porce.Name = "Porce";
            this.Porce.Size = new System.Drawing.Size(139, 19);
            this.Porce.TabIndex = 2;
            this.Porce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Natura Play", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Porcentagem de Dano:";
            // 
            // Atq_Fis
            // 
            this.Atq_Fis.Font = new System.Drawing.Font("Natura Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atq_Fis.Location = new System.Drawing.Point(19, 37);
            this.Atq_Fis.Name = "Atq_Fis";
            this.Atq_Fis.Size = new System.Drawing.Size(139, 19);
            this.Atq_Fis.TabIndex = 0;
            this.Atq_Fis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Atq_Mag
            // 
            this.Atq_Mag.Font = new System.Drawing.Font("Natura Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atq_Mag.Location = new System.Drawing.Point(19, 86);
            this.Atq_Mag.Name = "Atq_Mag";
            this.Atq_Mag.Size = new System.Drawing.Size(139, 19);
            this.Atq_Mag.TabIndex = 1;
            this.Atq_Mag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Natura Play", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ataque Mágico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Natura Play", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ataque Físico:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.A_Ref);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(222, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 102);
            this.panel3.TabIndex = 12;
            // 
            // A_Ref
            // 
            this.A_Ref.BackColor = System.Drawing.Color.White;
            this.A_Ref.Font = new System.Drawing.Font("Natura Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Ref.Location = new System.Drawing.Point(19, 36);
            this.A_Ref.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.A_Ref.Name = "A_Ref";
            this.A_Ref.ReadOnly = true;
            this.A_Ref.Size = new System.Drawing.Size(139, 19);
            this.A_Ref.TabIndex = 0;
            this.A_Ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A_Ref.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Natura Play", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(19, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Critico (100%)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Natura Play", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade de Golpes:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Natura Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 27);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Natura Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 27);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Location = new System.Drawing.Point(679, 46);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(41, 22);
            this.Minimizar.TabIndex = 16;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Location = new System.Drawing.Point(679, 6);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(41, 34);
            this.Fechar.TabIndex = 15;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Info.Controls.Add(this.Qnt);
            this.Info.Controls.Add(this.Cri);
            this.Info.Controls.Add(this.label6);
            this.Info.Enabled = false;
            this.Info.Location = new System.Drawing.Point(222, 271);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(175, 102);
            this.Info.TabIndex = 12;
            // 
            // Qnt
            // 
            this.Qnt.BackColor = System.Drawing.Color.White;
            this.Qnt.Font = new System.Drawing.Font("Natura Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qnt.Location = new System.Drawing.Point(19, 36);
            this.Qnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qnt.Name = "Qnt";
            this.Qnt.ReadOnly = true;
            this.Qnt.Size = new System.Drawing.Size(139, 19);
            this.Qnt.TabIndex = 0;
            this.Qnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cri
            // 
            this.Cri.AutoSize = true;
            this.Cri.Font = new System.Drawing.Font("Natura Play", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cri.Location = new System.Drawing.Point(19, 66);
            this.Cri.Name = "Cri";
            this.Cri.Size = new System.Drawing.Size(99, 17);
            this.Cri.TabIndex = 1;
            this.Cri.Text = "Critico (100%)";
            this.Cri.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Natura Play", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade de Golpes:";
            // 
            // Final
            // 
            this.Final.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Final.Controls.Add(this.label5);
            this.Final.Controls.Add(this.Dan_Fin);
            this.Final.Enabled = false;
            this.Final.Location = new System.Drawing.Point(403, 271);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(295, 102);
            this.Final.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Natura Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dano Final (Aproximado)";
            // 
            // Dan_Fin
            // 
            this.Dan_Fin.Font = new System.Drawing.Font("Natura Play", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dan_Fin.Location = new System.Drawing.Point(13, 44);
            this.Dan_Fin.Multiline = true;
            this.Dan_Fin.Name = "Dan_Fin";
            this.Dan_Fin.Size = new System.Drawing.Size(270, 36);
            this.Dan_Fin.TabIndex = 14;
            this.Dan_Fin.TabStop = false;
            this.Dan_Fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmDano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 401);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Atributos);
            this.Controls.Add(this.Escolhas);
            this.Controls.Add(this.Final);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDano";
            this.Escolhas.ResumeLayout(false);
            this.Atributos.ResumeLayout(false);
            this.Atributos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_Ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qnt)).EndInit();
            this.Final.ResumeLayout(false);
            this.Final.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Escolhas;
        private System.Windows.Forms.RadioButton Rad_Hib;
        private System.Windows.Forms.RadioButton Rad_Mag;
        private System.Windows.Forms.RadioButton Rad_Fis;
        private System.Windows.Forms.Panel Atributos;
        private System.Windows.Forms.TextBox Porce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Atq_Fis;
        private System.Windows.Forms.TextBox Atq_Mag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown A_Ref;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.NumericUpDown Qnt;
        private System.Windows.Forms.CheckBox Cri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Final;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Dan_Fin;


    }
}