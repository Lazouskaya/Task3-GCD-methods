using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDMethods
{   
    public static class Nod
    {
        private static int EvclideanNod(int greater, int less)
        {
            while (less != 0)
                less = greater % (greater = less);
            return greater;
        }
        
        public static int Evclidean(int firstNum, int secondNum, out TimeSpan executionTime)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int nod = EvclideanNod(firstNum,secondNum);
            executionTime = stopWatch.Elapsed;
            return nod;
        }
        public static int Evclidean( out TimeSpan executionTime, params int[] numbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int number;
            int nod = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                number = numbers[i];
                nod = EvclideanNod(number, nod);
            }
            executionTime = stopWatch.Elapsed;
            return nod;
        }

        private static int StainNod(int firstNum, int secondNum)
        {
            //НОД(0, n) = n; НОД(m, 0) = m.
            if (firstNum == 0 || secondNum == 0)
            { return firstNum | secondNum; }
            //НОД(m, m) = m;
            else if (firstNum == secondNum)
            { return firstNum; }
            //НОД(1, n) = 1; НОД(m, 1) = 1;
            else if (firstNum == 1 && secondNum == 1)
            { return 1; }
            //Если m, n чётные, то НОД(m, n) = 2*НОД(m/2, n/2);
            else if (firstNum % 2 == 0 && secondNum % 2 == 0)
            { return 2 * EvclideanNod(firstNum / 2, secondNum / 2); }
            //Если m чётное, n нечётное, то НОД(m, n) = НОД(m/2, n);
            else if (firstNum % 2 == 0 && secondNum % 2 != 0)
            { return EvclideanNod(firstNum / 2, secondNum); }
            //Если n чётное, m нечётное, то НОД(m, n) = НОД(m, n/2);
            else if (firstNum % 2 != 0 && secondNum % 2 == 0)
            {
                return EvclideanNod(firstNum, secondNum / 2);
            }
            //Если m, n нечётные и n < m, то НОД(m, n) = НОД((m-n)/2, n);
            else
            {
                return EvclideanNod(firstNum - secondNum / 2, secondNum);
            }
        }

        public static int Stain(int firstNum, int secondNum, out TimeSpan executionTime)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int nod = StainNod(firstNum, secondNum);
            executionTime = stopWatch.Elapsed;
            return nod;
        }

        public static int Stain(out TimeSpan executionTime, params int[] numbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int number;
            int nod = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                number = numbers[i];
                nod = StainNod(number, nod);
            }
            executionTime = stopWatch.Elapsed;
            return nod;
        }
    }
}
