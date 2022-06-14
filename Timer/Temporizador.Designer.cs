namespace Timer
{
    partial class Temporizador
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
            this.MascaraHorario = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempoAtual = new System.Windows.Forms.Label();
            this.TimerOff = new System.Windows.Forms.Timer(this.components);
            this.TimerOn = new System.Windows.Forms.Timer(this.components);
            this.Iniciar = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MascaraHorario
            // 
            this.MascaraHorario.Location = new System.Drawing.Point(104, 17);
            this.MascaraHorario.Mask = "00:00:00";
            this.MascaraHorario.Name = "MascaraHorario";
            this.MascaraHorario.PromptChar = ' ';
            this.MascaraHorario.Size = new System.Drawing.Size(54, 20);
            this.MascaraHorario.TabIndex = 0;
            this.MascaraHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MascaraHorario.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Horário Definido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário Atual:";
            // 
            // TempoAtual
            // 
            this.TempoAtual.Location = new System.Drawing.Point(104, 51);
            this.TempoAtual.Name = "TempoAtual";
            this.TempoAtual.Size = new System.Drawing.Size(54, 13);
            this.TempoAtual.TabIndex = 3;
            this.TempoAtual.Text = "00:00:00";
            this.TempoAtual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerOff
            // 
            this.TimerOff.Enabled = true;
            this.TimerOff.Interval = 1000;
            this.TimerOff.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerOn
            // 
            this.TimerOn.Interval = 1000;
            this.TimerOn.Tick += new System.EventHandler(this.TimerOn_Tick);
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(170, 14);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(66, 23);
            this.Iniciar.TabIndex = 6;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(170, 46);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(66, 23);
            this.Parar.TabIndex = 7;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Temporizador
            // 
            this.AcceptButton = this.Iniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 81);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.TempoAtual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MascaraHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Temporizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Temporizador_FormClosed);
            this.Load += new System.EventHandler(this.Temporizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MascaraHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TempoAtual;
        private System.Windows.Forms.Timer TimerOff;
        private System.Windows.Forms.Timer TimerOn;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Parar;
    }
}

