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
{path: '**', component: HomeComponent pathMatch:'full'},// Path Matching 
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
