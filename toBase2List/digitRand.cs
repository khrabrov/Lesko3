using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace toBase2List {
    class digitRand {
        public int[] iGetAnswer(int iVarNum) 
        {
            int[] iReturn = new int[4] { 0, 0, 0, 0 };
            int[,] iArr = iCountDigits(iVarNum);
            int iInnerCounter = 0;

            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 16; j++) 
                {
                    iInnerCounter = (iArr[i, j] - 50000 / 2) * (iArr[i, j] - 50000 / 2) / 25000;
                    iReturn[i] += iInnerCounter;

                    //хи квадрат = сумма i от 1 до m (mi- N * Pi)^2/N * Pi.   mi - массив групп.
                    //Pi = 1/2(0,5)

                    //N - колличество чисел.

                }
            }

            foreach (int i in iReturn) { Console.WriteLine(i); }
            return iReturn;
        }

        private int[,] iCountDigits(int iVarNum)
        {
            int[,] iArr = new int[4, 16] 
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            List<string> lBin = new List<string>();
            toBase2Tool tb2tObj = new toBase2Tool();

            for (int iFileCount = 0; iFileCount < 4; iFileCount++)
            {
                lBin = tb2tObj.getByteList(iVarNum + "\\Task1\\" + iFileCount);

                foreach (string sListCont in lBin)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        if (sListCont.Length > i && sListCont[i] == '1') 
                        {
                            iArr[iFileCount, i]++;
                        }
                    }
                }
            }

            return iArr;
        }
    }
}
