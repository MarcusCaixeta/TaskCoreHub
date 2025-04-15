using TaskCoreHub.Core.Entitites;

public class User : BaseEntity
{
    public User(string name, int idEmployee, Guid idTeam, string email, string password)
    {
        Name = name;
        IdEmployee = idEmployee;
        IdTeam = idTeam;
        Email = email;
        Password = password;
    }

    protected User() { }

    public string Name { get; private set; }
    public int IdEmployee { get; private set; }
    public Guid IdTeam { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }  
}
