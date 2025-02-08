namespace lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public int[] ProceduralSort(int[] num)
		{
			Array.Sort(num);
			return num;
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			int[] num = { 3, 1, 5, 2, 4 };
			int[] sorted = ProceduralSort((int[])num);
			listBoxResult.DataSource = sorted;
		}
	}
}
