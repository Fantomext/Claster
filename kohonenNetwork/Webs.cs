using kohonenNetwork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claster
{
    public class Webs
    {
        private List<Clasteriztaion> webs = new List<Clasteriztaion>();
        public Clasteriztaion _bestClaster { get; set; }
        string path = "data.txt";

        public void CreateWebs(int numClusters, int numParameters)
        {
            this.webs.Clear();
            for (int i = 2; i <= numClusters; i++)
            {
                Clasteriztaion kohWeb = new Clasteriztaion(numParameters, i);
                kohWeb.SelfOrganizingMaps(0.0001, 0.3, path);
                webs.Add(kohWeb);
            }
        }
        public void PrintWebs(TextBox outputBox)
        {

            for (int i = 0; i < webs.Count; i++)
            {
                Dictionary<int, string> outPut = webs[i].getOutput();
                outputBox.Text += $"Новая{i}: ";
                outputBox.Text += webs[i].ReturnCoef();

                foreach (var item in outPut)
                {
                    outputBox.Text += item.ToString() + '\r' + '\n';
                }
                outputBox.Text += Environment.NewLine;
            }
        }

        public Clasteriztaion FindBestClasterisation()
        {
            double maxVaue = -2;
            for (int i = 0; i < webs.Count; i++)
            {
                if (maxVaue < webs[i].ReturnCoef())
                {
                    maxVaue = webs[i].ReturnCoef();
                    _bestClaster = webs[i];
                }
            }
            return _bestClaster;
        }
    }
}
