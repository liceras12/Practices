using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class Delegate
    {
        public delegate void Callback(string msg);
        public void Main()
        {
            Callback del = MethodA;
            del.Invoke("Message that needs to be printed");
            del("Message that needs to be printed");

            DelegateAsParameter(MethodA);
            DelegateAsParameter(del);
        }
        public void DelegateAsParameter(Callback callback)
        {
            callback("From another method");
        }   

        public void MethodA(string anotherThing)
        {
            Console.WriteLine($"Printing the message: {anotherThing}");
        }


            
    }
}
