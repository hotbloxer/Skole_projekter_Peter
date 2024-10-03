using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_projekter_Peter
{
    class GradeList
    {
        private readonly Grade[] grade_list;
        int track_Instances = 0;
        int _max_number_of_grades;
        

        public GradeList(int MaxNumbersOfGrades)
        {
            grade_list = new Grade[MaxNumbersOfGrades];
            _max_number_of_grades = MaxNumbersOfGrades;
        }

        public Grade getGrade (int index)
        {
            return grade_list[index];
        }

        public void addGrade (Grade grade)
        {
            if (track_Instances < _max_number_of_grades)
            {
                grade_list[track_Instances] = grade;
                track_Instances++;
            }
            else
            {
                Console.WriteLine("for mange klasse");
            }
            

        }

        public Grade[] getAllGrades ()
        {
            return grade_list;
        }

        public double getAverage ()
        {
            int sum_of_grades = 0;


            foreach (Grade grade in grade_list) 
            {
                sum_of_grades += (Int32) grade.Given_grade;
            }



            return (double)sum_of_grades / grade_list.Length;
        }

        public string toString ()
        {
            return "Gennemsnits karakter: " + getAverage() + 
                "\nAntal karaktere givet: " + getSize();
        }


        public int getSize ()
            {
            return grade_list.Length;
            }


    }
}
