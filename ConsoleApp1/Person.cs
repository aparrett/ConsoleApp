﻿using System;

namespace ConsoleApp1
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    }
}