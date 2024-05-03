#47
Client Login and Register:
    1. Creating components using the Angular Client
    2. Using Angular Template forms
    3. Using Angular Services
    4. Understanding Observables
    5. Using Angular structural directives to conditionally display elements on a page

#48 localhost:4200
at nav folder
- cd client
- ng g --help
- ng g c nav --skip-tests --dry-run (/src/app/nav/...)
creating nav.component.ts / nav.component.html
app.component.html (removed {title} replace <app-nav> </app-nav> )


#49 Angular forms
app.modules.ts:
import: [
    FormsModule
]

#50 Angular Services
At ("API/Client/app/_services") - added _services folder creating account.service.ts
- ng g s _services/account --skip-tests --dry-run

#51
modify - account.service.ts
modify - nav.component.ts

#52
modify - nav.component.ts
modify - nav.component.html

#53 
ngx-bootstrap - dropdown
- ng add ngx-bootstrap  --component dropdowns
Result: Updated src/app/app.modules.ts 
modify - nav.component.html
modify - nav.component.css

#54. Introduction to observables (Watch)

# 55 Persisting the Login (check)
modify -    account.service.ts
create (_models) folder "API/Client/app/_models"creating user.ts"
modify -    app.component.ts
modify -    nav.component.ts

#56 
=> unsubscribe
add property in nav.component.ts
modify - nav.component.html