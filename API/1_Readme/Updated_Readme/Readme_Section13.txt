#151 - (pagination)
    1. How to implement pagination on the API & client
    2. Deferred Execution using iQueryable
    3. How to implement filtering on the API & client
    4. How to implement sorting on the API & client
    5. Using Action Filters
    6. Adding a TimeAgo pipe
    7. implement caching in the client for paginated resources. 


#152
(create) - API/Helpers/PagedList.cs

#153
(create) - API/Helpers/PaginationHeader.cs
(create) - API/Extensions/HttpExtensions.cs
(create) - API/Helpers/UserParams.cs

#154
(modify) - API/Helpers/UserParams.cs
(modify) - API/Interfaces/IUserRepository.cs
(modify) - API/Data/UserRepository.cs
(modify) - API/Controllers/UsersController.cs

#155
(create) - client/src/app/_models/pagination.ts
(modify) - client/src/app/_services/members.service.ts
(modify) - client/src/app/members/member-list/member-list.component.ts

#156
https://valor-software.com/ngx-bootstrap/#/components/pagination?tab=overview
(modify) - client/src/app/members/member-list/member-list.component.html
(modify) - client/src/app/_modules/shared.module.ts

#157
(modify) - API/Helpers/UserParams.cs
(modify) - API/Controllers/UsersController.cs
(modify) - API/Data/UserRepository.cs

#158
(modify) - API/Helpers/UserParams.cs
(modify) - API/Data/UserRepository.cs

#159 - Housekeeping (checking)
(modify) - API/DTOs/UserDto.cs
(modify) - API/Controllers/AccountController.cs
(modify) - client/src/app/_models/user.ts
(modify) - client/src/app/nav/nav.component.html
(modify) - client/src/app/_services/members.service.ts
(create) - client/src/app/_models/userParams.ts
(modify) - client/src/app/members/member-list/member-list.component.ts

#160
(modify) - client/src/app/members/member-list/member-list.component.ts
(modify)- client/src/app/members/member-list/member-list.component.html
(modify) - client/src/app/members/member-card/member-card.component.html

#161
(modify) - API/Helpers/UserParams.cs
(modify) - API/Data/UserRepository.cs

#162
(create) - API/Helpers/LogUserActivity.cs
(modify) - API/Extensions/ApplicationServiceExtensions.cs

#163
(modify) - API/Data/UserRepository.cs
(modify) - API/Services/TokenService.cs
(modify) - API/Extensions/ClaimsPrincipalExtensions.cs
(modify) - API/Helpers/LogUserActivity.cs

#164
https://valor-software.com/ngx-bootstrap/#/components/buttons?tab=overview
(modify) - client/src/app/_modules/shared.module.ts
(modify) - client/src/app/members/member-list/member-list.component.html
(modify) - client/src/app/_models/userParams.ts
(modify) - client/src/app/_services/members.service.ts

#165
(modify) - client/src/app/members/member-detail/member-detail.component.html
https://www.npmjs.com/package/ngx-timeago
- npm install ngx-timeago
(modify) - client/src/app/_modules/shared.module.ts
(modify) - client/src/app/members/member-detail/member-detail.component.ts
(modify) - client/src/app/members/member-edit/member-edit.component.html

#166
(modify) - client/src/app/_services/members.service.ts

#167
(modify) - client/src/app/_services/members.service.ts

#168
(modify) - client/src/app/members/member-list/member-list.component.ts
(modify) - client/src/app/_services/members.service.ts

#169