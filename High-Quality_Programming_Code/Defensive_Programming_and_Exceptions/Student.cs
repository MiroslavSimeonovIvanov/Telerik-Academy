using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;

            if (firstName == null || firstName.Length == 0)
            {
                throw new ArgumentException("Invalid first name!");
            }
        }
    }

    private string lastName;
    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            lastName = value;

            if (lastName == null || lastName.Length == 0)
            {
                throw new ArgumentException("Invalid last name!");
            }
        }
    }

    private IList<Exam> exams;
    public IList<Exam> Exams
    {
        get
        {
            return exams;
        }
        set
        {
            exams = value;

            if (exams == null || exams.Count == 0)
            {
                throw new ArgumentException("The student has no exams!");
            }
        }
    }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();

        for (int index = 0; index < this.Exams.Count; index++)
        {
            results.Add(this.Exams[index].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();

        for (int index = 0; index < examResults.Count; index++)
        {
            examScore[index] =
                ((double)examResults[index].Grade - examResults[index].MinGrade) /
                (examResults[index].MaxGrade - examResults[index].MinGrade);
        }

        return examScore.Average();
    }
}
