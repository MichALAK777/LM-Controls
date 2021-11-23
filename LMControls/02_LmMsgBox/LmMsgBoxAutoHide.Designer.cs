
namespace LMControls
{
    partial class LmMsgBoxAutoHide
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbIcone = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(217)))));
            this.pnlPrincipal.Controls.Add(this.lblTexto);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Controls.Add(this.ptbIcone);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(2, 2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(782, 101);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTexto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(87)))), ((int)(((byte)(90)))));
            this.lblTexto.Location = new System.Drawing.Point(80, 28);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Padding = new System.Windows.Forms.Padding(15, 3, 15, 5);
            this.lblTexto.Size = new System.Drawing.Size(150, 26);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "Seu Texto Aqui";
            this.lblTexto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(87)))), ((int)(((byte)(90)))));
            this.lblTitulo.Location = new System.Drawing.Point(80, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(702, 28);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo Aqui";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseDown);
            // 
            // ptbIcone
            // 
            this.ptbIcone.BackColor = System.Drawing.Color.Transparent;
            this.ptbIcone.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ptbIcone.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.ptbIcone.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ptbIcone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbIcone.IconSize = 80;
            this.ptbIcone.Location = new System.Drawing.Point(0, 0);
            this.ptbIcone.Name = "ptbIcone";
            this.ptbIcone.Size = new System.Drawing.Size(80, 101);
            this.ptbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbIcone.TabIndex = 0;
            this.ptbIcone.TabStop = false;
            this.ptbIcone.UseGdi = true;
            this.ptbIcone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseDown);
            // 
            // LmMsgBoxAutoHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 105);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrincipal);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LmMsgBoxAutoHide";
            this.Text = "LmMsgBoxAutoHide";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LmMsgBoxAutoHide_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private FontAwesome.Sharp.IconPictureBox ptbIcone;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
    }
}