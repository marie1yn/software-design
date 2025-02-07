namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public int RecursiveFactorial(int num)
		{
			if(num == 0)
			{
				return 1;
			}
			return num * RecursiveFactorial(num-1);
		}

        private void button1_Click(object sender, EventArgs e)
        {
			int n = int.Parse(txtInput.Text);
			int r = RecursiveFactorial((int)n);
			lbl.Text = $"Factorial: {r}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
		public int RecursiveSum(int[] numbers, int n)
		{
			if (n == 0) { return numbers[0]; }
			return numbers[n] + RecursiveSum(numbers, n-1);
		}
        private void button2_Click(object sender, EventArgs e)
        {
			int[] numbers = txtInput.Text.Split(',').Select(int.Parse).ToArray();
			int r = RecursiveSum(numbers, numbers.Length - 1);
			lblSum.Text = $"Sum: {r}";
        }
    }
}
