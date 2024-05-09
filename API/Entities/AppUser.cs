using System;
using System.Collections.Generic;
using API.Extensions;


namespace API.Entities;
{
public class AppUser
{
    public int Id { get; set; }

    // [Required] #38 dotnet ef migration add UsernameRequired
    public string UserName { get; set; }

//#33
// dotnet ef migrations add UserPasswordAdded
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }

//#84
    public DataOnly DateOfBirth { get; set; }
    public string KnownAs { get; set; }
    public DataTime Created { get; set; } = DataTime.UtcNow;
    public DataTime LastActive { get; set; } = DataTime.UtcNow;
    public string Gender { get; set; }
    public string Introduction { get; set; }
    public string LookingFor { get; set; }
    public string Interests { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public List <Photo> Photos { get; set; } = new();

    //85
    //public int GetAge()
    //{
    //    return DateOfBirth.CalcuatedAge();
    //}

    //#97
    

}
}
