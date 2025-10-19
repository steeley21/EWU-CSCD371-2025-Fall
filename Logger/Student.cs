namespace Logger;

public record Student : Person
{
    public required string StudentId { get; set; }

    public Student(FullName fullName, string studentId) : base(fullName)
    {
        StudentId = studentId;
    }
    public override string Name
    {
        // Implicit implementation because Name getter should be publically available via Student Instance
        get
        {
            return $"{PersonDisplayName} (ID: {StudentId})";
        }
    }

    public virtual bool Equals(Student? obj)
    {
        if (obj is not Student otherStudent)
        {
            return false;
        }

        return this.StudentId == otherStudent.StudentId && this.FullName.Equals(otherStudent.FullName);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FullName, StudentId);
    }
}