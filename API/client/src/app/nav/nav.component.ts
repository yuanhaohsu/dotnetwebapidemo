import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Observable, of } from 'rxjs';
import { User } from '../_models/user';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})

//51
  export class NavComponent implements OnInit {
    model: any = {}
//56 - loggeIn: = false
//currentUser$ = Observable<User | null> = of(null);

  constructor(public accountService: AccountService, private router: Router, private toastr: Toastr) { } //66
//55    but for temporary purposes
  ngOnInit(): void {
 //this.currentUser$ = this.acoountService.currentUser$;
  }
//55 , 56
// getCurrentUser() { //this.acoountService.currentUser$.subscribe({ //next: user => this.loggedIn = !!user; //error: err => console.log(err);}) // }

  login() {
    this.accountService.login(this.model).subscribe({
      next: _ => this.router.navigatebyUrl('/members'),  //66
      error: error => console.log(error)
    })
  }
//52
  logout() {
    this.accountService.logout();
    this.router.navigate(['/']); //66
  }

}