
namespace LMControls
{
    partial class FrmConsultaGeral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaGeral));
            this.dgv = new LMControls.LmControls.LmDataGridMini();
            this.flpRodape = new LMControls.LmControls.LmPanelFlow();
            this.lnkIrPrimeiro = new System.Windows.Forms.PictureBox();
            this.lnkIrAnterior = new System.Windows.Forms.PictureBox();
            this.lnkIrProximo = new System.Windows.Forms.PictureBox();
            this.lnkIrUltimo = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new LMControls.LmControls.LmTextBox();
            this.btnConfirmar = new LMControls.LmControls.LmButton();
            this.msMenuStrip = new LMControls.LmControls.LmStatusStrip();
            this.lblPagina = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPosicao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslTotalRetorno = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.tslTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl5000 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl500 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl200 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl50 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl15 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrInicioPesquisa = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.flpRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrPrimeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrProximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrUltimo)).BeginInit();
            this.msMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgv.Location = new System.Drawing.Point(2, 30);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(596, 147);
            this.dgv.TabIndex = 0;
            this.dgv.UseSelectable = true;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            this.dgv.Sorted += new System.EventHandler(this.Dgv_Sorted);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_KeyDown);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_KeyPress);
            // 
            // flpRodape
            // 
            this.flpRodape.Controls.Add(this.lnkIrPrimeiro);
            this.flpRodape.Controls.Add(this.lnkIrAnterior);
            this.flpRodape.Controls.Add(this.lnkIrProximo);
            this.flpRodape.Controls.Add(this.lnkIrUltimo);
            this.flpRodape.Controls.Add(this.txtPesquisar);
            this.flpRodape.Controls.Add(this.btnConfirmar);
            this.flpRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpRodape.Location = new System.Drawing.Point(2, 177);
            this.flpRodape.Name = "flpRodape";
            this.flpRodape.Size = new System.Drawing.Size(596, 40);
            this.flpRodape.TabIndex = 1;
            // 
            // lnkIrPrimeiro
            // 
            this.lnkIrPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("lnkIrPrimeiro.Image")));
            this.lnkIrPrimeiro.Location = new System.Drawing.Point(3, 3);
            this.lnkIrPrimeiro.Name = "lnkIrPrimeiro";
            this.lnkIrPrimeiro.Size = new System.Drawing.Size(20, 31);
            this.lnkIrPrimeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkIrPrimeiro.TabIndex = 0;
            this.lnkIrPrimeiro.TabStop = false;
            this.toolTip1.SetToolTip(this.lnkIrPrimeiro, "Ir Para Primeira Página");
            this.lnkIrPrimeiro.Click += new System.EventHandler(this.LnkIrPrimeiro_Click);
            // 
            // lnkIrAnterior
            // 
            this.lnkIrAnterior.Image = ((System.Drawing.Image)(resources.GetObject("lnkIrAnterior.Image")));
            this.lnkIrAnterior.Location = new System.Drawing.Point(29, 3);
            this.lnkIrAnterior.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lnkIrAnterior.Name = "lnkIrAnterior";
            this.lnkIrAnterior.Size = new System.Drawing.Size(20, 31);
            this.lnkIrAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkIrAnterior.TabIndex = 1;
            this.lnkIrAnterior.TabStop = false;
            this.toolTip1.SetToolTip(this.lnkIrAnterior, "Ir Para Página Anterior");
            this.lnkIrAnterior.Click += new System.EventHandler(this.LnkIrAnterior_Click);
            // 
            // lnkIrProximo
            // 
            this.lnkIrProximo.Image = ((System.Drawing.Image)(resources.GetObject("lnkIrProximo.Image")));
            this.lnkIrProximo.Location = new System.Drawing.Point(49, 3);
            this.lnkIrProximo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lnkIrProximo.Name = "lnkIrProximo";
            this.lnkIrProximo.Size = new System.Drawing.Size(20, 31);
            this.lnkIrProximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkIrProximo.TabIndex = 2;
            this.lnkIrProximo.TabStop = false;
            this.toolTip1.SetToolTip(this.lnkIrProximo, "Ir Para Próxima Página");
            this.lnkIrProximo.Click += new System.EventHandler(this.LnkIrProximo_Click);
            // 
            // lnkIrUltimo
            // 
            this.lnkIrUltimo.Image = ((System.Drawing.Image)(resources.GetObject("lnkIrUltimo.Image")));
            this.lnkIrUltimo.Location = new System.Drawing.Point(75, 3);
            this.lnkIrUltimo.Name = "lnkIrUltimo";
            this.lnkIrUltimo.Size = new System.Drawing.Size(20, 31);
            this.lnkIrUltimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkIrUltimo.TabIndex = 3;
            this.lnkIrUltimo.TabStop = false;
            this.toolTip1.SetToolTip(this.lnkIrUltimo, "Ir Para Última Página");
            this.lnkIrUltimo.Click += new System.EventHandler(this.LnkIrUltimo_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPesquisar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPesquisar.BorderRadius = 0;
            this.txtPesquisar.BorderSize = 2;
            this.txtPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPesquisar.Icon = ((System.Drawing.Image)(resources.GetObject("txtPesquisar.Icon")));
            this.txtPesquisar.IconShow = true;
            this.txtPesquisar.Lines = new string[0];
            this.txtPesquisar.Location = new System.Drawing.Point(102, 4);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.Propriedade = null;
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.ShortcutsEnabled = true;
            this.txtPesquisar.ShowClearButton = true;
            this.txtPesquisar.Size = new System.Drawing.Size(180, 31);
            this.txtPesquisar.TabIndex = 4;
            this.txtPesquisar.TextPrompt = "Pesquisar";
            this.txtPesquisar.UnderlinedStyle = true;
            this.txtPesquisar.UseCustomBackColor = false;
            this.txtPesquisar.UseSelectable = true;
            this.txtPesquisar.Valor_Decimais = ((short)(0));
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPesquisar_KeyDown);
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
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(296, 4);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(10, 4, 3, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 30);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Selecionar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseCustomBackColor = false;
            this.btnConfirmar.UseCustomIconColor = false;
            this.btnConfirmar.UseSelectable = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.msMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPagina,
            this.lblPosicao,
            this.toolStripStatusLabel1,
            this.tslTotalRetorno,
            this.tslDropDown});
            this.msMenuStrip.Location = new System.Drawing.Point(2, 217);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Size = new System.Drawing.Size(596, 26);
            this.msMenuStrip.SizingGrip = false;
            this.msMenuStrip.TabIndex = 2;
            this.msMenuStrip.Text = "lmStatusStrip1";
            // 
            // lblPagina
            // 
            this.lblPagina.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(103, 21);
            this.lblPagina.Text = "PG.: 100 de 700";
            // 
            // lblPosicao
            // 
            this.lblPosicao.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblPosicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(134, 21);
            this.lblPosicao.Text = "9976 a 9999 de 9999";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 21);
            this.toolStripStatusLabel1.Text = "Limite P/ Pag.:";
            // 
            // tslTotalRetorno
            // 
            this.tslTotalRetorno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.tslTotalRetorno.Name = "tslTotalRetorno";
            this.tslTotalRetorno.Size = new System.Drawing.Size(22, 21);
            this.tslTotalRetorno.Text = "15";
            // 
            // tslDropDown
            // 
            this.tslDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTodos,
            this.tsl5000,
            this.tsl1000,
            this.tsl500,
            this.tsl200,
            this.tsl100,
            this.tsl50,
            this.tsl15});
            this.tslDropDown.Image = ((System.Drawing.Image)(resources.GetObject("tslDropDown.Image")));
            this.tslDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslDropDown.Name = "tslDropDown";
            this.tslDropDown.Size = new System.Drawing.Size(29, 24);
            this.tslDropDown.Text = "toolStripDropDownButton1";
            // 
            // tslTodos
            // 
            this.tslTodos.Name = "tslTodos";
            this.tslTodos.Size = new System.Drawing.Size(112, 22);
            this.tslTodos.Text = "Todos";
            this.tslTodos.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tsl5000
            // 
            this.tsl5000.Name = "tsl5000";
            this.tsl5000.Size = new System.Drawing.Size(112, 22);
            this.tsl5000.Text = "5000";
            this.tsl5000.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tsl1000
            // 
            this.tsl1000.Name = "tsl1000";
            this.tsl1000.Size = new System.Drawing.Size(112, 22);
            this.tsl1000.Text = "1000";
            this.tsl1000.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tsl500
            // 
            this.tsl500.Name = "tsl500";
            this.tsl500.Size = new System.Drawing.Size(112, 22);
            this.tsl500.Text = "500";
            this.tsl500.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tsl200
            // 
            this.tsl200.Name = "tsl200";
            this.tsl200.Size = new System.Drawing.Size(112, 22);
            this.tsl200.Text = "200";
            this.tsl200.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tsl100
            // 
            this.tsl100.Name = "tsl100";
            this.tsl100.Size = new System.Drawing.Size(112, 22);
            this.tsl100.Text = "100";
            this.tsl100.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tsl50
            // 
            this.tsl50.Name = "tsl50";
            this.tsl50.Size = new System.Drawing.Size(112, 22);
            this.tsl50.Text = "50";
            this.tsl50.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tsl15
            // 
            this.tsl15.Name = "tsl15";
            this.tsl15.Size = new System.Drawing.Size(112, 22);
            this.tsl15.Text = "15";
            this.tsl15.Click += new System.EventHandler(this.TslLimite_Click);
            // 
            // tmrInicioPesquisa
            // 
            this.tmrInicioPesquisa.Tag = "0";
            this.tmrInicioPesquisa.Tick += new System.EventHandler(this.TmrInicioPesquisa_Tick);
            // 
            // FrmConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 245);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.flpRodape);
            this.Controls.Add(this.msMenuStrip);
            this.Name = "FrmConsultaGeral";
            this.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.Resizable = false;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FrmConsultaGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Estilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.flpRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrPrimeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrProximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkIrUltimo)).EndInit();
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LmControls.LmDataGridMini dgv;
        private LmControls.LmPanelFlow flpRodape;
        private LmControls.LmStatusStrip msMenuStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblPagina;
        private System.Windows.Forms.ToolStripStatusLabel lblPosicao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslTotalRetorno;
        private System.Windows.Forms.ToolStripDropDownButton tslDropDown;
        private System.Windows.Forms.ToolStripMenuItem tslTodos;
        private System.Windows.Forms.ToolStripMenuItem tsl5000;
        private System.Windows.Forms.ToolStripMenuItem tsl1000;
        private System.Windows.Forms.ToolStripMenuItem tsl500;
        private System.Windows.Forms.ToolStripMenuItem tsl200;
        private System.Windows.Forms.ToolStripMenuItem tsl100;
        private System.Windows.Forms.ToolStripMenuItem tsl50;
        private System.Windows.Forms.ToolStripMenuItem tsl15;
        private System.Windows.Forms.PictureBox lnkIrPrimeiro;
        private System.Windows.Forms.PictureBox lnkIrAnterior;
        private System.Windows.Forms.PictureBox lnkIrProximo;
        private System.Windows.Forms.PictureBox lnkIrUltimo;
        private LmControls.LmTextBox txtPesquisar;
        private LmControls.LmButton btnConfirmar;
        private System.Windows.Forms.Timer tmrInicioPesquisa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}