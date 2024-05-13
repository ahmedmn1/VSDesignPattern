
namespace FactoryMethod.Solution
{
    public interface IMatchaViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}