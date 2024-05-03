02/05/2024_Section 3
-- Adding 
#33
Disable Hot Reload:
Add new enetities: \API\Entities\AppUser.cs
dotnet ef migrations add UserPasswordAdded 
#34 
Creat BaseApiController at \dotnetwebapidemo-master\API\Controllers\BaseApiController.cs
#35
Create AccountController.cs at \dotnetwebapidemo-master\API\Controllers\AccountController.cs
#36 
Check debugging 

#37
Create new folder in API "DTOs" then create ResgisterDto.cs

#38 
in /API/Enities/AppUser.cs added [Required]:
- dotnet ef migration add UsernameRequired  //not necessary 
- dotnet ef migration remove

in /API/DTOs/ResgisterDto.cs added [Required]:
- dotnet watch --no-hot-reload 

------------------------------------------------------------------
#39
AccountController.cs (modified)
API/DTOs/LoginDto.cs (Created)

40. JSON web tokens

#41 
Create folder interfaces (For Services purpose ) /API/Interfaces/ITokenService.cs 
Create Services /API/Services/TokenService.cs 
Program.cs (modified)

#42
NugGet Gallery: Search System.identity (System.IdentityModel.Token.JWT)
TokenService.cs (modified)

#43
Create API/DTOs/User Dto
modified AccountController.cs
modified appsettings.Development.json
"TOKEN": "Super secret unguessable key" 
// in the most recent security packages you need to use a 
much longer key than this and needs to beat least 64 characters 
jwt.ms (Website)

#44
https://learn.microsoft.com/en-us/aspnet/core/security/authorization/simple?view=aspnetcore-8.0
nuget gallery -> Microsoft.AspNetCore.Authentication.JwtBearer
Program.cs (modified)

#45 (Watch-again)
Create extensions, Application extensions Service 