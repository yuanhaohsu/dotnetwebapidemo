namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public string UserName { get; set; }

//#33
// dotnet ef migrations add UserPasswordAdded 
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}
