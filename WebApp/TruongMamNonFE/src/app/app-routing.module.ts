import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DanhMucThucDonComponent } from './danh-muc-thuc-don/danh-muc-thuc-don.component';
import { NienHocComponent } from './nien-hoc/nien-hoc.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { PhongBanComponent } from './phong-ban/phong-ban.component';
import { LopHocComponent } from './lop-hoc/lop-hoc.component';
import { HocSinhComponent } from './hoc-sinh/hoc-sinh.component';

const routes: Routes = [
  {path:'CauHinhNienHoc', component:NienHocComponent},
  {path:'PhongBan', component:PhongBanComponent},
  {path:'DanhSachLopHoc', component:LopHocComponent},
  {path:'HoSoHocSinh', component:HocSinhComponent},
  {path:'DanhMucThucDon', component:DanhMucThucDonComponent},
  {path: '', component:HomeComponent},
  {path: 'home', component:HomeComponent},
  {path:'**', component:PageNotFoundComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
