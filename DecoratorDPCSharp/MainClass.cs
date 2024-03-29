using DecoratorDPCSharp.BaseComponents.ConcreteComponent;
using DecoratorDPCSharp.BaseComponents.IComponent;
using DecoratorDPCSharp.DecoratorClasses.ColorDecorator;
using DecoratorDPCSharp.DecoratorClasses.PlainDecorator;
using DecoratorDPCSharp.DecoratorClasses.UpperCaseDecorator;

namespace DecoratorDPCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            IComponent<string> concreteComponent = new ConcreteComponent();
            IComponent<string> plainDecorator = new PlainDecorator(concreteComponent);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(concreteComponent);
            IComponent<string> colorDecorator = new ColorDecorator(concreteComponent);
            
            Console.WriteLine("ConcreteComponent: " + concreteComponent.GetText());
            Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());
            Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());
        }
    }
}
