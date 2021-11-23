
namespace LMControls
{
    partial class LmImputBox
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
            this.lblTitulo = new LMControls.LmControls.LmLabel();
            this.lblDesc = new LMControls.LmControls.LmLabel();
            this.txt = new LMControls.LmControls.LmTextBox();
            this.btnConfirmar = new LMControls.LmControls.LmButton();
            this.btnCancelar = new LMControls.LmControls.LmButton();
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(64, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "lmLabel1";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(44, 28);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(3);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(64, 19);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "lmLabel2";
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txt.BorderRadius = 6;
            this.txt.BorderSize = 2;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt.Icon = FontAwesome.Sharp.IconChar.None;
            this.txt.IconF7 = FontAwesome.Sharp.IconChar.Check;
            this.txt.IconF8 = FontAwesome.Sharp.IconChar.Times;
            this.txt.IconSize = 16;
            this.txt.IconSizeF7 = 30;
            this.txt.IconSizeF8 = 30;
            this.txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt.Lines = new string[0];
            this.txt.Location = new System.Drawing.Point(44, 48);
            this.txt.Margin = new System.Windows.Forms.Padding(4);
            this.txt.MaxLength = 32767;
            this.txt.Name = "txt";
            this.txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt.PasswordChar = '\0';
            this.txt.Propriedade = null;
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt.SelectedText = "";
            this.txt.SelectionLength = 0;
            this.txt.SelectionStart = 0;
            this.txt.ShortcutsEnabled = true;
            this.txt.ShowButtonF7 = true;
            this.txt.ShowButtonF8 = true;
            this.txt.Size = new System.Drawing.Size(277, 31);
            this.txt.TabIndex = 0;
            this.txt.TextPrompt = "";
            this.txt.UnderlinedStyle = false;
            this.txt.Valor_Decimais = ((short)(0));
            this.txt.ButtonClickF7 += new LMControls.LmControls.LmTextBox.ButClick(this.Txt_ButtonClickF7);
            this.txt.ButtonClickF8 += new LMControls.LmControls.LmTextBox.ButClick(this.Txt_ButtonClickF8);
            this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmar.BorderRadius = 15;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnConfirmar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmar.IconSize = 21;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(95, 86);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 30);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 21;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(211, 86);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // LmImputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 94);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitulo);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LmImputBox";
            this.Text = "FrmImputBox";
            this.SizeChanged += new System.EventHandler(this.LmImputBox_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LmControls.LmLabel lblTitulo;
        private LmControls.LmLabel lblDesc;
        private LmControls.LmButton btnConfirmar;
        private LmControls.LmButton btnCancelar;
        internal LmControls.LmTextBox txt;
    }
}