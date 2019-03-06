import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { OutletComponent } from './outlet/outlet.component';
import { BookComponent } from './book/book.component';
import { LoginComponent } from './authenticate/login/login.component';
import { RegisterComponent } from './authenticate/register/register.component';
import { LayoutComponent } from './layout/layout.component';
import { ProfileComponent } from './profile/profile.component';
import { ServiceTypeComponent } from './service-type/service-type.component';
import { ServiceDetailComponent } from './service-detail/service-detail.component';
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

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  {
    path: '', component: LayoutComponent, children: [
      {
        path: 'home', component: HomeComponent, children: [
          { path: 'login', component: LoginComponent }
        ]
      },
      { path: 'book', component: BookComponent },
      { path: 'outlet', component: OutletComponent },
      { path: 'outlet-manager', component: OutletManagerComponent },
      { path: 'contact', component: ContactComponent },
      { path: 'promotion', component: PromotionComponent },
      { path: 'promotion1', component: Promotion1Component },
      { path: 'promotion2', component: Promotion2Component },
      { path: 'promotion3', component: Promotion3Component },
      { path: 'promotion4', component: Promotion4Component },
      { path: 'promotion5', component: Promotion5Component },
      { path: 'promotion6', component: Promotion6Component },
      { path: 'promotion7', component: Promotion7Component },
      { path: 'promotion8', component: Promotion8Component },
      { path: 'promotion9', component: Promotion9Component },
      { path: 'aboutus', component: AboutusComponent },

      { path: 'profile', component: ProfileComponent },
      { path: 'history', component: HistoryComponent },
      { path: 'service', component: ServiceTypeComponent },
      { path: 'services/:id', component: ServiceDetailComponent },
      { path: 'userManager', component: UserManagementComponent },
      { path: 'vnpay', component: VNPAYComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { onSameUrlNavigation: 'reload' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
