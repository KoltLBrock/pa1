using System;
using System.Collections.Generic;
/*
Kolton L Brock
 */
namespace pa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> undergrads = new List<object>(); 
            List<object> grads = new List<object>();
            int runtimeloop = 0;
            int studentcount = 0;
            Console.WriteLine("Enter 1 to add grad student.\nEnter 2 to add undergrad student.\nEnter 3 to list grad students.\nEnter 4 to list undergrad students.\nEnter 5 to exit.");
            while(runtimeloop != 5){
                runtimeloop = 0;
                Console.Write("Enter Command Code:");
                runtimeloop = Convert.ToInt32(Console.ReadLine());
                if(runtimeloop == 1){
                    string stud_name; string birth_date; long student_id; string student_major; float student_gpa;string prev_degree; string prev_uni; string undergrad_major;float undergrad_gpa;
                    Console.Write("Enter name: ");
                    stud_name = Console.ReadLine();
                    Console.Write("Enter Birth Date: ");
                    birth_date = Console.ReadLine();
                    Console.Write("Enter student id: ");
                    student_id = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter student major: ");
                    student_major = Console.ReadLine();
                    Console.Write("Enter student GPA: ");
                    student_gpa = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter previous degree: ");
                    prev_degree = Console.ReadLine();
                    Console.Write("Enter previous university: ");
                    prev_uni = Console.ReadLine();
                    Console.Write("Enter undergrad major: ");
                    undergrad_major = Console.ReadLine();
                    Console.Write("Enter undergrad GPA: ");
                    undergrad_gpa = Convert.ToSingle(Console.ReadLine());
                    Grad_Student grad = new Grad_Student(stud_name,birth_date,student_id,student_major,student_gpa,prev_degree,prev_uni,undergrad_major,undergrad_gpa);
                    grads.Add(grad);
                    studentcount += 1;
                }
                if(runtimeloop == 2){
                    string stud_name; string birth_date; long student_id; string student_major; float student_gpa;string prev_high_school;string std_classification;
                    Console.Write("Enter name: ");
                    stud_name = Console.ReadLine();
                    Console.Write("Enter Birth Date: ");
                    birth_date = Console.ReadLine();
                    Console.Write("Enter student id: ");
                    student_id = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter student major: ");
                    student_major = Console.ReadLine();
                    Console.Write("Enter student GPA: ");
                    student_gpa = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter previous high school: ");
                    prev_high_school = Console.ReadLine();
                    Console.Write("Enter classification: ");
                    std_classification = Console.ReadLine();
                    Undergrad_Student ugrad = new Undergrad_Student(stud_name,birth_date,student_id,student_major,student_gpa,prev_high_school,std_classification);
                    studentcount += 1;
                    undergrads.Add(ugrad);
                }
                if(runtimeloop == 3){
                    foreach(Grad_Student x in grads){
                        x.displayStdInfo();
                    }
                }
                if(runtimeloop == 4){
                    foreach(Undergrad_Student x in undergrads){
                        x.displayStdInfo();
                    }
                }
            }
        }
    }
}
