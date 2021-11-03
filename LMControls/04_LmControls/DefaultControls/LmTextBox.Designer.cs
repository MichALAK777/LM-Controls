
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LmTextBox));
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.ptbF8 = new System.Windows.Forms.PictureBox();
            this.ptbF7 = new System.Windows.Forms.PictureBox();
            this.ptbClearButton = new System.Windows.Forms.PictureBox();
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
            this.baseTextBox.Location = new System.Drawing.Point(31, 7);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(56, 15);
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
            this.ptbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbIcon.Location = new System.Drawing.Point(10, 7);
            this.ptbIcon.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(21, 16);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIcon.TabIndex = 1;
            this.ptbIcon.TabStop = false;
            this.ptbIcon.Visible = false;
            // 
            // ptbF8
            // 
            this.ptbF8.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbF8.Location = new System.Drawing.Point(124, 7);
            this.ptbF8.Name = "ptbF8";
            this.ptbF8.Size = new System.Drawing.Size(16, 16);
            this.ptbF8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbF8.TabIndex = 2;
            this.ptbF8.TabStop = false;
            this.ptbF8.Visible = false;
            this.ptbF8.Click += new System.EventHandler(this._buttonF8_Click);
            // 
            // ptbF7
            // 
            this.ptbF7.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbF7.Location = new System.Drawing.Point(108, 7);
            this.ptbF7.Name = "ptbF7";
            this.ptbF7.Size = new System.Drawing.Size(16, 16);
            this.ptbF7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbF7.TabIndex = 3;
            this.ptbF7.TabStop = false;
            this.ptbF7.Visible = false;
            this.ptbF7.Click += new System.EventHandler(this._buttonF7_Click);
            // 
            // ptbClearButton
            // 
            this.ptbClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ptbClearButton.Image")));
            this.ptbClearButton.Location = new System.Drawing.Point(87, 7);
            this.ptbClearButton.Name = "ptbClearButton";
            this.ptbClearButton.Size = new System.Drawing.Size(21, 16);
            this.ptbClearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClearButton.TabIndex = 4;
            this.ptbClearButton.TabStop = false;
            this.ptbClearButton.Visible = false;
            // 
            // LmTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.baseTextBox);
            this.Controls.Add(this.ptbClearButton);
            this.Controls.Add(this.ptbF7);
            this.Controls.Add(this.ptbF8);
            this.Controls.Add(this.ptbIcon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LmTextBox";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(150, 30);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbF8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbF7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClearButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.PictureBox ptbClearButton;
        internal System.Windows.Forms.PictureBox ptbF8;
        internal System.Windows.Forms.PictureBox ptbF7;
    }
}
