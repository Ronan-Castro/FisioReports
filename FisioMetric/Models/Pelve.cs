namespace FisioMetric.Models
{
    public class Pelve
    {
        public bool IsNormal { get; set; } = false;
        public bool IsAnteversao { get; set; } = false;
        public bool IsRetroversao { get; set; } = false;
        public bool IsElevadoDireita { get; set; } = false;
        public bool IsElevadoEsquerda { get; set; } = false;
        public bool IsEscoliose { get; set; } = false;
    }
}