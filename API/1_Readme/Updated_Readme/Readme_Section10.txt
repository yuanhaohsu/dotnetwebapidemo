#113
    1. Angular Template forms
    2. The CanDeactivate Route Guard
    3. The @ViewChild decorator
    4. Persisting change to the API
    5. Adding loading indicators to the client app
    6. Caching data in Angular services

#114
- ng g c members/member-edit 
(modify) - app-routing.modules.ts
(modify) - nav.component.html
(create) - member-edit.component.css
(create) - member-edit.component.html
(create) - member-edit.component.ts

#115
(modify) - member-edit.component.html

#116  
ViewChild
(modify) - member-edit.component.html
(modify) - member-edit.component.ts

#117 - Deactivate route guard
- ng g g _guards/prevent-unsaved-changes 
> CanDeactivate
(create) - prevent-unsaved-changes.guard.ts
(modify) - app-routing.module.ts
(modify) - member-edit.component.ts


#118 - Create new DTOs
(Create) - MemberUpdateDto.cs (API/DTOs)
(modify) - AutoMapperProfiles.cs
(modify) - UserController.cs

#119
(modify) - members.service.ts
(modify) - member-edit.component.ts
(modify) - member-edit.component.html

#120    https://www.npmjs.com/package/ngx-spinner
- npm install ngx-spinner@16
(modify) - Angular.json
(modify) - shared.module

-ng g s _services/busy
(create) - busy.service.ts

- ng g _interceptor _interceptors/loading (client/src/app/_interceptors)
(create) - loading.interceptor.ts
(modify) - app.module.ts
(modify) - app.component.html

#121
(modify) - members.service.ts
(modify) - member-list.component.ts
(modify) - member-list.component.html