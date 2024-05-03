import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { User } from './user';

@Injectable({
    providedIn:'root'
})

export class AccountService{
    baseUrl = 'http://localhost:5194/api/';
    //#55
    private currentUserSource = new BehaviorSubject<User | null>(null);
    currentUser$ = this.currentUserSource.asObservable();

    constructor(private http: HttpClient){}

    // #55
    login(model:any){
        return this.http.post<User>(this.baseUrl + 'account/login', model).pipe(
            map((response:User) => {
                const user = response;
                if(user){
                    localStorage.setItem('user', JSON.stringify(user));
                    //55
                    this.currentUserSource.next(user);
                }
            })
        );
    }
//55
        setCurrentUser(user: User){
            this.currentUserSource.next(user);
        }

    logout(){
        localStorage.removeItem('user');
        this.currentUserSource.next(null);
    }
}