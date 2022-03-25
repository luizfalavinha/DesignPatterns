namespace DesignPatterns.Estrutural.Facade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string key)
        {
            return "KEY-" + key;
        }
    }
}