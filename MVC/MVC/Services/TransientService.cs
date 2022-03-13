namespace MVC.Services
{
    public interface ITransientService: IService { }
    public class TransientService : ITransientService       
    {
        private string _guid;

        public string Guid1
        {
            get { return _guid; }
            set { _guid = value; }
        }
        public string GetGuid()
        {
            return _guid;
        }
        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }
    }
}
