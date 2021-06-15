using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.SteelBeam
{
    class SteelBeamInitializer
    {
        public SteelBeamInitializer()
        {
            
        }

        public static List<UBData> CreateUBList()
        {
            List<UBData> UBList = new List<UBData>();

            //310UB46.2 x-axis bending
            double phiMsx = 197;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas = { 0.940, 0.876, 0.805, 0.735, 0.667, 0.605, 0.550, 0.501, 0.421, 0.361, 0.314, 0.278, 0.249 };
            double phiVv = 356;//kN
            UBData ub = new UBData("310UB46.2", phiMsx, alphas, phiVv);
            UBList.Add(ub);


            //310UB40.4 x-axis bending
            phiMsx = 182;//kN*m
                         // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas2 = { 0.930, 0.859, 0.782, 0.704, 0.631, 0.564, 0.506, 0.455, 0.375, 0.316, 0.272, 0.238, 0.212 };
            phiVv = 320;//kN
            ub = new UBData("310UB40.4", phiMsx, alphas2, phiVv);
            UBList.Add(ub);

            //310UB32.0 x-axis bending
            phiMsx = 134;//kN*m
                         // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas3 = { 0.901, 0.813, 0.721, 0.633, 0.553, 0.484, 0.426, 0.377, 0.304, 0.252, 0.215, 0.187, 0.165 };
            phiVv = 283;//kN
            ub = new UBData("310UB32.0", phiMsx, alphas3, phiVv);
            UBList.Add(ub);

            //250UB37.3 x-axis bending
            phiMsx = 140;//kN*m
                         // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas4 = { 0.910, 0.832, 0.751, 0.674, 0.605, 0.544, 0.491, 0.446, 0.375, 0.322, 0.281, 0.249, 0.224 };
            phiVv = 283;//kN
            ub = new UBData("250UB37.3", phiMsx, alphas4, phiVv);
            UBList.Add(ub);

            //250UB31.4 x-axis bending
            phiMsx = 114;//kN*m
                         // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas5 = { 0.902, 0.818, 0.730, 0.647, 0.572, 0.507, 0.451, 0.405, 0.333, 0.281, 0.243, 0.213, 0.190 };
            phiVv = 265;//kN
            ub = new UBData("250UB31.4", phiMsx, alphas5, phiVv);
            UBList.Add(ub);

            //250UB25.7 x-axis bending
            phiMsx = 92;//kN*m
                        // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas6 = { 0.853, 0.747, 0.646, 0.556, 0.481, 0.419, 0.370, 0.329, 0.269, 0.226, 0.195, 0.172, 0.153 };
            phiVv = 214;//kN
            ub = new UBData("250UB25.7", phiMsx, alphas6, phiVv);
            UBList.Add(ub);

            //200UB29.8 x-axis bending
            phiMsx = 90;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas7 = { 0.894, 0.812, 0.730, 0.655, 0.589, 0.532, 0.483, 0.441, 0.374, 0.324, 0.285, 0.254, 0.229 };
            phiVv = 225;//kN
            ub = new UBData("200UB29.8", phiMsx, alphas7, phiVv);
            UBList.Add(ub);



            //200UB25.4 x-axis bending
            phiMsx = 75;//kN*m
                               // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas8 = { 0.883, 0.793, 0.704, 0.622, 0.551, 0.490, 0.439, 0.397, 0.330, 0.282, 0.246, 0.218, 0.195 };
            phiVv = 204;//kN
            ub = new UBData("200UB25.4", phiMsx, alphas8, phiVv);
            UBList.Add(ub);

            //200UB22.3 x-axis bending
            phiMsx = 65;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas9 = { 0.884, 0.792, 0.700, 0.615, 0.541, 0.478, 0.426, 0.382, 0.315, 0.267, 0.231, 0.204, 0.182 };
            phiVv = 174;//kN
            ub = new UBData("200UB22.3", phiMsx, alphas9, phiVv);
            UBList.Add(ub);

            //200UB18.2 x-axis bending
            phiMsx = 52;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas10 = { 0.777, 0.655, 0.550, 0.466, 0.401, 0.349, 0.309, 0.277, 0.228, 0.194, 0.169, 0.150, 0.134 };
            phiVv = 154;//kN
            ub = new UBData("200UB18.2", phiMsx, alphas10, phiVv);
            UBList.Add(ub);

            //460UB82.1 x-axis bending
            phiMsx = 496;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas11 = { 0.957, 0.901, 0.837, 0.771, 0.705, 0.642, 0.585, 0.533, 0.447, 0.380, 0.329, 0.289, 0.257 };
            phiVv = 788;//kN
            ub = new UBData("460UB82.1", phiMsx, alphas11, phiVv);
            UBList.Add(ub);

            //460UB74.6 x-axis bending
            phiMsx = 449;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas12 = { 0.955, 0.897, 0.832, 0.763, 0.695, 0.630, 0.571, 0.518, 0.429, 0.362, 0.311, 0.271, 0.240 };
            phiVv = 719;//kN
            ub = new UBData("460UB74.6", phiMsx, alphas12, phiVv);
            UBList.Add(ub);

            //460UB67.1 x-axis bending
            phiMsx = 399;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas13 = { 0.953, 0.894, 0.826, 0.754, 0.684, 0.617, 0.555, 0.500, 0.410, 0.342, 0.291, 0.252, 0.222 };
            phiVv = 667;//kN
            ub = new UBData("460UB67.1", phiMsx, alphas13, phiVv);
            UBList.Add(ub);

            //410UB59.7 x-axis bending
            phiMsx = 324;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas14 = { 0.946, 0.883, 0.812, 0.739, 0.668, 0.602, 0.543, 0.490, 0.404, 0.339, 0.291, 0.254, 0.225 };
            phiVv = 548;//kN
            ub = new UBData("410UB59.7", phiMsx, alphas14, phiVv);
            UBList.Add(ub);

            //410UB53.7 x-axis bending
            phiMsx = 304;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas15 = { 0.936, 0.866, 0.789, 0.709, 0.633, 0.563, 0.500, 0.446, 0.360, 0.298, 0.253, 0.218, 0.192 };
            phiVv = 529;//kN
            ub = new UBData("410UB53.7", phiMsx, alphas15, phiVv);
            UBList.Add(ub);

            //360UB56.7 x-axis bending
            phiMsx = 273;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas16 = { 0.942, 0.879, 0.809, 0.737, 0.669, 0.606, 0.549, 0.499, 0.418, 0.356, 0.309, 0.272, 0.243 };
            phiVv = 496;//kN
            ub = new UBData("360UB56.7", phiMsx, alphas16, phiVv);
            UBList.Add(ub);

            //360UB50.7 x-axis bending
            phiMsx = 242;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas17 = { 0.940, 0.874, 0.800, 0.726, 0.654, 0.589, 0.530, 0.478, 0.395, 0.333, 0.286, 0.251, 0.223 };
            phiVv = 449;//kN
            ub = new UBData("360UB50.7", phiMsx, alphas17, phiVv);
            UBList.Add(ub);

            //360UB44.7 x-axis bending
            phiMsx = 222;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas18 = { 0.930, 0.858, 0.778, 0.697, 0.620, 0.550, 0.489, 0.436, 0.353, 0.293, 0.248, 0.215, 0.190 };
            phiVv = 420;//kN
            ub = new UBData("360UB44.7", phiMsx, alphas18, phiVv);
            UBList.Add(ub);

            return UBList;
        }

        public static List<UBDimensions> CreateDimensionsList()
        {
            List<UBDimensions> dimensionsList = new List<UBDimensions>();

            UBDimensions dimensions = new UBDimensions("310UB46.2", 46.2, 307, 166, 11.8, 6.7 );
            dimensionsList.Add(dimensions);

            dimensions = new UBDimensions("310UB40.4", 40.4, 304, 165, 10.2, 6.1 );
            dimensionsList.Add(dimensions);

            dimensions = new UBDimensions("310UB32.0", 32.0, 298, 149, 8, 5.5);
            dimensionsList.Add(dimensions);

            dimensions = new UBDimensions("250UB37.3", 37.3, 256, 146, 10.9, 6.4);
            dimensionsList.Add(dimensions);

            dimensions = new UBDimensions("250UB31.4", 31.4, 252, 146, 8.6, 6.1);
            dimensionsList.Add(dimensions);

            dimensions = new UBDimensions("250UB25.7", 25.7, 248, 124, 8, 5 );
            dimensionsList.Add(dimensions);

            dimensions = new UBDimensions("200UB29.8", 29.8, 207, 134, 9.6, 6.3);
            dimensionsList.Add(dimensions);

            dimensions = new UBDimensions("200UB25.4", 25.4, 203, 133, 7.8, 5.8);
            dimensionsList.Add(dimensions);

            return dimensionsList;

        }

        }
}
