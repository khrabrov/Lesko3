using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace toBase2List {
    /// <summary>
    /// перевод в 2 вид - выплевывает все в лист
    /// </summary>
    class toBase2Tool {
        public List<string> getByteList(string sFilePath)
        {
            List<string> lOutput = new List<string>();
            StreamReader srFile = new StreamReader(sFilePath);
            int iTemp;
            while (!srFile.EndOfStream) 
            {
                iTemp = int.Parse(srFile.ReadLine());
                lOutput.Add(Convert.ToString(iTemp,2));
            }
            srFile.Close();
            return lOutput;
        }
    }
}
