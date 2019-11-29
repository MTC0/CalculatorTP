using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine
    {
        /// <summary>
        /// Fonction to Addition two values.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="nbSecond"></param>
        /// <returns></returns>
        public virtual int Addition(int nbPremier, int nbSecond)
        {
            return nbPremier + nbSecond;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="nbSecond"></param>
        /// <returns></returns>
        public virtual int Soustraire(int nbPremier, int nbSecond)
        {
            return nbPremier - nbSecond;
        }
        public virtual int Multiplier(int nbPremier, int nbSecond)
        {
            return nbPremier * nbSecond;
        }
        public virtual int Division(int nbPremier, int nbSecond)
        {
            int res;

            if(nbSecond > 0)
            {
                res = nbPremier / nbSecond;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }
    }
}
