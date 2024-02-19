using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //var result = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    var number = numbers[i];
            //    if (number % 2 == 0)
            //    {
            //        result.Add(number);
            //    }
            //}

            //listBox1.Items.Clear();
            //foreach (var number in result)
            //{
            //    listBox1.Items.Add(number.ToString());
            //}


            //Xyz((int number) => number % 2 == 0);
            //Xyz((number) => number % 2 == 0);
            //Xyz(number => number % 2 == 0);

            //lambda express
            //lazy

            var result = Xyz(n => n % 2 == 0);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(result.Cast<object>().ToArray());

        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            //var result = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    var number = numbers[i];
            //    if (number % 2 != 0)
            //    {
            //        result.Add(number);
            //    }
            //}

            //listBox1.Items.Clear();
            //foreach (var number in result)
            //{
            //    listBox1.Items.Add(number.ToString());
            //}
            var result = Xyz(x => x % 2 != 0);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(result.Cast<object>().ToArray());
        }

        private void buttonGT5_Click(object sender, EventArgs e)
        {
            //var result = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    var number = numbers[i];
            //    if (number > 5)
            //    {
            //        result.Add(number);
            //    }
            //}

            //listBox1.Items.Clear();
            //foreach (var number in result)
            //{
            //    listBox1.Items.Add(number.ToString());
            //}


            Xyz((int x) => {
                //
                return x > 5;
            });
            Xyz((int x) => x > 5);
            Xyz(x => x > 5);

            var result = Xyz(x => x > 5);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(result.Cast<object>().ToArray());
        }


        private List<int> Xyz(Func<int, bool> shart)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (shart(number))
                {
                    result.Add(number);
                }
            }

            return result;           
        }

        
    }
}
