using iTextSharp.text;
using iTextSharp.text.pdf;
using LMControls.LmControls;
using LMControls.LmDesign;
using LMControls.LmForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.Metodos
{
    public class Controles
    {
        /// <summary>
        /// Limpar Controles
        /// TextBox, LmTextBox, ComboBox, LmComboBox_
        /// DateTime muda para Data Atual em Lm
        /// </summary>
        /// <param name="control">Proprietaros dos controles a serem limpos</param>
        public static void Clear(Control control)
        {
            //foreach (Control ctrl in control.Controls)
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else if (ctrl is LmTextBox)
                {
                    ((LmTextBox)ctrl).Clear();
                }
                else if (ctrl is DateTimePicker)
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                else if (ctrl is LmCheckBox && Convert.ToString(((LmCheckBox)ctrl).Tag).ToLower() != "bloqueado")
                    ((LmCheckBox)ctrl).Checked = false;
                else if (ctrl is RichTextBox)
                    ((RichTextBox)ctrl).Clear();
                else if (ctrl is LmLabel && Convert.ToString(((LmLabel)ctrl).Tag).ToLower() == "limpar")
                {
                    ((LmLabel)ctrl).Text = string.Empty;
                }
                else if (ctrl is Label && Convert.ToString(((Label)ctrl).Tag).ToLower() == "limpar")
                {
                    ((Label)ctrl).Text = string.Empty;
                }
                else if (ctrl is Panel && Convert.ToString(((Panel)ctrl).Tag).ToLower() == "limpar")
                {
                    ((Panel)ctrl).BackgroundImage = null;
                }
                else if (ctrl is PictureBox && Convert.ToString(((PictureBox)ctrl).Tag).ToLower() == "limpar")
                {
                    ((PictureBox)ctrl).ImageLocation = null;
                }
                Clear(ctrl);
            }
        }

        public static void BloquearFormulario(List<Control> controles)
        {
            Control ctrlTemp = null;
            try
            {
                foreach (Control ctrl in controles)
                {
                    ctrlTemp = ctrl;
                    if (ctrl is LmTextBox box && !box.IsPrimaryKey)
                    {
                        ((LmTextBox)ctrl.Parent.Controls[ctrl.Name]).ReadOnly = true;
                        ((LmTextBox)ctrl.Parent.Controls[ctrl.Name]).ptbF7.Enabled =
                        ((LmTextBox)ctrl.Parent.Controls[ctrl.Name]).ptbF8.Enabled = false;
                    }
                    else if (ctrl is LmButton)
                        ((LmButton)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is LmCheckBox)
                        ((LmCheckBox)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is LmRadioButton)
                        ((LmRadioButton)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is LmDataGridViewUC)
                        ((LmDataGridViewUC)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is LmDataGridView)
                        ((LmDataGridView)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is LmPanel)
                        ((LmPanel)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is FlowLayoutPanel)
                        ((FlowLayoutPanel)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is LmGroupBox)
                        ((LmGroupBox)ctrl.Parent.Controls[ctrl.Name]).Enabled = false;
                    else if (ctrl is RichTextBox)
                        ((RichTextBox)ctrl.Parent.Controls[ctrl.Name]).ReadOnly = true;
                }

                GetParentForm(controles[0]).Refresh();
            }
            catch (Exception ex)
            {
                MsgBox.Show($"Erro ao bloquear campo({ctrlTemp.Name}) do formulário.\n\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DesbloquearFormulario(List<Control> controles)
        {
            Control ctrlTemp = null;
            try
            {
                foreach (Control ctrl in controles)
                {
                    ctrlTemp = ctrl;
                    if (ctrl is LmTextBox box && !box.IsPrimaryKey)
                    {
                        ((LmTextBox)ctrl.Parent.Controls[ctrl.Name]).ReadOnly = false;
                        ((LmTextBox)ctrl.Parent.Controls[ctrl.Name]).ptbF7.Enabled =
                        ((LmTextBox)ctrl.Parent.Controls[ctrl.Name]).ptbF7.Enabled = true;
                    }
                    else if (ctrl is LmButton)
                        ((LmButton)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is LmCheckBox)
                        ((LmCheckBox)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is LmRadioButton)
                        ((LmRadioButton)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is LmDataGridViewUC)
                        ((LmDataGridViewUC)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is LmDataGridView)
                        ((LmDataGridView)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is LmPanel)
                        ((LmPanel)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is FlowLayoutPanel)
                        ((FlowLayoutPanel)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is LmGroupBox)
                        ((LmGroupBox)ctrl.Parent.Controls[ctrl.Name]).Enabled = true;
                    else if (ctrl is RichTextBox)
                        ((RichTextBox)ctrl.Parent.Controls[ctrl.Name]).ReadOnly = false;
                }

                GetParentForm(controles[0]).Refresh();
            }
            catch (Exception ex)
            {
                MsgBox.Show($"Erro ao desbloquear campo({ctrlTemp.Name}) do formulário.\n\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdatePrimaryKeyControl(Control lmForm, bool tornarSomenteLeitura, string text = "")
        {
            foreach (Control ctrl in lmForm.Controls)
            {
                if (ctrl is LmTextBox)
                {
                    if (((LmTextBox)ctrl).IsPrimaryKey)
                    {
                        ((LmTextBox)ctrl).ReadOnly = tornarSomenteLeitura;

                        if (!string.IsNullOrEmpty(text))
                            ((LmTextBox)ctrl).Text = text;

                        ((LmTextBox)ctrl).Refresh();

                        return;
                    }
                }

                UpdatePrimaryKeyControl(ctrl, tornarSomenteLeitura, text);
            }
        }

        public static void FocusPrimaryKey(Control lmForm)
        {
            foreach (Control ctrl in lmForm.Controls)
            {
                if (ctrl is LmTextBox)
                {
                    if (((LmTextBox)ctrl).IsPrimaryKey)
                    {
                        ((LmTextBox)ctrl).Focus();

                        ((LmTextBox)ctrl).Refresh();

                        return;
                    }
                }

                FocusPrimaryKey(ctrl);
            }
        }

        public static LmChildForm GetParentForm(Control sender)
        {
            short cont = 0;
            Control _ctrl = sender;

            if (_ctrl is LmChildForm)
                _ctrl = ((LmChildForm)_ctrl).ParentForm;

            while (true)
            {
                if (_ctrl is LmChildForm)
                {
                    return (LmChildForm)_ctrl;
                }
                else
                {
                    cont++;
                    if (_ctrl != null)
                        _ctrl = _ctrl.Parent;
                }
                if (cont >= 20)
                {
                    return null;
                }
            }
        }

        internal static LmMainForm GetMainForm(Control ctrl)
        {
            LmMainForm _return = null;
            ctrl = ctrl.Parent;

            while (ctrl != null)
            {
                if (ctrl is LmMainForm)
                {
                    _return = (LmMainForm)ctrl;
                    break;
                }
                ctrl = ctrl.Parent;
            }
            return _return;
        }

        public static bool PossuiCamposInvalidos(Control ctrlPatern)
        {
            var objs = new List<object>();

            Controles.PercorrerControles(ctrlPatern, objs);

            foreach (var obj in objs)
            {
                MsgBox.ShowToolTip((LmTextBox)((object[])obj)[0], (string)((object[])obj)[1]);
            }

            if (objs.Count > 0)
            {
                int index = 0;
                int tabIndex = 369;

                for (int i = 0; i < objs.Count; i++)
                {
                    if (((LmTextBox)((object[])objs[i])[0]).TabIndex < tabIndex)
                    {
                        tabIndex = ((LmTextBox)((object[])objs[i])[0]).TabIndex;
                        index = i;
                    }
                }

                Control ctrl = ((LmTextBox)((object[])objs[index])[0]).Parent;
                string tabName = string.Empty;
                do
                {
                    if (ctrl is LmTabPage)
                        tabName = ((LmTabPage)ctrl).Name;

                    if (ctrl.Parent is LmTabControl)
                    {
                        ((LmTabControl)ctrl.Parent).SelectTab(tabName);
                        break;
                    }
                    ctrl = ctrl.Parent;


                } while (ctrl != null);


                ((LmTextBox)((object[])objs[index])[0]).Focus();

                return true;
            }
            else
                return false;
        }

        internal static void PercorrerControles(Control control, List<object> objects)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is LmTextBox)
                {
                    if (((LmTextBox)ctrl).CampoObrigatorio && string.IsNullOrEmpty(((LmTextBox)ctrl).Text))
                    {
                        objects.Add(new object[] { (LmTextBox)ctrl, "Campo Obrigatório!" });
                        continue;
                    }

                    switch (((LmTextBox)ctrl).Valor)
                    {
                        case LmValueType.Data:
                            {
                                if (!DateTime.TryParse(((LmTextBox)ctrl).Text, out _))
                                {
                                    if (((LmTextBox)ctrl).CampoObrigatorio || !string.IsNullOrEmpty(((LmTextBox)ctrl).Text))
                                    {
                                        objects.Add(new object[] { (LmTextBox)ctrl, "Data Inválida!" });
                                    }
                                }
                            }
                            break;
                        case LmValueType.Hora:
                            {
                                var tmp = ((LmTextBox)ctrl).Text.FormatarHora();
                                if (!string.IsNullOrEmpty(tmp))
                                {
                                    var hor = Convert.ToInt32(tmp.Split(':')[0]);
                                    var min = Convert.ToInt32(tmp.Split(':')[1]);
                                    if (hor > 23)
                                    {
                                        if (((LmTextBox)ctrl).Valor_Decimais != 3)
                                        {
                                            objects.Add(new object[] { (LmTextBox)ctrl, $"Hora '{hor:00}' Não Pode Ser Maior que 23!" });
                                        }
                                    }
                                    if (min > 59)
                                    {
                                        objects.Add(new object[] { (LmTextBox)ctrl, $"Minuto '{min:00}' Não Pode Ser Maior que 59!" });
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                PercorrerControles(ctrl, objects);
            }
        }

        /// <summary>
        /// Preencher Controles com as propriedades de um Objeto _ 
        /// O Nome do Controle deve terminar com nome da propriedade
        /// Comprimento do Nome de Controle deve ser <= Comprimento nome da propriedade + 3
        /// </summary>
        /// <typeparam name="T">Tipo do Objeto</typeparam>
        /// <param name="sender">Formulário que chamou evento</param>
        /// <param name="objeto">Objeto com as propriedades que serão passadas para controles</param>
        /// <returns></returns>
        public static void PreencherControles(Control sender, object objeto)
        {
            foreach (Control ctrl in sender.Controls)
            {
                if (string.IsNullOrEmpty(ctrl.Name)) continue;

                if (ctrl is LmTextBox || ctrl is LmCheckBox)
                {
                    string valor = string.Empty;
                    string nome = string.Empty;

                    foreach (PropertyInfo pro in objeto.GetType().GetProperties())
                    {
                        valor = Convert.ToString(pro.GetValue(objeto, null));
                        nome = pro.Name;

                        if ((ctrl is LmTextBox))
                        {
                            if (((LmTextBox)ctrl).Propriedade == nome)
                            {
                                if (((LmTextBox)ctrl).Valor == LmValueType.Fone)
                                    ctrl.Text = valor.FormatarFone();
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Monetario)
                                    ctrl.Text = valor.FormatarMonetario();
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Cpf_Cnpj)
                                    ctrl.Text = valor.FormatarCpf_Cnpf();
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Data)
                                {
                                    if (!string.IsNullOrEmpty(valor))
                                        ctrl.Text = valor.FormatarData();
                                }
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Num_Real)
                                    ctrl.Text = valor.Numerico(((LmTextBox)ctrl).Valor_Decimais);
                                else if (((LmTextBox)ctrl).Valor == LmValueType.ComboBox)
                                {
                                    if (int.TryParse(valor, out int nVal))
                                        ((LmTextBox)ctrl).SelectedValue = nVal;
                                    else if (pro.PropertyType == typeof(System.String))
                                        ((LmTextBox)ctrl).SelectedValue = valor;
                                }
                                else if (((LmTextBox)ctrl).Valor == LmValueType.ComboBox_Enum)
                                {
                                    if (!string.IsNullOrEmpty(valor))
                                        ((LmTextBox)ctrl).SelectedValue = pro.GetValue(objeto);
                                }
                                else
                                    ctrl.Text = valor;

                                // ctrl.Refresh();

                                break;
                            }
                        }
                        else if ((ctrl is LmCheckBox))
                        {
                            if (((LmCheckBox)ctrl).Propriedade == nome)
                            {
                                if (pro.PropertyType == typeof(System.Boolean))
                                    ((LmCheckBox)ctrl).Checked = (bool)pro.GetValue(objeto);
                                else if (pro.PropertyType.IsEnum)
                                {
                                    if ((int)pro.GetValue(objeto) == 0)
                                        ((LmCheckBox)ctrl).Checked = false;
                                    else
                                        ((LmCheckBox)ctrl).Checked = true;
                                }

                                break;
                            }
                        }
                    }
                }

                PreencherControles(ctrl, objeto);
            }
        }

        /// <summary>
        /// Atualiiza as propriedades de um Objeto De acordo com valores dos Controles _ 
        /// O Nome do Controle deve terminar com nome da propriedade
        /// Comprimento do Nome de Controle deve ser <= Comprimento nome da propriedade + 3
        /// </summary>
        /// <typeparam name="T">Tipo do Objeto</typeparam>
        /// <param name="sender">Formulário que chamou evento</param>
        /// <param name="objeto">Objeto com as propriedades que serão passadas para controles</param>
        /// <returns></returns>
        public static void AtualizarObjeto(Control sender, object objeto)
        {
            foreach (Control ctrl in sender.Controls)
            {
                if (string.IsNullOrEmpty(ctrl.Name)) continue;

                if (ctrl is LmTextBox || ctrl is LmCheckBox)
                {
                    string nome = string.Empty;

                    foreach (PropertyInfo pi in objeto.GetType().GetProperties())
                    {
                        var valor = pi.GetValue(objeto, null);
                        nome = pi.Name;

                        if ((ctrl is LmTextBox))
                        {
                            if (((LmTextBox)ctrl).IsPrimaryKey)
                                break;

                            if (((LmTextBox)ctrl).Propriedade == nome)
                            {
                                if (((LmTextBox)ctrl).IsPrimaryKey && string.IsNullOrEmpty(ctrl.Text))
                                    ctrl.Text = "0";

                                var converter = TypeDescriptor.GetConverter(pi.PropertyType);

                                ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.Replace("\r\r\n", Environment.NewLine);
                                ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.Replace("\n", Environment.NewLine);
                                ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.Replace("\r\r\n", Environment.NewLine);

                                if (((LmTextBox)ctrl).Valor == LmValueType.Fone ||
                                    ((LmTextBox)ctrl).Valor == LmValueType.Cpf_Cnpj)
                                    ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.SomenteNumeros();
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Monetario)
                                    ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.Replace("R", "").Replace("$", "");

                                if (((LmTextBox)ctrl).Valor == LmValueType.Data)
                                {
                                    if (DateTime.TryParse(ctrl.Text.Replace("/", "."), out DateTime dt))
                                        valor = dt;
                                }
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Num_Real)
                                {
                                    if (!string.IsNullOrEmpty(ctrl.Text))
                                        valor = Convert.ToDouble(ctrl.Text);
                                }
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Num_Inteiro)
                                {
                                    if (!string.IsNullOrEmpty(ctrl.Text))
                                        valor = Convert.ToInt32(ctrl.Text.SomenteNumeros());
                                    else
                                        valor = null;
                                    //valor = converter.ConvertTo(ctrl.Text, pi.PropertyType);
                                }
                                else if (((LmTextBox)ctrl).Valor == LmValueType.ComboBox || ((LmTextBox)ctrl).Valor == LmValueType.ComboBox_Enum)
                                {
                                    if (((LmTextBox)ctrl).SelectedValue != null || converter is NullableConverter)
                                        valor = ((LmTextBox)ctrl).SelectedValue;
                                }
                                else
                                {
                                    valor = converter.ConvertTo(ctrl.Text, pi.PropertyType);
                                }

                                pi.SetValue(objeto, valor);

                                if (((LmTextBox)ctrl).Valor == LmValueType.Fone)
                                    ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.FormatarFone();
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Cpf_Cnpj)
                                    ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.FormatarCpf_Cnpf();
                                else if (((LmTextBox)ctrl).Valor == LmValueType.Monetario)
                                    ((LmTextBox)ctrl).Text = ((LmTextBox)ctrl).Text.FormatarMonetario();

                                break;
                            }
                        }
                        else if (ctrl is LmCheckBox)
                        {
                            if (((LmCheckBox)ctrl).Propriedade == nome)
                            {
                                if (pi.PropertyType == typeof(System.Boolean))
                                    pi.SetValue(objeto, ((LmCheckBox)ctrl).Checked);
                                else if (((LmCheckBox)ctrl).Checked)
                                    pi.SetValue(objeto, 1);
                                else
                                    pi.SetValue(objeto, 0);
                                break;
                            }
                        }
                    }
                }

                AtualizarObjeto(ctrl, objeto);
            }
        }

        /// <summary>
        /// Seta o foco no controle em que a propriedade "IsPrimariKey" esta definida como "true"
        /// </summary>
        /// <param name="control">Controle proprietário</param>
        public static void FocusCtrlPrimaryKey(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is LmTextBox)
                    if (((LmTextBox)ctrl).IsPrimaryKey)
                    {
                        ctrl.Focus();
                        return;
                    }

                FocusCtrlPrimaryKey(ctrl);
            }
        }

        /// <summary>
        /// Verifica se Scroll Vertical esta ativo
        /// </summary>
        /// <param name="dgv">DataGrid WindowsForm</param>
        /// <returns>Verdadeiro se Ativo</returns>
        public static bool HScrollAtivo(DataGridView dgv)
        {
            int height = dgv.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgv.Rows)
                height += row.Height;

            if (height >= dgv.Height)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verificar se Arquivo esta em uso pelo sisTheme
        /// </summary>
        /// <param name="fileName"> Path nome completo do arquivo</param>
        /// <returns>Verdadeiro ou false</returns>
        public static bool ArquivoEstaAberto(string fileName)
        {
            try
            {
                if (!System.IO.File.Exists(fileName)) return false;

                System.IO.FileStream fs = System.IO.File.OpenWrite(fileName);
                fs.Close();
                GC.SuppressFinalize(fs);
                GC.Collect();
                return false;
            }
            catch (System.IO.IOException)
            {
                return true;
            }

        }

        /// <summary>
        /// Copiar Diretório com seus arquivos
        /// </summary>
        /// <param name="sourceDir">Diretorio à copiar</param>
        /// <param name="destinDir">destino do diretorio copiado</param>
        public static void CopyDirectory(string sourceDir, string destinDir)
        {
            String[] Files;

            if (destinDir[destinDir.Length - 1] != Path.DirectorySeparatorChar)
                destinDir += Path.DirectorySeparatorChar;
            if (!Directory.Exists(destinDir)) Directory.CreateDirectory(destinDir);
            Files = Directory.GetFileSystemEntries(sourceDir);
            foreach (string Element in Files)
                if (Directory.Exists(Element))
                    CopyDirectory(Element, destinDir + Path.GetFileName(Element));// Sub directories
                else
                    File.Copy(Element, destinDir + Path.GetFileName(Element), true);// Files in directory           
        }

        /// <summary>
        /// Seleciona a linha que contém ID informado(Nome Coluna Dever Ser "ID")
        /// </summary>
        /// <param name="ID">Id a ser Procurado</param>
        /// <param name="dgv">DataGrid para Pesquisar</param>
        /// <returns>
        /// Verdadeiro - Se Encontrol Linha com ID Informado
        /// Falso - Se Não Encontrol Linha com ID Informado
        /// </returns>
        public static bool SelRegistroDgvPorId(int ID, DataGridView dgv)
        {
            bool _return = false;
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                    if ((int)row.Cells["ID"].Value == ID)
                    {
                        dgv.Rows[row.Index].Cells[0].Selected = true;
                        _return = true;
                        dgv.Refresh();
                        break;
                    }

                return _return;
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro nao Visivel Pelo Usuário", true);
                return _return;
            }
        }

        /// <summary>
        /// Seleciona a linha que contém Valor informado na Coluna informada
        /// </summary>
        /// <param name="nomeColuna">Nome da coluna a ser Verificada</param>
        /// <param name="valor">Id a ser Procurado</param>
        /// <param name="dgv">DataGrid para Pesquisar</param>
        /// <returns>
        /// Verdadeiro - Se Encontrol Valor na coluna informada Informado
        /// Falso - Se Não Encontrol Valor na coluna informada Informado
        /// </returns>
        public static bool SelRegistroDgvPorId(string nomeColuna, string valor, DataGridView dgv)
        {
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                    if (row.Cells[nomeColuna].Value.ToString() == valor)
                    {
                        dgv.Rows[row.Index].Cells[nomeColuna].Selected = true;
                        dgv.Refresh();
                        return true;
                    }

                return false;
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro nao Visivel Pelo Usuário", true);
                return false;
            }
        }

        /// <summary>
        /// Inverter Cores de Um BitMap
        /// </summary>
        /// <param name="bitmapImage"></param>
        /// <returns></returns>
        public static Bitmap ApplyInvert(System.Drawing.Image imagem)
        {
            byte A, R, G, B;
            Color pixelColor;
            Bitmap bitmapImage = new Bitmap(imagem);

            for (int y = 0; y < bitmapImage.Height; y++)
            {
                for (int x = 0; x < bitmapImage.Width; x++)
                {
                    pixelColor = bitmapImage.GetPixel(x, y);
                    A = pixelColor.A;
                    R = (byte)(255 - pixelColor.R);
                    G = (byte)(255 - pixelColor.G);
                    B = (byte)(255 - pixelColor.B);
                    bitmapImage.SetPixel(x, y, Color.FromArgb(A, R, G, B));
                }
            }

            return bitmapImage;
        }

        public static void ConvertGridToCSV(LmDataGridViewUC dgv)
        {
            if (dgv.Grid.RowCount == 0)
            {
                MsgBox.Show("O Grid não Possui Linhas, Conversão para CSV Cancelado", "Conversão para CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string name = dgv.Grid.CurrentRow != null ? dgv.Grid.CurrentRow.DataBoundItem.GetType().ToString() : "Nome";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.Title = "Salvar arquivo CSV";
            sfd.Filter = "CSV|*.csv|All files|*.*";
            sfd.DefaultExt = "csv";
            sfd.FileName = name;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;

                if (ArquivoEstaAberto(filename))
                {
                    MsgBox.Show("Um Documento com este nome já está aberto.\n" +
                        "Feche o mesmo para conseguir gerar outro, ou salve com um nome diferente.", "Documento Em Uso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MsgBox.ShowWaitMessage("Convertendo grid em CSV...");

                try
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Create))
                    {
                        string encoding = /*rdbUtf8.Checked ? "UTF-8" :*/ "ISO-8859-1";
                        using (StreamWriter file = new StreamWriter(fs, Encoding.GetEncoding(encoding)))
                        {
                            string linha = string.Empty;

                            List<DataGridViewColumn> colunas = new List<DataGridViewColumn>();

                            foreach (DataGridViewColumn cln in dgv.Grid.Columns)
                                if (cln.ValueType != typeof(System.Drawing.Bitmap) && cln.Visible)
                                    colunas.Add(cln);

                            DataGridViewColumn clnChange = new DataGridViewColumn();

                            for (int i = 0; i < colunas.Count; i++)
                            {
                                for (int h = i + 1; h < colunas.Count; h++)
                                {
                                    if (colunas[i].DisplayIndex > colunas[h].DisplayIndex)
                                    {
                                        clnChange = colunas[i];
                                        colunas[i] = colunas[h];
                                        colunas[h] = clnChange;
                                    }
                                }
                            }

                            foreach (DataGridViewColumn cln in colunas)
                            {
                                linha += $"{cln.HeaderText.Replace("▲  ", "").Replace("▼  ", "")};";
                            }

                            file.WriteLine(linha.Substring(0, linha.Length - 1));

                            foreach (DataGridViewRow row in dgv.Grid.Rows)
                            {
                                linha = string.Empty;
                                foreach (DataGridViewColumn cln in colunas)
                                {
                                    if (cln.ValueType == typeof(string))
                                        linha += $"\"{Convert.ToString(row.Cells[cln.Name].EditedFormattedValue.ToString())}\";" ?? string.Empty + ";";
                                    else
                                        linha += $"{Convert.ToString(row.Cells[cln.Name].EditedFormattedValue.ToString())};" ?? string.Empty + ";";
                                }

                                // linha = linha.Replace("\r\n", " ");
                                file.WriteLine(linha.Substring(0, linha.Length - 1));
                            }
                            file.Close();
                        }
                        fs.Close();
                    }

                    if (File.Exists(filename))
                        if (MsgBox.Show("Deseja Abrir o Arquivo?", "CSV criado com sucesso",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            Process.Start(filename);
                }
                catch (Exception ex)
                {
                    MsgBox.Show($"Erro ao escrever arquivo<SEP>" +
                        $"{ex.Message}", "Erro ao Converter grid em CSV",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    MsgBox.CloseWaitMessage();
                }

            }
        }

        #region Imprimi DGV

        public static string ImprimirDGV(
            object sender, LmDataGridViewUC dgv, string nomeParaImpressao, string usuario,
            string dadosEmpresa, System.Drawing.Image logoEmpresa, string titulo, string colunasOcultas,
            bool abrirAposSalvar, out string colOcultasImpress)
        {
            if (dgv.Grid.RowCount == 0)
            {
                MsgBox.Show("O Grid não Possui Linhas, Impressão Cancelada", "Imprimir PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                colOcultasImpress = colunasOcultas;
                return string.Empty;
            }

            try
            {
                nomeParaImpressao = nomeParaImpressao.RemoverCaracteresEspeciais().Replace("_", " ");

                DateTime agora = DateTime.Now;

                string pathName = ValPadrao.PastaTemp +
                    agora.Year + "." +
                    agora.Month.ToString("00") + "." +
                    agora.Day.ToString("00") + "." +
                    agora.Hour.ToString("00") + "." +
                    agora.Minute.ToString("00") + "." +
                    agora.Second.ToString("00") + "_" +
                    nomeParaImpressao + ".PDF";

                List<DataGridViewColumn> colunas = new List<DataGridViewColumn>();

                foreach (DataGridViewColumn cln in dgv.Grid.Columns)
                    if (cln.ValueType != typeof(System.Drawing.Bitmap) && cln.Visible)
                        colunas.Add(cln);

                DataGridViewColumn clnChange = new DataGridViewColumn();

                for (int i = 0; i < colunas.Count; i++)
                {
                    for (int h = i + 1; h < colunas.Count; h++)
                    {
                        if (colunas[i].DisplayIndex > colunas[h].DisplayIndex)
                        {
                            clnChange = colunas[i];
                            colunas[i] = colunas[h];
                            colunas[h] = clnChange;
                        }
                    }
                }

                colOcultasImpress = SelColunasImpressao(sender, colunas, colunasOcultas);

                if (colOcultasImpress == null)
                {
                    MsgBox.Show("Cancelado pelo usuário", "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colOcultasImpress = colunasOcultas;
                    return string.Empty;
                }

                foreach (var str in colOcultasImpress.Split(new string[] { "^" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    colunas.Remove(dgv.Grid.Columns[str]);
                }

                int numeroColunas = 0, larguraTotal = 0;
                foreach (DataGridViewColumn c in colunas)
                {
                    if (c.ValueType != typeof(Bitmap) && c.Visible)
                    {
                        numeroColunas++;
                        larguraTotal += c.Width;
                    }
                }

                bool retrato = true;

                if (larguraTotal >= 1150)
                {
                    retrato = false;
                }

                if (larguraTotal >= 1500)
                {
                    if (MsgBox.Show("As colunas selecionadas ultrapassam o límite da largura ideal.<SEP>" +
                        "Deseja gerar o PDF mesmo assim?", "Largura Máxima Excedida",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return string.Empty;
                    }
                }

                CriarTabela(dgv.Grid, colunas, pathName, dadosEmpresa, logoEmpresa, titulo, numeroColunas, retrato);

                InserirPagNumPDF(pathName, usuario, retrato);

                if (File.Exists(pathName) && abrirAposSalvar)
                    Process.Start(pathName);
                else if (File.Exists(pathName))
                {
                    //PrintDialog printDlg = new PrintDialog();
                    //if (printDlg.ShowDialog() == DialogResult.OK)
                    //{
                    Process process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            CreateNoWindow = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "print",
                            FileName = pathName,
                            //Arguments = String.Format(@"-t ""{0}"" ""{1}""", printDlg, printDlg.PrinterSettings.PrinterName),// printDlg.PrinterSettings.PrinterName
                        },
                    };
                    process.Start();
                    //}
                }

                return pathName;
            }
            catch (Exception ex)
            {
                MsgBox.Show("Erro ao converter grid em PDF.\n" + ex.Message, "Erro ao Imprimir PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                colOcultasImpress = colunasOcultas;
                return string.Empty;
            }
        }

        public static void ImprimirDGV(string doc)
        {
            //PdfDocument docPDF = new PdfDocument();
            //docPDF.LoadFromFile(doc);
        }

        private static void CriarTabela(LmDataGridView dgv,
            List<DataGridViewColumn> colunas, string pathName, string dadosEmpresa,
            System.Drawing.Image logoEmpresa, string titulo, int numeroColunas, bool retrato)
        {
            try
            {
                //Criando tabela iTextSharp a partir dos dados DataGridView 
                Document pdfDoc = retrato
                    ? new Document(PageSize.A4, 12f, 3f, 20f, 50f)
                    : new Document(PageSize.A4.Rotate(), 12f, 3f, 20f, 50f);

                PdfPTable pdfTable = new PdfPTable(numeroColunas);
                PdfPTable pdfCabecalho = new PdfPTable(2);
                PdfPTable pdfRodape = new PdfPTable(2);

                int f = Convert.ToInt32(iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 7, f, BaseColor.Black);

                //pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 90;
                pdfCabecalho.WidthPercentage = 90;
                pdfRodape.WidthPercentage = 90;

                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                pdfTable.SetWidths(GetWidthPerc(colunas));
                pdfCabecalho.SetWidths(new[] { 25f, 75f });
                pdfRodape.SetWidths(new[] { 85f, 15f });

                CriarCabecalho(pdfCabecalho, dadosEmpresa, logoEmpresa, titulo);
                CriarCabecalhoTabela(colunas, pdfTable);

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    List<PdfPCell> pdfPCells = new List<PdfPCell>();
                    foreach (DataGridViewColumn c in colunas)
                    {
                        int hrAlignment = 0;

                        switch (c.DefaultCellStyle.Alignment)
                        {
                            case DataGridViewContentAlignment.NotSet:
                                hrAlignment = Element.ALIGN_UNDEFINED;
                                break;
                            case DataGridViewContentAlignment.TopLeft:
                                hrAlignment = Element.ALIGN_LEFT;
                                break;
                            case DataGridViewContentAlignment.TopCenter:
                                hrAlignment = Element.ALIGN_CENTER;
                                break;
                            case DataGridViewContentAlignment.TopRight:
                                hrAlignment = Element.ALIGN_RIGHT;
                                break;
                            case DataGridViewContentAlignment.MiddleLeft:
                                hrAlignment = Element.ALIGN_LEFT;
                                break;
                            case DataGridViewContentAlignment.MiddleCenter:
                                hrAlignment = Element.ALIGN_CENTER;
                                break;
                            case DataGridViewContentAlignment.MiddleRight:
                                hrAlignment = Element.ALIGN_RIGHT;
                                break;
                            case DataGridViewContentAlignment.BottomLeft:
                                hrAlignment = Element.ALIGN_LEFT;
                                break;
                            case DataGridViewContentAlignment.BottomCenter:
                                hrAlignment = Element.ALIGN_CENTER;
                                break;
                            case DataGridViewContentAlignment.BottomRight:
                                hrAlignment = Element.ALIGN_RIGHT;
                                break;
                            default:
                                break;
                        }
                        PdfPCell cell = new PdfPCell(new Phrase(row.Cells[c.Name].EditedFormattedValue.ToString(), blackFont))
                        {
                            Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER,
                            HorizontalAlignment = hrAlignment,
                            VerticalAlignment = Element.ALIGN_MIDDLE,
                        };

                        pdfPCells.Add(cell);
                    }

                    foreach (var cell in pdfPCells)
                    {
                        pdfTable.AddCell(cell);
                    }
                }

                using (FileStream stream = new FileStream(pathName, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfCabecalho);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Add(pdfRodape);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                retrato = true;
                MsgBox.Show("Erro ao Criar Tabela\n" + ex.Message, "Erro ao Imprimir PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CriarCabecalho(PdfPTable pdfCabecalho, string dadosEmpresa, System.Drawing.Image logoEmpresa, string titulo)
        {
            try
            {
                int f = Convert.ToInt32(iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 8, f, BaseColor.Black);
                iTextSharp.text.Font tituloFont = FontFactory.GetFont("Arial", 10, f, BaseColor.Black);

                string imagemTemp = ValPadrao.PastaTemp + "Logo.JPEG";
                var imgBytes = logoEmpresa.ToByteArray();
                File.WriteAllBytes(imagemTemp, imgBytes);

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagemTemp);

                PdfPCell cellLogo = new PdfPCell(logo, true)
                {
                    Border = 0,
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                };

                PdfPCell cellEmpresa = new PdfPCell(new Phrase(dadosEmpresa, blackFont))
                {
                    Border = 0,
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                };

                PdfPCell cellTitulo = new PdfPCell(new Phrase(titulo, tituloFont))
                {
                    Border = 0,
                    Colspan = 2,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                };

                PdfPCell cellVazia = new PdfPCell(new Phrase("", blackFont))
                {
                    FixedHeight = 5,
                    Border = 0,
                    Colspan = 2
                };

                pdfCabecalho.AddCell(cellLogo);
                pdfCabecalho.AddCell(cellEmpresa);
                pdfCabecalho.AddCell(cellVazia);
                pdfCabecalho.AddCell("");
                pdfCabecalho.AddCell("");
                pdfCabecalho.AddCell(cellVazia);
                pdfCabecalho.AddCell(cellTitulo);
                pdfCabecalho.AddCell(cellVazia);
            }
            catch (Exception ex)
            {
                MsgBox.Show("Erro ao Criar Cabeçalho da Página\n" + ex.Message, "Erro ao Imprimir PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CriarCabecalhoTabela(List<DataGridViewColumn> colunas, PdfPTable pdfTable)
        {
            try
            {
                int f = Convert.ToInt32(iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 8, f, BaseColor.Black);

                List<PdfPCell> pdfPCells = new List<PdfPCell>();
                foreach (DataGridViewColumn c in colunas)
                {
                    pdfPCells.Add(new PdfPCell(new Phrase(c.HeaderText, blackFont))
                    {
                        Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER,
                        HorizontalAlignment = Element.ALIGN_MIDDLE,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        BackgroundColor = new iTextSharp.text.BaseColor(Color.FromArgb(180, 180, 180))
                    });
                }

                foreach (var cell in pdfPCells)
                {
                    pdfTable.AddCell(cell);
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show("Erro ao Criar Cabeçalho da Tabela\n" + ex.Message, "Erro ao Imprimir PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void InserirPagNumPDF(string pathName, string usuario, bool retrato)
        {
            try
            {
                if (!File.Exists(pathName))
                    return;

                int largPDF = 0;
                //int altPDF = 0;

                int f = Convert.ToInt32(iTextSharp.text.Font.NORMAL);
                byte[] bytes = File.ReadAllBytes(pathName);
                iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 8, f, BaseColor.Black);
                iTextSharp.text.Font grayFont = FontFactory.GetFont("Arial", 8, f, BaseColor.Gray);

                using (MemoryStream stream = new MemoryStream())
                {
                    PdfReader reader = new PdfReader(bytes);
                    PdfStamper stamper = new PdfStamper(reader, stream);

                    string data = DateTime.Now.ToShortDateString();
                    string hora = DateTime.Now.ToShortTimeString();
                    int pages = reader.NumberOfPages;
                    for (int i = 1; i <= pages; i++)
                    {
                        iTextSharp.text.Rectangle mediabox = reader.GetPageSize(i);
                        largPDF = Convert.ToInt16(mediabox.Height);
                        //altPDF = Convert.ToInt16(mediabox.Width);

                        // default
                        float x = 80f;
                        float y = 7f;
                        float ang = 0;

                        x = 40f; y = 25f; ang = 0;
                        ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT,
                            new Phrase($"Relatório gerado por {usuario} em {data} as {hora}", grayFont), x, y, ang);

                        x = retrato ? 510f : 750f;

                        ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase("Página " + i.ToString() + " de " + pages, blackFont), x, y, ang);
                    }

                    bytes = stream.ToArray();
                }
                File.WriteAllBytes(pathName, bytes);
            }
            catch (Exception ex)
            {
                MsgBox.Show("Erro ao Inserir Número de Página\n" + ex.Message, "Erro ao Imprimir PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static float[] GetWidthPerc(List<DataGridViewColumn> colunas)
        {
            List<float> wPerc = new List<float>();

            float totalwidth = 0;
            foreach (DataGridViewColumn c in colunas)
                totalwidth += c.Width;

            foreach (DataGridViewColumn c in colunas)
                wPerc.Add((100 / totalwidth) * c.Width);// (c.Width / (float)dgv.Width) * 100);

            float[] _return = new float[wPerc.Count];

            for (int i = 0; i < wPerc.Count; i++)
            {
                _return[i] = wPerc[i];
            }

            return _return;
        }

        private static string SelColunasImpressao(object sender, List<DataGridViewColumn> colunas, string colunasOcultas)
        {
            /*
             * Comentado Temporariamente
             * 
             * 
             * 
             * 
            var ctrl = (Control)sender;

            FrmConfigColunasGrid frm = new FrmConfigColunasGrid("Selecionar Colunas para Imprimir");
            System.Drawing.Rectangle areaTrabalho = Screen.GetWorkingArea(frm);

            var ptScreen = ctrl.PointToScreen(Point.Empty);
            ptScreen.Y += ctrl.Height;

            bool paraBaixo = areaTrabalho.Bottom - ptScreen.Y < ptScreen.Y ? false : true;

            int ladoMaior = (areaTrabalho.Bottom - ptScreen.Y) < ptScreen.Y ? ptScreen.Y : areaTrabalho.Bottom - ptScreen.Y;
            int ladoMenor = ladoMaior == ptScreen.Y ? areaTrabalho.Bottom - ptScreen.Y : ptScreen.Y;

            ladoMaior -= 50;

            int altura = frm.Height;

            var dict = new Dictionary<string, string>();

            foreach (DataGridViewColumn cln in colunas)
            {
                dict.Add(cln.Name, cln.HeaderText);

                if (altura < ladoMaior)
                    altura += 20;
            }

            frm.Height = altura;
            frm.Width += 40;

            int posX = ptScreen.X;
            int posY = ptScreen.Y;

            if (posX > areaTrabalho.Width - frm.Width - 5)
                posX = areaTrabalho.Width - frm.Width - 5;

            if (paraBaixo || (!paraBaixo && ladoMenor > frm.Height))
            {
                posY = ptScreen.Y;
            }
            else if (!paraBaixo)
            {
                posY = ptScreen.Y - frm.Height - ctrl.Height;
            }

            frm.Location = new Point(posX, posY);

            frm.clbColunas.DataSource = new BindingSource(dict, null);
            frm.clbColunas.DisplayMember = "Value";
            frm.clbColunas.ValueMember = "Key";

            for (int i = 0; i < frm.clbColunas.Items.Count; i++)
            {
                frm.clbColunas.SelectedIndex = i;
                frm.clbColunas.SetItemChecked(i, true);

                foreach (var item in colunasOcultas?.Split(new string[] { "^" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (item == frm.clbColunas.SelectedValue.ToString())
                    {
                        frm.clbColunas.SetItemChecked(i, false);
                        break;
                    }
                }
            }
            frm.clbColunas.SelectedIndex = 0;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string _return = string.Empty;

                for (int i = 0; i < frm.clbColunas.Items.Count; i++)
                {
                    frm.clbColunas.SelectedIndex = i;
                    var indicesSelecionados = frm.clbColunas.CheckedItems;

                    if (!indicesSelecionados.Contains(frm.clbColunas.SelectedItem))
                        _return += frm.clbColunas.SelectedValue.ToString() + "^";
                }

                if (_return.EndsWith("^"))
                    _return = _return.Substring(0, _return.Length - 1);

                //foreach (var item in frm.clbColunas.CheckedItems)
                //    _return += item.;

                return _return;
            }
            else

                */
                return null;
        }

        #endregion

    }
}
