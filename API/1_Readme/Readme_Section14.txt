#171
(modify) - API/Entities/AppUser.cs
(create) - API/Entities/UserLike.cs
(modify) - API/Data/DataContext.cs

- dotnet ef migrations add LikeEntityAdded (not necessary can cause error)

#172
(create) - API/Interfaces/ILikesRepository.cs
(create) - API/DTOs/LikeDto.cs
(create) - API/Data/LikesRepository.cs
(modify) - API/Extensions/ApplicationServiceExtensions.cs

#173
(modify) - API/Data/LikesRepository.cs

#174
(create) - API/Controllers/LikesController.cs

#175
(modify) - client/src/app/_services/members.service.ts
(modify) - client/src/app/members/member-card/member-card.component.ts
(modify) - client/src/app/members/member-card/member-card.component.html

#176
(modify) - client/src/app/lists/lists.component.ts
(modify) - client/src/app/_services/members.service.ts
(modify) - client/src/app/lists/lists.component.html

#177
(create) - API/Helpers/PaginationParams.cs
(modify) - API/Helpers/UserParams.cs
(create) - API/Helpers/LikesParams.cs
(modify) - API/Data/LikesRepository.cs
(modify) - API/Controllers/LikesController.cs
(modify) - ClaimsPrincipalExtensions.cs  
[changed string to int ]
(modify) - LogUserActivity.cs   [remove int.parse]
(modify) - LikeController.cs    [remove int.parse]

#178
(modify) - client/src/app/_services/members.service.ts
(modify) - client/src/app/lists/lists.component.ts
(modify) - client/src/app/lists/lists.component.html
