namespace FR.DependencyInjection.CasesDI
{
    public interface IFly
    {
        string Fly();
    }

    public class Bird : IFly
    {
        public string Fly()
        {
            return "Bird is flying";
        }
    }

    public class Airplane : IFly
    {
        public string Fly()
        {
            return "Airplane is flying";
        }
    }

    public class IronMan : IFly
    {
        public string Fly()
        {
            return "Iron Man is flying";
        }
    }
}