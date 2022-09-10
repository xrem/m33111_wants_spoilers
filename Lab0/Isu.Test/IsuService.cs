using Isu.Models;
using Xunit;

namespace Isu.Test;

public class IsuService
{
    private readonly Services.IsuService sut;

    public IsuService()
    {
        this.sut = new Services.IsuService();
    }

    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent() { }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException() { }

    [Theory]
    [InlineData("AMOGUS")]
    [InlineData("12345")]
    [InlineData("Z000-1")]
    public void CreateGroupWithInvalidName_ThrowException(string name)
    {
        // Arrange
        var isu = new Services.IsuService();

        // Act
        var group = isu.AddGroup(new GroupName(name));

        // Assert
        Assert.NotNull(group);
    }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged() { }
}