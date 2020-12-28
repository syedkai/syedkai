using System;
using LearningFoundation;


namespace Background_Subraction
{
    public class Background_Substraction : IPipelineModule<double[,,], double[,,]>
    {
       

        private double thres;
        
        public Background_Substraction (double thres = 70)
        {
            this.thres = thres;
        }
        public double[,,] Run(double[,,] data, IContext ctx)




        {


            double[,,] result = new double[data.GetLength(0), data.GetLength(1), 3];




            double averageGreen = (data[1, 1, 1] + data[1, data.GetLength(1) - 2, 1] + data[data.GetLength(0) - 2, 1, 1]
                                                   + data[data.GetLength(0) - 2, data.GetLength(1) - 2, 1]) / 4;




            double avaerageBlue = (data[1, 1, 2] + data[1, data.GetLength(1) - 2, 2] + data[data.GetLength(0) - 2, 1, 2]
                                                   + data[data.GetLength(0) - 2, data.GetLength(1) - 2, 2]) / 4;




            double averageRed = (data[1, 1, 0] + data[1, data.GetLength(1) - 2, 0] + data[data.GetLength(0) - 2, 1, 0]
                                                   + data[data.GetLength(0) - 2, data.GetLength(1) - 2, 0]) / 4;

            


            
            double thresh = 65;


            for (int i = 0; i < data.GetLength(0); i++)
            {

                for (int j = 0; j < data.GetLength(1); j++)
                {

                    if (Math.Abs(averageRed - data[i, j, 0]) < thresh &
                        Math.Abs(averageGreen - data[i, j, 1]) < thresh &
                        Math.Abs(avaerageBlue - data[i, j, 2]) < thresh)
                    {

                        result[i, j, 0] = 230;
                        result[i, j, 1] = 230;
                        result[i, j, 2] = 230;

                    }
                    else
                    {

                        result[i, j, 0] = data[i, j, 0];
                        result[i, j, 1] = data[i, j, 1];
                        result[i, j, 2] = data[i, j, 2];

                    }

                }

            }





           
            return result;
        }
    }
}
