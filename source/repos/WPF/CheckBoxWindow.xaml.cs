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

namespace WPF
{
    /// <summary>
    /// Interaction logic for CheckBoxWindow.xaml
    /// </summary>
    public partial class CheckBoxWindow : Window
    {
        public CheckBoxWindow()
        {
            InitializeComponent();
        }

        private void Lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.OriginalSource is CheckBox)
            {
                lst.SelectedItem = e.OriginalSource;
            }
            if (lst.SelectedItem == null) return;
            txtSelection.Text=string.Format(
                "you choose item at {0}.\r\nChecked state is {1}."),lst.SelectedIndex,((CheckBox)lst.SelectedIndex).IsChecked);
        }
    }
}
