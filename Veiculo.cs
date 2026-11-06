using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Veiculo
    {
        private double VelocidadeValor;

        public double Velocidade
        {
            get
            {
                return VelocidadeValor;
            }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    VelocidadeValor = value;
                }
            }
        }
    }
}