using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPK
{
    class Normalization
    {
        public static void NormalizationMatrixR() {

           for (int m = 0; m < 17; m++) {
                GlobalVariablesClass.max[m] = GlobalVariablesClass.MatrixX[0, m];
                GlobalVariablesClass.min[m] = GlobalVariablesClass.MatrixX[0, m];
                for (int n = 0; n < 3; n++) {
                    if (GlobalVariablesClass.MatrixX[n, m] > GlobalVariablesClass.max[m]) {
                        GlobalVariablesClass.max[m] = GlobalVariablesClass.MatrixX[n, m];
                    }

                    if (GlobalVariablesClass.MatrixX[n, m] < GlobalVariablesClass.min[m])
                    {
                        GlobalVariablesClass.min[m] = GlobalVariablesClass.MatrixX[n, m];
                    }
                }
            }


            for (int o = 0; o < 17; o++) {
                for (int p = 0; p < 3; p++)
                {
                    if (o % 2 == 0)
                    {
                        GlobalVariablesClass.NormalizationR[p, o] = GlobalVariablesClass.MatrixX[p, o] / GlobalVariablesClass.max[o];
                    }
                    else
                    {
                        GlobalVariablesClass.NormalizationR[p, o] = GlobalVariablesClass.min[o] / GlobalVariablesClass.MatrixX[p, o];
                    }
                }
                
            }
           
        }
    }
}
