using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_projekter_Peter
{
    class Company
    {
        private Name _name;
        private List<Employee> _employees;
        private Date _registrationDate;
        
        public Company (Date registration, string name )
        {
            _name = new Name(name, "");
            _registrationDate = registration.Copy();
            _employees = new List<Employee>();

        }


        private Name GetCompanyName()
        {
            return _name;
        }

        private Date GetCompanyRegistration()
        {
            return _registrationDate.Copy();
        }

        public void HireEmployee (Date startDate, char gender, string firstName, string lastName, int status)
        {
            _employees.Add(new Employee(startDate, gender, firstName, lastName, status));
            
        }

        public bool FireEmployee (Employee employee)
        { 
            return _employees.Remove(employee);
        }


        public int GetEmployeeCount ()
        {
            return _employees.Count();
        }


        public int GetEmployeeCountByTenure (int months, Date currentDate)
        {           
            return _employees.FindAll(employee => employee.GetTenureInMonths(currentDate) == months).Count;
        }

        public int GetEmployeeCountByGender(char gender)
        {
            return _employees.FindAll(employee => employee.GetGender() == gender).Count;
        }

        public int GetEmployeeCountByStatus (int status)
        {
            return _employees.FindAll(employee => employee.GetStatus() == status).Count;
        }

        public int GetEmployeeCountByName (Name name)
        {
            return _employees.FindAll(
                employee =>
                employee.GetName().GetFirstName() == name.GetFirstName() &&
                employee.GetName().GetLastName() == name.GetLastName()
                ).Count; 
        }
    }

    class Name
    {
        private string firstName;
        private string lastName;

        public Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public void SetFirstName (string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName (string lastName)
        {
            this.lastName = lastName;
        }

    }
    class Employee
    {
        private Date _startDate;
        private char _gender;
        private Name _name;
        private int _status;
        public Employee(Date startDate, char gender, string firstName, string lastName, int status)
        {
            _startDate = startDate;
            _gender = gender;
            _name = new Name(firstName, lastName);
            _status = status;
        }

        public Employee(Date startDate, char gender, string firstName, string lastName)
        {
            _startDate = startDate;
            _gender = gender;
            _name = new Name(firstName, lastName);
            _status = 0;
        }

        public char GetGender ()
        {
            return _gender;
        }

        public int GetTenureInDays (Date currentDate)
        {
            int totalDays = 0;

            totalDays += currentDate.GetDay() - _startDate.GetDay();
            totalDays += (currentDate.GetMonth() - _startDate.GetMonth()) * (365/12);
            totalDays += (currentDate.GetYear() - _startDate.GetYear()) * 365;

            return totalDays;
        }

        public int GetTenureInMonths (Date currentDate)
        {
            int titalMonths = 0;
            titalMonths += (currentDate.GetMonth() - _startDate.GetMonth());
            titalMonths += (currentDate.GetYear() - _startDate.GetYear()) * 12;
            return titalMonths;
        }


        public int GetTenureInYears (Date currentDate)
        {
            return currentDate.GetYear() - _startDate.GetYear();
        }


        public Date getStartDate ()
        {
            return new Date(_startDate.GetYear(), _startDate.GetMonth(), _startDate.GetDay());
        }

        public int GetStatus ()
        {
            return _status;
        }

        public Name GetName ()
        {
            return _name;
        }

        public void SetStatus (int status)
        {
            _status = status;
        }

    }
    class Date
    {
        private int year;
        private int month;
        private int day;


        public Date(int year,int month,int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }



        public int GetDay()
        {
            return day;
        }

        public int GetMonth()
        {
            return month;
        }

        public int GetYear()
        {
            return year;
        }

        public Date Copy()
        {
            return new Date(year, month, day);
        }
    }
}
