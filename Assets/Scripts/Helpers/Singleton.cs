using System;

namespace BallJumper
{
    public class Singleton<T> where T : class
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = Activator.CreateInstance(typeof(T)) as T;
                }

                return _instance;
            }
        }
    }
}
