
namespace LMControls
{
    partial class FrmConfigGeralGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigGeralGrid));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpbColOculta = new LMControls.LmControls.LmGroupBox();
            this.flpColOculta = new LMControls.LmControls.LmPanelFlow();
            this.btnCancelar = new LMControls.LmControls.LmButton();
            this.btnConfirmar = new LMControls.LmControls.LmButton();
            this.gpbColVisivel = new LMControls.LmControls.LmGroupBox();
            this.flpColVisivel = new LMControls.LmControls.LmPanelFlow();
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gpbColOculta.SuspendLayout();
            this.gpbColVisivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gpbColOculta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirmar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gpbColVisivel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 210);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gpbColOculta
            // 
            this.gpbColOculta.Controls.Add(this.flpColOculta);
            this.gpbColOculta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbColOculta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gpbColOculta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.gpbColOculta.Location = new System.Drawing.Point(361, 3);
            this.gpbColOculta.Name = "gpbColOculta";
            this.gpbColOculta.Size = new System.Drawing.Size(353, 168);
            this.gpbColOculta.TabIndex = 3;
            this.gpbColOculta.TabStop = false;
            this.gpbColOculta.Text = "Colunas Ocultas";
            // 
            // flpColOculta
            // 
            this.flpColOculta.AutoSize = true;
            this.flpColOculta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpColOculta.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpColOculta.Location = new System.Drawing.Point(3, 22);
            this.flpColOculta.Name = "flpColOculta";
            this.flpColOculta.Size = new System.Drawing.Size(347, 143);
            this.flpColOculta.TabIndex = 1;
            this.flpColOculta.WrapContents = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(361, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(353, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseCustomBackColor = false;
            this.btnCancelar.UseCustomIconColor = false;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmar.BorderRadius = 15;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(3, 177);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(352, 30);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = " Salvar e Fechar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseCustomBackColor = false;
            this.btnConfirmar.UseCustomIconColor = false;
            this.btnConfirmar.UseSelectable = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // gpbColVisivel
            // 
            this.gpbColVisivel.Controls.Add(this.flpColVisivel);
            this.gpbColVisivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbColVisivel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gpbColVisivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.gpbColVisivel.Location = new System.Drawing.Point(3, 3);
            this.gpbColVisivel.Name = "gpbColVisivel";
            this.gpbColVisivel.Size = new System.Drawing.Size(352, 168);
            this.gpbColVisivel.TabIndex = 2;
            this.gpbColVisivel.TabStop = false;
            this.gpbColVisivel.Text = "Colunas Visíveis";
            // 
            // flpColVisivel
            // 
            this.flpColVisivel.AllowDrop = true;
            this.flpColVisivel.AutoSize = true;
            this.flpColVisivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpColVisivel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpColVisivel.Location = new System.Drawing.Point(3, 22);
            this.flpColVisivel.Name = "flpColVisivel";
            this.flpColVisivel.Size = new System.Drawing.Size(346, 143);
            this.flpColVisivel.TabIndex = 0;
            this.flpColVisivel.WrapContents = false;
            this.flpColVisivel.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpColVisivel_DragDrop);
            this.flpColVisivel.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpColVisivel_DragEnter);
            // 
            // FrmConfigGeralGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 242);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigGeralGrid";
            this.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.Text = "Configuração Geral Grid";
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gpbColOculta.ResumeLayout(false);
            this.gpbColOculta.PerformLayout();
            this.gpbColVisivel.ResumeLayout(false);
            this.gpbColVisivel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LmControls.LmButton btnCancelar;
        private LmControls.LmButton btnConfirmar;
        private LmControls.LmGroupBox gpbColOculta;
        private LmControls.LmPanelFlow flpColOculta;
        private LmControls.LmGroupBox gpbColVisivel;
        private LmControls.LmPanelFlow flpColVisivel;
    }
}