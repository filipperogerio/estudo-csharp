using System;

namespace FR.DependencyInjection.CasesDI
{
    public class LifeCycleService
    {
        public LifeCycleService(ILifeCycleTransient transient,
            ILifeCycleScoped scoped,
            ILifeCycleSingleton singleton,
            ILifeCycleSingletonInstance singletonInstance)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }

        public ILifeCycleTransient Transient { get; set; }
        public ILifeCycleScoped Scoped { get; set; }
        public ILifeCycleSingleton Singleton { get; set; }
        public ILifeCycleSingletonInstance SingletonInstance { get; set; }
    }


    public class LifeCycle : ILifeCycleTransient,
        ILifeCycleScoped,
        ILifeCycleSingleton,
        ILifeCycleSingletonInstance
    {
        public LifeCycle() : this(Guid.NewGuid()) { }

        public LifeCycle(Guid lifeCycleId)
        {
            LifeCycleId = lifeCycleId;
        }

        public Guid LifeCycleId { get; }
    }

    public interface ILifeCycle
    {
        Guid LifeCycleId { get; }
    }

    public interface ILifeCycleTransient : ILifeCycle { }
    public interface ILifeCycleScoped : ILifeCycle { }
    public interface ILifeCycleSingleton : ILifeCycle { }
    public interface ILifeCycleSingletonInstance : ILifeCycle { }
}
