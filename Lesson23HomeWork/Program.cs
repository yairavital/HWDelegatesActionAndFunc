using System;

namespace Lesson23HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
             SimpleCalculator simpleCalculator = new SimpleCalculator();
            AtomicCalculator atomicCalculator = new AtomicCalculator();
            atomicCalculator.GetUserChoice = simpleCalculator.GetUserChoice;
            atomicCalculator.GetNumberFromUser = simpleCalculator.NumberGetter;
            atomicCalculator.MenuPrinter = simpleCalculator.PrintMenu;
            atomicCalculator.Calaculate = simpleCalculator.Calculate;
            atomicCalculator.ResultPrinter = simpleCalculator.PrintResultNicely;
            atomicCalculator.Run();
            #region ChellenageWithLambada
            atomicCalculator.ResultPrinter = (num) => Console.WriteLine($"****{num}****");
           
            #endregion

        }
    }
}
