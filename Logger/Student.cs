namespace Logger;

public record Student(FullName fullName) : Person(fullName)
{
    // All interface members are implicit because Person handles their implementation.
}