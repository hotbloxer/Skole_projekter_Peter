using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_projekter_Peter
{
    class TestClass
    {
        static void Main(string[] args)
        {
            GradeList grade_list = new GradeList(3);


            grade_list.addGrade(new Grade("dansk", DateTime.Now, "Lærer 1", "Lærer 4", Grade.gradeValue.TOLV));
            grade_list.addGrade(new Grade("Matematik", DateTime.Now, "Lærer 2", "Lærer 1", Grade.gradeValue.NULTRE));
            grade_list.addGrade(new Grade("Fysik", DateTime.Now, "Lærer 1", "Lærer 3", Grade.gradeValue.MINUSTRE));


            Console.WriteLine(grade_list.toString());
        }
    }
}
