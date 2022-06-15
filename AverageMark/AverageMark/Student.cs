using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMark
{
    public class Student
    {
        private string name;
        private int number;
        private int clas;
        private double ocenkaBel;
        private double ocenkaFL;
        private double ocenkaMath;
        private double ocenkaInformatika;
        private double ocenkaFizika;
        private double ocenkaBio;
        private double averageMark;
        
        public Student(string name, int number, int clas, double ocenkaBel, double ocenkaFl, double ocenkaMath, double ocenkaInformatika, double ocenkaFizika, double ocenkaBio, double averageMark)
        {
            this.name = name;
            this.number = number;
            this.clas = clas;
            this.ocenkaBel = ocenkaBel;
            this.ocenkaFL = ocenkaFl;
            this.ocenkaMath = ocenkaMath;
            this.ocenkaInformatika = ocenkaInformatika;
            this.ocenkaFizika = ocenkaFizika;
            this.ocenkaBio = ocenkaBio;
            this.averageMark = averageMark;
        }
        public string Name
        {
            get { return this.name; }
        }
        public int Number
        {
            get { return this.number; }
        }
        public int Clas
        {
            get { return this.clas;}
        }
        public double OcenkaBel
        {
            get { return this.ocenkaBel; }
        }
        public double OcenkaFL
        {
            get { return this.ocenkaFL; }
        }
        public double OcenkaMath
        {
            get { return this.ocenkaMath; }
        }
        public double OcenkaInformatika
        {
            get { return this.ocenkaInformatika; }
        }
        public double OcenkaFizika
        {
            get { return this.ocenkaFizika; }
        }
        public double OcenkaBio
        {
            get { return this.ocenkaBio; }
        }
        public double AverageMark
        {
            get { return this.averageMark; }
        }

    }
}
