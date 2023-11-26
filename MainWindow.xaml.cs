using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatrice
{
    public partial class MainWindow : Window
    {

        public string history = " ";
        public string result;

        public MainWindow()
        {
            InitializeComponent();
        }

        public bool IfNumberToShowIsInScreen()
        {
            return history.Length <= 23;
        }

        public bool IfLastCharacterIsSpace()
        {
            if (history.Length > 0 && history[history.Length - 1] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowResult()
        {
            string operatorValue;
            bool operatorFinded = false;

            double firstNumber, secondNumber;
            string[] parts = history.Split('+', '-', 'x', '/');
            if (double.TryParse(parts[0], out firstNumber) && double.TryParse(parts[1], out secondNumber))

                foreach (var character in history)
                {
                    switch (character)
                    {
                        case '+':
                            operatorFinded = true;
                            operatorValue = "+";
                            break;
                        case '-':
                            operatorFinded = true;
                            operatorValue = "-";
                            break;
                        case 'x':
                            operatorFinded = true;
                            operatorValue = "*";
                            break;
                        case '/':
                            if (secondNumber != 0)
                            {
                                operatorValue = ":";
                                operatorFinded = true;
                            }
                            else
                            {
                                History.Content = "Impossible de diviser par 0";
                            }
                            break;
                        default:
                            operatorFinded = false;
                            break;
                    }
                    if (operatorFinded)
                    {
                        history = " ";
                        History.Content = "0";



                        result = "..";
                    }
                }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "0";
                History.Content = history;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "1";
                History.Content = history;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "2";
                History.Content = history;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "3";
                History.Content = history;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "4";
                History.Content = history;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "5";
                History.Content = history;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "6";
                History.Content = history;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "7";
                History.Content = history;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "8";
                History.Content = history;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += "9";
                History.Content = history;
            }
        }

        private void Button_Click_dot(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                history += ",";
                History.Content = history;
            }
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                if (!IfLastCharacterIsSpace())
                {
                    history += " + ";
                    History.Content = history;
                }
            }
            ShowResult();
        }

        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                if (!IfLastCharacterIsSpace())
                {
                    history += " - ";
                    History.Content = history;
                }
            }
            ShowResult();
        }

        private void Button_Click_multiply(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                if (!IfLastCharacterIsSpace())
                {
                    history += " x ";
                    History.Content = history;
                }
            }
            ShowResult();
        }

        private void Button_Click_divide(object sender, RoutedEventArgs e)
        {
            if (IfNumberToShowIsInScreen())
            {
                if (!IfLastCharacterIsSpace())
                {
                    history += " / ";
                    History.Content = history;
                }
            }
            ShowResult();
        }

        private void Button_Click_equals(object sender, RoutedEventArgs e)
        {
            ShowResult();
        }

        private void Button_Click_delete(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(history))
            {
                if (history.Length > 1)
                {
                    char charBeforeLast = history[history.Length - 2];

                    if (charBeforeLast == 'x' || charBeforeLast == '+' || charBeforeLast == '-' || charBeforeLast == '/')
                    {
                        history = history.Substring(0, history.Length - 3);
                    }
                    else
                    {
                        history = history.Substring(0, history.Length - 1);
                    }
                    History.Content = history;
                }
                else
                {
                    history = " ";
                    History.Content = 0;
                }
            }
        }

        private void Button_Click_clear(object sender, RoutedEventArgs e)
        {
            history = " ";
            result = "";
            History.Content = "0";
            Result.Content = "0";
        }
    }
}
