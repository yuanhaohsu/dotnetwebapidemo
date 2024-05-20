#83
    1. Entity Framework Relationships
    2. Entity Framework Conentons
    3. Seeding Data int the Database
    4. The repository pattern
    5. Using AutoMapper

#84
(modify) - AppUser.ts   (API/Entities)
(create) - photo.cs     (API/Entities)

#85 - Method to calcaute the age
(modify) - AppUser.ts   (API/Entities)
(create) - DataTimeExtensions.cs (API/Extensions)

#86 - Relationship between User and photo
(modify) - photo.cs     (API/Entities)
- dotnet ef migrations add ExtendedUserEntity
https://learn.microsoft.com/en-us/ef/core/modeling/relationships
https://learn.microsoft.com/en-us/ef/core/modeling/relationships/conventions
- dotnet ef database update

#87 - Watch again
https://json-generator.com/ put jsongenerator.txt from (studentAssets)
(Create) - UserSeedData.json (API/Data)

#88 
(Create) - Seed.cs (API/Data)
(modify) - Program.cs

#89
 - dotnet ef database drop
 - dotnet watch --no-hot-reload 
 - check database
 (modify) - UserController
 
 #90 - The repository pattern (Watch again)
    (Advantages)
    1. Minimizes duplicate query logic
    2. Decouples application from persistence Framework
    3. All Database queries are centralized and not scattered throughout the app
    4. Allows us to change ORM easily
    5. Promotes testability 
        - We can easily Mock a repository interface, testing against the DbContext is more difficult. 

 #91 - Create repository
 (Create) - interface IUserRepository.cs (API/interface)
 (create) - UserRepository.cs (API/Data)
 (modify) - ApplicationServiceExtensions.cs (API/Extensions)

 #92 
(modify) - UsersController.cs 

#93
(create) - MemberDto.cs (API/DTOs)
(create) - Photo.cs (API/DTOs)

#94 - AutoMapper
Nuget Gallery: AutoMapper.microsoft.dependency...etc 
(create) - Helper (API) - AutoMapperProfiles.cs
(modify) - ApplicationServiceExtensions.cs (API/Extensions)

 #95
 (modify) - UsersController.cs 

 #96
 (modify) - MemberDto.cs
 (modify) - AutoMapperProfiles.cs

 #97
 (modify) - IUserRepository.cs
 (modify) - UserRepository.cs
 (modify) - UserController.cs
 (modify) - UserApp.cs
 (modify) - AutoMapperProfiles