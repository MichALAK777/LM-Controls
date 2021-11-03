using LMControls.LmDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls
{
    public class MsgBox
    {
        public enum RetornoMsgBox
        {
            [System.ComponentModel.Description("Selecionado Opção 1")]
            Opcao1 = 1,
            [System.ComponentModel.Description("Selecionado Opção 2")]
            Opcao2 = 2,
            [System.ComponentModel.Description("Selecionado Opção 3")]
            Opcao3 = 3,
            SemRetorno = 99
        }

        /// <summary>
        /// Mostrar Caixa de Mensagem Personalizada
        /// </summary>
        /// <param name="texto">Texto para Exibição</param>
        /// <param name="titulo">Título da mensagem</param>
        /// <param name="msgBoxButtons">Escolha Botões</param>
        /// <param name="msgBoxIcon">Escolha Icone</param>
        /// <returns></returns>
        [STAThreadAttribute]
        public static DialogResult Show(string texto, string titulo = "",
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK,
            MessageBoxIcon msgBoxIcon = MessageBoxIcon.None,
            string textoBotao1 = "", string textoBotao2 = "", string textoBotao3 = "") 
        {
            return DialogResult.Abort; //temporariamente
            /*
             * 
             * comentado temporariamente
             * 
             * 
            try                                     
            {
                CloseWaitMessage();

                FrmMsgBox frm = new FrmMsgBox(texto, titulo, msgBoxButtons, msgBoxIcon, textoBotao1, textoBotao2, textoBotao3);

                if (InfoDefaultUI.DefaultMsgType == LmMessageType.InTaskBar )
                    frm.StartPosition = FormStartPosition.Manual;

                if ((msgBoxIcon == MessageBoxIcon.Information || msgBoxIcon == MessageBoxIcon.None) &&
                     msgBoxButtons == MessageBoxButtons.OK)
                {
                    frm.Show();
                }
                else
                    frm.ShowDialog();

                return frm.DialogResult;
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro não visivel pelo Usuario", true);
                return DialogResult.Abort;
            }
            */
        }

        public static RetornoMsgBox Show(string texto, string titulo, MessageBoxIcon msgBoxIcon,
            string textoBotao1, string textoBotao2 = "", string textoBotao3 = "",
            Image iconButton1 = null, Image iconButton2 = null, Image iconButton3 = null)
        {
            return RetornoMsgBox.SemRetorno; //temporariamente
            /*
             * 
             * comentado temporariamente
             * 
             * 
            try
            {
                CloseWaitMessage();

                FrmMsgBoxCustom frm = new FrmMsgBoxCustom(texto, titulo, msgBoxIcon,
                    textoBotao1, textoBotao2, textoBotao3,
                    iconButton1, iconButton2, iconButton3);
                frm.ShowDialog();

                return frm.DialogResult ==
                    DialogResult.OK ? RetornoMsgBox.Opcao1 : frm.DialogResult == DialogResult.No ? RetornoMsgBox.Opcao2 : RetornoMsgBox.Opcao3;
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro não visivel pelo Usuario", true);
                return RetornoMsgBox.SemRetorno;
            }
            */
        }

        /// <summary>
        /// Mostrar Dica no controle especificado
        /// </summary>
        /// <param name="owner">Formulário onde estara embutido o controle</param>
        /// <param name="control">Controle que irá mostrar a Dica</param>
        /// <param name="texto">Mensagem a ser exibida</param>
        /// <param name="titulo">Titulo da mensagem (Não Obrigatório)</param>
        /// <param name="tempoExibicao">Tempo de exposição da mensagem em milisegundos (Não Obrigatório)</param>
        [STAThreadAttribute]
        public static void ShowToolTip(/*IWin32Window owner,*/ Control control, string texto, string titulo = "", int tempoExibicao = 0)
        {
            /*
             * 
             * comentado temporariamente
             * 
             * 
            try
            {
                CloseWaitMessage();

                if (control != null && control.Parent != null)
                {
                    Control _owner = control.Parent;

                    frmMsgToolTip _msgToolTip = new frmMsgToolTip(texto, titulo, tempoExibicao);

                    _msgToolTip.Size = new Size(1, 1);

                    _msgToolTip.TopLevel = false;

                    _owner.Controls.Add(_msgToolTip);

                    _msgToolTip.Show();

                    _msgToolTip.Location = new Point(_owner.Controls[control.Name].Left, _owner.Controls[control.Name].Top + control.Height + 1);

                    if (_msgToolTip.Left + _msgToolTip.Width > _owner.Width)
                        _msgToolTip.Left = _owner.Width - _msgToolTip.Width - 1;

                    if (_msgToolTip.Top + _msgToolTip.Height > _owner.Height)
                        _msgToolTip.Top = _owner.Height - _msgToolTip.Height - 1;

                    if (control.Parent is FlowLayoutPanel)
                        _msgToolTip.SendToBack();
                    else
                        _msgToolTip.BringToFront();
                }
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro não visivel pelo Usuario", true);
            }

            */
        }

        [STAThreadAttribute]
        public static void ShowToolTipPerson(Control control, string texto)
        {
            /*
             * 
             * comentado temporariamente
             * 
             * 
             * 
            try
            {
                if (control != null && control.Parent != null)
                {
                    Control _owner = control.Parent;

                    FrmMsgToolTipPerson frm = new FrmMsgToolTipPerson(texto);
                    Rectangle areaTrabalho = Screen.GetWorkingArea(_owner);

                    var ptScreen = control.PointToScreen(Point.Empty);
                    ptScreen.Y += control.Height;

                    bool paraBaixo = areaTrabalho.Bottom - ptScreen.Y < ptScreen.Y ? false : true;

                    int ladoMaior = (areaTrabalho.Bottom - ptScreen.Y) < ptScreen.Y ? ptScreen.Y : areaTrabalho.Bottom - ptScreen.Y;
                    int ladoMenor = ladoMaior == ptScreen.Y ? areaTrabalho.Bottom - ptScreen.Y : ptScreen.Y;

                    ladoMaior -= 50;

                    int posX = ptScreen.X;
                    int posY = ptScreen.Y;

                    if (paraBaixo || (!paraBaixo && ladoMenor > frm.Height))
                    {
                        posY -= control.Height;
                    }
                    else if (!paraBaixo)
                    {
                        posY -= frm.Height;
                    }

                    frm.Location = new Point(posX, posY);

                    frm.ShowDialog();

                    if (control.Parent is FlowLayoutPanel)
                        frm.SendToBack();
                    else
                        frm.BringToFront();
                }
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro não visivel pelo Usuario", true);
            }
            */
        }

        public static void ShowWaitMessage(string texto = "Aguarde...")
        {
            try
            {
                CloseWaitMessage();

                string pastaTemp = "C:\\Temp\\";
                if (!System.IO.Directory.Exists(pastaTemp))
                    System.IO.Directory.CreateDirectory(pastaTemp);

                string fileName = pastaTemp + "MessageWait.lmproj";

                using (System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Create))
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(fs))
                    {
                        file.WriteLine(texto);
                        file.Close();
                    }
                    fs.Close();
                }

                System.Diagnostics.Process.Start(Application.StartupPath + "\\LmMessageBox.exe");
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro não visivel pelo Usuario", true);
            }
        }

        public static void CloseWaitMessage()
        {
            try
            {
                var processes = System.Diagnostics.Process.GetProcessesByName("LmMessageBox");
                foreach (var p in processes)
                    try
                    {
                        p.Kill();
                    }
                    catch (Exception)
                    {
                    }

                string fileName = "C:\\Temp\\MessageWait.lmproj";
                if (System.IO.File.Exists(fileName))
                    System.IO.File.Delete(fileName);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                GC.Collect();
            }
        }

        public static string ImputBox(string message = "", string titulo = "", string textoImputPadrao = "",
            LmValueType lmValueType = LmValueType.Alfanumerico, bool textoLongo = false, bool CentralizarForm = false)
        {
            /*
             * comentado temporariamente
             * 
             * 
             * 
             * 
            FrmImputBox frm = new FrmImputBox(message, titulo, textoImputPadrao, lmValueType, textoLongo, CentralizarForm);
            if (frm.ShowDialog() == DialogResult.OK)
                return frm.txt.Text;
            else

                */
                return string.Empty;
        }
        public static string ImputBox(out DialogResult dialogResult, string message = "", string titulo = "", string textoImputPadrao = "",
             LmValueType lmValueType = LmValueType.Alfanumerico, bool textoLongo = false, bool CentralizarForm = false)
        {
            /*
             * comentado temporariamente
             * 
             * 
             * 
            FrmImputBox frm = new FrmImputBox(message, titulo, textoImputPadrao, lmValueType, textoLongo, CentralizarForm);

            dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
                return frm.txt.Text;
            else
                */
            dialogResult = DialogResult.None; // temporariamente
            return string.Empty;
        }

    }
}
