using Shott.Model;
using Shott.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shott.ViewModel
{
    class MainViewModel : NotifyProperty
    {
        private Coach selectedCoach;
        private Student selectedStudent;
        private Exercise selectedExercise;
        private RelayCommand addStudent;
        private RelayCommand addCoach;
        private RelayCommand addExercise;
        private RelayCommand removeStudent;
        private RelayCommand removeCoach;
        private RelayCommand removeExercise;
        public Coach SelectedCoach
        {
            get { return selectedCoach; }
            set
            {
                selectedCoach = value;
                OnPropertyChanged(nameof(SelectedCoach));
            }
        }
        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }
        public Exercise SelectedExercise
        {
            get => selectedExercise;
            set
            {
                selectedExercise = value;
                OnPropertyChanged(nameof(SelectedExercise));
            }
        }
        
        public RelayCommand AddStudent
        {
            get
            {
                return addStudent ??
                  (addStudent = new RelayCommand(obj =>
                  {
                      Student student = new Student("name", "surname", 18, "adress", new());
                      SelectedCoach.Students.Add(student);
                  }));
            }
        }
        public RelayCommand RemoveStudent
        {
            get
            {
                return removeStudent ??
                  (removeStudent = new RelayCommand(obj =>
                  {
                      SelectedCoach.Students.Remove(SelectedStudent);
                  }, (obj) => SelectedStudent != null));
            }
        }
        public RelayCommand AddCoach
        {
            get
            {
                return addCoach ??
                  (addCoach = new RelayCommand(obj =>
                  {
                      var coach = new Coach("", "", "", new());
                      if (new CoachDiolog(coach).ShowDialog()==true)
                      {
                          Coaches.Add(coach);
                      }
                  }));
            }
        }
        public RelayCommand RemoveCoach
        {
            get
            {
                return removeCoach ??
                  (removeCoach = new RelayCommand(obj =>
                  {
                      Coaches.Remove(SelectedCoach);
                  }, (obj) => SelectedCoach != null));
            }
        }
        public RelayCommand AddExercise
        {
            get
            {
                return addExercise ??
                  (addExercise = new RelayCommand(obj =>
                  {
                      Exercises.Add(new(20,ShotType.rifle));
                  }));
            }
        }
        public RelayCommand RemoveExercise
        {
            get
            {
                return removeExercise ??
                  (removeExercise = new RelayCommand(obj =>
                  {
                      Exercises.Remove(SelectedExercise);
                  }, (obj) => SelectedExercise != null));
            }
        }
        public ObservableCollection<Coach> Coaches { get; set; } = DataBase.Coaches;
        public ObservableCollection<Student> Students { get; set; } = DataBase.Students;
        public ObservableCollection<Exercise> Exercises { get; set; } = DataBase.Exercises;
        public List<ShotType> ShotTypes { get; set; }= new() {ShotType.rifle, ShotType.pistol};

    }
}
