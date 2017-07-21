using System;

public class ExamResult
{
    private int grade;
    public int Grade
    {
        get
        {
            return grade;
        }
        private set
        {
            grade = value;

            if (grade < 0)
            {
                throw new ArgumentException("The grade can't be negative.");
            }
        }
    }

    private int minGrade;
    public int MinGrade
    {
        get
        {
            return minGrade;
        }
        private set
        {
            minGrade = value;

            if (minGrade < 0)
            {
                throw new ArgumentException("The minimum grade can't be negative.");
            }
        }
    }

    private int maxGrade;
    public int MaxGrade
    {
        get
        {
            return maxGrade;
        }
        private set
        {
            maxGrade = value;

            if (maxGrade <= minGrade)
            {
                throw new ArgumentException("The maximum grade can't be less or equal to the minimum grade.");
            }
        }
    }

    private string comments;
    public string Comments
    {
        get
        {
            return comments;
        }
        private set
        {
            comments = value;

            if (comments == null || comments.Length == 0)
            {
                throw new NullReferenceException("You should write a comment.");
            }
        }
    }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
