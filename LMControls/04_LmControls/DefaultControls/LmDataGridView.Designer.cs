
namespace LMControls.LmControls
{
    partial class LmDataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LmDataGridView));
            this.pnlGrid = new LMControls.LmControls.LmPanel();
            this.lblMessage = new LMControls.LmControls.LmLabel();
            this.Grid = new LMControls.LmControls.LmDataGridMini();
            this.GridRodape = new LMControls.LmControls.LmDataGridMini();
            this.flpBotoes = new LMControls.LmControls.LmPanelFlow();
            this.lnkCsv = new System.Windows.Forms.PictureBox();
            this.lnkPdf = new System.Windows.Forms.PictureBox();
            this.lnkImprimir = new System.Windows.Forms.PictureBox();
            this.lmLabel2 = new LMControls.LmControls.LmLabel();
            this.lnkColunas = new System.Windows.Forms.PictureBox();
            this.lnkResraurarGrid = new System.Windows.Forms.PictureBox();
            this.txtProcurar = new LMControls.LmControls.LmTextBox();
            this.lblSep3 = new LMControls.LmControls.LmLabel();
            this.lblTotal = new LMControls.LmControls.LmLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmrInicioLocalizar = new System.Windows.Forms.Timer(this.components);
            this.tmrInternal = new System.Windows.Forms.Timer(this.components);
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRodape)).BeginInit();
            this.flpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnkCsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkResraurarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.lblMessage);
            this.pnlGrid.Controls.Add(this.Grid);
            this.pnlGrid.Controls.Add(this.GridRodape);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(447, 201);
            this.pnlGrid.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.FontSize = LMControls.LmDesign.LmLabelSize.Tall;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(447, 49);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "A consulta não retornou nenhum registro!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.WrapToLine = true;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.RowTemplate.Height = 25;
            this.Grid.Size = new System.Drawing.Size(447, 176);
            this.Grid.TabIndex = 1;
            this.Grid.UseSelectable = true;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            this.Grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellEnter);
            this.Grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseUp);
            this.Grid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Grid_CellPainting);
            this.Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValueChanged);
            this.Grid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Grid_ColumnWidthChanged);
            this.Grid.Enter += new System.EventHandler(this.Grid_Enter);
            this.Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_KeyDown);
            this.Grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseDown);
            // 
            // GridRodape
            // 
            this.GridRodape.AllowUserToAddRows = false;
            this.GridRodape.AllowUserToDeleteRows = false;
            this.GridRodape.AllowUserToOrderColumns = true;
            this.GridRodape.AllowUserToResizeRows = false;
            this.GridRodape.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.GridRodape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridRodape.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.GridRodape.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRodape.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridRodape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridRodape.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridRodape.EnableHeadersVisualStyles = false;
            this.GridRodape.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GridRodape.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.GridRodape.Location = new System.Drawing.Point(0, 176);
            this.GridRodape.MultiSelect = false;
            this.GridRodape.Name = "GridRodape";
            this.GridRodape.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRodape.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridRodape.RowHeadersVisible = false;
            this.GridRodape.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridRodape.RowTemplate.Height = 25;
            this.GridRodape.Size = new System.Drawing.Size(447, 25);
            this.GridRodape.TabIndex = 2;
            this.GridRodape.UseSelectable = true;
            // 
            // flpBotoes
            // 
            this.flpBotoes.Controls.Add(this.lnkCsv);
            this.flpBotoes.Controls.Add(this.lnkPdf);
            this.flpBotoes.Controls.Add(this.lnkImprimir);
            this.flpBotoes.Controls.Add(this.lmLabel2);
            this.flpBotoes.Controls.Add(this.lnkColunas);
            this.flpBotoes.Controls.Add(this.lnkResraurarGrid);
            this.flpBotoes.Controls.Add(this.txtProcurar);
            this.flpBotoes.Controls.Add(this.lblSep3);
            this.flpBotoes.Controls.Add(this.lblTotal);
            this.flpBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBotoes.Location = new System.Drawing.Point(0, 201);
            this.flpBotoes.Name = "flpBotoes";
            this.flpBotoes.Size = new System.Drawing.Size(447, 39);
            this.flpBotoes.TabIndex = 0;
            // 
            // lnkCsv
            // 
            this.lnkCsv.Image = ((System.Drawing.Image)(resources.GetObject("lnkCsv.Image")));
            this.lnkCsv.Location = new System.Drawing.Point(3, 3);
            this.lnkCsv.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lnkCsv.Name = "lnkCsv";
            this.lnkCsv.Size = new System.Drawing.Size(20, 31);
            this.lnkCsv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkCsv.TabIndex = 5;
            this.lnkCsv.TabStop = false;
            this.lnkCsv.Click += new System.EventHandler(this.LnkCsv_Click);
            // 
            // lnkPdf
            // 
            this.lnkPdf.Image = ((System.Drawing.Image)(resources.GetObject("lnkPdf.Image")));
            this.lnkPdf.Location = new System.Drawing.Point(25, 3);
            this.lnkPdf.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lnkPdf.Name = "lnkPdf";
            this.lnkPdf.Size = new System.Drawing.Size(20, 31);
            this.lnkPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkPdf.TabIndex = 6;
            this.lnkPdf.TabStop = false;
            this.lnkPdf.Click += new System.EventHandler(this.LnkPdf_Click);
            // 
            // lnkImprimir
            // 
            this.lnkImprimir.Image = ((System.Drawing.Image)(resources.GetObject("lnkImprimir.Image")));
            this.lnkImprimir.Location = new System.Drawing.Point(47, 3);
            this.lnkImprimir.Margin = new System.Windows.Forms.Padding(1, 3, 0, 3);
            this.lnkImprimir.Name = "lnkImprimir";
            this.lnkImprimir.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lnkImprimir.Size = new System.Drawing.Size(20, 31);
            this.lnkImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkImprimir.TabIndex = 7;
            this.lnkImprimir.TabStop = false;
            this.lnkImprimir.Click += new System.EventHandler(this.LnkImprimir_Click);
            // 
            // lmLabel2
            // 
            this.lmLabel2.AutoSize = true;
            this.lmLabel2.FontWeight = LMControls.LmDesign.LmLabelWeight.Bold;
            this.lmLabel2.Location = new System.Drawing.Point(67, 9);
            this.lmLabel2.Margin = new System.Windows.Forms.Padding(0, 9, 0, 3);
            this.lmLabel2.Name = "lmLabel2";
            this.lmLabel2.Size = new System.Drawing.Size(14, 19);
            this.lmLabel2.TabIndex = 12;
            this.lmLabel2.Text = "|";
            // 
            // lnkColunas
            // 
            this.lnkColunas.Image = ((System.Drawing.Image)(resources.GetObject("lnkColunas.Image")));
            this.lnkColunas.Location = new System.Drawing.Point(81, 3);
            this.lnkColunas.Margin = new System.Windows.Forms.Padding(0, 3, 1, 3);
            this.lnkColunas.Name = "lnkColunas";
            this.lnkColunas.Size = new System.Drawing.Size(20, 31);
            this.lnkColunas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkColunas.TabIndex = 8;
            this.lnkColunas.TabStop = false;
            this.lnkColunas.Click += new System.EventHandler(this.LnkColunas_Click);
            // 
            // lnkResraurarGrid
            // 
            this.lnkResraurarGrid.Image = ((System.Drawing.Image)(resources.GetObject("lnkResraurarGrid.Image")));
            this.lnkResraurarGrid.Location = new System.Drawing.Point(103, 3);
            this.lnkResraurarGrid.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.lnkResraurarGrid.Name = "lnkResraurarGrid";
            this.lnkResraurarGrid.Size = new System.Drawing.Size(20, 31);
            this.lnkResraurarGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lnkResraurarGrid.TabIndex = 13;
            this.lnkResraurarGrid.TabStop = false;
            this.lnkResraurarGrid.Click += new System.EventHandler(this.LnkResraurarGrid_Click);
            // 
            // txtProcurar
            // 
            this.txtProcurar.BackColor = System.Drawing.SystemColors.Window;
            this.txtProcurar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtProcurar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProcurar.BorderRadius = 0;
            this.txtProcurar.BorderSize = 2;
            this.txtProcurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProcurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProcurar.Icon = ((System.Drawing.Image)(resources.GetObject("txtProcurar.Icon")));
            this.txtProcurar.IconShow = true;
            this.txtProcurar.Lines = new string[0];
            this.txtProcurar.Location = new System.Drawing.Point(128, 4);
            this.txtProcurar.Margin = new System.Windows.Forms.Padding(2, 4, 4, 4);
            this.txtProcurar.MaxLength = 32767;
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProcurar.PasswordChar = '\0';
            this.txtProcurar.Propriedade = null;
            this.txtProcurar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProcurar.SelectedText = "";
            this.txtProcurar.SelectionLength = 0;
            this.txtProcurar.SelectionStart = 0;
            this.txtProcurar.ShortcutsEnabled = true;
            this.txtProcurar.ShowClearButton = true;
            this.txtProcurar.Size = new System.Drawing.Size(140, 31);
            this.txtProcurar.TabIndex = 9;
            this.txtProcurar.TextPrompt = "Procurar Por...";
            this.txtProcurar.UnderlinedStyle = true;
            this.txtProcurar.UseCustomBackColor = false;
            this.txtProcurar.UseSelectable = true;
            this.txtProcurar.Valor_Decimais = ((short)(0));
            this.txtProcurar.TextChanged += new System.EventHandler(this.TxtProcurar_TextChanged);
            this.txtProcurar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProcurar_KeyDown);
            // 
            // lblSep3
            // 
            this.lblSep3.AutoSize = true;
            this.lblSep3.FontWeight = LMControls.LmDesign.LmLabelWeight.Bold;
            this.lblSep3.Location = new System.Drawing.Point(272, 9);
            this.lblSep3.Margin = new System.Windows.Forms.Padding(0, 9, 0, 3);
            this.lblSep3.Name = "lblSep3";
            this.lblSep3.Size = new System.Drawing.Size(14, 19);
            this.lblSep3.TabIndex = 11;
            this.lblSep3.Text = "|";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(286, 9);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0, 9, 3, 3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 19);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Registro: 0 de 0";
            // 
            // tmrInicioLocalizar
            // 
            this.tmrInicioLocalizar.Tag = "0";
            this.tmrInicioLocalizar.Tick += new System.EventHandler(this.TmrInicioLocalizar_Tick);
            // 
            // tmrInternal
            // 
            this.tmrInternal.Enabled = true;
            this.tmrInternal.Interval = 500;
            this.tmrInternal.Tag = "-1";
            this.tmrInternal.Tick += new System.EventHandler(this.TmrInternal_Tick);
            // 
            // LmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.flpBotoes);
            this.Name = "LmDataGridView";
            this.Size = new System.Drawing.Size(447, 240);
            this.Load += new System.EventHandler(this.LmDataGridView_Load);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRodape)).EndInit();
            this.flpBotoes.ResumeLayout(false);
            this.flpBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnkCsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkResraurarGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LmControls.LmPanel pnlGrid;
        private LmControls.LmPanelFlow flpBotoes;
        private LmDataGridMini GridRodape;
        public LmDataGridMini Grid;
        private LmLabel lblMessage;
        private System.Windows.Forms.PictureBox lnkCsv;
        private System.Windows.Forms.PictureBox lnkPdf;
        private System.Windows.Forms.PictureBox lnkImprimir;
        private System.Windows.Forms.PictureBox lnkColunas;
        private LmTextBox txtProcurar;
        private LmLabel lmLabel2;
        private System.Windows.Forms.PictureBox lnkResraurarGrid;
        private LmLabel lblSep3;
        private LmLabel lblTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tmrInicioLocalizar;
        private System.Windows.Forms.Timer tmrInternal;
    }
}
