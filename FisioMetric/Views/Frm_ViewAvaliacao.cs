using FisioMetric.Data;
using FisioMetric.Models;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisioMetric.Views
{
    public partial class Frm_ViewAvaliacao : KryptonForm
    {
        SqliteDbContext _dbContext = new SqliteDbContext();
        Avaliacao avaliacao = new();
        public Frm_ViewAvaliacao(int relatorioId)
        {
            InitializeComponent();

            avaliacao = _dbContext.Avaliacoes.FirstOrDefault(x => x.IdAvaliacao == relatorioId);
        }

        private void Frm_ViewRelatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
