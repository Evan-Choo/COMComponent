using ComComponent.Properties;
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

namespace COM
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(add1.Text.Trim());
            int b = Int32.Parse(add2.Text.Trim());

            MyClass myClass = new MyClass();
            int result = myClass.add(a, b);
            addresult.Clear();
            addresult.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(mul1.Text.Trim());
            int b = Int32.Parse(mul2.Text.Trim());

            MyClass myClass = new MyClass();
            int result = myClass.multi(a, b);
            mulresult.Clear();
            mulresult.Text = result.ToString();
        }
    }
}
