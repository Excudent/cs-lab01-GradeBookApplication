using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool weight) : base(name, weight)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            int liczba = Students.Count;
            if(liczba < 5)
            {
                throw new InvalidOperationException();
            }
            {
                if (averageGrade >= 80)
                    return 'A';
                else if (averageGrade >= 60)
                    return 'B';
                else if (averageGrade >= 40)
                    return 'C';
                else if (averageGrade >= 20)
                    return 'D';
                else
                    return 'F';
            }
        }
        public override void CalculateStatistics()
        {
            int liczba = Students.Count;
            if(liczba < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            } else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            int liczba = Students.Count;
            if (liczba < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
            
        }
    }
}
