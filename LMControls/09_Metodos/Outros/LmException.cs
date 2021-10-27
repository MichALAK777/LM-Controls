using LMControls.Metodos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMControls
{
    public class LmException
    {
        #region Variaveis

        static Exception _ex;
        static string _errorMessageTitulo = "";

        #endregion

        #region Chamada das Excessões
        /*
        /// <summary>
        /// Exeção padrão lancada caso algum erro seja gerado ao salvar
        /// </summary>
        /// <param name="ex">Exceção do tipo "DbEntityValidationException"</param>
        public static void DbExceptionSave(DbEntityValidationException ex)
        {
            if (ex.EntityValidationErrors != null)
            {

                foreach (var validationErrors in ex.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        MsgBox.Show(TraduzirErro(validationError.ErrorMessage), "Erro ao Salvar Registro",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ex = ex;
                _errorMessageTitulo = "Erro ao Salvar Registro";

                ArquivoLogErro(ex.ToString());

                System.Threading.Thread t = new System.Threading.Thread(EnviarEmail);
                t.Start();
            }
            else if (ex.InnerException != null)
                ShowException(ex.InnerException, "Erro ao Salvar Registro");

            MsgBox.CloseWaitMessage();
        }
        */

        /// <summary>
        /// Exeção Padrão Envia Email com log do erro
        /// </summary>
        /// <param name="ex">Exeção gerada</param>
        /// <param name="errorMessageTitulo">Titulo da Caixa de mensagem</param>
        /// <param name="naoMostrarMensagem">Marcar Como 'true' para ocultar a mensagem para o usuario</param>
        public static void ShowException(Exception ex, string errorMessageTitulo, bool naoMostrarMensagem = false, bool naoEnviarEmail = false)
        {
            if (ex.Message == "Não é possível chamar Invoke ou BeginInvoke em um controle antes da criação do identificador de janela.")
                return;

            if (!naoMostrarMensagem)
            {
                //if (ex.InnerException != null)
                //{
                //    if (ex.InnerException.InnerException != null)
                //        MsgBox.Show(TraduzirErro(ex.InnerException.InnerException.Message) + MensagemComplementar(ex), errorMessageTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    else
                //        MsgBox.Show(TraduzirErro(ex.InnerException.Message) + MensagemComplementar(ex), errorMessageTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //    MsgBox.Show(TraduzirErro(ex.Message + MensagemComplementar(ex)), errorMessageTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _ex = ex;
            _errorMessageTitulo = errorMessageTitulo;

            ArquivoLogErro(ex.ToString());

            if (!naoEnviarEmail)
            {
                System.Threading.Thread t = new System.Threading.Thread(() => { EnviarEmail(); }) { IsBackground = true };
                t.Start();
            }

            //MsgBox.CloseWaitMessage();
        }

        private static string TraduzirErro(string erro)
        {
            if (erro.StartsWith("The model backing the"))
                erro = $"DataBase Alterada.\nAtualize o Sistema para a última versão.";

            if (erro.ToLower().Contains("duplicate entry") && erro.ToLower().Contains("for key") && erro.ToLower().Contains("primary"))
            {
                var cod = erro.SomenteNumeros();
                return $"Foi encontrado um registro com este código '{cod}' na base de dados.\n" +
                    $"Tente salvar novamente para usar o próximo código.";
            }

            if (erro.ToLower().Contains("unable to connect to any of the specified mysql hosts") ||
                erro.ToLower().Contains("the underlying provider failed on Open"))
            {
                return $"Aviso!\n" +
                    $"O Sistema tentou se conectar com o servidor, mas não conseguiu!" +
                    $"Se isso persistir, verifique sua conexão.";
            }

            return erro
            .Replace("Cannot delete or update a parent row: a foreign key constraint fails",
                     "Não é possível Excluir este Registro devido a restrição abaixo\n\n");
        }

        private static string MensagemComplementar(Exception ex)
        {
            var _return = "";

            try
            {
                var stktrace1 = ex.StackTrace.Split(new string[] { "\\" }, StringSplitOptions.None);
                var erroOnde1 = stktrace1[stktrace1.Length - 1];

                var stktrace2 = erroOnde1.Split(new string[] { " em " }, StringSplitOptions.None);
                var erroOnde2 = stktrace2[stktrace2.Length - 1];

                var stktrace3 = erroOnde2.Split(new string[] { " na " }, StringSplitOptions.None);
                _return = $"\n<sep>{stktrace3[stktrace3.Length - 1].Trim()}";
            }
            catch (Exception)
            {
            }

            return _return.Trim();
        }

        #endregion

        #region Metodos

        static void EnviarEmail()
        {
            ////SalvarImagemErro();
            //Metodos.Email.SendEmailofException(_ex, _errorMessageTitulo);

            //try
            //{
            //    if (System.IO.File.Exists(ValPadrao.PathImagemLogErro))
            //        System.IO.File.Delete(ValPadrao.PathImagemLogErro);
            //}
            //catch (Exception)
            //{
            //}
        }

        /// <summary>
        /// Gravar arquivo de log de Erro 
        /// </summary>
        /// <param name="objetoConfiguracao">Objeto que contem a configuração para a integração com o DJPDV</param>
        /// <param name="ex">Exception que contêm mensagem de erro caso houver</param>
        public static void ArquivoLogErro(string ex)
        {
            //if (!Directory.Exists(ValPadrao.PastaLog))
            //    Directory.CreateDirectory(ValPadrao.PastaLog);

            //string nomeArquivo = $"{ValPadrao.PastaLog}{DateTime.Now.Year}.{DateTime.Now.Month.ToString("00")}.{DateTime.Now.Day.ToString("00")}_LogError.txt";

            //string mensagem = $"------>> {DateTime.Now} <<--->> {_errorMessageTitulo} <<----------{Environment.NewLine}{Environment.NewLine}" +
            //                       $"Erro: {ex}{Environment.NewLine}-------------------------------------------------------------------{Environment.NewLine}";

            //using (FileStream fs = new FileStream(nomeArquivo, FileMode.Append))
            //{
            //    using (StreamWriter file = new StreamWriter(fs))
            //    {
            //        file.WriteLine(mensagem);
            //        file.Close();
            //    }
            //    fs.Close();
            //}
        }

        #endregion
    }
}
