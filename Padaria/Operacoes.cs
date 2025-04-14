using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    public class Operacoes
    {
        public double SomaValor(double v1,double v2)
        {
            return (v1 + v2);
        }
        public double subtracaoValor(double v1, double v2)
        {
            return (v1 - v2);
        }
        public double multiplicacaoValor(double v1, double v2)
        {
            return (v1 * v2);
        }
        public double divisaoValor(double v1, double v2)
        {
            if (v2 == 0)
            {
                return 0;
            }
            else 
            {
                return (v1 / v2);
            }

        }
    }
}
