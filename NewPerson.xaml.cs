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

namespace ListViewHW
{
  /// <summary>
  /// Interaction logic for NewPerson.xaml
  /// </summary>
  public partial class NewPerson : Window
  {
    public bool Update { get; set; }

    public NewPerson()
    {
      Update = false;
      InitializeComponent();
      DataContext = new Person();
    }

    public NewPerson(Person person)
    {
      Update = true;
      InitializeComponent();
      DataContext = person;
    }

    private void NewPerBut_Click(object sender, RoutedEventArgs e)
    {
      if (!Update)
        Person.People.Add((Person)DataContext);
    }
  }
}
