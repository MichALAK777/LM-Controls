using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LMControls.Metodos
{
    public class Web
    {
        public static void AbrirBuscaCep()
        {
            try
            {
                if (IsConnected())
                {                                   //http://www.buscacep.correios.com.br/sistemas/buscacep/buscaCepEndereco.cfm
                    System.Diagnostics.Process.Start("http://www.buscacep.correios.com.br/sistemas/buscacep/");
                }
                else
                {
                    MsgBox.Show("Sem Conexão com a Internet!", "Sem Internet", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro ao Abrir Site de Busca");
            }
        }

        public static void AbrirGoogleMaps(string cep, string rua, string cidade, string uf, string numero)
        {
            try
            {
                if (IsConnected())
                {
                    StringBuilder @string = new StringBuilder();

                    @string.Append("http://maps.google.com/maps?q=");

                    if (!string.IsNullOrEmpty(rua)) @string.Append($"{rua},+");
                    if (!string.IsNullOrEmpty(numero)) @string.Append($"{numero},+");
                    if (!string.IsNullOrEmpty(cidade)) @string.Append($"{cidade},+");
                    if (!string.IsNullOrEmpty(uf)) @string.Append($"{uf},+");
                    if (!string.IsNullOrEmpty(cep)) @string.Append($"{cep},+");

                    System.Diagnostics.Process.Start(@string.ToString());
                }
                else
                {
                    MsgBox.Show("Sem Conexão com a Internet!", "Sem Internet", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro ao Abrir Google Map");
            }
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnected()
        {
            return InternetGetConnectedState(out int Description, 0);
        }
    }
}
