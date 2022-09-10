using Isu.Exceptions;

namespace Isu.Entities;

public class Student
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public Student(int id, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Name is not valid");
        }

        if (id <= 0)
        {
            throw new StudentValidationException("Id must be > 0");
        }

        Id = id;
        Name = name;
    }
}