using System;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double _comprimento;
        private double _largura;
        private bool _valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                this._comprimento = comprimento;
                this._largura = largura;    
                _valido = true;
            } else 
            {
                Console.WriteLine("Valores inválidos!");
            }    
        }
        public double ObterArea()
        {
            if(_valido)
            {
                return _comprimento * _largura;
            }
            else 
            {
                System.Console.WriteLine("Preencha valores válidos!");
                return 0;
            }
        }
    }
}