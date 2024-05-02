Lecture 25 issues with CORS support:
Error message: Access to XMLHttpRequest at 'http://localhost:5194/api/users' from origin 'http://localhost:4200' 
has been blocked by CORS policy: No 'Access-Control-Allow-Origin' header is present on the requested resource.
Status: sovled 


Lecture 28:
         // "options": {
         //   "ssl": true,
         //   "sslCert": "./ssl/localhost.pem",
         //   "sslKey": "./ssl/localhost-key.pem"
         //  },
After added is unable to turn on ng serve
https://stackoverflow.com/questions/39774194/ng-serve-does-not-work-after-a-double-install
Status:

02/05/2024
-- Adding 
#33
Disable Hot Reload:
Add new enetities: \API\Entities\AppUser.cs
dotnet ef migrations add UserPasswordAdded 
#Lecture 34 
Creat BaseApiController at \dotnetwebapidemo-master\API\Controllers\BaseApiController.cs
#35
Create AccountController.cs at \dotnetwebapidemo-master\API\Controllers\AccountController.cs
