namespace AutoInstaller
{
    partial class Form1
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
            this.chkNotepadplusplus = new System.Windows.Forms.CheckBox();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkNotepadplusplus
            // 
            this.chkNotepadplusplus.AutoSize = true;
            this.chkNotepadplusplus.Location = new System.Drawing.Point(12, 12);
            this.chkNotepadplusplus.Name = "chkNotepadplusplus";
            this.chkNotepadplusplus.Size = new System.Drawing.Size(82, 17);
            this.chkNotepadplusplus.TabIndex = 1;
            this.chkNotepadplusplus.Text = "Notepad ++";
            this.chkNotepadplusplus.UseVisualStyleBackColor = true;
            // 
            // btnInstalar
            // 
            this.btnInstalar.Location = new System.Drawing.Point(12, 260);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(158, 50);
            this.btnInstalar.TabIndex = 2;
            this.btnInstalar.Text = "Instalar";
            this.btnInstalar.UseVisualStyleBackColor = true;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 359);
            this.Controls.Add(this.btnInstalar);
            this.Controls.Add(this.chkNotepadplusplus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNotepadplusplus;
        private System.Windows.Forms.Button btnInstalar;
    }
}

