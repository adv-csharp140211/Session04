using Sesion02.Utils;

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
            var date = DateTime.Now;
            date.ToJalali();

            DateUtil.MiladiToJalai(date);
            DateUtil.ToJalali(date);


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

          
            var result1 = Where(n => n % 2 == 0);
            var result2 = numbers.Where(n => n % 2 == 0); // filter
            var result3 = numbers.Select(n => n % 2 == 0);


            //Linq 
            // 1. query
            // 2. lambda

            //linq -> query
            var result4 = from n in numbers
                          where n % 2 == 0
                          select n;


            var result5 = numbers
                .Where(n => n % 2 == 0)
                .Select( x => x*10);
             
            listBox1.Items.Clear();
            listBox1.Items.AddRange(result5.Cast<object>().ToArray());

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
            var result = Where(x => x % 2 != 0);

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


            Where((int x) => {
                //
                return x > 5;
            });
            Where((int x) => x > 5);
            Where(x => x > 5);

            var result = Where(x => x > 5);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(result.Cast<object>().ToArray());
        }


        private List<int> Where(Func<int, bool> shart)
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

        private List<bool> Select(Func<int, bool> p) //map
        {
            var result = new List<bool>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                result.Add(p(number));
            }

            return result;
        }


    }
}
