import { AccountService } from "./account.service";
import {Component, OnInit} from @angular/core';

Component({
    selector:'app.nav',
    templateUrl: './nav.component.html',
    StyleUrls:['./nav.component.css']
})
export class NavComponent implements OnInit{
    //#51
        model:any = {};
        //56  - loggedIn: = false;
        currentUser$ = Observable<User | null> = of(null);

constructor(private acoountService: AccountService) {}
//55    but for temporary purposes
    ngOnIni():void{ //56
        this.currentUser$ = this.acoountService.currentUser$;
    }
    //55 , 56
    // getCurrentUser() { //this.acoountService.currentUser$.subscribe({ //next: user => this.loggedIn = !!user; //error: err => console.log(err);}) // }
    login(){
        this.acoountService.login(this.model).subscribe
        (response => {
            console.log(response);
            //this.loggedIn = true;
        }, error => {
            console.log(error);
        });
    }
    //52
    logout(){
        this.acoountService.logout();
        //this.loggedIn = false;
    }
}