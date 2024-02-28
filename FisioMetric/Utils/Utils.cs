using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FisioMetric.Utils
{
    public static class Utils
    {
        public static string FormatarTelefone(string telefone)
        {
            // Define a máscara de telefone usando expressão regular
            string padrao = @"(\d{2})(\d{4,5})(\d{4})"; // Formato padrão para números de telefone
            string mascara = "($1) $2-$3"; // Máscara desejada: (XX) XXXX-XXXX ou (XX) XXXXX-XXXX

            // Aplica a máscara usando a expressão regular
            string telefoneFormatado = Regex.Replace(telefone, padrao, mascara);

            return telefoneFormatado;
        }
    }
}
