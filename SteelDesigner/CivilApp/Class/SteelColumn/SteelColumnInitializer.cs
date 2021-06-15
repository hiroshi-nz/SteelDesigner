using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.SteelColumn
{
    class SteelColumnInitializer
    {

        public static List<UBData> CreateUCXBendingList()
        {
            List<UBData> UBList = new List<UBData>();

            //310UC158 x-axis bending
            double phiMsx = 676;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas = { 1.000, 0.997, 0.977, 0.956, 0.933, 0.910, 0.886, 0.864, 0.819, 0.778, 0.739, 0.704, 0.670};
            double phiVv = 832;//kN
            UBData ub = new UBData("310UC158", phiMsx, alphas, phiVv);
            UBList.Add(ub);

            //310UC137 x-axis bending
            phiMsx = 580;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas2 = { 1.000, 0.996, 0.975, 0.952, 0.927, 0.902, 0.876, 0.851, 0.802, 0.756, 0.714, 0.675, 0.639};
            phiVv = 717;//kN
            ub = new UBData("310UC137", phiMsx, alphas2, phiVv);
            UBList.Add(ub);

            //310UC118 x-axis bending
            phiMsx = 494;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas3 = { 1.000, 0.994, 0.972, 0.947, 0.921, 0.893, 0.865, 0.837, 0.783, 0.733, 0.686, 0.644, 0.605 };
            phiVv = 606;//kN
            ub = new UBData("310UC118", phiMsx, alphas3, phiVv);
            UBList.Add(ub);

            //310UC96.8 x-axis bending
            phiMsx = 422;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas4 = { 1.000, 0.991, 0.966, 0.938, 0.908, 0.877, 0.844, 0.812, 0.750, 0.691, 0.638, 0.590, 0.548 };
            phiVv = 527;//kN
            ub = new UBData("310UC96.8", phiMsx, alphas4, phiVv);
            UBList.Add(ub);



            //250UC89.5 x-axis bending
            phiMsx = 309;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas5 = { 1.000, 0.979, 0.951, 0.920, 0.889, 0.858, 0.828, 0.798, 0.743, 0.692, 0.646, 0.605, 0.568 };
            phiVv = 472;//kN
            ub = new UBData("250UC89.5", phiMsx, alphas5, phiVv);
            UBList.Add(ub);

            //250UC72.9 x-axis bending
            phiMsx = 266;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas6 = { 0.999, 0.972, 0.940, 0.905, 0.868, 0.831, 0.795, 0.760, 0.695, 0.637, 0.585, 0.540, 0.500 };
            phiVv = 377;//kN
            ub = new UBData("250UC72.9", phiMsx, alphas6, phiVv);
            UBList.Add(ub);




            //200UC59.5 x-axis bending
            phiMsx = 177;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas7 = { 0.981, 0.945, 0.905, 0.864, 0.825, 0.787, 0.751, 0.717, 0.655, 0.601, 0.554, 0.513, 0.476};
            phiVv = 337;//kN
            ub = new UBData("200UC59.5", phiMsx, alphas7, phiVv);
            UBList.Add(ub);

            //200UC52.2 x-axis bending
            phiMsx = 154;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas8 = { 0.980, 0.941, 0.898, 0.855, 0.811, 0.770, 0.730, 0.693, 0.627, 0.570, 0.521, 0.478, 0.442 };
            phiVv = 285;//kN
            ub = new UBData("200UC52.2", phiMsx, alphas8, phiVv);
            UBList.Add(ub);

            //200UC46.2 x-axis bending
            phiMsx = 133;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas9 = { 0.979, 0.938, 0.894, 0.847, 0.801, 0.757, 0.715, 0.675, 0.605, 0.545, 0.494, 0.451, 0.414};
            phiVv = 257;//kN
            ub = new UBData("200UC46.2", phiMsx, alphas9, phiVv);
            UBList.Add(ub);



            //150UC37.2 x-axis bending
            phiMsx = 84;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas10 = { 0.946, 0.894, 0.843, 0.794, 0.749, 0.707, 0.668, 0.633, 0.570, 0.517, 0.472, 0.433, 0.400 };
            phiVv = 226;//kN
            ub = new UBData("150UC37.2", phiMsx, alphas10, phiVv);
            UBList.Add(ub);

            //150UC30.0 x-axis bending
            phiMsx = 72;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas11 = { 0.933, 0.873, 0.811, 0.753, 0.699, 0.650, 0.606, 0.566, 0.498, 0.444, 0.399, 0.361, 0.330 };
            phiVv = 180;//kN
            ub = new UBData("150UC30.0", phiMsx, alphas11, phiVv);
            UBList.Add(ub);

            //150UC23.4 x-axis bending
            phiMsx = 51;//kN*m
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas12 = { 0.928, 0.861, 0.792, 0.725, 0.664, 0.609, 0.560, 0.517, 0.445, 0.389, 0.345, 0.309, 0.280 };
            phiVv = 161;//kN
            ub = new UBData("150UC23.4", phiMsx, alphas12, phiVv);
            UBList.Add(ub);



            //100UC14.8 x-axis bending
            phiMsx = 21;//kN*m
                                 // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphas13 = { 0.857, 0.783, 0.717, 0.659, 0.608, 0.563, 0.524, 0.489, 0.429, 0.382, 0.343, 0.311, 0.283 };
            phiVv = 83.8;//kN
            ub = new UBData("100UC14.8", phiMsx, alphas13, phiVv);
            UBList.Add(ub);

            return UBList;
        }

        public static List<UCData> CreateUCYBucklingList()
        {
            List<UCData> UCList = new List<UCData>();

            //310UC158 y-axis buckling
            double phiNs = 5065;//kN
                             // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac = { 0.978, 0.955, 0.930, 0.904, 0.875, 0.843, 0.807, 0.767, 0.677, 0.583, 0.494, 0.417, 0.353 };
            UCData uc = new UCData("310UC158", phiNs, alphac);
            UCList.Add(uc);

            //310UC137 y-axis buckling
            phiNs = 4410;//kN
                              // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac2 = { 0.977, 0.954, 0.929, 0.902, 0.873, 0.840, 0.804, 0.763, 0.672, 0.577, 0.488, 0.411, 0.348 };
            uc = new UCData("310UC137", phiNs, alphac2);
            UCList.Add(uc);

            //310UC118 y-axis buckling
            phiNs = 3780;//kN
                               // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac3 = { 0.977, 0.953, 0.928, 0.901, 0.871, 0.838, 0.800, 0.759, 0.667, 0.571, 0.482, 0.406, 0.343 };
            uc = new UCData("310UC118", phiNs, alphac3);
            UCList.Add(uc);

            //310UC96.8 y-axis buckling
            phiNs = 3348;//kN
                               // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac4 = { 0.973, 0.948, 0.922, 0.893, 0.861, 0.824, 0.784, 0.739, 0.641, 0.541, 0.452, 0.378, 0.319};
            uc = new UCData("310UC96.8", phiNs, alphac4);
            UCList.Add(uc);

            //250UC89.5 y-axis buckling
            phiNs = 2873;//kN
                               // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac5 = { 0.963, 0.934, 0.902, 0.867, 0.826, 0.780, 0.728, 0.673, 0.559, 0.456, 0.372, 0.307, 0.256 };
            uc = new UCData("250UC89.5", phiNs, alphac5);
            UCList.Add(uc);

            //250UC72.9 y-axis buckling
            phiNs = 2516;//kN
                              // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac6 = { 0.959, 0.929, 0.895, 0.856, 0.812, 0.761, 0.705, 0.646, 0.528, 0.427, 0.346, 0.284, 0.236};
            uc = new UCData("250UC72.9", phiNs, alphac6);
            UCList.Add(uc);

            //200UC59.5 y-axis buckling
            phiNs = 2057;//kN
                             // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac7 = { 0.937,0.895, 0.846, 0.788, 0.721, 0.647, 0.573, 0.502, 0.385, 0.299, 0.237, 0.192, 0.158 };
            uc = new UCData("200UC59.5", phiNs, alphac7);
            UCList.Add(uc);

            //200UC52.2 y-axis buckling
            phiNs = 1798;//kN
                               // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac8 = { 0.936, 0.894, 0.845, 0.787, 0.719, 0.645, 0.570, 0.500, 0.383, 0.297, 0.236, 0.191, 0.157 };
            uc = new UCData("200UC52.2", phiNs, alphac8);
            UCList.Add(uc);

            //200UC46.2 y-axis buckling
            phiNs = 1593;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac9 = { 0.935, 0.892, 0.842, 0.783, 0.714, 0.639, 0.564, 0.493, 0.377, 0.292, 0.232, 0.187, 0.155 };
            uc = new UCData("200UC46.2", phiNs, alphac9);
            UCList.Add(uc);

            //150UC37.2 y-axis buckling
            phiNs = 1277;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac10 = { 0.894, 0.826, 0.741, 0.643, 0.544, 0.455, 0.381, 0.321, 0.234, 0.178, 0.139, 0.111, 0.091 };
            uc = new UCData("150UC37.2", phiNs, alphac10);
            UCList.Add(uc);


            //150UC30.0 y-axis buckling
            phiNs = 1112;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac11 = { 0.886, 0.812, 0.720, 0.616, 0.515, 0.427, 0.356, 0.299, 0.217, 0.164, 0.128, 0.103, 0.084 };
            uc = new UCData("150UC30.0", phiNs, alphac11);
            UCList.Add(uc);

            //150UC23.4 y-axis buckling
            phiNs = 858;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac12 = { 0.877, 0.798, 0.700, 0.591, 0.488, 0.402, 0.333, 0.279, 0.202, 0.152, 0.119, 0.095, 0.078 };
            uc = new UCData("150UC23.4", phiNs, alphac12);
            UCList.Add(uc);

            //100UC14.8 y-axis buckling
            phiNs = 544;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac13 = { 0.753, 0.593, 0.445, 0.335, 0.258, 0.204, 0.164, 0.135, 0.096, 0.071, 0.055, 0.044, 0.036 };
            uc = new UCData("100UC14.8", phiNs, alphac13);
            UCList.Add(uc);


            return UCList;
        }




        public static List<UCData> CreateUCXBucklingList()
        {
            List<UCData> UCList = new List<UCData>();

            //310UC158 x-axis buckling
            double phiNs = 5065;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac = { 1.000, 0.994, 0.981, 0.969, 0.955, 0.942, 0.927, 0.913, 0.881, 0.844, 0.803, 0.758, 0.707 };
            UCData uc = new UCData("310UC158", phiNs, alphac);
            UCList.Add(uc);

            //310UC137 x-axis buckling
            phiNs = 4410;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac2 = { 1.000, 0.993, 0.981, 0.967, 0.954, 0.940, 0.926, 0.910, 0.878, 0.840, 0.798, 0.751, 0.700};
            uc = new UCData("310UC137", phiNs, alphac2);
            UCList.Add(uc);


            //310UC118 x-axis buckling
            phiNs = 3780;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac3 = { 1.000, 0.993, 0.980, 0.967, 0.953, 0.939, 0.925, 0.909, 0.876, 0.838, 0.796, 0.748, 0.696 };
            uc = new UCData("310UC118", phiNs, alphac3);
            UCList.Add(uc);

            //310UC96.8 x-axis buckling
            phiNs = 3348;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac4 = { 1.000, 0.990, 0.977, 0.963, 0.948, 0.933, 0.918, 0.901, 0.865, 0.824, 0.777, 0.725, 0.668 };
            uc = new UCData("310UC96.8", phiNs, alphac4);
            UCList.Add(uc);

            //250UC89.5 x-axis buckling
            phiNs = 2873;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac5 = { 0.998, 0.982, 0.966, 0.949, 0.932, 0.914, 0.894, 0.873, 0.827, 0.773, 0.711, 0.645, 0.578 };
            uc = new UCData("250UC89.5", phiNs, alphac5);
            UCList.Add(uc);

            //250UC72.9 x-axis buckling
            phiNs = 2516;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac6 = { 0.996, 0.979, 0.962, 0.945, 0.926, 0.907, 0.886, 0.864, 0.813, 0.754, 0.688, 0.618, 0.550 };
            uc = new UCData("250UC72.9", phiNs, alphac6);
            UCList.Add(uc);

            //200UC59.5 x-axis buckling
            phiNs = 2057;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac7 = { 0.984, 0.963, 0.941, 0.918, 0.893, 0.866, 0.836, 0.803, 0.727, 0.642, 0.556, 0.478, 0.410 };
            uc = new UCData("200UC59.5", phiNs, alphac7);
            UCList.Add(uc);

            //200UC52.2 x-axis buckling
            phiNs = 1798;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac8 = { 0.983, 0.963, 0.941, 0.917, 0.892, 0.864, 0.834, 0.800, 0.723, 0.638, 0.552, 0.473, 0.405 };
            uc = new UCData("200UC52.2", phiNs, alphac8);
            UCList.Add(uc);

            //200UC46.2 x-axis buckling
            phiNs = 1593;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac9 = { 0.983, 0.962, 0.939, 0.916, 0.890, 0.862, 0.831, 0.797, 0.718, 0.632, 0.545, 0.467, 0.399 };
            uc = new UCData("200UC46.2", phiNs, alphac9);
            UCList.Add(uc);

            //150UC37.2 x-axis buckling
            phiNs = 1277;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac10 = { 0.964, 0.936, 0.905, 0.870, 0.830, 0.785, 0.735, 0.680, 0.567, 0.465, 0.380, 0.314, 0.262 };
            uc = new UCData("150UC37.2", phiNs, alphac10);
            UCList.Add(uc);


            //150UC30.0 x-axis buckling
            phiNs = 1112;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac11 = { 0.961, 0.930, 0.897, 0.859, 0.816, 0.767, 0.712, 0.654, 0.537, 0.435, 0.354, 0.291, 0.242 };
            uc = new UCData("150UC30.0", phiNs, alphac11);
            UCList.Add(uc);

            //150UC23.4 x-axis buckling
            phiNs = 858;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac12 = { 0.957, 0.926, 0.890, 0.850, 0.804, 0.751, 0.693, 0.632, 0.513, 0.412, 0.333, 0.273, 0.227 };
            uc = new UCData("150UC23.4", phiNs, alphac12);
            UCList.Add(uc);

            //100UC14.8 x-axis buckling
            phiNs = 544;//kN
                                // 1.5m  2.0m   2.5m   3.0m   3.5m   4.0m   4.5m   5.0m   6.0m   7.0m   8.0m   9.0m   10.0m 
            double[] alphac13 = { 0.899, 0.835, 0.756, 0.663, 0.566, 0.477, 0.401, 0.339, 0.248, 0.189, 0.148, 0.118, 0.097 };
            uc = new UCData("100UC14.8", phiNs, alphac13);
            UCList.Add(uc);


            return UCList;
        }
    }
}
