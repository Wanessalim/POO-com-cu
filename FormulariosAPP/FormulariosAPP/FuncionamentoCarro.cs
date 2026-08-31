using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulariosAPP
{
    internal class FuncionamentoCarro
    {
        public string Modelo { set; get; }
        public double ConsumoPorKm { set; get; }
        public double NivelCombustivel { set; get; }
        public double DistanciaPercorrida { set; get; }

        public FuncionamentoCarro(string modelo, double consumoPorKm, double nivelCombustivel, double distanciaPercorrida)
        {
            this.Modelo = modelo;
            this.ConsumoPorKm = consumoPorKm;
            this.NivelCombustivel = nivelCombustivel;
            this.DistanciaPercorrida = distanciaPercorrida;

        }

        public void Abastecer(double Litros)
        {
            this.NivelCombustivel += Litros;
        }

        public bool Andar(double Distancia)
        {
            bool Resposta;
            double Autonomia = CalcularAutonomia();
            if(Distancia <= Autonomia)
            {
                Resposta = true;
                this.DistanciaPercorrida += Distancia;
                this.NivelCombustivel -= Distancia / this.ConsumoPorKm;
            }
            else
            {
                Resposta = false;
            }
                return Resposta;
        }

        public double CalcularAutonomia()
        {
            double DistanciaPossivel;
            DistanciaPossivel = this.NivelCombustivel * this.ConsumoPorKm;
            return DistanciaPossivel;
        }

        public double ConsultaCombustivel()
        {
            return this.NivelCombustivel;
        }

    }
}
