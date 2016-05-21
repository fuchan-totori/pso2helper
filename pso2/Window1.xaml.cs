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
using System.Windows.Shapes;
using System.Xml.Linq;
using System.IO;

namespace pso2
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void bsubmit_Click(object sender, RoutedEventArgs e)
        {
            Ability ab = new Ability();
            ab.Code = int.Parse(tcode.Text);
            ab.Name = tability.Text;
            ab.Power = byte.Parse(tpower.Text);

            //try
            //{
            //    var xdoc = XDocument.Load(@"..\..\..\ability.xml");
            //}
            //catch(FileNotFoundException exp)
            //{
            //    MessageBoxResult result = MessageBox.Show("ファイルが見つかりません．", "Error",
            //                                              MessageBoxButton.OK,
            //                                              MessageBoxImage.Warning);
            //}
            this.Close();
        }
    }
}
