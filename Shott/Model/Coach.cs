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
    public class Coach : NotifyProperty
    {
        private string name;
        private string surname;
        private string phone;
        private ObservableCollection<Student> students;

        public Coach(string name, string surname, string phone, ObservableCollection<Student> students)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.students = students;
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
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
                OnPropertyChanged("Students");
            }
        }
        public override string ToString()
        {
            return $"{Surname} {Name} {Phone}";
        }
    }
}
