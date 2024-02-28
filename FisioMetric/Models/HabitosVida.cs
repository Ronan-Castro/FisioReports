namespace FisioMetric.Models
{
    public class HabitosVida
    {
        public bool Tabagismo { get; set; } = true;
        public bool Etilismo { get; set; } = true;
        public bool IngereAgua { get; set; } = true;
        public bool Medicacao { get; set; } = true;
        public bool Intestino { get; set; } = true;
        public bool AtivFisica { get; set; } = true;
        public bool Pilates { get; set; } = true;
        public string? ObsHabitos { get; set; }
    }
}