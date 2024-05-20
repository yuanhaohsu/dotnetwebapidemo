#99 
    1. Using Typescript Types
    2. Using the async pipe
    3. Using bootstrap for styling
    4. Basic css tricks to enhance the look
    5. Using a 3rd party photo gallery

#100

#101 
https://transform.tools/json-to-typescript
Create member.ts (/client/src/app/_models)
Create photo.ts (/client/src/app/_models)

#102 add new member service
(modfiy) - (_service/account.services.ts)
- ng g environments 
(environment.development.ts) | (environment.ts)

-ng g s _service/members (members.services.ts)

#103 #104
    Create members folder (API/client/src)
    - ng -g c members/member-card
    - ng -g c members/member-list
    - ng -g c members/member-detail
        (create) - member-card folder
            member-card.component.css       #105    #106
            member-card.component.ts
            member-card.component.html
        (create) - member-detail foler 
            member-detail.component.css     
            member-detail.component.ts
            member-detail.component.html
        (create) - member-lists folder 
            member-list.component.css
            member-list.component.html
            member-list.component.ts

#107
- ng g interceptor _interceptos/jwt 
(create) - jwt.interceptor.ts 
(modfiy) - app.module.ts 
(modfiy) - member.service.ts

#108
(modfiy) - member-detail.component.ts 
(modfiy) - app-routing.module.ts
(modfiy) - member-detail.component.html
(modfiy) - member-card.component.html

#109 / 110 
# css (styling)

#111
https://www.npmjs.com/package/ng-gallery 
- npm i ng-gallery @angular/cdk
(modfiy) - member-detail.component.ts
(modfiy) - member-detail.component.html