using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPK
{
    class SAWMethod
    {
        public static void SAW()
        {
            //Array of Number
            double[] nilaiNumber =
            {
                4,
                3.75, 3.5, 3.25, 3,
                2.75, 2.5, 2.25, 2,
                1.75, 1.5, 1.25, 1,
                0.75, 0.5, 0.25, 0,
            };

            //Convert string to number
            for (int i = 0; i < 17; i++)
            {
                GlobalVariablesClass.NilaiNumber[i] = nilaiNumber[GlobalVariablesClass.Nilai[i]];
            }

            Fuzzy.ConvertFuzzy();

            //Create Matrix Decision X

            for (int j = 0; j < 17; j++)
            {
                GlobalVariablesClass.MatrixX[0, j] = GlobalVariablesClass.FuzzyRSI[j];
            }
            for (int k = 0; k < 17; k++)
            {
                GlobalVariablesClass.MatrixX[1, k] = GlobalVariablesClass.FuzzyRPL[k];
            }
            for (int l = 0; l < 17; l++)
            {
                GlobalVariablesClass.MatrixX[2, l] = GlobalVariablesClass.FuzzyRSK[l];
            }

            Normalization.NormalizationMatrixR();

            //Multiple Matrix W*R
            for (int q = 0; q < 3; q++) {
                for (int r = 0; r < 17; r++) {

                    GlobalVariablesClass.V[q] += GlobalVariablesClass.VektorBobotW[r] * GlobalVariablesClass.NormalizationR[q,r];
                }
            }



        }
    }
}
