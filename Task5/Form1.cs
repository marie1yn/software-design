namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] BubbleSort(int[] num)
        {
            int n = num.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            return num;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] num = { 3, 1, 5, 2, 4 };
            int[] sorted = BubbleSort(num);
            listBoxResult.DataSource = sorted;
        }
    }
}
