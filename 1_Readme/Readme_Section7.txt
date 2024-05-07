#73
1. API MiddleWare
2. Angular Interceptors
3. Trobleshooing exceptions

#74
Create BuggyControl.cs at (API/Controllers/BuggyControl)
(modfiy) - BuggyControl.cs
- dotnet watch --no-hot-reload
(modfiy) - ResgisterDto.cs

#75
(modfiy) - Prgram.cs

#76
Create folder ("Errors") ["API/Errors"]
(Create) ApiExceptions.cs ["API/Errors"]
Create folder ("MiddleWare") ["API/MiddleWare"]
(create) ExceptionMiddleware.cs ["API/MiddleWare"]

#77
- ng g c errors/test-error
(create) - test-errors.component.html
(create) - test-errors.component.ts
(create) - test-errors.component.css

(modfiy) - app-routing.module.ts
(modfiy) - nav.component.html

#78
- ng g interceptor _interceptors/error  
(modfiy) - app.module.ts

#79
(modfiy) - test-error.component.ts
(modfiy) - test-error.component.html

#80
- ng g c errors/not-found | (src/app/errors/)
(create) - not-found.component.css 
(create) - not-found.component.html
(create) - not-found.component.ts

- ng g c errors/server-error | (src/app/errors/)
(create) - server-error.component.css
(create) - server-error.component.html
(create) - server-error.component.ts

(modfiy) - app-routing.module
(modfiy) - nav.component.ts

#81
(modfiy) - error.interceptor.ts
(modfiy) - server-error.component.css
(modfiy) - server-error.component.html
(modfiy) - server-error.component.ts