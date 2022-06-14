namespace System_KWB
{
    partial class frmRecuperação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperação));
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.buttonRecuperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 12);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(122, 16);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email de Cadastro:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(15, 31);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(267, 20);
            this.textEmail.TabIndex = 2;
            // 
            // buttonRecuperar
            // 
            this.buttonRecuperar.BackColor = System.Drawing.Color.White;
            this.buttonRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecuperar.Location = new System.Drawing.Point(288, 29);
            this.buttonRecuperar.Name = "buttonRecuperar";
            this.buttonRecuperar.Size = new System.Drawing.Size(72, 23);
            this.buttonRecuperar.TabIndex = 4;
            this.buttonRecuperar.Text = "&Recuperar";
            this.buttonRecuperar.UseVisualStyleBackColor = false;
            this.buttonRecuperar.Click += new System.EventHandler(this.buttonRecuperar_Click);
            // 
            // frmRecuperação
            // 
            this.AcceptButton = this.buttonRecuperar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 63);
            this.Controls.Add(this.buttonRecuperar);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recuperação de Usuário/Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button buttonRecuperar;
    }
}