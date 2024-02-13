namespace TestScoreCalculator_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> scores = new();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                scores.Add(Convert.ToInt32(txtScore.Text));
                int total = 0;

                foreach (int s in scores)
                {
                    total += s;
                }

                int avg = total / scores.Count;

                txtScoreTotal.Text = total.ToString();
                txtScoreCount.Text = scores.Count.ToString();
                txtAverage.Text = avg.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            txtScore.Focus();
            txtScore.Text = "";

        }

        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            string output = "";

            foreach (int s in scores)
            {
                output += s.ToString() + " ";
            }

            MessageBox.Show(output);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Text = "";

            scores.Clear();

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}