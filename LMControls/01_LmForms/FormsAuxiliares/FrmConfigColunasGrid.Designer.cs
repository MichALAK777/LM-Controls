
namespace LMControls
{
    partial class FrmConfigColunasGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigColunasGrid));
            this.clbColunas = new System.Windows.Forms.CheckedListBox();
            this.lmPanel1 = new LMControls.LmControls.LmPanel();
            this.btnConfirmar = new LMControls.LmControls.LmButton();
            this.btnCancelar = new LMControls.LmControls.LmButton();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMarcar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDesmarcar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).BeginInit();
            this.lmPanel1.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbColunas
            // 
            this.clbColunas.BackColor = System.Drawing.Color.Linen;
            this.clbColunas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbColunas.CheckOnClick = true;
            this.clbColunas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbColunas.FormattingEnabled = true;
            this.clbColunas.Location = new System.Drawing.Point(2, 30);
            this.clbColunas.Name = "clbColunas";
            this.clbColunas.Size = new System.Drawing.Size(468, 86);
            this.clbColunas.TabIndex = 1;
            // 
            // lmPanel1
            // 
            this.lmPanel1.Controls.Add(this.btnConfirmar);
            this.lmPanel1.Controls.Add(this.btnCancelar);
            this.lmPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lmPanel1.Location = new System.Drawing.Point(2, 116);
            this.lmPanel1.Name = "lmPanel1";
            this.lmPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.lmPanel1.Size = new System.Drawing.Size(468, 36);
            this.lmPanel1.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmar.BorderRadius = 15;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(245, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 30);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = " Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseCustomBackColor = false;
            this.btnConfirmar.UseCustomIconColor = false;
            this.btnConfirmar.UseSelectable = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(355, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseCustomBackColor = false;
            this.btnCancelar.UseCustomIconColor = false;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsMarcar,
            this.cmsDesmarcar});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(192, 52);
            // 
            // cmsMarcar
            // 
            this.cmsMarcar.Image = ((System.Drawing.Image)(resources.GetObject("cmsMarcar.Image")));
            this.cmsMarcar.Name = "cmsMarcar";
            this.cmsMarcar.Size = new System.Drawing.Size(191, 24);
            this.cmsMarcar.Text = "Selecionar Todos";
            this.cmsMarcar.Click += new System.EventHandler(this.CmsMarcar_Click);
            // 
            // cmsDesmarcar
            // 
            this.cmsDesmarcar.Image = ((System.Drawing.Image)(resources.GetObject("cmsDesmarcar.Image")));
            this.cmsDesmarcar.Name = "cmsDesmarcar";
            this.cmsDesmarcar.Size = new System.Drawing.Size(191, 24);
            this.cmsDesmarcar.Text = "Limpar Seleção";
            this.cmsDesmarcar.Click += new System.EventHandler(this.CmsDesmarcar_Click);
            // 
            // FrmConfigColunasGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 154);
            this.Controls.Add(this.clbColunas);
            this.Controls.Add(this.lmPanel1);
            this.KeyPreview = true;
            this.Name = "FrmConfigColunasGrid";
            this.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.Text = "Selecionar Colunas para Exibir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfigColunasGrid_FormClosed);
            this.Load += new System.EventHandler(this.FrmConfigColunasGrid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConfigColunasGrid_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).EndInit();
            this.lmPanel1.ResumeLayout(false);
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckedListBox clbColunas;
        private LmControls.LmPanel lmPanel1;
        private LmControls.LmButton btnConfirmar;
        private LmControls.LmButton btnCancelar;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsMarcar;
        private System.Windows.Forms.ToolStripMenuItem cmsDesmarcar;
    }
}