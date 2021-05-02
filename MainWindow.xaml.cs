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

namespace ListViewHW
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      Person.InitPeople();
      lvPeople.DataContext = Person.People;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      lvPeople.SelectedIndex = 0;
    }

    private void lvPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      Person person = (Person)(sender as ListView).SelectedItem;
      DataContext = person;
    }

    private void lvPeople_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      Person person = (Person)(sender as ListView).SelectedItem;
      NewPerson np = new NewPerson(person);
      np.ShowDialog();
    }

    private void AddBut_Click(object sender, RoutedEventArgs e)
    {
      NewPerson np = new NewPerson();
      np.ShowDialog();
    }
  }
}
