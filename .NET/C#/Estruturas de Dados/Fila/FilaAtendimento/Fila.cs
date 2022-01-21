using System;
using System.Collections.Generic;

namespace FilaAtendimento
{
    public class Fila
    {
        private Queue<int> _filaDeAtendimento;
        private int _proximoDaFila = 1;

        public Fila()
        {
            _filaDeAtendimento = new Queue<int>();
        }

        public int GerarSenha()
        {
            _filaDeAtendimento.Enqueue(_proximoDaFila);
            Console.WriteLine("Senha Gerada com Sucesso!");
            return _proximoDaFila++;
        }

        public void ChamarProximo()
        {
            var proximoNumeroDaFila = _filaDeAtendimento.Dequeue();
            Console.WriteLine($"Chamando a Próxima Senha: {proximoNumeroDaFila}");
        }

        public void MostrarFila()
        {
            if(_filaDeAtendimento.Count > 0)
            {
                Console.Write("Próximas Senhas da Fila: ");

                foreach (var senha in _filaDeAtendimento)
                {
                    Console.Write(senha + " ");
                }
                Console.WriteLine();
            } 
            else 
            {
                System.Console.WriteLine("Não existem pessoas na fila!");
            }
            
        }

        public int EspiarProximoDaFila() 
        { 
            if(_filaDeAtendimento.TryPeek(out int primeiroDaFila))
            {
                return primeiroDaFila;
            }
            return 0;
        }

        public void ReiniciarFila()
        {
            _filaDeAtendimento.Clear();
        }

    }
}
