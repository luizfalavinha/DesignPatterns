namespace DesignPatterns.Estrutural.Facade.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string key);
    }
}