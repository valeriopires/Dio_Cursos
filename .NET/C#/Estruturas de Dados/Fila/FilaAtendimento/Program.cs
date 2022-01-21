
namespace FilaAtendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            fila.GerarSenha();
            fila.GerarSenha();
            fila.GerarSenha();
            fila.GerarSenha();

            var espiar = fila.EspiarProximoDaFila();
            fila.ChamarProximo();

            espiar = fila.EspiarProximoDaFila();
            fila.ChamarProximo();

            fila.MostrarFila();

            fila.ReiniciarFila();
            espiar = fila.EspiarProximoDaFila();

            fila.MostrarFila();
        }
    }
}
