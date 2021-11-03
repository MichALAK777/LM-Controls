
namespace LMControls.LmControls
{
    partial class LmColunaGrid
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lnkExcluir = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lnkExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(226, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Nome Coluna no Grid";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkExcluir
            // 
            this.lnkExcluir.BackColor = System.Drawing.Color.Transparent;
            this.lnkExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnkExcluir.Image = global::LMControls.Properties.Resources.seta_cheia_frente_15px;
            this.lnkExcluir.Location = new System.Drawing.Point(226, 0);
            this.lnkExcluir.Name = "lnkExcluir";
            this.lnkExcluir.Size = new System.Drawing.Size(22, 13);
            this.lnkExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkExcluir.TabIndex = 1;
            this.lnkExcluir.TabStop = false;
            // 
            // LmColunaGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lnkExcluir);
            this.Name = "LmColunaGrid";
            this.Size = new System.Drawing.Size(248, 13);
            ((System.ComponentModel.ISupportInitialize)(this.lnkExcluir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox lnkExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label lblDescricao;
    }
}
