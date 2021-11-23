
namespace LMControls.LmControls
{
    partial class LmTextBox
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
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.ptbIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ptbF8 = new FontAwesome.Sharp.IconPictureBox();
            this.ptbF7 = new FontAwesome.Sharp.IconPictureBox();
            this.ptbClearButton = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbF8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbF7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClearButton)).BeginInit();
            this.SuspendLayout();
            // 
            // baseTextBox
            // 
            this.baseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTextBox.Location = new System.Drawing.Point(34, 7);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(73, 15);
            this.baseTextBox.TabIndex = 0;
            this.baseTextBox.AcceptsTabChanged += new System.EventHandler(this.BaseTextBoxAcceptsTabChanged);
            this.baseTextBox.Click += new System.EventHandler(this.BaseTextBoxClick);
            this.baseTextBox.CausesValidationChanged += new System.EventHandler(this.BaseTextBoxCausesValidationChanged);
            this.baseTextBox.ClientSizeChanged += new System.EventHandler(this.BaseTextBoxClientSizeChanged);
            this.baseTextBox.ContextMenuStripChanged += new System.EventHandler(this.BaseTextBoxContextMenuStripChanged);
            this.baseTextBox.CursorChanged += new System.EventHandler(this.BaseTextBoxCursorChanged);
            this.baseTextBox.SizeChanged += new System.EventHandler(this.BaseTextBoxSizeChanged);
            this.baseTextBox.TextChanged += new System.EventHandler(this.BaseTextBoxTextChanged);
            this.baseTextBox.Enter += new System.EventHandler(this.baseTextBox_Enter);
            this.baseTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseTextBoxKeyDown);
            this.baseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaseTextBoxKeyPress);
            this.baseTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BaseTextBoxKeyUp);
            this.baseTextBox.Leave += new System.EventHandler(this.baseTextBox_Leave);
            this.baseTextBox.MouseEnter += new System.EventHandler(this.BaseTextBox_MouseEnter);
            this.baseTextBox.MouseLeave += new System.EventHandler(this.BaseTextBox_MouseLeave);
            this.baseTextBox.MouseHover += new System.EventHandler(this.BaseTextBox_MouseHover);
            this.baseTextBox.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.BaseTextBoxChangeUiCues);
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ptbIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbIcon.IconSize = 16;
            this.ptbIcon.Location = new System.Drawing.Point(10, 7);
            this.ptbIcon.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(24, 16);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbIcon.TabIndex = 1;
            this.ptbIcon.TabStop = false;
            this.ptbIcon.UseGdi = true;
            // 
            // ptbF8
            // 
            this.ptbF8.BackColor = System.Drawing.Color.Transparent;
            this.ptbF8.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbF8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbF8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ptbF8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbF8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbF8.IconSize = 16;
            this.ptbF8.Location = new System.Drawing.Point(147, 7);
            this.ptbF8.Name = "ptbF8";
            this.ptbF8.Size = new System.Drawing.Size(16, 16);
            this.ptbF8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbF8.TabIndex = 2;
            this.ptbF8.TabStop = false;
            this.ptbF8.UseGdi = true;
            this.ptbF8.Click += new System.EventHandler(this._buttonF8_Click);
            this.ptbF8.MouseEnter += new System.EventHandler(this.Ptb_MouseEnter);
            this.ptbF8.MouseLeave += new System.EventHandler(this.ptb_MouseLeave);
            // 
            // ptbF7
            // 
            this.ptbF7.BackColor = System.Drawing.Color.Transparent;
            this.ptbF7.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbF7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbF7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ptbF7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbF7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ptbF7.IconSize = 16;
            this.ptbF7.Location = new System.Drawing.Point(131, 7);
            this.ptbF7.Name = "ptbF7";
            this.ptbF7.Size = new System.Drawing.Size(16, 16);
            this.ptbF7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbF7.TabIndex = 3;
            this.ptbF7.TabStop = false;
            this.ptbF7.UseGdi = true;
            this.ptbF7.Click += new System.EventHandler(this._buttonF7_Click);
            this.ptbF7.MouseEnter += new System.EventHandler(this.Ptb_MouseEnter);
            this.ptbF7.MouseLeave += new System.EventHandler(this.ptb_MouseLeave);
            // 
            // ptbClearButton
            // 
            this.ptbClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ptbClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbClearButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ptbClearButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbClearButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ptbClearButton.IconSize = 16;
            this.ptbClearButton.Location = new System.Drawing.Point(107, 7);
            this.ptbClearButton.Name = "ptbClearButton";
            this.ptbClearButton.Size = new System.Drawing.Size(24, 16);
            this.ptbClearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbClearButton.TabIndex = 4;
            this.ptbClearButton.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbClearButton, "Limpar Caixa de texto");
            this.ptbClearButton.UseGdi = true;
            this.ptbClearButton.Click += new System.EventHandler(this.PtbClearButton_Click);
            this.ptbClearButton.MouseEnter += new System.EventHandler(this.Ptb_MouseEnter);
            this.ptbClearButton.MouseLeave += new System.EventHandler(this.ptbClose_MouseLeave);
            // 
            // LmTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.baseTextBox);
            this.Controls.Add(this.ptbClearButton);
            this.Controls.Add(this.ptbIcon);
            this.Controls.Add(this.ptbF7);
            this.Controls.Add(this.ptbF8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LmTextBox";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(173, 30);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbF8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbF7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClearButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseTextBox;
        private FontAwesome.Sharp.IconPictureBox ptbIcon;
        private FontAwesome.Sharp.IconPictureBox ptbClearButton;
        internal FontAwesome.Sharp.IconPictureBox ptbF8;
        internal FontAwesome.Sharp.IconPictureBox ptbF7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
