namespace Isu.Exceptions;

public class StudentValidationException : Exception
{
    public StudentValidationException()
        : base("Student validation error")
    {
    }

    public StudentValidationException(string message)
        : base(message)
    {
    }
}