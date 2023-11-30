using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shott.Model
{
    public enum ShotType
    {
        rifle,
        pistol
    }
    public class Exercise : NotifyProperty
    {
        private int shotCount;
        private ShotType type;

        public Exercise(int shotCount, ShotType type)
        {
            this.shotCount = shotCount;
            this.type = type;
        }
        public override string ToString()
        {
            if (type == ShotType.pistol)
                return "ПП-" + ShotCount.ToString();
            if (type == ShotType.rifle)
                return "ВП-" + ShotCount.ToString();
            return ShotCount.ToString();
        }

        public int ShotCount
        {
            get { return shotCount; }
            set
            {
                shotCount = value;
                OnPropertyChanged("ShotCount");
            }
        }
        public ShotType Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
    }

}
