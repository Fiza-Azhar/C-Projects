using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class Angle
    {
        private int Degree;
        private float Minutes;
        private char Direction;
        public int getDegree()
        {
            return Degree;
        }
        public float getMinutes()
        {
            return Minutes;
        }
        public char getDirection()
        {
            return Direction;
        }
        public void SetLat_Degree(int degree)
        {
            if (degree >= 0 && degree <= 90)
            {
                this.Degree = degree;

            }
            else
            {
                this.Degree = 0;
            }
        }
        public void SetLong_Degree(int degree)
        {
            if (degree >= 0 && degree <= 180)
            {
                this.Degree = degree;

            }
            else
            {
                this.Degree = 0;
            }
        }
        public void setMinute(float minutes)
        {
            if (minutes <= 60 && minutes >= 0)
            {
                this.Minutes = minutes;
            }
            else
            {
                this.Minutes = 0;
            }
        }
        public void setLatitudeDirection(char direction)
        {
            if (direction == 'N' || direction == 'n' || direction == 'S' || direction == 's')
            {
                this.Direction = direction;

            }
            else
            {
                this.Direction = ' ';
            }
        }
        public void setLongitudeDirection(char direction)
        {
            if (direction == 'E' || direction == 'W' || direction == 'e' || direction == 'w')
            {
                this.Direction = direction;

            }
            else
            {
                this.Direction = ' ';
            }
        }
        public char getLatitudeDirection()
        {
            return Direction;
        }
        public char getLongitudeDirection()
        {
            return Direction;
        }
        public Angle(string s, int Degree, float Minutes, char Direction)
        {
            if (s == "Latitude")
            {
                SetLong_Degree(Degree);
                setMinute(Minutes);
                setLatitudeDirection(Direction);
            }
            if (s == "Longitude")
            {
                SetLong_Degree(Degree);
                setMinute(Minutes);
                setLongitudeDirection(Direction);
            }
        }

        public void UpdateAngle(string s, int degree, float minute, char direction)
        {
            if (s == "Latitude")
            {
                SetLong_Degree(Degree);
                setMinute(Minutes);
                setLatitudeDirection(Direction);
            }
            if (s == "Longitude")
            {
                SetLong_Degree(Degree);
                setMinute(Minutes);
                setLongitudeDirection(Direction);
            }

        }

    }
}
