using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Shott.Model
{
    public class Result : NotifyProperty
    {
        private Exercise exercise;
        private List<double> shots;

        public Result(Exercise exercise, List<double> shots)
        {
            this.exercise = exercise;
            this.Shots = shots;
        }

        public double ShotsTotal { get; set; }
        public int CenterShotCount { get; set; }
        public Exercise Exercise
        {
            get { return exercise; }
            set
            {
                exercise = value;
                OnPropertyChanged("Exercise");
            }
        }
        public List<double> Shots
        {
            get { return shots; }
            set
            {
                shots = value;
                ShotsTotal = 0;
                CenterShotCount = 0;
                foreach (var item in shots)
                {
                    ShotsTotal += item;
                    if(item >= 10.2)
                    {
                        CenterShotCount++;
                    }
                }

                OnPropertyChanged("Shots");
                OnPropertyChanged("ShotsTotal");
                OnPropertyChanged("CenterShotCount");
            }
        }
    }
}
