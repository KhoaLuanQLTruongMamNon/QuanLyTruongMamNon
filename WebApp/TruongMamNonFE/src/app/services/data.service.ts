import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { DanhMucThucDon } from '../models/danh-muc-thuc-don.model';
import { HocSinh } from '../models/hoc-sinh.model';
import { KhoiLop } from '../models/khoi-lop.model';
import { LopHoc } from '../models/lop-hoc.model';
import { NienHoc } from '../models/nien-hoc.model';
import { PhongBan } from '../models/phong-ban.model';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  private REST_API_SERVER = environment.api;
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    }),
  };
  public newNienHoc: NienHoc = {
    maNienHoc:0,
    tenNienHoc:'',
    batDauHK1:new Date(Date.now()),
    ketThucHK1:new Date(),
    batDauHK2:new Date(),
    ketThucHK2:new Date()
  };
  public selectedNienHoc$ = new BehaviorSubject<NienHoc>(
    this.newNienHoc
  );
  constructor(private httpClient: HttpClient) {}


  //#region Danh mục thực đơn
  public newDanhMucThucDon: DanhMucThucDon = {
    maDanhMuc: 0,
    tenDanhMuc: '',
    ghiChu: '',
    thoiGian: '',
    nangLuong: 0,
    chatDam: 0,
    chatBeo: 0,
    chatBot: 0,
  };
  public getDanhMucThucDons(): Observable<DanhMucThucDon[]> {
    const url = `${this.REST_API_SERVER}/DanhMucThucDons`;
    return this.httpClient.get<DanhMucThucDon[]>(url, this.httpOptions);
  }

  public postDanhMucThucDon(
    data: DanhMucThucDon
  ): Observable<DanhMucThucDon> {
    const url = `${this.REST_API_SERVER}/DanhMucThucDons`;
    return this.httpClient.post<DanhMucThucDon>(url, data,this.httpOptions);
  }

  public putDanhMucThucDon(ma:number,
    data: DanhMucThucDon
  ): Observable<DanhMucThucDon> {
    const url = `${this.REST_API_SERVER}/DanhMucThucDons/${ma}`;
    return this.httpClient.put<DanhMucThucDon>(url, data,this.httpOptions);
  }

  public deleteDanhMucThucDon(ma:number,
  ): Observable<DanhMucThucDon> {
    const url = `${this.REST_API_SERVER}/DanhMucThucDons/${ma}`;
    return this.httpClient.delete<DanhMucThucDon>(url,this.httpOptions);
  }
  //#endregion

  //#region Niên học

  public getNienHocs(): Observable<NienHoc[]> {
    const url = `${this.REST_API_SERVER}/NienHocs`;
    return this.httpClient.get<NienHoc[]>(url, this.httpOptions);
  }

  public postNienHoc(
    data: NienHoc
  ): Observable<NienHoc> {
    const url = `${this.REST_API_SERVER}/NienHocs`;
    return this.httpClient.post<NienHoc>(url, data,this.httpOptions);
  }

  public putNienHoc(ma:number,
    data: NienHoc
  ): Observable<NienHoc> {
    const url = `${this.REST_API_SERVER}/NienHocs/${ma}`;
    return this.httpClient.put<NienHoc>(url, data,this.httpOptions);
  }

  public deleteNienHoc(ma:number,
  ): Observable<NienHoc> {
    const url = `${this.REST_API_SERVER}/NienHocs/${ma}`;
    return this.httpClient.delete<NienHoc>(url,this.httpOptions);
  }
  
  //#endregion

  //#region Phòng ban
  public newPhongBan: PhongBan = {
    maPhongBan:0,
    tenPhongBan:"",
    ghiChu:""
  };
  public getPhongBans(): Observable<PhongBan[]> {
    const url = `${this.REST_API_SERVER}/PhongBans`;
    return this.httpClient.get<PhongBan[]>(url, this.httpOptions);
  }

  public postPhongBan(
    data: PhongBan
  ): Observable<PhongBan> {
    const url = `${this.REST_API_SERVER}/PhongBans`;
    return this.httpClient.post<PhongBan>(url, data,this.httpOptions);
  }

  public putPhongBan(ma:number,
    data: PhongBan
  ): Observable<PhongBan> {
    const url = `${this.REST_API_SERVER}/PhongBans/${ma}`;
    return this.httpClient.put<PhongBan>(url, data,this.httpOptions);
  }

  public deletePhongBan(ma:number
  ): Observable<PhongBan> {
    const url = `${this.REST_API_SERVER}/PhongBans/${ma}`;
    return this.httpClient.delete<PhongBan>(url,this.httpOptions);
  }
  //#endregion

  //#region Khoi lop
  public newKhoiLop: KhoiLop = {
    maKhoiLop:0,
    tenKhoiLop:"",
    ghiChu:""
  };
  public getKhoiLops(): Observable<KhoiLop[]> {
    const url = `${this.REST_API_SERVER}/KhoiLops`;
    return this.httpClient.get<KhoiLop[]>(url, this.httpOptions);
  }

  public postKhoiLop(
    data: KhoiLop
  ): Observable<KhoiLop> {
    const url = `${this.REST_API_SERVER}/KhoiLops`;
    return this.httpClient.post<KhoiLop>(url, data,this.httpOptions);
  }

  public putKhoiLop(ma:number,
    data: KhoiLop
  ): Observable<KhoiLop> {
    const url = `${this.REST_API_SERVER}/KhoiLops/${ma}`;
    return this.httpClient.put<KhoiLop>(url, data,this.httpOptions);
  }

  public deleteKhoiLop(ma:number
  ): Observable<KhoiLop> {
    const url = `${this.REST_API_SERVER}/KhoiLops/${ma}`;
    return this.httpClient.delete<KhoiLop>(url,this.httpOptions);
  }
  //#endregion

  //#region Lop hoc
  public newLopHoc: LopHoc = {
    maLop:0,
    tenLop:"",
    maKhoiLop:0,
    hocPhi:0,
    maNienHoc:0,
    khoiLop: this.newKhoiLop,
    nienHoc:this.newNienHoc 
  };
  public getLopHocs(maNienHoc:number): Observable<LopHoc[]> {
    const url = `${this.REST_API_SERVER}/LopHocs/NienHoc/${maNienHoc}`;
    return this.httpClient.get<LopHoc[]>(url, this.httpOptions);
  }

  public postLopHoc(
    data: LopHoc
  ): Observable<LopHoc> {
    const url = `${this.REST_API_SERVER}/LopHocs`;
    return this.httpClient.post<LopHoc>(url, data,this.httpOptions);
  }

  public putLopHoc(ma:number,
    data: LopHoc
  ): Observable<LopHoc> {
    const url = `${this.REST_API_SERVER}/LopHocs/${ma}`;
    return this.httpClient.put<LopHoc>(url, data,this.httpOptions);
  }

  public deleteLopHoc(ma:number
  ): Observable<LopHoc> {
    const url = `${this.REST_API_SERVER}/LopHocs/${ma}`;
    return this.httpClient.delete<LopHoc>(url,this.httpOptions);
  }
  //#endregion

  //#region Lop hoc
  public newHocSinh: HocSinh = {
    maHocSinh:"",
    ho:"",
    ten:"",
    gioiTinh:"",
    maLopHoc:0,
    ngayNhapHoc:new Date(Date.now()),
    trangThaiHoc:"",
    lyDoNghiHoc:"",
    ngayCapNhat:new Date(Date.now()),
    ngaySinh:new Date(),
    noiSinh:"",
    danToc:"",
    tonGiao:"",
    quocTich:"",
    ghiChu:"",
    hoKhau:"",
    diaChi:"",
    hinhAnh:"",
    matKhau:"",
    trangThaiTaiKhoan:"",
    hoTenPhuHuynh:"",
    namSinhPhuHuynh:new Date(),
    cmndPhuHuynh:"",
    sdtPhuHuynh:"",
    ngheNghiepPhuHuynh:"",
    emailPhuHuynh:"",
    diaChiPhuHuynh:"",
    lopHoc:this.newLopHoc,

  };
  public getHocSinhs(): Observable<HocSinh[]> {
    const url = `${this.REST_API_SERVER}/HocSinhs`;
    return this.httpClient.get<HocSinh[]>(url, this.httpOptions);
  }

  public postHocSinh(
    data: HocSinh
  ): Observable<HocSinh> {
    const url = `${this.REST_API_SERVER}/HocSinhs`;
    return this.httpClient.post<HocSinh>(url, data,this.httpOptions);
  }

  public putHocSinh(ma:string,
    data: HocSinh
  ): Observable<HocSinh> {
    const url = `${this.REST_API_SERVER}/HocSinhs/${ma}`;
    return this.httpClient.put<HocSinh>(url, data,this.httpOptions);
  }

  public deleteHocSinh(ma:string
  ): Observable<HocSinh> {
    const url = `${this.REST_API_SERVER}/HocSinhs/${ma}`;
    return this.httpClient.delete<HocSinh>(url,this.httpOptions);
  }
  //#endregion
}
