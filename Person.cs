using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ListViewHW
{
  class Person : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    private string name;
    public string Name 
    { 
      get => name;
      set { 
        name = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("name"));
      }
    }

    private string surname;
    public string Surname 
    {
      get => surname; 
      set
      {
        surname = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("surname"));
      } 
    }

    private DateTime birthday;
    public DateTime Birthday 
    {
      get => birthday;
      set
      {
        birthday = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("birthday"));
      }
    }

    private int id;
    public int Id 
    { get => id; 
      set
      {
        id = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("id"));
      }
    }

    public static Dictionary<string, Person> people = new Dictionary<string, Person>();

    public static void InitPeople()
    {
      people["Surname1"] = new Person
      {
        Name = "Name1",
        Surname = "Surname1",
        Birthday = new DateTime(2000, 3, 5),
        Id = 1
      };

      people["Surname2"] = new Person 
      {
        Name = "Name2",
        Surname = "Surname2",
        Birthday = new DateTime(1995, 8, 15),
        Id = 2
      };

      people["Surname3"] = new Person 
      { 
        Name = "Name3",
        Surname = "Surname3",
        Birthday = new DateTime(1982, 7, 23),
        Id = 3
      };
    }
  }
}
