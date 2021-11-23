
namespace LMControls
{
    partial class LmMsgBox
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
            this.btnCancel = new LMControls.LmControls.LmButton();
            this.btnNo = new LMControls.LmControls.LmButton();
            this.btnYes = new LMControls.LmControls.LmButton();
            this.btnOk = new LMControls.LmControls.LmButton();
            this.btnIgnore = new LMControls.LmControls.LmButton();
            this.btnRetry = new LMControls.LmControls.LmButton();
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
            this.flpBotoes.Controls.Add(this.btnCancel);
            this.flpBotoes.Controls.Add(this.btnNo);
            this.flpBotoes.Controls.Add(this.btnYes);
            this.flpBotoes.Controls.Add(this.btnOk);
            this.flpBotoes.Controls.Add(this.btnIgnore);
            this.flpBotoes.Controls.Add(this.btnRetry);
            this.flpBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBotoes.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotoes.Location = new System.Drawing.Point(80, 66);
            this.flpBotoes.Name = "flpBotoes";
            this.flpBotoes.Size = new System.Drawing.Size(702, 35);
            this.flpBotoes.TabIndex = 1;
            this.flpBotoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 20;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(591, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnNo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNo.BorderRadius = 15;
            this.btnNo.BorderSize = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnNo.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnNo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNo.IconSize = 22;
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.Location = new System.Drawing.Point(479, 3);
            this.btnNo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(110, 30);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "&Não";
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnYes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnYes.BorderRadius = 15;
            this.btnYes.BorderSize = 0;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnYes.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnYes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnYes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYes.IconSize = 20;
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.Location = new System.Drawing.Point(367, 3);
            this.btnYes.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(110, 30);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "&Sim";
            this.btnYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOk.BorderRadius = 15;
            this.btnOk.BorderSize = 0;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnOk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOk.IconSize = 20;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(255, 3);
            this.btnOk.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&OK";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnIgnore
            // 
            this.btnIgnore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnIgnore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIgnore.BorderRadius = 15;
            this.btnIgnore.BorderSize = 0;
            this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnIgnore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnIgnore.FlatAppearance.BorderSize = 0;
            this.btnIgnore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnIgnore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnIgnore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgnore.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgnore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnIgnore.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.btnIgnore.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnIgnore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIgnore.IconSize = 20;
            this.btnIgnore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIgnore.Location = new System.Drawing.Point(143, 3);
            this.btnIgnore.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(110, 30);
            this.btnIgnore.TabIndex = 5;
            this.btnIgnore.Text = "&Ignorar";
            this.btnIgnore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIgnore.UseVisualStyleBackColor = false;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRetry.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRetry.BorderRadius = 15;
            this.btnRetry.BorderSize = 0;
            this.btnRetry.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnRetry.FlatAppearance.BorderSize = 0;
            this.btnRetry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnRetry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRetry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnRetry.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.btnRetry.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnRetry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRetry.IconSize = 20;
            this.btnRetry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetry.Location = new System.Drawing.Point(31, 3);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(110, 30);
            this.btnRetry.TabIndex = 4;
            this.btnRetry.Text = "&Repetir";
            this.btnRetry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetry.UseVisualStyleBackColor = false;
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
            // LmMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 105);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrincipal);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LmMsgBox";
            this.Text = "LmMsgBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LmMsgBox_KeyDown);
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
        private LmControls.LmButton btnCancel;
        private LmControls.LmButton btnNo;
        private LmControls.LmButton btnYes;
        private LmControls.LmButton btnOk;
        private LmControls.LmButton btnIgnore;
        private LmControls.LmButton btnRetry;
    }
}