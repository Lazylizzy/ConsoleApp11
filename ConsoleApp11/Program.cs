using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{  
    struct UserInfo
    {
        public double k;
        public double b;
        public double x;

        public UserInfo(double k, double b, double x)
        {
            this.k = k;
            this.b = b;
            this.x = (0-b)/k;
        }

        public void Root()
        {
            Console.WriteLine("коэф.k= {0}, коэф.b= {1}, x= {2}", k, b,x);
        }
    }

    class Program
    {
        static void Main()
        {
            

            UserInfo result = new UserInfo(2,8,0);

            Console.Write(" ");
            result.Root();            
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
