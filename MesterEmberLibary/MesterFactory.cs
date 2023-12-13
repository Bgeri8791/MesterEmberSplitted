using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesterEmberLibary
{
    public class MesterFactory
    {
        public static MesterEmber? Factory(string adatsor)
        {
            var splitted = adatsor.Split(';');
            return splitted[0] switch
            {
                "b" =>
                        splitted[3] == "" ? null:
                        new Burkolo(splitted[1], int.Parse(splitted[2]), Enum.Parse<Burkolo.Tipus>(splitted[3])),
                "v" => new VizvezetekSzerelo(splitted[1], int.Parse(splitted[2])),
                _ => null
            };
        }
    }
}
