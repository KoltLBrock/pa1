using System;
using pa;

namespace pa{
    class Grad_Student : Student{
        //deals with grad students
        protected string previousDegree;
        protected string previousUniversity;
        protected string undergradMajor;
        protected float undergradGPA;
        protected Grad_Student(string stud_name, string birth_date, long student_id, string student_major, float student_gpa,string prev_degree, string prev_uni, string undergrad_major,float undergrad_gpa){
            StudName = stud_name;
            DateOfBirth = birth_date;
            StudID = student_id;
            Major = student_major;
            GPA = student_gpa;
            previousDegree = prev_degree;
            previousUniversity = prev_uni;
            undergradMajor = undergrad_major;
            undergradGPA = undergrad_gpa;
        }
        protected void addStudentInfo(){

        }
        protected void updateStdInfo(){

        }
        protected void displayStdInfo(){
            base.displayStdInfo();
            Console.WriteLine("Previous Degree: " + previousDegree + "\nPrevious University: " + previousUniversity + "\nUndergrad Major: " + undergradMajor + "\nUndergrad GPA" + undergradGPA);
        }
    }
}