namespace App04
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>() { 2, 5, 6, 7, 9, 10, 12, 13 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }

            listBox1.Items.Clear();
            foreach (var number in result)
            {
                listBox1.Items.Add(number.ToString());
            }

        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (number % 2 != 0)
                {
                    result.Add(number);
                }
            }

            listBox1.Items.Clear();
            foreach (var number in result)
            {
                listBox1.Items.Add(number.ToString());
            }
        }

        private void buttonGT5_Click(object sender, EventArgs e)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (number > 5)
                {
                    result.Add(number);
                }
            }

            listBox1.Items.Clear();
            foreach (var number in result)
            {
                listBox1.Items.Add(number.ToString());
            }
        }


        private void Xyz(Func<int, bool> predicate)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (predicate(number))
                {
                    result.Add(number);
                }
            }

            listBox1.Items.Clear();
            foreach (var number in result)
            {
                listBox1.Items.Add(number.ToString());
            }
        }
    }
}
