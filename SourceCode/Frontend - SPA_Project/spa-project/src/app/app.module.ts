import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { DatePipe } from '@angular/common';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { HeaderComponent } from './layout/header/header.component';
import { LoginComponent } from './authenticate/login/login.component';
import { OutletComponent } from './outlet/outlet.component';
import { ServiceDetailComponent } from './service-detail/service-detail.component';
import { ServiceTypeComponent } from './service-type/service-type.component';
import { BookComponent } from './book/book.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { DlDateTimePickerDateModule } from 'angular-bootstrap-datetimepicker';
import {NgxPaginationModule} from 'ngx-pagination';

// IMPORT PRIME
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CalendarModule } from 'primeng/calendar';
import { DialogModule } from 'primeng/dialog';
import { TableModule } from 'primeng/table';
import { DropdownModule } from 'primeng/dropdown';
import { CheckboxModule } from 'primeng/checkbox';
import { RadioButtonModule } from 'primeng/radiobutton';
import { KeyFilterModule } from 'primeng/keyfilter';
// import { MultiSelectModule } from 'primeng/multiselect';
import { InputSwitchModule } from 'primeng/inputswitch';
import { InputMaskModule } from 'primeng/inputmask';
import { InputTextModule } from 'primeng/inputtext';
import { SelectButtonModule } from 'primeng/selectbutton';
import { PasswordModule } from 'primeng/password';


import { CommonModule } from '@angular/common';
import { RegisterComponent } from './authenticate/register/register.component';
import { LayoutComponent } from './layout/layout.component';
import { ProfileComponent } from './profile/profile.component';
import { AgmCoreModule } from '@agm/core';
import { OutletManagerComponent } from './outlet-manager/outlet-manager.component';
import { PromotionComponent } from './promotion/promotion.component';
import { Promotion1Component } from './promotion/promotion1/promotion1.component';
import { Promotion2Component } from './promotion/promotion2/promotion2.component';
import { Promotion3Component } from './promotion/promotion3/promotion3.component';
import { Promotion4Component } from './promotion/promotion4/promotion4.component';
import { Promotion5Component } from './promotion/promotion5/promotion5.component';
import { Promotion6Component } from './promotion/promotion6/promotion6.component';
import { Promotion7Component } from './promotion/promotion7/promotion7.component';
import { Promotion8Component } from './promotion/promotion8/promotion8.component';
import { Promotion9Component } from './promotion/promotion9/promotion9.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { UserManagementComponent } from './authenticate/user-management/user-management.component';
import { HistoryComponent } from './history/history.component';
import { VNPAYComponent } from './vnpay/vnpay.component';
import { GooglemapComponent } from './googlemap/googlemap.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    LoginComponent,
    ContactComponent,
    OutletComponent,
    ServiceDetailComponent,
    ServiceTypeComponent,
    BookComponent,
    RegisterComponent,
    LayoutComponent,
    ProfileComponent,
    OutletManagerComponent,
    PromotionComponent,
    Promotion1Component,
    Promotion2Component,
    Promotion3Component,
    Promotion4Component,
    Promotion5Component,
    Promotion6Component,
    Promotion7Component,
    Promotion8Component,
    Promotion9Component,
    AboutusComponent,
    UserManagementComponent,
    HistoryComponent,
    VNPAYComponent,
    GooglemapComponent
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    DlDateTimePickerDateModule,
    CommonModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyAJdswXF23XMSHInDeviihQoURUzVK8Cj0'
    }),
    NgxPaginationModule,
    CalendarModule,
    DialogModule,
    TableModule,
    DropdownModule,
    CheckboxModule,
    RadioButtonModule,
    KeyFilterModule,
    // MultiSelectModule,
    InputSwitchModule,
    InputMaskModule,
    SelectButtonModule,
    InputTextModule,
    PasswordModule

  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
