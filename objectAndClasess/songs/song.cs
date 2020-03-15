using System;
using System.Collections.Generic;
using System.Text;

namespace songs1
{
    class song
    {
        public song (string typeList, string name, string duration)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Duration = duration;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
    }
}
