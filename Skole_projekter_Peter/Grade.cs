using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Skole_projekter_Peter.Grade;

namespace Skole_projekter_Peter
{
    internal class Grade 
        (
        string topic, 
        DateTime date, 
        string teacher, 
        string examinor,
        gradeValue given_grade
        )
    {

        public enum gradeValue { MINUSTRE = -3, NUL = 0, NULTRE = 3, SYV = 7, TI = 10, TOLV = 12 }

        private string _topic = topic;
        private DateTime _date = date;
        private string _teacher = teacher;
        private string _examinor = examinor;
        private gradeValue _given_grade = given_grade;

        public string Topic { get => _topic; }
        public DateTime Date { get => _date;  }
        public string Teacher { get => _teacher;  }
        public string Examinor { get => _examinor;   }
        public gradeValue Given_grade { get => _given_grade;  }
    }
}
