using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMControls.LmDesign
{
    public enum LmTheme
    {
        Padrao = 0,
        Azul = 1,
        Vermelho = 2,
        Lilas = 3,
        Verde = 4,
        Amarelo = 5,
        Laranja = 6,
        Marrom = 7,
        Cinza = 8,
        Preto = 9,
        Personalizado = 99,
    }

    public enum LmMessageType
    {
        [System.ComponentModel.Description("Centralizada")]
        Padrao = 0,
        [System.ComponentModel.Description("Próximo ao Relógio")]
        InTaskBar = 1,
        [System.ComponentModel.Description("Mostar no Controle")]
        InToolTip = 2
    }

    public enum LmValueType
    {
        Alfanumerico = 0,
        Num_Inteiro = 1,
        Num_Real = 2,
        Data = 3,
        Fone = 4,
        Monetario = 5,
        Email = 6,
        Cpf_Cnpj = 7,
        Hora = 8,
        ComboBox = 9,
        ComboBox_Enum = 10,
        Senha = 11,
    }

    public enum LmTransactionType 
    {
        Novo = 0,
        Alterar = 1,
        Excluir = 2,
        Login = 3,
        Diversos = 99,
    }

}
