using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace toBase2List {
    class digitRand2 {
        public double[] iGetAnswer(int iVarNum) {
            double[] iReturn = new double[4] { 0.0, 0.0, 0.0, 0.0 };
            int[,] iArr = iCountDigits(iVarNum);
            double iInnerCounter = 0, Pi = 0.0;
            
            for (int i = 0; i < 4; i++) {
                Pi = 0.0000152587890625;
                for (int j = 0; j < 17; j++) {
                    if (j != 0) 
                    {
                        Pi = ((16 - j + 1) / j) * Pi;
                    }
                    iInnerCounter = (iArr[i, j] - 50000 * Pi) * (iArr[i, j] - 50000 * Pi) / 50000 * Pi;
                    iReturn[i] += iInnerCounter;

                    //хи квадрат = сумма i от 1 до m (mi- N * Pi)^2/N * Pi.   mi - массив групп.
                    //P0 = 1/2^16
                    //k = 16
                    //Pi = ((k - i + 1)/i)*P(i-1)
                    //N - колличество чисел.
                }
            }

            foreach (double i in iReturn) { Console.WriteLine(i); }
            return iReturn;
        }

        private int[,] iCountDigits(int iVarNum) {
            int[,] iArr = new int[4, 17] 
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            List<string> lBin = new List<string>();
            toBase2Tool tb2tObj = new toBase2Tool();

            for (int iFileCount = 0; iFileCount < 4; iFileCount++) {
                lBin = tb2tObj.getByteList(iVarNum + "\\Task1\\" + iFileCount);

                foreach (string sListCont in lBin) {
                    int iInnerCounter = 0;
                    foreach (char cInString in sListCont)
                    {
                        iInnerCounter++;
                        if (cInString == '1')
                        {
                            iArr[iFileCount, iInnerCounter]++;
                        }
                    }
                }
            }

            return iArr;
        }
    }
}
