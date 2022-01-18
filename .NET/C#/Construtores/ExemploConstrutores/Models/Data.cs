namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes; //Não permite modificação diretamente de fora da classe
        private bool mesValido;

        public int Mes 
        { 
            get
            {
                return this.mes;
            }

            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    mesValido = true;
                }
            }
        }

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                mesValido = true;
            }
        }

        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                switch (this.mes)
                {
                    case 1:
                      System.Console.WriteLine("Janeiro");                     
                    break;

                    case 2:
                      System.Console.WriteLine("Fevereiro");                     
                    break;

                    case 3:
                      System.Console.WriteLine("Março");                     
                    break;

                    case 4:
                      System.Console.WriteLine("Abril");                     
                    break;

                    case 5:
                      System.Console.WriteLine("Maio");                     
                    break;

                    case 6:
                      System.Console.WriteLine("Junho");                     
                    break;

                    case 7:
                      System.Console.WriteLine("Julho");                     
                    break;

                    case 8:
                      System.Console.WriteLine("Agosto");                     
                    break;

                    case 9:
                      System.Console.WriteLine("Setembro");                     
                    break;

                    case 10:
                      System.Console.WriteLine("Outubro");                     
                    break;

                    case 11:
                      System.Console.WriteLine("Novembro");                     
                    break;

                    case 12:
                      System.Console.WriteLine("Dezembro");                     
                    break;

                    default:
                       System.Console.WriteLine("Escolha um Mês válido");
                    break;
                }
            } else
            {
                System.Console.WriteLine("Mês inválido!");
            }
        }
    }
}