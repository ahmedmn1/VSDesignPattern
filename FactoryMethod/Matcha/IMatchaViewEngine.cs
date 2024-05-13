
namespace FactoryMethod.Matcha
{
    public interface IMatchaViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}