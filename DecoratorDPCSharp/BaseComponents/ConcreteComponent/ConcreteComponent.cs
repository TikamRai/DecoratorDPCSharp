using DecoratorDPCSharp.BaseComponents.IComponent;

namespace DecoratorDPCSharp.BaseComponents.ConcreteComponent
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Implementation of Decorator Design Pattern Successful.";
        }
    }
}
