using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23HomeWork
{
   

    public class AtomicCalculator
    {
        public int X { get;private set; }
        public int Y { get; private set; }
  public Action MenuPrinter { get; set; }
        
       public Func<int> GetNumberFromUser { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, int> Calaculate { get; set; }
        public Action<double> ResultPrinter { get; set; }
        public void Run()
        {
            X = GetNumberFromUser();
            Y = GetNumberFromUser();
            MenuPrinter();
            int z = GetUserChoice();
           int result= Calaculate(X, Y, z);
            ResultPrinter(result);


        }





    }
}
