import{ Componet, OnInit} from '@angular/core';

@Componet({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {
    registerMode = false;
    constructor() { }

    ngOnInit() {
    }

    registertoggle() {
        this.registerMode = !this.registerMode;
    }
}