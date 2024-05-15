import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';
import { AbstractControl, FormBuilder, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};
  //#149
  registerForm: FormGroup = new FormGroup({});
  maxDate: Date = new Date();
  validationErrors: string[] | undefined;

  //#145
  constructor(private accountService: AccountService, private toastr: ToastrService, 
    private fb: FormBuilder, private router: Router) { }

  ngOnInit(): void {
    this.initializeForm();
    this.maxDate.setFullYear(this.maxDate.getFullYear() - 18);
  }

  //#140
    initializaForm() {
      this.registerForm = this.fb.group({
        gender: ['male'],
        username: ['', Validators.required],
        knownAs: ['', Validators.required],
        dateOfBirth: ['', Validators.required],
        city: ['', Validators.required],
        country: ['', Validators.required],
        //#141
        password: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(8)]],
        confirmPassword: ['', [Validators.required, this.matchValues('password')]]
      });
      //#142
      this.registerForm.controls['password'].valueChanges.subscribe({
        next: () => this.registerForm.controls['confirmPassword'].updateValueAndValidity()
      });
    }

    //#142 - Match values (validation)
    matchValues(matchTo: string): ValidatorFn {
      return (control: AbstractControl) => {
        return control?.value === control?.parent?.get(matchTo)?.value ? null : {isMatching: true}
      }
    }

        //#149
  register() {
    const dob = this.GetDateOnly(this.registerForm.controls['dateOfBirth'].value)
    const values = {...this.registerForm.value, dateOfBirth: this.GetDateOnly(dob)}
    this.accountService.register(values).subscribe({
      next: response => {
        this.router.navigateByUrl('/members');
      },
      //#149
      error: error => {
        this.validationErrors = error;
      } 
    })
  }
  cancel() {
    this.cancelRegister.emit(false);
  }

    private GetDateOnly(dob: string | undefined) {
    if (!dob) return;
    let theDob = new Date(dob);
    return new Date(theDob.setMinutes(theDob.getMinutes()-theDob.getTimezoneOffset())).toISOString().slice(0,10);
  }

}
