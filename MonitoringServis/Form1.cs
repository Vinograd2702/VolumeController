namespace MonitoringServis
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


            currentValueBox.Text = myControl.currentVlalue.ToString();

        }



        private void myControl_Click(object sender, EventArgs e)
        {
            currentValueBox.Text = Math.Round((myControl.currentVlalue)).ToString();
        }



        private void myControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentValueBox.Text = Math.Round((myControl.currentVlalue)).ToString();
            }
        }
  
    }
}
