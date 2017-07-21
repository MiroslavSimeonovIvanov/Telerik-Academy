using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;
    public int ProblemsSolved
    {
        get
        {
            return problemsSolved;
        }
        private set
        {
            problemsSolved = value;

            if (problemsSolved < 0)
            {
                throw new ArgumentException("The solved problems can't be negative.");
            }

            if (problemsSolved > 10)
            {
                throw new ArgumentException("The solved problems can't be more than 10.");
            }
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: good.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Excellent result: well done.");
        }

        return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
    }
}
