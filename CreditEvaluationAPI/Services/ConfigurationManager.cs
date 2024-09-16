namespace CreditEvaluationAPI.Services
{
    public class ConfigurationManager
    {
        private static ConfigurationManager? _instance;
        private static readonly object _lock = new object();

        public static ConfigurationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ConfigurationManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public string GetConfiguration(string key)
        {
            // Lógica para buscar as configurações
            return "Configuração";
        }
    }

}
