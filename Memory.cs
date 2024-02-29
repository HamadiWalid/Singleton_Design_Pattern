using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public sealed class Memory //Restrict inheritance
    {
        private static Memory _instance;
        public int Id { get; private set; }

        private static readonly object _lock = new();
        private Memory(){}

        public static Memory Instance(int id)
        {
            if(_instance == null )
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new Memory();
                        _instance.Id = id;  
                    }
                }
            }//We use lock to create un single instance if we have multiple thread so if we have thread 1 and thread 2 thread 2 will wait until first thread is done 
            return _instance;   
        }
    }
}
