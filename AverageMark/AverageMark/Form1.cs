using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double oBel, oMath, oPhysic, oFl, oInformatika, oBio;
        List<Student> students = new List<Student>();
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            oBel = double.Parse(textBoxBel.Text);
            oMath = double.Parse(textBoxMath.Text);
            oPhysic = double.Parse(textBoxPhysic.Text);
            oFl = double.Parse(textBoxForeign.Text);
            oInformatika = double.Parse(textBoxInformatics.Text);
            oBio = double.Parse(textBoxBio.Text);
            double averageMark = (oBel + oMath + oPhysic + oFl + oInformatika + oBio) / 6;
            labelAverage.Text = averageMark.ToString();

   
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            Student student = new Student(textBoxName.Text, int.Parse(textBox2.Text),int.Parse(textBoxClas.Text), oBel, oFl, oMath, oInformatika, oPhysic, oBio, double.Parse(labelAverage.Text));
            students.Add(student);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            foreach  (Student student in students)
            {
                if(student.Number == int.Parse(textBox2.Text) && student.Clas == int.Parse(textBoxClas.Text))
                {
                    
                    textBoxName.Text = student.Name;
                    textBoxBel.Text = student.OcenkaBel.ToString();
                    textBoxMath.Text = student.OcenkaMath.ToString();
                    textBoxInformatics.Text = student.OcenkaInformatika.ToString();
                    textBoxForeign.Text = student.OcenkaFL.ToString();
                    textBoxPhysic.Text = student.OcenkaFizika.ToString();
                    textBoxBio.Text = student.OcenkaBio.ToString();
                    labelAverage.Text = student.AverageMark.ToString();

                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxClas.Clear();
            textBox2.Clear();
            textBoxName.Clear();
            textBoxBel.Clear();
            textBoxMath.Clear();
            textBoxPhysic.Clear();
            textBoxBio.Clear();
            textBoxForeign.Clear();
            textBoxInformatics.Clear();
            labelAverage.Text = "";
        }

        
    }
}
