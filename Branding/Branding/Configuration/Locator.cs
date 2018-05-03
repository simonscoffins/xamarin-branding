using System;
using SimpleInjector;

namespace Branding.Configuration {
    public class Locator {

        private readonly Container _container;

        static Locator() {
            Instance = new Locator();
        }

        public Locator() : this(new Container()) {}

        public Locator(Container container) {
            _container = container;
        }

        public static Locator Instance { get; }

        public static void Register() {
            
        }

        public T Resolve<T>() where T : class{
            return _container.GetInstance<T>();
        } 

        public object Resolve(Type type) {
            return _container.GetInstance(type);
        }

        public static void Bootstrap() {
            CompositionRoot.Register(Instance._container);
        }

        //public void Register<TInterface, TImplementation>() where TImplementation : TInterface {
        //    _containerBuilder.RegisterType<TImplementation>().As<TInterface>();
        //}

        //public void Register<T>() where T : class {
        //    _containerBuilder.RegisterType<T>();
        //}

        //public void Build() {
        //    _container = _containerBuilder.Build();
        //}


    }
}