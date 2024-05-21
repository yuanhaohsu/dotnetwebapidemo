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
(modify) - API/Controllers/AccountController.cs

#206
(modify) - API/Data/Seed.cs
(modify) - API/Program.cs

#207
(modify) - API/Services/TokenService.cs
(modify) - API/Interfaces/ITokenService.cs
(modify) - API/Controllers/AccountController.cs

#208
(create) - API/Controllers/AdminController.cs
(modify) - API/Extensions/IdentityServiceExtensions.cs

#209
(modify) - API/Controllers/AdminController.cs

#210
(modify) - API/Controllers/AdminController.cs

client
#211
- ng g c admin/admin-panel
(create) - client/src/app/admin/admin-panel/admin-panel.component.css
(create) - client/src/app/admin/admin-panel/admin-panel.component.ts
(create) - client/src/app/admin/admin-panel/admin-panel.component.html
(modify) - client/src/app/app-routing.module.ts
(modify) - client/src/app/nav/nav.component.html

#212
(modify) - client/src/app/_services/account.service.ts
(modify) - client/src/app/_models/user.ts
- ng g guard _guards/admin
(create) - client/src/app/_guards/admin.guard.ts
> canActivate
(modify) - client/src/app/app-routing.module.ts

#213
- ng g d _directives/has-role
(create) - client/src/app/_directives/has-role.directive.ts
(modify) - client/src/app/nav/nav.component.html
(modify) - client/src/app/app.module.ts

#214
- ng g c admin/user-management
(create) - cclient/src/app/admin/user-management/user-management.component.ts
(create) - cclient/src/app/admin/user-management/user-management.component.css
(create) - cclient/src/app/admin/user-management/user-management.component.html

- ng g c admin/photo-management 
(create) - client/src/app/admin/photo-management/photo-management.component.css
(create) - client/src/app/admin/photo-management/photo-management.component.ts
(create) - client/src/app/admin/photo-management/photo-management.component.html

(modify) - client/src/app/admin/admin-panel/admin-panel.component.html
(modify) - client/src/app/admin/admin-panel/admin-panel.component.css
(modify) - client/src/app/admin/admin-panel/admin-panel.component.ts

(create) - client/src/app/_services/admin.service.ts

#215
https://valor-software.com/ngx-bootstrap/#/components/modals?tab=overview
(modify) - client/src/app/_modules/shared.module.ts
- ng g c modals/roles-modal

(modify) - cclient/src/app/admin/user-management/user-management.component.ts

(create) - client/src/app/modals/roles-modal/roles-modal.component.css
(create) - client/src/app/modals/roles-modal/roles-modal.component.html
(create) - client/src/app/modals/roles-modal/roles-modal.component.ts

#216
(modify) - client/src/app/modals/roles-modal/roles-modal.component.ts
(modify) - client/src/app/modals/roles-modal/roles-modal.component.html

#217
(modify) - client/src/app/_services/admin.service.ts
(modify) - client/src/app/admin/user-management/user-management.component.ts
(modify) - client/src/app/admin/user-management/user-management.component.html
(modify) - client/src/app/modals/roles-modal/roles-modal.component.html
