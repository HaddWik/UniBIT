using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new List<Student>();

        while (true)
        {
            Console.WriteLine("Въведете данни за студента (Използвайте фразата 'Край' за резултат)");
            Console.Write("Студент: ");
            var semesters = new List<Semester>();
            var studentName = Console.ReadLine();

            if (studentName == "Край")
                break;

            var dataArr = Console.ReadLine().Split("; ").ToList();

            foreach (var subject in dataArr)
            {
                bool stopCycle = false;
                var splittedSubjects = subject.Split(", ");

                var semesterNumber = int.Parse(splittedSubjects[0]);
                var lectureHours = int.Parse(splittedSubjects[2]);
                var exerciseHours = int.Parse(splittedSubjects[3]);
                var grade = double.Parse(splittedSubjects[5]);
                var totalHours = lectureHours + exerciseHours;

                if (semesters.Count == 0)
                {
                    var currentSemester = new Semester(semesterNumber, totalHours, grade);
                    semesters.Add(currentSemester);
                }
                else
                {
                    foreach (var semester in semesters)
                    {
                        if (semester.SemesterNumber == semesterNumber)
                        {
                            semester.AddSubject(totalHours, grade);
                            stopCycle = true;
                        }
                    }

                    if (stopCycle)
                        continue;
                    else
                    {
                        var currentSemester = new Semester(semesterNumber, totalHours, grade);
                        semesters.Add(currentSemester);
                    }
                }
            }

            var studentBook = new StudentBook(semesters);
            var student = new Student(studentName, studentBook);
            students.Add(student);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

        foreach (var student in students)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(student);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
        }
    }
}
