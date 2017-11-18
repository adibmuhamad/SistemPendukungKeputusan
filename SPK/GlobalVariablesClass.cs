using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPK
{
    class GlobalVariablesClass
    {
        private static int[] ArrayNilai = new int[17];

        public static int[] Nilai
        {
            get
            {
                return ArrayNilai;
            }
            set
            {
                ArrayNilai = value;
            }
        }

        private static double[] ArrayNilaiNumber = new double[17];

        public static double[] NilaiNumber
        {
            get
            {
                return ArrayNilaiNumber;
            }
            set
            {
                ArrayNilaiNumber = value;
            }
        }

        private static double[] ValueFuzzyRSI = new double[17];

        public static double[] FuzzyRSI
        {
            get
            {
                return ValueFuzzyRSI;
            }
            set
            {
                ValueFuzzyRSI = value;
            }
        }

        private static double[] ValueFuzzyRPL = new double[17];

        public static double[] FuzzyRPL
        {
            get
            {
                return ValueFuzzyRPL;
            }
            set
            {
                ValueFuzzyRPL = value;
            }
        }

        private static double[] ValueFuzzyRSK = new double[17];

        public static double[] FuzzyRSK
        {
            get
            {
                return ValueFuzzyRSK;
            }
            set
            {
                ValueFuzzyRSK = value;
            }
        }

        public static int[] VektorBobotW = {3, 4, 4, 4, 3, 4, 2, 4, 4, 4, 4, 2, 4, 1, 2, 4, 3};

        private static double[,] MatrixDecisionX = new double[3,17];

        public static double[,] MatrixX
        {
            get
            {
                return MatrixDecisionX;
            }
            set
            {
                MatrixDecisionX = value;
            }
        }

        private static double[,] NormalizationMatrixR = new double[3, 17];

        public static double[,] NormalizationR
        {
            get
            {
                return NormalizationMatrixR;
            }
            set
            {
                NormalizationMatrixR = value;
            }
        }

        private static double[] maxArray = new double[17];

        public static double[] max
        {
            get
            {
                return maxArray;
            }
            set
            {
                maxArray = value;
            }
        }

        private static double[] minArray = new double[17];
        
        public static double[] min
        {
            get
            {
                return minArray;
            }
            set
            {
                minArray = value;
            }
        }

        private static double[] ArrayV = new double[3];

        public static double[] V
        {
            get
            {
                return ArrayV;
            }
            set
            {
                ArrayV = value;
            }
        }
    }
}
