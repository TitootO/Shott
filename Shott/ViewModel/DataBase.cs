using Shott.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shott.ViewModel
{
    public static class DataBase
    {
        public static ObservableCollection<Exercise> Exercises { get; set; } = new()
        {
            new Exercise(20, ShotType.rifle),
            new Exercise(30, ShotType.rifle),
            new Exercise(40, ShotType.rifle),
            new Exercise(60, ShotType.rifle),
            new Exercise(20, ShotType.pistol),
            new Exercise(30, ShotType.pistol),
            new Exercise(40, ShotType.pistol),
            new Exercise(60, ShotType.pistol)
        };
        public static ObservableCollection<Student> Students { get; set; } = new()
        {
            new Student("Константин", "Кузнецов", 18, "пр. Ломоносова, 15", new()
            {
               new Result(Exercises[0], new(){9.8, 10.3, 10.7, 9.9})
            }),
            new Student("Константин", "Миронов", 17, "пл. Ленина, 24", new()),
            new Student("Вера", "Панкратова", 19, " пр. Домодедовская, 98", new()),
            new Student("Максим", "Голубев", 19, "шоссе 1905 года, 30", new()),
            new Student("Руслан", "Смирнов", 19, "пер. Балканская, 72", new()),
        };
        
        public static ObservableCollection<Coach> Coaches { get; set; } = new()
        {
            new Coach("Семён", "Соловьев", "+7(913)794-61-50", new()
            {
                Students[0], Students[1]
            }),
            new Coach("Мария", "Демидова", "+7(913)592-79-44", new()
            {
                Students[2]
            }),
            new Coach("Роман", "Прокофьев", "+7(983)064-88-28", new()
            {
                Students[3], Students[4]
            }),
            new Coach("Александра", "Левина", "+7(983)513-38-82", new()),
            new Coach("Евгения", "Макарова", "+7(913)067-65-99", new()),
        };
    }
}
