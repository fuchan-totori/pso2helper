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
using System.Xml.Linq;

namespace pso2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Data hoge = new Data();
            textBox.DataContext = hoge;

            //List<Ability> ablist = new List<Ability>();
            //Ability test = new Ability(500);
            //ablist.Add(test);
            //textBox.DataContext = ablist[0].Code;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var win = new Window1();
            win.Show();
        }
    }
}
