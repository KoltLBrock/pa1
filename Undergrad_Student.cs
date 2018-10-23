using System;
using pa;

namespace pa{
    class Undergrad_Student : Student{
        //deals with undergrad students
        string previousHSchool;
        Classification stdClass;
        protected Undergrad_Student(){
            
        }
        protected Undergrad_Student(string stud_name, string birth_date, long student_id, string student_major, float student_gpa,string prev_high_school,Classification std_classification){
            StudName = stud_name;
            DateOfBirth = birth_date;
            StudID = student_id;
            Major = student_major;
            GPA = student_gpa;
            previousHSchool = prev_high_school;
            stdClass = std_classification;
        }
        protected void addStudentInfo(){

        }
        protected void updateStdInfo(){

        }
        protected void displayStdInfo(){
            base.displayStdInfo();
            Console.WriteLine("Previous High School: " + previousHSchool + "\nStudent Level: " + stdClass);
        }
    }
}