
namespace LMControls
{
    partial class LmMsgBoxCustom
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
            this.flpBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpcao3 = new LMControls.LmControls.LmButton();
            this.btnOpcao2 = new LMControls.LmControls.LmButton();
            this.btnOpcao1 = new LMControls.LmControls.LmButton();
            this.ptbIcone = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.flpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(217)))));
            this.pnlPrincipal.Controls.Add(this.lblTexto);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Controls.Add(this.flpBotoes);
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
            // flpBotoes
            // 
            this.flpBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(207)))));
            this.flpBotoes.Controls.Add(this.btnOpcao3);
            this.flpBotoes.Controls.Add(this.btnOpcao2);
            this.flpBotoes.Controls.Add(this.btnOpcao1);
            this.flpBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBotoes.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotoes.Location = new System.Drawing.Point(80, 66);
            this.flpBotoes.Name = "flpBotoes";
            this.flpBotoes.Size = new System.Drawing.Size(702, 35);
            this.flpBotoes.TabIndex = 1;
            this.flpBotoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseDown);
            // 
            // btnOpcao3
            // 
            this.btnOpcao3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnOpcao3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpcao3.BorderRadius = 15;
            this.btnOpcao3.BorderSize = 0;
            this.btnOpcao3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpcao3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnOpcao3.FlatAppearance.BorderSize = 0;
            this.btnOpcao3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnOpcao3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnOpcao3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcao3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpcao3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOpcao3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOpcao3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOpcao3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpcao3.IconSize = 20;
            this.btnOpcao3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpcao3.Location = new System.Drawing.Point(591, 3);
            this.btnOpcao3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnOpcao3.Name = "btnOpcao3";
            this.btnOpcao3.Size = new System.Drawing.Size(110, 30);
            this.btnOpcao3.TabIndex = 3;
            this.btnOpcao3.Text = "Opção 3";
            this.btnOpcao3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpcao3.UseVisualStyleBackColor = false;
            // 
            // btnOpcao2
            // 
            this.btnOpcao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnOpcao2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpcao2.BorderRadius = 15;
            this.btnOpcao2.BorderSize = 0;
            this.btnOpcao2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnOpcao2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnOpcao2.FlatAppearance.BorderSize = 0;
            this.btnOpcao2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnOpcao2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnOpcao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcao2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpcao2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOpcao2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOpcao2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOpcao2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpcao2.IconSize = 22;
            this.btnOpcao2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpcao2.Location = new System.Drawing.Point(479, 3);
            this.btnOpcao2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnOpcao2.Name = "btnOpcao2";
            this.btnOpcao2.Size = new System.Drawing.Size(110, 30);
            this.btnOpcao2.TabIndex = 2;
            this.btnOpcao2.Text = "Opção 2";
            this.btnOpcao2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpcao2.UseVisualStyleBackColor = false;
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnOpcao1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpcao1.BorderRadius = 15;
            this.btnOpcao1.BorderSize = 0;
            this.btnOpcao1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOpcao1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnOpcao1.FlatAppearance.BorderSize = 0;
            this.btnOpcao1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnOpcao1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnOpcao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcao1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpcao1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOpcao1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOpcao1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOpcao1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpcao1.IconSize = 20;
            this.btnOpcao1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpcao1.Location = new System.Drawing.Point(367, 3);
            this.btnOpcao1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnOpcao1.Name = "btnOpcao1";
            this.btnOpcao1.Size = new System.Drawing.Size(110, 30);
            this.btnOpcao1.TabIndex = 1;
            this.btnOpcao1.Text = "Opção 1";
            this.btnOpcao1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpcao1.UseVisualStyleBackColor = false;
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
            // LmMsgBoxCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 105);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrincipal);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LmMsgBoxCustom";
            this.Text = "LmMsgBoxCustom";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LmMsgBoxCustom_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.flpBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private FontAwesome.Sharp.IconPictureBox ptbIcone;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotoes;
        private LmControls.LmButton btnOpcao3;
        private LmControls.LmButton btnOpcao2;
        private LmControls.LmButton btnOpcao1;
    }
}