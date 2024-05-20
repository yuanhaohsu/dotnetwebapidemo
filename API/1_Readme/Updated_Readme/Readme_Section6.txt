#64 - Create Several components:
- ng g c members/member-list
- ng g c members/member-detail
- ng g c lists
- ng g c messages

#65
added "routerLink" function
added "routerLinkActive="active"
(modify) nav.components.html 
(modify) app-routing module ts 

#66 Routing code
added private router: Router
(modify) app.components.html 

#67 adding toast


ngx-toastr - https://ngx-toastr.vercel.app/
- npm install ngx-toastr@17
at angular.json add:
"styles": [
  "styles.scss",
  "node_modules/ngx-toastr/toastr.css" // try adding '../' if you're using angular cli before 6
]

at app.module:
@NgModule({
  imports: [
    CommonModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot({
        positionClass: 'toast-bottom-
    }), // ToastrModule added
  ],

  restart server 

 (modify)   nav.components.ts
 (modify)   register.componets.ts

#68 - client side security:
(modify) nav.components.html
- ng g --help
- ng g g _guards/auth
- CanActivate
(Create) auth._guards (client/src/app/_guards)
(modify) app-routing.module.ts 

#69
(modify) app-routing.module.ts 
(modify) nav.components.html.html

#70 Adding New theme
https://bootswatch.com/ - united
- npm install bootswatch
at angular.json add:
"styles": [
  "node_modules/bootswatch/dist/united/bootstrap.css"
]
restart server 

(modify) nav.components.html

#71 shared module
(housekeep) app.module.ts 
- ng g m _modules/shared --flat

add sharemodule at imports at app.module.ts 
import: [
    shareModule
]