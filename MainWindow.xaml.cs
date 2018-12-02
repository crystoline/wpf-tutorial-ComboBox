using System.Collections.Generic;
using System.Windows.Media;

namespace WpfCombobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

      
            Colors.ItemsSource = typeof (Colors).GetProperties();
        }

    }

    
}