using Claster;

namespace kohonenNetwork
{
    public partial class Form1 : Form
    {
        /*
        ???? ????? - ?? 1 ?? 12 (?? ????? ???????)
        ???????????? - ?? 0 ?? 100000 (????)
        ?????? - ?? 100 ?? 2000 (?? ? ???)
         */

        Webs webs = new Webs();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Clear();

            webs.CreateWebs((int)numClusters.Value, (int)numParams.Value);

            //webs.PrintWebs(outputBox);

            webs.FindBestClasterisation();

            Dictionary<int,string> output = webs._bestClaster.getOutput();

            foreach (var item in output)
            {
                outputBox.Text += item + Environment.NewLine;
            }

            int a = 3;
        }
    }
}