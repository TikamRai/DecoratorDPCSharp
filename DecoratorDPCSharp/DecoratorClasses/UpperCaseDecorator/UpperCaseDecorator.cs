using DecoratorDPCSharp.BaseComponents.IComponent;
using DecoratorDPCSharp.DecoratorClasses.Decorator;

namespace DecoratorDPCSharp.DecoratorClasses.UpperCaseDecorator
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return base.GetText().ToUpper();
        }
    }
}
