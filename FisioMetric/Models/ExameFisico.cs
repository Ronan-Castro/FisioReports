﻿namespace FisioMetric.Models
{
    public class ExameFisico
    {
        public bool Equilibrio { get; set; }
        public bool FroxidaoLigamentar { get; set; }
        public bool EstabilidadeEscapular { get; set; }
        public bool MobilidadeColuna { get; set; }
        public PadraoMovimento PadraoMovimento { get; set; } = new();
        public Cabeca Cabeca { get; set; } = new();
        public Cervical Cervical { get; set; } = new();
        public Ombros Ombros { get; set; } = new();
        public Coluna Coluna { get; set; } = new();
        public Pelve Pelve { get; set; } = new();
        public Joelhos Joelhos { get; set; } = new();
        public Pes Pes { get; set; } = new();
    }


}