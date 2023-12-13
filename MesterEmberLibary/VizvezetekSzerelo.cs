using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesterEmberLibary
{
    public class VizvezetekSzerelo : MesterEmber
    {
        public int Tapasztalat { get; }
        public VizvezetekSzerelo(string nev, int tapasztalat) : base(nev, tapasztalat * 6000)
        {
            this.Tapasztalat = tapasztalat;
        }

        public override string ToString()
        {
            return base.ToString() + $" {Tapasztalat} ev tapasztalattal";
        }

        public override bool MunkaVallal(int nap)
        {
            if (nap < 2 || nap >= 31)
            {
                throw new ArgumentOutOfRangeException(nameof(nap), $"2 és 30 között kell lennie.");
            }
            if (!this[nap-1] && !this[nap] && !this[nap + 1])
            {
                return false;
            }
            Lefoglal(nap-1);
            Lefoglal(nap);
            Lefoglal(nap+1);
            return true;
        }
        public override IEnumerable<int> FoglalhatoNapok()
        {
            return Enumerable
                .Range(2, 29)
                .Where(x => this[x - 1] && this[x] && this[x + 1]);
        }
    }
}
