using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPK
{
    class Fuzzy
    {
        public static void ConvertFuzzy() {

            

            //Convert Number Progdas to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[0] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[0] = 3;
                GlobalVariablesClass.FuzzyRPL[0] = 4;
                GlobalVariablesClass.FuzzyRSK[0] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[0] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[0] = 2;
                GlobalVariablesClass.FuzzyRPL[0] = 3;
                GlobalVariablesClass.FuzzyRSK[0] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[0] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[0] = 2;
                GlobalVariablesClass.FuzzyRPL[0] = 2;
                GlobalVariablesClass.FuzzyRSK[0] = 2;
            }

            //Convert Number PTI to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[1] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[1] = 4;
                GlobalVariablesClass.FuzzyRPL[1] = 1;
                GlobalVariablesClass.FuzzyRSK[1] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[1] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[1] = 3;
                GlobalVariablesClass.FuzzyRPL[1] = 1;
                GlobalVariablesClass.FuzzyRSK[1] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[1] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[1] = 3;
                GlobalVariablesClass.FuzzyRPL[1] = 1;
                GlobalVariablesClass.FuzzyRSK[1] = 1;
            }

            //Convert Number ASD to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[2] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[2] = 4;
                GlobalVariablesClass.FuzzyRPL[2] = 2;
                GlobalVariablesClass.FuzzyRSK[2] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[2] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[2] = 3;
                GlobalVariablesClass.FuzzyRPL[2] = 2;
                GlobalVariablesClass.FuzzyRSK[2] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[2] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[2] = 3;
                GlobalVariablesClass.FuzzyRPL[2] = 2;
                GlobalVariablesClass.FuzzyRSK[2] = 1;
            }

            //Convert Number Probstat to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[3] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[3] = 4;
                GlobalVariablesClass.FuzzyRPL[3] = 1;
                GlobalVariablesClass.FuzzyRSK[3] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[3] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[3] = 3;
                GlobalVariablesClass.FuzzyRPL[3] = 1;
                GlobalVariablesClass.FuzzyRSK[3] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[3] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[3] = 3;
                GlobalVariablesClass.FuzzyRPL[3] = 1;
                GlobalVariablesClass.FuzzyRSK[3] = 1;
            }

            //Convert Number PBO to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[4] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[4] = 3;
                GlobalVariablesClass.FuzzyRPL[4] = 4;
                GlobalVariablesClass.FuzzyRSK[4] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[4] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[4] = 3;
                GlobalVariablesClass.FuzzyRPL[4] = 3;
                GlobalVariablesClass.FuzzyRSK[4] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[4] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[4] = 1;
                GlobalVariablesClass.FuzzyRPL[4] = 2;
                GlobalVariablesClass.FuzzyRSK[4] = 2;
            }
            //Convert Number Arsikom to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[5] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[5] = 1;
                GlobalVariablesClass.FuzzyRPL[5] = 1;
                GlobalVariablesClass.FuzzyRSK[5] = 4;
            }
            else if (GlobalVariablesClass.NilaiNumber[5] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[5] = 1;
                GlobalVariablesClass.FuzzyRPL[5] = 1;
                GlobalVariablesClass.FuzzyRSK[5] = 3;
            }
            else if (GlobalVariablesClass.NilaiNumber[5] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[5] = 1;
                GlobalVariablesClass.FuzzyRPL[5] = 1;
                GlobalVariablesClass.FuzzyRSK[5] = 3;
            }

            //Convert Number Modsim to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[6] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[6] = 2;
                GlobalVariablesClass.FuzzyRPL[6] = 1;
                GlobalVariablesClass.FuzzyRSK[6] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[6] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[6] = 2;
                GlobalVariablesClass.FuzzyRPL[6] = 1;
                GlobalVariablesClass.FuzzyRSK[6] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[6] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[6] = 2;
                GlobalVariablesClass.FuzzyRPL[6] = 1;
                GlobalVariablesClass.FuzzyRSK[6] = 1;
            }

            //Convert Number Jarkomdat to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[7] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[7] = 2;
                GlobalVariablesClass.FuzzyRPL[7] = 1;
                GlobalVariablesClass.FuzzyRSK[7] = 4;
            }
            else if (GlobalVariablesClass.NilaiNumber[7] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[7] = 1;
                GlobalVariablesClass.FuzzyRPL[7] = 1;
                GlobalVariablesClass.FuzzyRSK[7] = 3;
            }
            else if (GlobalVariablesClass.NilaiNumber[7] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[7] = 1;
                GlobalVariablesClass.FuzzyRPL[7] = 1;
                GlobalVariablesClass.FuzzyRSK[7] = 3;
            }

            //Convert Number Sismik to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[8] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[8] = 1;
                GlobalVariablesClass.FuzzyRPL[8] = 1;
                GlobalVariablesClass.FuzzyRSK[8] = 4;
            }
            else if (GlobalVariablesClass.NilaiNumber[8] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[8] = 1;
                GlobalVariablesClass.FuzzyRPL[8] = 1;
                GlobalVariablesClass.FuzzyRSK[8] = 3;
            }
            else if (GlobalVariablesClass.NilaiNumber[8] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[8] = 1;
                GlobalVariablesClass.FuzzyRPL[8] = 1;
                GlobalVariablesClass.FuzzyRSK[8] = 3;
            }

            //Convert Basdat Basdat to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[9] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[9] = 4;
                GlobalVariablesClass.FuzzyRPL[9] = 2;
                GlobalVariablesClass.FuzzyRSK[9] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[9] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[9] = 3;
                GlobalVariablesClass.FuzzyRPL[9] = 2;
                GlobalVariablesClass.FuzzyRSK[9] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[9] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[9] = 3;
                GlobalVariablesClass.FuzzyRPL[9] = 1;
                GlobalVariablesClass.FuzzyRSK[9] = 1;
            }

            //Convert Number Sisop to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[10] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[10] = 4;
                GlobalVariablesClass.FuzzyRPL[10] = 1;
                GlobalVariablesClass.FuzzyRSK[10] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[10] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[10] = 3;
                GlobalVariablesClass.FuzzyRPL[10] = 1;
                GlobalVariablesClass.FuzzyRSK[10] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[10] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[10] = 3;
                GlobalVariablesClass.FuzzyRPL[10] = 1;
                GlobalVariablesClass.FuzzyRSK[10] = 1;
            }

            //Convert Number TVG to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[11] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[11] = 1;
                GlobalVariablesClass.FuzzyRPL[11] = 2;
                GlobalVariablesClass.FuzzyRSK[11] = 3;
            }
            else if (GlobalVariablesClass.NilaiNumber[11] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[11] = 1;
                GlobalVariablesClass.FuzzyRPL[11] = 2;
                GlobalVariablesClass.FuzzyRSK[11] = 3;
            }
            else if (GlobalVariablesClass.NilaiNumber[11] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[11] = 1;
                GlobalVariablesClass.FuzzyRPL[11] = 1;
                GlobalVariablesClass.FuzzyRSK[11] = 3;
            }

            //Convert Number Tekdig to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[12] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[12] = 1;
                GlobalVariablesClass.FuzzyRPL[12] = 1;
                GlobalVariablesClass.FuzzyRSK[12] = 4;
            }
            else if (GlobalVariablesClass.NilaiNumber[12] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[12] = 1;
                GlobalVariablesClass.FuzzyRPL[12] = 1;
                GlobalVariablesClass.FuzzyRSK[12] = 4;
            }
            else if (GlobalVariablesClass.NilaiNumber[12] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[12] = 1;
                GlobalVariablesClass.FuzzyRPL[12] = 1;
                GlobalVariablesClass.FuzzyRSK[12] = 3;
            }

            //Convert Number AI to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[13] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[13] = 2;
                GlobalVariablesClass.FuzzyRPL[13] = 3;
                GlobalVariablesClass.FuzzyRSK[13] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[13] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[13] = 2;
                GlobalVariablesClass.FuzzyRPL[13] = 3;
                GlobalVariablesClass.FuzzyRSK[13] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[13] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[13] = 1;
                GlobalVariablesClass.FuzzyRPL[13] = 2;
                GlobalVariablesClass.FuzzyRSK[13] = 1;
            }

            //Convert Number APL to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[14] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[14] = 3;
                GlobalVariablesClass.FuzzyRPL[14] = 3;
                GlobalVariablesClass.FuzzyRSK[14] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[14] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[14] = 2;
                GlobalVariablesClass.FuzzyRPL[14] = 3;
                GlobalVariablesClass.FuzzyRSK[14] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[14] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[14] = 1;
                GlobalVariablesClass.FuzzyRPL[14] = 2;
                GlobalVariablesClass.FuzzyRSK[14] = 1;
            }

            //Convert Number RPL to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[15] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[15] = 3;
                GlobalVariablesClass.FuzzyRPL[15] = 4;
                GlobalVariablesClass.FuzzyRSK[15] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[15] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[15] = 2;
                GlobalVariablesClass.FuzzyRPL[15] = 3;
                GlobalVariablesClass.FuzzyRSK[15] = 2;
            }
            else if (GlobalVariablesClass.NilaiNumber[15] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[15] = 1;
                GlobalVariablesClass.FuzzyRPL[15] = 2;
                GlobalVariablesClass.FuzzyRSK[15] = 1;
            }

            //Convert Number IMK to Fuzzy
            if (GlobalVariablesClass.NilaiNumber[16] >= 3.25)
            {
                GlobalVariablesClass.FuzzyRSI[16] = 4;
                GlobalVariablesClass.FuzzyRPL[16] = 2;
                GlobalVariablesClass.FuzzyRSK[16] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[16] >= 2)
            {
                GlobalVariablesClass.FuzzyRSI[16] = 3;
                GlobalVariablesClass.FuzzyRPL[16] = 1;
                GlobalVariablesClass.FuzzyRSK[16] = 1;
            }
            else if (GlobalVariablesClass.NilaiNumber[16] <= 1.75)
            {
                GlobalVariablesClass.FuzzyRSI[16] = 3;
                GlobalVariablesClass.FuzzyRPL[16] = 1;
                GlobalVariablesClass.FuzzyRSK[16] = 1;
            }
        }
    }
}
