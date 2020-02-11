using System;
using System.Collections.Generic;

namespace Lesson5___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Doe");
            Student student2 = new Student("Jane", "Deen");
            Student student3 = new Student("Jack", "Black");
            Course englishCourse = new Course("English");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            EnrollStudentsToCourse(students, englishCourse);

            float[] grades = { 9, 8, 7, 7, 9, 8, 10 };
            List<float> englishGradesOfStudent1 = new List<float>(grades);
            student1.AddGradesToCourse(englishGradesOfStudent1, englishCourse);
            float avgGrade = student1.CalculateAverageGrade(englishCourse);
            Console.WriteLine($"Average grade: { avgGrade }");
        }

        static void EnrollStudentsToCourse(List<Student> students, Course course)
        {
            foreach (var student in students)
            {
                student.Enroll(course);
            }
        }
    }
}

class Student
{
    string firstName;
    string lastName;
    List<Course> courses;
    Dictionary<Course, List<float>> grades;
    public void Enroll(Course course)
    {
        courses.Add(course);
        List<float> courseGrades = new List<float>();
        grades.Add(course, courseGrades);
    }

    public void AddGradesToCourse(List<float> courseGrades, Course course)
    {
        if (IsEnrolled(course))
        {
            grades[course] = courseGrades;
        }
        else
        {
            Console.WriteLine("This student is not enrolled to this course");
        }
    }

    public float CalculateAverageGrade(Course course)
    {
        if (IsEnrolled(course))
        {
            return CalcAvgGrade(grades[course]);
        }
        else
        {
            Console.WriteLine("This student is not enrolled to this course");
            return 0;
        }
    }

    private bool IsEnrolled(Course course)
    {
        if (grades.ContainsKey(course))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private float CalcAvgGrade(List<float> grades)
    {
        float avg = 0;
        foreach (var grade in grades)
        {
            avg += grade;
        }
        return avg / grades.Count;
    }

    public Student(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        courses = new List<Course>();
        grades = new Dictionary<Course, List<float>>();
    }
}

class Course
{
    string name;

    public Course(string name)
    {
        this.name = name;
    }
}
