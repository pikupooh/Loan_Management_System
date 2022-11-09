import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ProfileComponent } from './profile/profile.component';
import { ProfileidComponent } from './profileid/profileid.component';
import { AddpaymentComponent } from './addpayment/addpayment.component';
import { GetpaymentsbyidComponent } from './getpaymentsbyid/getpaymentsbyid.component';
import { GetpaymentsbypidComponent } from './getpaymentsbypid/getpaymentsbypid.component';
import { GetpaymentsbycustidComponent } from './getpaymentsbycustid/getpaymentsbycustid.component';
import { GetallpaymentsComponent } from './getallpayments/getallpayments.component';
import { AllloantypesComponent } from './allloantypes/allloantypes.component';
import { LoantypenameComponent } from './loantypename/loantypename.component';
import { LoanbycustidComponent } from './loanbycustid/loanbycustid.component';
import { LoanbylidComponent } from './loanbylid/loanbylid.component';
import { AllloansComponent } from './allloans/allloans.component';
import { AllapplicationsComponent } from './allapplications/allapplications.component';
import { AllapplicationsbycustidComponent } from './allapplicationsbycustid/allapplicationsbycustid.component';
import { AllapplicationsbyappidComponent } from './allapplicationsbyappid/allapplicationsbyappid.component';
import { CalculateemiComponent } from './calculateemi/calculateemi.component';
import { BankdetailsComponent } from './bankdetails/bankdetails.component';
import { BankdetailsbyidComponent } from './bankdetailsbyid/bankdetailsbyid.component';

@NgModule({
  declarations: [
    AppComponent,
    ProfileComponent,
    ProfileidComponent,
    AddpaymentComponent,
    GetpaymentsbyidComponent,
    GetpaymentsbypidComponent,
    GetpaymentsbycustidComponent,
    GetallpaymentsComponent,
    AllloantypesComponent,
    LoantypenameComponent,
    LoanbycustidComponent,
    LoanbylidComponent,
    AllloansComponent,
    AllapplicationsComponent,
    AllapplicationsbycustidComponent,
    AllapplicationsbyappidComponent,
    CalculateemiComponent,
    BankdetailsComponent,
    BankdetailsbyidComponent
  ],
  imports: [
    BrowserModule, HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
