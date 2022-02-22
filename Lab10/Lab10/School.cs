using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class School
    {
        public List<Student> Students = new();

        public School()
        {
            Array values = Enum.GetValues(typeof(EPosition));
            Random random = new Random();

            for (int i = 1; i <= 50000; i++)
            {
                Students.Add(new Student()
                {
                    Number = i,
                    CountPhone = random.Next(1, 15),
                    CountLunch = random.Next(1, 6),
                    Position = (EPosition)values.GetValue(random.Next(values.Length))
                });
            }
        }

        public (Student, Student) FindMinMaxEmployee()
        {
            List<Student> sorted = Students.OrderBy(x => x.CountPhone).ThenBy(x => x.Position).ToList();
            return (sorted.First(), sorted.Last());
        }

        public void Reward((Student, Student) st)
        {
            st.Item2.CountLunch += st.Item1.CountLunch;
            st.Item1.CountLunch = 0;
        }
    }
}
