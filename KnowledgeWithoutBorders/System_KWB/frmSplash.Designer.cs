namespace System_KWB
{
    partial class frmSplash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.Progresso = new System.Windows.Forms.ProgressBar();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.pictureSplash = new System.Windows.Forms.PictureBox();
            this.pictureCancelar = new System.Windows.Forms.PictureBox();
            this.pictureCarregamento = new System.Windows.Forms.PictureBox();
            this.Descrição = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSplash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarregamento)).BeginInit();
            this.SuspendLayout();
            // 
            // Progresso
            // 
            this.Progresso.Location = new System.Drawing.Point(57, 242);
            this.Progresso.Name = "Progresso";
            this.Progresso.Size = new System.Drawing.Size(345, 16);
            this.Progresso.TabIndex = 0;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 200;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // pictureSplash
            // 
            this.pictureSplash.BackColor = System.Drawing.Color.White;
            this.pictureSplash.Image = ((System.Drawing.Image)(resources.GetObject("pictureSplash.Image")));
            this.pictureSplash.Location = new System.Drawing.Point(15, 12);
            this.pictureSplash.Name = "pictureSplash";
            this.pictureSplash.Size = new System.Drawing.Size(409, 200);
            this.pictureSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSplash.TabIndex = 2;
            this.pictureSplash.TabStop = false;
            // 
            // pictureCancelar
            // 
            this.pictureCancelar.BackColor = System.Drawing.Color.White;
            this.pictureCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pictureCancelar.Image")));
            this.pictureCancelar.Location = new System.Drawing.Point(408, 242);
            this.pictureCancelar.Name = "pictureCancelar";
            this.pictureCancelar.Size = new System.Drawing.Size(16, 16);
            this.pictureCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCancelar.TabIndex = 3;
            this.pictureCancelar.TabStop = false;
            this.pictureCancelar.Click += new System.EventHandler(this.pictureCancelar_Click);
            // 
            // pictureCarregamento
            // 
            this.pictureCarregamento.BackColor = System.Drawing.Color.White;
            this.pictureCarregamento.Image = ((System.Drawing.Image)(resources.GetObject("pictureCarregamento.Image")));
            this.pictureCarregamento.Location = new System.Drawing.Point(11, 222);
            this.pictureCarregamento.Name = "pictureCarregamento";
            this.pictureCarregamento.Size = new System.Drawing.Size(36, 36);
            this.pictureCarregamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCarregamento.TabIndex = 4;
            this.pictureCarregamento.TabStop = false;
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.BackColor = System.Drawing.Color.White;
            this.Descrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrição.Location = new System.Drawing.Point(54, 223);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(154, 16);
            this.Descrição.TabIndex = 5;
            this.Descrição.Text = "Inicializando o Sistema...";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.pictureCarregamento);
            this.Controls.Add(this.pictureCancelar);
            this.Controls.Add(this.pictureSplash);
            this.Controls.Add(this.Progresso);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Splash";
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            ((System.ComponentModel.ISupportInitialize)(this.pictureSplash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarregamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Progresso;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.PictureBox pictureSplash;
        private System.Windows.Forms.PictureBox pictureCancelar;
        private System.Windows.Forms.PictureBox pictureCarregamento;
        private System.Windows.Forms.Label Descrição;
    }
}

