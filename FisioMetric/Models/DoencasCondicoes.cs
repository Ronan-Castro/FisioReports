using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioMetric.Models
{
    public class DoencasCondicoes
    {
        public bool Metabolica { get; set; } = true;
        public bool Cardiaca { get; set; } = true;
        public bool Respiratorias { get; set; } = true;
        public bool Vasculares { get; set; } = true;
        public bool Neurologicas { get; set; } = true;
        public bool Endocrina { get; set; } = true;
        public bool Dermatologica { get; set; } = true;
        public bool GastroIntestinal { get; set; } = true;
        public bool Visual { get; set; } = true;
        public bool Covid { get; set; } = true;
        public bool Diabete { get; set; } = true;
        public bool Hipertensao { get; set; } = true;
        public bool Cardiopatia { get; set; } = true;
        public bool Neoplasias { get; set; } = true;
        public bool DoencasHereditarias { get; set; } = true;
        public bool Gestacao { get; set; } = true;
        public bool Cirurgias { get; set; } = true;
    }
}
