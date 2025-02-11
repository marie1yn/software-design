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
            if (num == 0)
            {
                return 1;
            }
            return num * RecursiveFactorial(num - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInput.Text);
            int r = RecursiveFactorial(n);
            lbl.Text = $"Factorial: {r}";
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) { return numbers[0]; }
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }


        public int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }


        public int RecursivePower(int x, int n)
        {
            if (n == 0) return 1;
            return x * RecursivePower(x, n - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtBase.Text);
            int n = int.Parse(txtExponent.Text);
            int r = RecursivePower(x, n);
            lblPower.Text = $"{x}^{n} = {r}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = textSum.Text.Split(',').Select(int.Parse).ToArray();
            int r = RecursiveSum(numbers, numbers.Length - 1);
            lblSum.Text = $"Sum: {r}";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFibonacciInput.Text);
            int r = RecursiveFibonacci(n);
            lblFibonacci.Text = $"Fibonacci({n}): {r}";
        }


    }
}
