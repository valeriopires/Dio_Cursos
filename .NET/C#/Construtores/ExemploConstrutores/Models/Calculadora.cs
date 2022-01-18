namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();
        
        //Evento
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int num1, int num2)
        {
            if(EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {num1 + num2}");
                EventoCalculadora();
            }
            else 
            {
                System.Console.WriteLine("Nenhum inscrito!");
            }
        }

        public static void Subtrair(int num1, int num2)
        {
            System.Console.WriteLine($"Subtração: {num1  - num2}");
        }
    }
}