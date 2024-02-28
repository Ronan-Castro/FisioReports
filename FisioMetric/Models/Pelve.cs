namespace FisioMetric.Models
{
    public class Pelve
    {
        public bool IsNormal { get; set; } = true;
        public bool IsAnteversao { get; set; } = true;
        public bool IsRetroversao { get; set; } = true;
        public bool IsElevadoDireita { get; set; } = true;
        public bool IsElevadoEsquerda { get; set; } = true;
        public bool IsEscoliose { get; set; } = true;
    }
}