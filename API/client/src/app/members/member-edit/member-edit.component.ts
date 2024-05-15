import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { AccountService } from 'src/app/_services/account.service';
import { MembersService } from 'src/app/_services/members.service';

@Component({
  selector: 'app-member-edit',
  templateUrl: './member-edit.component.html',
  styleUrls: ['./member-edit.component.css']
})
export class MemberEditComponent implements OnInit {
    @ViewChild('editForm') editForm:NgForm | undefined;     //#116
    @HostListener('windows:beforeload',['$event'])unloadNotification($event: any){   //#117
        if(this.editForm?.dirty) {
            $event.returnValue = true;
        }
    }           
    memmber: Member | undefined;
    user: User | null = null;

    constructor(private accountService: AccountService, private memberService: MembersService, private toastr: ToastrService) { 
        this.accountService.currentUser$.pipe(take(1)).subscribe({
            next:user => this.user = user
        })
    }
    ngOnInit(): void {
        this.loadMember

    }
    loadMember() {
        if(!this,user) return;
        this.memberService.getMember(this.user.username).subscribe({
            next: member => this.memmber = member
        })
    }

    updateMember(){
        this.memberService.updateMember(this.editForm?.valute).subscribe({ //#119
            next: _ => {
                this.toastr.success('Profile updated successfully');
                this.editForm?.reset(this.memmber);  //#116
            }
        })
        
    }
}