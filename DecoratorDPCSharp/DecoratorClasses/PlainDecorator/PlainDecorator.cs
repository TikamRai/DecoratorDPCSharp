using DecoratorDPCSharp.BaseComponents.IComponent;
using DecoratorDPCSharp.DecoratorClasses.Decorator;

namespace DecoratorDPCSharp.DecoratorClasses.PlainDecorator
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return "Yay!" + base.GetText();
        }
    }
}
