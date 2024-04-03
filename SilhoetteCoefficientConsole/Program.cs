using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilhoetteCoefficientConsole
{
    internal class Program
    {
        
    static double EuclideanDistance(double[] p1, double[] p2)
        {
            double sum = 0.0;
            for (int i = 0; i < p1.Length; i++)
            {
                sum += Math.Pow(p1[i] - p2[i], 2);
            }
            return Math.Sqrt(sum);
        }

        static double CalculateSilhouetteCoefficient(List<double[]> data, List<int> clusterAssignments)
        {
            int n = data.Count;
            double silhouetteCoefficient = 0.0;

            for (int i = 0; i < n; i++)
            {
                double a = 0.0, b = double.MaxValue;
                int cluster = clusterAssignments[i];

                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        double distance = EuclideanDistance(data[i], data[j]);
                        if (clusterAssignments[j] == cluster)
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
                silhouetteCoefficient += s;
            }

            silhouetteCoefficient /= n;
            return silhouetteCoefficient;
        }

        static void Main()
        {
            List<double[]> data = new List<double[]>
        {
            new double[] {1.0, 2.0, 3},
            new double[] {2.0, 3.0, 5},
            new double[] {3.0, 4.0, 2},
            new double[] {7.0, 8.0, 1},
            new double[] {8.0, 9.0, 9},
            new double[] {9.0, 10.0, 2}
        };

            List<int> clusterAssignments = new List<int> { 0, 0, 0, 1, 1, 1 }; // Пример принадлежности к кластерам

            double silhouetteCoefficient = CalculateSilhouetteCoefficient(data, clusterAssignments);
            Console.WriteLine($"Silhouette Coefficient: {silhouetteCoefficient}");
        }
    }
}

