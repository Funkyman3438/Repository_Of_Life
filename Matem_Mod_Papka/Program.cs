using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            PotentialMethod p = new PotentialMethod("Potenc.csv"); //Транспорт задача 16
            p.MainSolution();
            //JohnsonMethod j = new JohnsonMethod("Jhon.csv", "BratJhon.csv"); //Задача 1
            //j.Calculate();
            //var pf = new PathFinder("Zadacha17.csv", "CritPut.txt"); //задача 17
            //pf.CalculateCriticalPath();
            //Сommivoyageur commivoyageur = new Сommivoyageur("Jora.csv", "BratJora.txt");
            //commivoyageur.Calculate(); //Задача 14
        }
    }
}
