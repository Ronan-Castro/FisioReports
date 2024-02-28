using FisioMetric.Authentication;
using FisioMetric.Data;
using FisioMetric.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Text;

namespace FisioMetric
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            string usuario = "";
            List<string> chavesAceitas = new List<string> {
                "4b7d032995651f069c9b805ac80c7be2b6b54db18bc0a452cd0ef1d064c7653b",
                "44ccdd754d38a2a3e7d64bda18047d84cab40f3043c95d73fc3413f7e05fea65"
            };

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            await using var dbContext = new SqliteDbContext();
            //await dbContext.Database.EnsureCreatedAsync();
            dbContext.Database.Migrate();

            try
            {
                usuario = Auth.AbreArquivo();
            }
            catch
            {
                MessageBox.Show("Não foi possível encontrar sua chave de autenticação");
            }
            var verificacao = CalcularHashSHA256(usuario, "FisioReports");

            if (chavesAceitas.Contains(verificacao))
            {
                Application.Run(new Frm_Main());
            }
            else
            {
                MessageBox.Show("Você não tem autorização para utilizar o programa");
            }
        }


        static string CalcularHashSHA256(string texto, string chave)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(chave)))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = hmac.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }
    }
}