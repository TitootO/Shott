using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shott.Model
{
    public class Student : NotifyProperty
    {
        private string name;
        private string surname;
        private int age;
        private string adress;
        private ObservableCollection<Result> results;

        public Student(string name, string surname, int age, string adress, ObservableCollection<Result> results)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.adress = adress;
            this.results = results;
        }

        public string Name 
        { 
            get { return name; } 
            set 
            { 
                name = value;
                OnPropertyChanged("Name");
            } 
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public string Adress
        {
            get { return adress; }
            set
            {
                adress = value;
                OnPropertyChanged("Adress");
            }
        }
        public ObservableCollection<Result> Results
        {
            get { return results; }
            set
            {
                results = value;
                OnPropertyChanged("Results");
            }
        }
    }
}
