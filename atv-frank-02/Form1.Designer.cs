namespace atv_frank_02
{
    partial class Ola
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOii
            // 
            this.btnOii.BackColor = System.Drawing.Color.LightBlue;
            this.btnOii.Location = new System.Drawing.Point(12, 12);
            this.btnOii.Name = "btnOii";
            this.btnOii.Size = new System.Drawing.Size(195, 45);
            this.btnOii.TabIndex = 0;
            this.btnOii.Text = "Mensagem disponivel!";
            this.btnOii.UseVisualStyleBackColor = false;
            this.btnOii.Click += new System.EventHandler(this.btnOii_Click);
            // 
            // Ola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(219, 66);
            this.Controls.Add(this.btnOii);
            this.Name = "Ola";
            this.Text = "Olá ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOii;
    }
}

