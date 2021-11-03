using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMControls
{
    public class ValPadrao
    {
        public static string PastaPrograma { get; set; }
        public static string PastaTemp { get; set; }
        public static string PastaConfig { get; set; }
        public static string PastaLog { get; set; }
        public static string PastaArquivo { get; set; }
        public static string PastaImagem { get; set; }
        public static string PathImagemLogoRelatorio { get; set; }
        public static string PathImagemLogErro { get; set; }
        public static string ConnectionString { get; set; }
        public static string Mail { get; set; }
        public static string NomeSistema { get; set; }
        public static string NomeCliente { get; set; }


        public static void DefinirPadrao(string PastaRaiz, string nomeSisTheme, string nomeCliente = "", string mail = "")
        {
            NomeSistema = nomeSisTheme;

            if (string.IsNullOrEmpty(nomeCliente))
                NomeCliente = "LM Projetos";
            else
                NomeCliente = nomeCliente;

            if (string.IsNullOrEmpty(mail))
                Mail = "michalakleo@gmail.com";
            else Mail = mail;

            PastaPrograma = $@"C:\{PastaRaiz}\{nomeSisTheme}\";
            PastaImagem = PastaPrograma + @"Imagens\";
            PastaTemp = $@"{PastaPrograma}Temp\";
            PastaConfig = $@"{PastaPrograma}Config\";
            PastaLog = $@"{PastaPrograma}Logs\";
            PastaArquivo = $@"{PastaPrograma}Arquivos\";

            PathImagemLogoRelatorio = $@"{PastaImagem}Logo.PNG";

            PathImagemLogErro = $@"{PastaImagem}Error.PNG";

            ConnectionString = PastaConfig + "ConnectionString.cnn";

            if (!System.IO.Directory.Exists(PastaPrograma))
                System.IO.Directory.CreateDirectory(PastaPrograma);

            if (!System.IO.Directory.Exists(PastaTemp))
                System.IO.Directory.CreateDirectory(PastaTemp);

            if (!System.IO.Directory.Exists(PastaImagem))
                System.IO.Directory.CreateDirectory(PastaImagem);

            if (!System.IO.Directory.Exists(PastaConfig))
                System.IO.Directory.CreateDirectory(PastaConfig);

            if (!System.IO.Directory.Exists(PastaLog))
                System.IO.Directory.CreateDirectory(PastaLog);

            if (!System.IO.Directory.Exists(PastaArquivo))
                System.IO.Directory.CreateDirectory(PastaArquivo);

            if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(PathImagemLogoRelatorio)))
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(PathImagemLogoRelatorio));

            if (!System.IO.File.Exists(PathImagemLogoRelatorio))
            {
                Image img = new Bitmap(50, 50);
                img.Save(PathImagemLogoRelatorio, System.Drawing.Imaging.ImageFormat.Png);
            }

            CriarPadraoECompactarLog();
        }

        private static void CriarPadraoECompactarLog()
        {
            try
            {
                DateTime date = DateTime.Now;

                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    var files = Directory.GetFiles(ValPadrao.PastaLog).Where(x => x.ToLower().EndsWith("logerror.txt"));

                    if (files.Count() > 0)
                    {
                        List<string> ArqValidos = new List<string>();

                        string ini = "";
                        string fim = "";

                        foreach (var f in files)
                        {
                            string name = Path.GetFileName(f);
                            if (int.TryParse(name.Substring(0, 4), out int ano) && int.TryParse(name.Substring(5, 2), out int Mes) && int.TryParse(name.Substring(8, 2), out int dia))
                            {
                                if (new DateTime(ano, Mes, dia) < date.Date)
                                    ArqValidos.Add(f);
                            }
                        }

                        if (ArqValidos.Count == 0) return;
                        else
                        {
                            string nameIni = Path.GetFileName(ArqValidos[0]);
                            string nameFim = Path.GetFileName(ArqValidos[ArqValidos.Count - 1]);
                            ini = $"{nameIni.Substring(0, 4)}.{nameIni.Substring(5, 2)}.{nameIni.Substring(8, 2)}";
                            fim = $"{nameFim.Substring(0, 4)}.{nameFim.Substring(5, 2)}.{nameFim.Substring(8, 2)}";
                        }

                        string pastaRaizZip = $"Log_De_{ini}_Ate_{fim}";

                        string zipName = $"{ValPadrao.PastaLog}{pastaRaizZip}.zip";

                        using (ZipFile zip = new ZipFile(/*zipName*/))
                        {

                            foreach (var file in ArqValidos)
                                zip.AddFile(file.ToString(), pastaRaizZip);

                            zip.Save(zipName);

                            foreach (var file in ArqValidos)
                                File.Delete(file);
                        }
                    }
                }

                if (date.DayOfWeek == DayOfWeek.Tuesday)
                {
                    var files = Directory.GetFiles(ValPadrao.PastaLog).Where(x => x.ToLower().EndsWith(".zip") &&
                                Path.GetFileName(x).ToLower().StartsWith("log_de_"));

                    if (files.Count() > 0)
                    {
                        List<string> ArqValidos = new List<string>();

                        string zipName = "";

                        foreach (var f in files)
                        {
                            string[] spl = Path.GetFileName(f).Split('_');
                            string name = spl[spl.Count() - 1];

                            if (int.TryParse(name.Substring(0, 4), out int ano) && int.TryParse(name.Substring(5, 2), out int Mes))
                            {
                                if (Mes < date.Month || ano < date.Year)
                                    ArqValidos.Add(f);
                            }
                        }

                        if (ArqValidos.Count == 0) return;
                        else
                        {
                            string[] spl = Path.GetFileName(ArqValidos[ArqValidos.Count - 1]).Split('_');
                            string name = spl[spl.Count() - 1];
                            int ano = int.Parse(name.Substring(0, 4));
                            int mes = int.Parse(name.Substring(5, 2));

                            zipName = $"{PastaLog}LogsErro_Ano_{ano}_Mes_{mes.ToString("00")}_{new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(mes)/*.PrimeiraMaiuscula()*/}.zip";
                        }

                        using (ZipFile zip = new ZipFile(/*zipName*/))
                        {
                            foreach (var file in ArqValidos)
                                zip.AddFile(file.ToString(), "");

                            zip.Save(zipName);

                            foreach (var file in ArqValidos)
                                File.Delete(file);
                        }
                    }
                }

                if (date.DayOfWeek == DayOfWeek.Wednesday)
                {
                    var files = Directory.GetFiles(ValPadrao.PastaLog).Where(x => x.ToLower().EndsWith(".zip") &&
                                Path.GetFileName(x).ToLower().StartsWith("logserro_ano_"));
                    if (files.Count() > 0)
                    {
                        List<string> ArqValidos = new List<string>();

                        string zipName = "";

                        foreach (var f in files)
                        {
                            string[] spl = Path.GetFileName(f).Split('_');

                            if (spl.Count() > 4 && int.TryParse(spl[spl.Count() - 4], out int ano))
                            {
                                if (ano < date.Year)
                                    ArqValidos.Add(f);
                            }
                        }

                        if (ArqValidos.Count == 0) return;
                        else
                        {
                            string[] spl = Path.GetFileName(ArqValidos[ArqValidos.Count - 1]).Split('_');
                            int ano = int.Parse(spl[spl.Count() - 4]);

                            zipName = $"{ValPadrao.PastaLog}LogsErro_BackUp {ano}.zip";
                        }

                        using (ZipFile zip = new ZipFile(/*zipName*/))
                        {
                            foreach (var file in ArqValidos)
                                zip.AddFile(file.ToString(), "");

                            zip.Save(zipName);

                            foreach (var file in ArqValidos)
                                File.Delete(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
