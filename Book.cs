using System.Collections.Generic;

namespace intro_to_csharp
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        private List<double> grades;
        private string name;
    }
}