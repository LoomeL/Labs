using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    struct Student
    {
        public EPosition Position { get; set; }
        public int Number { get; set; }
        public int CountLunch { get; set; }
        public int CountPhone { get; set; }
    }

    enum EPosition
    {
        HSStudent,
        ESStudent,
        PreSchool
    }
}
