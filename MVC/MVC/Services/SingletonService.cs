namespace MVC.Services
{
    public interface ISingletonService :IService
    {}
    public class SingletonService : ISingletonService
    {
        private string _guid;
        public string GetGuid()
        {
           return _guid;
        }

        public SingletonService()
        {
            _guid = Guid.NewGuid().ToString();
        }
    }
}
