using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Calculator
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Hide();

            LoadingScreen Screen = new LoadingScreen();
            Screen.Show();

            Thread.Sleep(1000);
            Screen.Close();

            Show();
            
        }

        private bool cancelWrite = true;    // Variable used to know whether to delete the number as soon as another one is written or not

        private void Percentual_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(Convert.ToDouble(Result.Text)/100);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
            lastOperation.Text = "";
            lastNum.Text = "";
            cancelWrite = true;
        }

        private void CancelLastDigit_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {

            }
            Result.Text = Result.Text.Remove(Result.Text.Length - 1);
            if(Result.Text == "")
            {
                Result.Text = "0";
            }
        }

        private void Fraction_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(1 / Convert.ToDouble(Result.Text));
        }

        private void Pow_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(Convert.ToDouble(Result.Text)*Convert.ToDouble(Result.Text));
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(Result.Text)));
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {

            switch (lastOperation.Text)
            {
                case "+":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) + Convert.ToDouble(Result.Text));
                    break;
                case "x":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) * Convert.ToDouble(Result.Text));
                    break;
                case "-":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) - Convert.ToDouble(Result.Text));
                    break;
                default:
                    if (lastNum.Text != "")
                    {
                        lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) / Convert.ToDouble(Result.Text));
                    }
                    else
                    {
                        lastNum.Text = Result.Text;
                    }
                    break;
            }

            lastOperation.Text = "÷";
            cancelWrite = true;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true)
            {
                Result.Text = "7";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "7";
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true)
            {
                Result.Text = "8";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "8";
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "9";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "9";
            }
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {

            switch (lastOperation.Text)
            {
                case "+":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) + Convert.ToDouble(Result.Text));
                    break;
                case "-":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) - Convert.ToDouble(Result.Text));
                    break;
                case "÷":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) / Convert.ToDouble(Result.Text));
                    break;
                default:
                    if (lastNum.Text != "")
                    {
                        lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) * Convert.ToDouble(Result.Text));
                    }
                    else
                    {
                        lastNum.Text = Result.Text;
                    }
                    break;
            }

            lastOperation.Text = "x";
            cancelWrite = true;

        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "4";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "4";
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "5";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "5";
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "6";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "6";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

            switch (lastOperation.Text)
            {
                case "+":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) + Convert.ToDouble(Result.Text));
                    break;
                case "x":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) * Convert.ToDouble(Result.Text));
                    break;
                case "÷":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) / Convert.ToDouble(Result.Text));
                    break;
                default:
                    if (lastNum.Text != "")
                    {
                        lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) - Convert.ToDouble(Result.Text));
                    }
                    else
                    {
                        lastNum.Text = Result.Text;
                    }
                    break;
            }

            lastOperation.Text = "-";
            cancelWrite = true;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "1";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "1";
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "2";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "2";
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "3";
                cancelWrite = false;
            }
            else
            {
                Result.Text += "3";
            }
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            switch (lastOperation.Text)
            {
                case "-":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) - Convert.ToDouble(Result.Text));
                    break;
                case "x":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) * Convert.ToDouble(Result.Text));
                    break;
                case "÷":
                    lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) / Convert.ToDouble(Result.Text));
                    break;
                default:
                    if (lastNum.Text != "")
                    {
                        lastNum.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) + Convert.ToDouble(Result.Text));
                        lastOperation.Text = "+";
                    }
                    else
                    {
                        lastNum.Text = Result.Text;
                    }
                    break;
            }

            lastOperation.Text = "+";
            cancelWrite = true;

        }

        private void Negative_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text.Insert(0, "-");
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (cancelWrite == true || Result.Text == "0")
            {
                Result.Text = "0";
                cancelWrite = true;
            }
            else
            {
                Result.Text += "0";
            }
        }

        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += ",";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (lastOperation.Text)
            {
                case "+":
                    Result.Text = Convert.ToString(Convert.ToDouble(Result.Text) + Convert.ToDouble(lastNum.Text));
                    break;
                case "-":
                    Result.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) - Convert.ToDouble(Result.Text));
                    break;
                case "x":
                    Result.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) * Convert.ToDouble(Result.Text));
                    break;
                case "÷":
                    Result.Text = Convert.ToString(Convert.ToDouble(lastNum.Text) / Convert.ToDouble(Result.Text));
                    break;
            }

            lastNum.Text = "";
            lastOperation.Text = "";
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            double n = Convert.ToDouble(Result.Text);
            double num = n;
            
            n--;
            while(n > 0)
            {
                num = num * n;
                n--;
            }


            Result.Text = Convert.ToString(num);
        }

    }
}