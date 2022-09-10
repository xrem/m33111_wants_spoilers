using Isu.Entities;
using Isu.Models;

namespace Isu.Services;

public class IsuService : IIsuService
{
    private int nextId = 100000;
    private Dictionary<string, List<Student>> studentsByGroupName;

    public IsuService()
    {
        studentsByGroupName = new Dictionary<string, List<Student>>();
    }

    public Group AddGroup(GroupName name)
    {
        throw new NotImplementedException();
    }

    public Student AddStudent(Group group, string name)
    {
        EnsureGroupIsValid(group);

        var currentStudentId = nextId++;
        var student = new Student(currentStudentId, name);

        throw new NotImplementedException();
    }

    private void EnsureGroupIsValid(Group group)
    {
        if (group is null)
        {
            throw new Exception("Group is not valid");
        }
    }

    public Student GetStudent(int id)
    {
        return studentsByGroupName
                   .Values
                   .SelectMany(x => x)
                   .SingleOrDefault(student => student.Id == id)
               ?? throw new Exception($"Student with {id} not found")
    }

    public Student FindStudent(int id)
    {
        try
        {
            return GetStudent(id);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public IEnumerable<Student> FindStudents(GroupName groupName)
    {
        if (studentsByGroupName.TryGetValue(
                groupName.Value,
                out List<Student> result))
        {
            return result;
        }

        return Enumerable.Empty<Student>();
    }

    public List<Student> FindStudents(CourseNumber courseNumber)
    {
        throw new NotImplementedException();
    }

    public Group FindGroup(GroupName groupName)
    {
        throw new NotImplementedException();
    }

    public List<Group> FindGroups(CourseNumber courseNumber)
    {
        throw new NotImplementedException();
    }

    public void ChangeStudentGroup(Student student, Group newGroup)
    {
        throw new NotImplementedException();
    }
}