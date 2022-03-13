﻿namespace MVC.Services
{
     public interface IScopedService :IService
    {
    }

    public class ScopedService : IScopedService
    {
        private string _guid;
        public string GetGuid()
        {
            return _guid;
        }

        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();  
        }
    }
}
