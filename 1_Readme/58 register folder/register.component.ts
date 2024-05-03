import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-register',
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
    })

    export class RegisterComponent implements OnInit {
        model: any = {};
    }

    constructor() { }   

    ngOnINIt(): void {
    }

    Register() {
        console.log(this.model);
    }

    cancel() {
        console.log('cancelled');

}