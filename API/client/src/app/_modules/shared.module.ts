import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner'; //#120
import { FileUploadModule } from 'ng2-file-upload'; //#131
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker'; //#147

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BsDropdownModule.forRoot(),
    TabsModule.forRoot(),
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }), //#120
    NgxSpinnerModule.forRoot({
      type: 'line-scale-party'
    //#131
    }),
    FileUploadModule,
    BsDatepickerModule.forRoot() //#147
  ],
  exports: [
    BsDropdownModule,
    ToastrModule,
    TabsModule,
    NgxSpinnerModule,  //#120
    FileUploadModule,  //#131
    BsDatepickerModule  //#147
  ]
})
export class SharedModule { }