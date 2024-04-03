using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claster
{
    public class QualityClaster
    {
        public double SilhouetteCoefficient { get; set; }
        List<double> _clusterAssignments = new List<double>();
        List<double[]> _data = new List<double[]>();
        public double EuclideanDistance(double[] p1, double[] p2)
        {
            double sum = 0.0;
            for (int i = 0; i < p1.Length; i++)
            {
                sum += Math.Pow(p1[i] - p2[i], 2);
            }
            return Math.Sqrt(sum);
        }

        public void ConverterData(List<(double,double)> clusterAndValue, double[][] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                _data.Add(data[i]);
                _clusterAssignments.Add(clusterAndValue[i].Item1);
            }
        }

        public double CalculateSilhouetteCoefficient()
        {
            int n = _data.Count;
            SilhouetteCoefficient = 0.0;

            for (int i = 0; i < n; i++)
            {
                double a = 0.0, b = double.MaxValue;
                double cluster = _clusterAssignments[i];

                for (int y = 0; y < n; y++)
                {
                    if (i != y)
                    {
                        double distance = EuclideanDistance(_data[i], _data[y]);
                        if (_clusterAssignments[y] == cluster)
                        {
                            a += distance;
                        }
                        else
                        {
                            b = Math.Min(b, distance);
                        }
                    }
                }

                double s = (b - a) / Math.Max(a, b);
                SilhouetteCoefficient += s;
            }

            SilhouetteCoefficient /= n;
            return SilhouetteCoefficient;
        }
    }
}
