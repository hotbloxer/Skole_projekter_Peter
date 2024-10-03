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


            grade_list.addGrade(new Grade("dansl", DateTime.Now, "Peter", "Katrine", Grade.gradeValue.TOLV));
            grade_list.addGrade(new Grade("dansl1", DateTime.Now, "Peter1", "Katrine1", Grade.gradeValue.NULTRE));
            grade_list.addGrade(new Grade("dansl2", DateTime.Now, "Peter2", "Katrine2", Grade.gradeValue.MINUSTRE));


            Console.WriteLine(grade_list.toString());
        }
    }
}
