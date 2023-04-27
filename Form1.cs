namespace SamTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Simulation s = new Simulation(int.Parse(txtNumberOfDie.Text));
            s.Roll(int.Parse(txtNumberOfRolls.Text));

            formsPlot.Plot.XLabel("Sum of die rolls");
            formsPlot.Plot.YLabel("Roll count");
            formsPlot.Plot.XAxis.SetBoundary(s.minValue, s.maxValue);
            formsPlot.Plot.Clear();
            formsPlot.Plot.AddScatter(s.xValues, s.yValues);

            formsPlot.Refresh();
        }
    }
}