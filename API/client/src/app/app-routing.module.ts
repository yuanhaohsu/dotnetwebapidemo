import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

{path: '', component: HomeComponent},
{path: '',
  runGuardsAndResolvers: 'always',
  canActivate: [authGuard],
  children: [
    {path: 'members', component: MemberListComponent},
    {path: 'members/:id', component: MemberDetailComponent, canActivate: [adminGuard]},
    {path: 'lists', component: ListsComponent},
    {path: 'messages', component: MessagesComponent},
   
  ]
},
{path: 'errors', component: TestErrorsComponent},
{path: 'not-found', component: NotFoundComponent},
{path: 'server-error', component: ServerErrorComponent},
{path: '**', component: NotFoundComponent, pathMatch: 'full'}, // path matching
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
