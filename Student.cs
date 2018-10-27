using System;
/*
Kolton L Brock
 */
namespace pa{
    public class Student{
        //generic student class
        protected string StudName;
        protected string DateOfBirth;
        protected long StudID;
        protected string Major;
        protected float GPA;
        protected Student(){
            
        }
        protected Student(string stud_name, string birth_date, long student_id, string student_major, float student_gpa){
            StudName = stud_name;
            DateOfBirth = birth_date;
            StudID = student_id;
            Major = student_major;
            GPA = student_gpa;
        }
        //protected void addStudentInfo(){

        //}
        protected void updateStdInfo(string stud_name, string birth_date, long student_id, string student_major, float student_gpa){
            StudName = stud_name;
            DateOfBirth = birth_date;
            StudID = student_id;
            Major = student_major;
            GPA = student_gpa;
        }
        protected void displayStdInfo(){
            Console.WriteLine("Student Name: " + StudName + "\nDate of Birth: " + DateOfBirth + "\nStudent ID: " + StudID + "\nMajor: " + Major + "\nGPA: " + GPA);
        }
    }
}