﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        private string _name;
        private double _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _name = value;
            }
        }

        public double Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Person()
        {}

        public Person(string name)
        {
            this.Name = name;
        }

        public bool isAdult()
        {
            return _age >= 18;
        }

        public override bool Equals(object obj)
        {
            Person other = (Person) obj;

            if ((decimal)this.Age == (decimal) other.Age && this.Name == other.Name)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }
    } 
}
