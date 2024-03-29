using DecoratorDPCSharp.BaseComponents.IComponent;

namespace DecoratorDPCSharp.DecoratorClasses.Decorator
{
    public abstract class Decorator<T> : IComponent<T>
    {
        protected IComponent<T> _component;

        protected Decorator(IComponent<T> component)
        {
            _component = component;
        }

        public virtual T GetText()
        {
            return _component.GetText();
        }
    }
}