namespace CST150_Activity1_Mars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double marsGravity = 2.65251989;
            double earthWgt;
            double marsWgt;

            earthWgt = double.Parse(txtWgtEarth.Text);
            marsWgt = earthWgt / marsGravity;


            txtOutput.Text = marsWgt.ToString();
        }
    }
}