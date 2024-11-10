using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Skole_projekter_Peter
{
    internal class Job
    {

        private string title;
        private double salary;
        private Person employee;
        private bool isAvailable;

        

        public Job(string title, double salary, Person employee)
        {
            this.title = title;
            this.salary = salary;
            this.employee = employee;

        }


        public Job()
        {
            this.title = title;
            this.salary = salary;
        }

        public string getTitle()
        {
            return title;
        }

        public double getSalary() { return salary; }

        public Person getEmployee() { return employee; }

        public bool IsAvailable() { return isAvailable; }

        public void hire(Person employee)
        {
            this.employee = employee;

        }

        public void fire()
        {
            employee = new Person(new Name());
        }

        public void setSalay(double salary)
        {

        }



    }



}


class Person
{
    private char gender;
    private int age;
    private Name name;
    private DateTime birthday;


    public Person(Name name, DateTime birthday, char gender)
    {
        this.gender = gender;

    }

    public Person(Name name, DateTime birthday)
    {

    }

    public Person(Name name)
    {

    }

    public Name GetName()

    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public char GetGender()
    {
        return gender;
    }

    public DateTime GetBirthday()
    {
        return birthday;
    }

    public void SetName(Name name)
    {
        this.name = name;
    }

    public void SetGender(char gender)
    {
        this.gender = gender;
    }


}


class Name
{
    private string name = "";


}



class MyDate
{
    private int day;
    private int month;
    private int year;
    string[] monthNames = ["januar", "februar", "marts", "april", "maj", "juni", "juli", "august", "september", "oktober", "november", "december"];



    MyDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    MyDate()
    {

    }

    public int getDay()
    {
        return day;
    }

    public int getMonth()
    {
        return month;
    }

    public int getYear()
    {
        return year;
    }


    public string getMonthName(int month)
    {

        return monthNames[month + 1];
    }

    public void setDay(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public bool isLeapYear()
    {
        return (year % 4 == 0);
    }

    public void stepForwardOneDay()
    {
        day++;
        //ToDo implement overflow into next month
    }

    public void stepForward(int days)
    {
        day = +days;
    }

    public int numberOfDaysInMonth()
    {
        return 42;
    }

    public int yearsBetween(int year1, int year2)
    {


        if (year1 < year2)
        {
            return year2 - year1;
        }

        return year1 - year2;
    }


    public bool isBefore(MyDate date)
    {
        if (date.year > year)
        {
            return true;
        }

        else if (date.month > month)
        {
            return true;
        }

        else if (date.day > day)
        {
            return true;
        }

        else { return false; }
    }

    public MyDate copy()
    {
        return new MyDate(year, month, day);
    }

    public bool equals(int year, int month, int day)
    {
        if (this.year == year
            &&
            this.month == month
            &&
            this.day == day
            )
        {
            return true;
        }

        return false;
    }

    public string ToString()
    {
        return year + "/" + month + "/" + day;
    }

    public string convertToMonthNumber(string monthName)
    {
        foreach (string name in monthNames)
        {
            if (name == monthName)
            {
                return name;
            }
        }
        return "name not reconqnized";

    }
}