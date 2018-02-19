using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace MultivariateStatistics
{
    public class DescriptiveStat
    {
        public double max, min, sum, avg, var, stddev, median, percentile1Quarter, percentile3Quarter;
        public string range;
    }

    public struct Mathtool
    {
               
        public static DescriptiveStat GetDescriptiveStat(List<double> data)
        {
            DescriptiveStat result = new DescriptiveStat();
            double sqSum = 0, loopMax, loopMin;
            result.sum = 0;
            int n = data.Count;
            List<double> maxes = new List<double>();
            List<double> mins = new List<double>();
            int maxIndex, minIndex;

            while (data.Count > 2)
            {

                loopMax = data[0];
                loopMin = data[0];
                maxIndex = 0;
                minIndex = 0;

                foreach (double d in data)
                {
                    if (d > loopMax)
                    {
                        loopMax = d;
                        maxIndex = data.IndexOf(d);
                    }
                    if (d < loopMin)
                    {
                        loopMin = d;
                        minIndex = data.IndexOf(d);
                    }
                }
                result.sum += loopMax + loopMin;
                sqSum += Math.Pow(loopMin, 2) + Math.Pow(loopMax, 2);
                maxes.Insert(0, loopMax);
                
                mins.Add(loopMin);

                if (maxIndex > minIndex)
                {
                    data.RemoveAt(maxIndex);
                    data.RemoveAt(minIndex);
                }
                else
                {
                    data.RemoveAt(minIndex);
                    data.RemoveAt(maxIndex);
                }

            }
            if(data.Count == 2)
                mins.Add(data.Min());
            maxes.Add(data.Max());
            result.median = maxes[0];
            data.Clear();
            data.AddRange(mins);
            data.AddRange(maxes);
            result.max = data[n-1];
            result.min = data[0];
            result.avg = result.sum / n;
            result.var = (sqSum - n * Math.Pow(result.avg, 2)) / n;
            result.stddev = Math.Sqrt(result.var);

            for (int i = 0; i < data.Count; i++ )
            {
                double percentile = ((double)i / (double)n);
                if (percentile > .25 && result.percentile1Quarter == 0)
                    result.percentile1Quarter = data[i];
                if (percentile > .75 && result.percentile3Quarter == 0)
                    result.percentile3Quarter = data[i];
            }
            return result;
        }


        public static double[] RegressionCoefficient(double[][] data, int x, int y)
        {
            double[] coefficients = new double[2];
            double xSum = 0, ySum = 0, sumProduct = 0, xSquareSum = 0;          
            if (data[x].Length==data[y].Length)
            {
		            for (int n = 0; n<data[x].Length;n++)
		            {
			            xSum += data[x][n];
			            ySum += data[y][n];
			            sumProduct +=  data[x][n]* data[y][n];
			            xSquareSum += Math.Pow(data[x][n], 2);
		            }
                    //coefficent[0] holds coefficient a (the x intercept)
		            coefficients[0] = (data[x].Length*sumProduct - xSum*ySum)/
			                          (data[x].Length*xSquareSum - Math.Pow(xSum, 2));
                    //coefficent[1] holds coefficient b (the "slope")
                    coefficients[1] = (xSum*xSquareSum-xSum*sumProduct) /
                                      (data[x].Length * xSquareSum - Math.Pow(xSum, 2));
	        }
            return coefficients;
        }

        public static double GetCoefficient(double[][] data, int i, int j)
        {
            double sumX = 0, sumY = 0, sumXY = 0, sqSumX = 0, sqSumY = 0;
            int h = data.Length;
            int w = data[0].Length;
            if (i >= w || j >= w)
                throw new Exception("Variables are incorrect");
            for (int k = 0; k < h; k++)
            {
                sumX += data[k][i];
                sqSumX += Math.Pow(data[k][i], 2);
                sumY += data[k][j];
                sqSumY += Math.Pow(data[k][j], 2);
                sumXY += data[k][i] * data[k][j];
            }
            return (h * sumXY - sumX * sumY) / Math.Sqrt(h * sqSumX - Math.Pow(sumX, 2)) * Math.Sqrt(h * sqSumY - Math.Pow(sumY, 2));
        }
    }
}
