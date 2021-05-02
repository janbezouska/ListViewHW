using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ListViewHW
{
  public class Person : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    private string name;
    public string Name 
    { 
      get => name;
      set { 
        name = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
      }
    }

    private string surname;
    public string Surname 
    {
      get => surname; 
      set
      {
        surname = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
      } 
    }

    private DateTime birthday;
    public DateTime Birthday
    {
      get => birthday;
      set
      {
        birthday = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Birthday)));
      }
    }

    private int id;
    public int Id 
    { get => id; 
      set
      {
        id = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
      }
    }

    public static ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

    public static void InitPeople()
    {
      People.Add(new Person
      {
        Name = "Name1",
        Surname = "Surname1",
        Birthday = new DateTime(2000, 3, 5),
        Id = 1
      });

      People.Add(new Person 
      {
        Name = "Name2",
        Surname = "Surname2",
        Birthday = new DateTime(1995, 8, 15),
        Id = 2
      });

      People.Add(new Person 
      { 
        Name = "Name3",
        Surname = "Surname3",
        Birthday = new DateTime(1982, 7, 23),
        Id = 3
      });
    }
  }
}
