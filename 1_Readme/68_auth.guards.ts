import { inject } from '@angular/core';
import { CanActivateFn } from '@angular/router';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';
import { map } from 'rxjs';


export const authGuard: CanActivateFn = (route, state) => {
    const accountService = injector(AccountService);
    const toastr = injector(ToastrService);

    return accountService.currentUser$.pipe(    // 1
        map(user => {   
            if (user) return true;  
            else{// 2
            toastr.error('You shall not pass!');  // 3 
            return false; 
            } // 4
})
    )
};