namespace Elsword_Method
{
    partial class frmIntrodução
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntrodução));
            this.Refino = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Calculadora = new System.Windows.Forms.PictureBox();
            this.Encantamento = new System.Windows.Forms.PictureBox();
            this.Atributos = new System.Windows.Forms.PictureBox();
            this.Mensagem = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Refino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calculadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encantamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atributos)).BeginInit();
            this.SuspendLayout();
            // 
            // Refino
            // 
            this.Refino.BackColor = System.Drawing.Color.Transparent;
            this.Refino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refino.Location = new System.Drawing.Point(26, 122);
            this.Refino.Name = "Refino";
            this.Refino.Size = new System.Drawing.Size(164, 142);
            this.Refino.TabIndex = 0;
            this.Refino.TabStop = false;
            this.Refino.Click += new System.EventHandler(this.Refino_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Location = new System.Drawing.Point(705, 6);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(44, 34);
            this.Fechar.TabIndex = 4;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Location = new System.Drawing.Point(705, 50);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(44, 22);
            this.Minimizar.TabIndex = 5;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Calculadora
            // 
            this.Calculadora.BackColor = System.Drawing.Color.Transparent;
            this.Calculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculadora.Location = new System.Drawing.Point(210, 286);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(165, 147);
            this.Calculadora.TabIndex = 6;
            this.Calculadora.TabStop = false;
            this.Calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // Encantamento
            // 
            this.Encantamento.BackColor = System.Drawing.Color.Transparent;
            this.Encantamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encantamento.Location = new System.Drawing.Point(210, 122);
            this.Encantamento.Name = "Encantamento";
            this.Encantamento.Size = new System.Drawing.Size(165, 142);
            this.Encantamento.TabIndex = 7;
            this.Encantamento.TabStop = false;
            // 
            // Atributos
            // 
            this.Atributos.BackColor = System.Drawing.Color.Transparent;
            this.Atributos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atributos.Location = new System.Drawing.Point(26, 286);
            this.Atributos.Name = "Atributos";
            this.Atributos.Size = new System.Drawing.Size(164, 143);
            this.Atributos.TabIndex = 8;
            this.Atributos.TabStop = false;
            // 
            // Mensagem
            // 
            this.Mensagem.ShowAlways = true;
            this.Mensagem.ToolTipTitle = "Elsword Method";
            // 
            // frmIntrodução
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.Atributos);
            this.Controls.Add(this.Encantamento);
            this.Controls.Add(this.Calculadora);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Refino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIntrodução";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introdução";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIntrodução_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIntrodução_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Refino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calculadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encantamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atributos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Refino;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Calculadora;
        private System.Windows.Forms.PictureBox Encantamento;
        private System.Windows.Forms.PictureBox Atributos;
        private System.Windows.Forms.ToolTip Mensagem;

    }
}