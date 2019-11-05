using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1 {
    class Program {
        static void Main(string[] args) {
            //PyramideGenerator(5);

            //CalculateSum(123);

            FactorialN(5);
        }

        public static void PyramideGenerator(int n) {
            String star = "";
            for(int i = 0; i < n; i++) {
                star += "*";
            }

            String myTempStar = star;

            while(n != 0) {
                Console.WriteLine(myTempStar);
                myTempStar = star.Substring(0, myTempStar.Length - 1);
                n--;
            }
            Console.ReadKey();
      
        }

        public static void CalculateSum(int a) {
            int sum = 0;
            while(a != 0) {
                sum += a % 10;
                a /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static void FactorialN(int a){
            int total = 1;

            while(a != 0) {
                total *= a--;
              
            }
            Console.WriteLine(total);
            Console.ReadKey();
        
        }
    }
}
