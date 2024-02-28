using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FisioMetric.Authentication
{
    public static class Auth
    {

        public static string AbreArquivo()
        {

            string arquivo = Directory.GetCurrentDirectory()+"\\auth.bin";

            // Chave de criptografia (deve ser a mesma usada para criptografar os dados)
            string chaveTexto = "FisioReports";

            // Converte a chave para um array de bytes
            byte[] chave = GerarChaveAES(chaveTexto);

            // Lê o conteúdo do arquivo e descriptografa
            string conteudoDescriptografado = DescriptografarConteudo(arquivo, chave);

            return conteudoDescriptografado;
        }

        private static byte[] GerarChaveAES(string chaveTexto)
        {
            // Converte a string de texto para um array de bytes usando a codificação UTF-8
            byte[] chaveBytes = Encoding.UTF8.GetBytes(chaveTexto);

            // Redimensiona a chave para o tamanho correto (256 bits = 32 bytes)
            Array.Resize(ref chaveBytes, 32);

            return chaveBytes;
        }

        private static string DescriptografarConteudo(string arquivo, byte[] chave)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = chave;
                aesAlg.IV = new byte[16]; // Use um IV (vetor de inicialização) aleatório para maior segurança

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (FileStream fs = new FileStream(arquivo, FileMode.Open))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Lê o conteúdo descriptografado do arquivo
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }        
    }
}

