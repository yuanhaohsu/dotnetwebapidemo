import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [ //64
  {path:'', component: HomeComponent},
  {path:'members', component: MemberListComponent},
  {path:'members/:id', component: MemberDetailComponent},
  {path:'lists', component: ListsComponent},
  {path:'messages', component: MessagesComponent},
  {path:'**', component: HomeComponent},
]; 

// Path Matching 


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
