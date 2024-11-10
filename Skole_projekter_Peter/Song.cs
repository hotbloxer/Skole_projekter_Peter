using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Skole_projekter_Peter
{
    class Song
    {
        private string artist;
        private string title;
        private Time length;

        public Song (string artist, string title, Time length)
        {
            this.artist = artist;
            this.title = title;
            this.length = length;
        }



        public string GetTitle()
        {
            return title;
        }


        public string GetArtist()
        {
            return artist;

        }


        public Time GetLength()
        {
            return length;
        }


        public override string ToString()
        {
            return "artist: " + artist + " title: " + title + " length: " + length.ToString();
            
        }




    }
    

    class Time
    {
        private int hour;
        private int minute;
        private int second;


        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public Time(int timeInSeconds)
        {
            hour = (int) timeInSeconds / 3600;
            second = (timeInSeconds % 3600) % 60;
            minute = ((timeInSeconds % 3600) % 60) % 60;

        }


        public void Set(int timeInSeconds)      
        {
            hour = (int)timeInSeconds / 3600;
            second = (timeInSeconds % 3600) % 60;
            minute = ((timeInSeconds % 3600) % 60) % 60;
        }

        public void Set(int hour, int minute, int seconds)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = seconds;
        }


        public int GetHour()
        {
            return hour;
        }


        public int  GetMinute()
        {
            return minute;
        }


        public int GetSeconds()
        {
            return second;
        }


        public int GetTimeInSeconds()
        {
            return hour * 3600 + minute *60 + second;
        }


        public override string ToString()
        {
            return hour + ":" + minute + ":" + second;
        }



        public Time Copy()
        {
            return new Time(hour, minute, second);
        }


    }



}
