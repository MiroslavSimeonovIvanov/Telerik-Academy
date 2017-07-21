using System;

public class CSharpExam : Exam
{
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        private set
        {
            score = value;

            if (score < 0)
            {
                throw new ArgumentException("The score from the exam can't be negative.");
            }
        }
    }

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public override ExamResult Check()
    {
        if (Score < 0 || Score > 100)
        {
            throw new ArgumentException("The score from the exam must be between 0 and 100.");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
