namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log;

        public string PropriedadeLog { get; set; }

        //Construtor Pivate evita instanciação da sua classe através do 'new'
        private Log()
        {
            
        }

        public static Log GetInstance()
        {
            if(_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }
}