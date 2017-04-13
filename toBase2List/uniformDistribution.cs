using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace toBase2List
{
    class uniformDistribution
    {
        static int[] groupsValues = new int[10] {10000,20000,30000,40000,50000,60000,70000,80000,90000,100000};
        static int N = 50000;
        static double Pi = 1 / groupsValues.Length;

        public int[,] getUniformDistr(int nVarNum)
        {
            int[,] currentDigits = new int[4, 10]
            { 
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            for (int nFileCount = 0; nFileCount < 4; nFileCount++)
            {
                StreamReader srFile = new StreamReader(nVarNum + "\\Task1\\" + nFileCount);
                string sAnotherString;
                while (!srFile.EndOfStream)
                {
                    sAnotherString = srFile.ReadLine();
                    for (int i = 0; i < groupsValues.Length; i++)
                    {
                        
                        if (int.Parse(sAnotherString) <= groupsValues[i])
                        {
                            currentDigits[nFileCount, i]++;
                            break;
                        }
                    }
                }
                srFile.Close();
            }
            return currentDigits;
        }

        public void getXUniformDistr(int nVarNum) {
            int nResultSumm;
            int[,] currentDigits = getUniformDistr(nVarNum);

            for (int nFileCount = 0; nFileCount < 4; nFileCount++)
            {
                nResultSumm = 0;
                for (int iDigitsCount = 0; iDigitsCount < groupsValues.Length; iDigitsCount++)
                {
                    nResultSumm += 
                        (
                            (currentDigits[nFileCount, iDigitsCount] - N / 10) *
                            (currentDigits[nFileCount, iDigitsCount] - N / 10)
                        ) 
                        / 
                        (N / 10);
    
                    //хи квадрат = сумма i от 1 до m(mi-N * Pi)^ 2 / N * Pi   
                    //mi - массив групп.
                    //Pi = 1 / m
                    //N - колличество чисел.

                }
                Console.WriteLine(nFileCount + ": " + nResultSumm);
            }

        }
    }
}
