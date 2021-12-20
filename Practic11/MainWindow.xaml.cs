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
using System.Text.RegularExpressions;

namespace Practic11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Rez_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            Regex regex = new Regex("a(b{1,2})a");
            string line = "aa aba abba abbba abbbba abbbbba";
            theLine.Text = line;
            MatchCollection matchCollection = regex.Matches(line);
            object[] array = new object[matchCollection.Count];
            matchCollection.CopyTo(array, 0);
            for (int i = 0; i < matchCollection.Count; i++)
            {
                listBox.Items.Add(matchCollection[i]);
            }
        }

        private void Exite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Потапкин. Задание:Дана строка 'aa aba abba abbba abbbba abbbbba'. Напишите регулярное выражение,которое найдет строки вида aba, в которых 'b' встречается менее 3 - х раз(включительно).Дана строка '23 2+3 2++3 2+++3 345 567'. Напишите регулярное выражение,которое найдет строки 2 + 3, 2++3, 2++ + 3, не захватив остальные(+может быть любое количество). ");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            Regex regex = new Regex("2([+]{1,3})3");
            string line1 = "23 2+3 2++3 2+++3 345 567";
            theLine1.Text = line1;
            MatchCollection matchCollection = regex.Matches(line1);
            object[] array = new object[matchCollection.Count];
            matchCollection.CopyTo(array, 0);
            for (int i = 0; i < matchCollection.Count; i++)
            {
                listBox1.Items.Add(matchCollection[i]);
            }
        }
    }
}
