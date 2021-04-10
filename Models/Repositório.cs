using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone2.Models
{
    public class Repositório
    {
        private static List<Banda> bandas = new List<Banda>();

        public static List<Banda> Bandas
        {
            get
            {
                List<Banda> cloneBandas = new List<Banda>(bandas);
                return cloneBandas;
            }
        }

        public static void AddBanda(Banda novaBanda)
        {
            bandas.Add(novaBanda);
        }
    }
}
