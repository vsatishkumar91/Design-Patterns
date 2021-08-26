using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public sealed class SigletonClass
    {
        private static Lazy<SigletonClass> sigletonClass = new Lazy<SigletonClass>(() => new SigletonClass());
        private SigletonClass()
        {
        }

        public static SigletonClass getInstance
        {
            get
            {
                return sigletonClass.Value;
            }
        }

        public void showMessage(string message)
        {
            Console.WriteLine($"message is - {message}");
        }


    }

}
