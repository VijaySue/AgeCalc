namespace AgeCalc
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                Invoke(new Action(() =>
                {
                    progressBar1.Value = i;
                    Thread.Sleep(50);
                }));
            }
            MessageBox.Show("ÄúµÄÄêÁäÎª" + (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(year.Text) - 
                (int.Parse(DateTime.Now.Month.ToString()) > int.Parse(month.Text) ||
                int.Parse(DateTime.Now.Month.ToString()) == int.Parse(month.Text) &&
                int.Parse(DateTime.Now.Day.ToString()) >= int.Parse(day.Text) ? 0 : 1)).ToString() + "Ëê");
            progressBar1.Value = 0;
        }
    }
}
