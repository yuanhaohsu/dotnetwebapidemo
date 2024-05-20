#199 - 218
    1. Using .Net Identity
    2. Role management
    3. Policy base authorization
    4. UserManager<T>
    5. SingInManager<T>
    6. RoleManager<T>

#200
(modify) - API/Entities/AppUser.cs
(create) - API/Entities/AppRole.cs
(create) - API/Entities/AppUserRole.cs
(modify) - API/Controllers/AccountController.cs
(modify) - API/Data/Seed.cs

#201
(modify) - API/Data/DataContext.cs
nuget gallery: "Microsoft.AspNetCore.Identity.EntityFrameworkCore Version="7.0.9" />

#202
(modify) - API/Extensions/IdentityServiceExtensions.cs

#203
- dotnet ef migrations add IdentityAdded
(modify) - API/Program.cs

#204
(modify) - API/Data/Seed.cs
(modify) - API/Program.cs
- dotnet ef database drop
- dotent watch run

#205
