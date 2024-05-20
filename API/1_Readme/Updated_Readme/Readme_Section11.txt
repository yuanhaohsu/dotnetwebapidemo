#123
    1. Photo storage options
    2. Adding related enetities
    3. Using a 3rd party API
    4. Using tje Debugger
    5. Updating and deleting resources
    6. What to return when creating resources in a REST based API
    -> Clodinary

#124
https://cloudinary.com/ | signed up by email

#125 setting Clodinary
Nuget Gallery:   <PackageReference Include="CloudinaryDotNet" Version="1.22.0" />
(modify) - appsettings.json
(Create) - API/Helpers/CloudinarySettings.cs
(modify) - API/Extensions/ApplicationServiceExtensions.cs

#126 - Uploading photos
(Create) - API/Interfaces/IPhotoService.cs
(Create) - API/Services/PhotoService.cs

#127 - add new method
(modify) - API/Controllers/UsersController.cs
(create) - API/Extensions/ClaimsPrincipalExtensions.cs

#128

#130
ng g c members/photo-editor
(Create) - photo-editor.component.css
(Create) - photo-editor.component.html
(Create) - photo-editor.component.ts
(modify) - member-edit.component.html

#131
ng2-file-upload - https://www.npmjs.com/package/ng2-file-upload
- npm install ng2-file-upload
(modify) - photo-editor.component.html
(modify) - shared.module.ts
(modify) - photo-editor.component.ts

#132
(modify) - photo-editor.component.html
(modify) - photo-editor.component.css

#133
(modify) - UsersController.ts

#134 
(modify) - UserDto
(modify) - AccountController.ts
(modify) - user.ts              client/src/app/_models/user.ts
(modify) - AccountService.ts    client/src/app/_services/account.service.ts
(modify) - nav.component.html
(modify) - nav.component.css
?   troubleshooting 
*1 - (modify) - UserDto
*2 - AccountController.cs

#135
(modify) - members.service.ts
(modify) - photo-editor.component.ts
(modify) - photo-editor.component.html

#136 - Deleting Function (API)
(modify) - UsersController.ts

#136 - Deleting Function (Client)
(modify) - client/src/app/_services/members.service.ts
(modify) - client/src/app/members/photo-editor/photo-editor.component.ts
(modify) - photo-editor.component.html