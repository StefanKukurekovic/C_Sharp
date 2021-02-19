using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            GenerateDemoData();
        }

        public ObservableCollection<Person> PersonData { get; set; }

        private void GenerateDemoData()
        {
            PersonData = new ObservableCollection<Person>();
            PersonData.Add(new Person("Marko", "Dimytriew", 25, new Address("Russian Alle", "Moscow")));
            PersonData.Add(new Person("Hello", "Baby", 4, new Address("Baby-street", "Babyvill")));
            PersonData.Add(new Person("John", "Ljuba", 33, new Address("Catgasse", "Katzendorf")));
            PersonData.Add(new Person("Jane", "Smith", 20, new Address("Talstrasse", "Innsbruck")));
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
