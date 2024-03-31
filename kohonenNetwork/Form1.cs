namespace kohonenNetwork
{
    public partial class Form1 : Form
    {
        /*
        ???? ????? - ?? 1 ?? 12 (?? ????? ???????)
        ???????????? - ?? 0 ?? 100000 (????)
        ?????? - ?? 100 ?? 2000 (?? ? ???)
         */
        string path = "data.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            Clasteriztaion kohWeb = new Clasteriztaion(Convert.ToInt32(numParams.Value), Convert.ToInt32(numClusters.Value));
            kohWeb.SelfOrganizingMaps(0.0001, 0.3, path);
            Dictionary <int,string> output = kohWeb.getOutput();
            foreach (var item in output)
            {
                outputBox.Text += item.ToString() + '\r' + '\n';
            }
        }
    }
}