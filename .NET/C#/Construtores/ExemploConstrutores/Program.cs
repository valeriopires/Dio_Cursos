using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            //Construtores
            //Pessoa p1 = new Pessoa("Valério", "Pires");
            //p1.Apresentar();

            //Construtores privado
            // Log log = new Log(); //CONSTRUTOR NÂO PERMITIDO

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            //Métodos Getters e Setters / Propriedades GET e SET
            // Aluno a1 = new Aluno("Valério", "Pires", "Informática");
            // a1.Apresentar();

            //Data data = new Data();
            // data.SetMes(2);

            // data.Mes = 10;
            // data.ApresentarMes();
            
            //Trabalhando com Delegates / Multi Cast Delegate
            // Operacao op = Calculadora.Somar;
            // op.Invoke(10,10);

            // Operacao op = new Operacao(Calculadora.Somar);

            // op += Calculadora.Somar;
            // op.Invoke(10, 10);
            // op(10, 10);

            Matematica mat = new Matematica(10, 20);
            mat.Somar();

  

        }
    }
}
