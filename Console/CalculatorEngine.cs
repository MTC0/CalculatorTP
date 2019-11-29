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
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int Addition(int a, int b)
        {
            return a+b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int soustraire(int a, int b)
        {
            return a-b;
        }
        public virtual int Multiplier(int a, int b)
        {
            return a*b;
        }
        public virtual int Division(int a, int b)
        {
            int res;

            if(b > 0)
            {
                res = a / b;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }
    }
}
