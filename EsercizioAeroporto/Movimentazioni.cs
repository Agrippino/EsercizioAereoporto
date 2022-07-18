using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAeroporto
{
    internal class Movimentazioni
    {
        private double CostoTotale { get; set; }
        public Movimentazioni()
        {

        }
        public double Acquista(double CostoBiglietto, int BigliettiDaAcquistare)
        {
            CostoTotale = CostoBiglietto * BigliettiDaAcquistare;
            return CostoTotale;
        }
    }
}
