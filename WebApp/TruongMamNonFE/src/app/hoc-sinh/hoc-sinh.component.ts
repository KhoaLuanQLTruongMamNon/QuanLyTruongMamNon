import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';
import { HocSinh } from '../models/hoc-sinh.model';
import { ConfirmationService } from 'primeng/api';
import { MessageService } from 'primeng/api';
import { KhoiLop } from '../models/khoi-lop.model';
import { NienHoc } from '../models/nien-hoc.model';
import { ExportService } from '../services/export.service';
import { LopHoc } from '../models/lop-hoc.model';

@Component({
  selector: 'app-lop-hoc',
  templateUrl: './hoc-sinh.component.html',
  providers: [MessageService, ConfirmationService],
  styleUrls: ['./hoc-sinh.component.scss'],

})
export class HocSinhComponent implements OnInit {
  constructor(
    private dataService: DataService,
    private exportService: ExportService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
  ) {}

  public loading = true;
  public hocSinhDialog = false;

  public hocSinhs: HocSinh[] = [];
  
  public hocSinh:HocSinh=Object.assign({},this.dataService.newHocSinh);
  public submitted: boolean = false;
  public gioiTinhs:any[]=[{name: "Nam", key:0},{name:"Nữ", key:1}, {name:"Khác", key:2}];
  public trangThaiHocs:any[]=[{name: "Đang học", key:0},{name:"Đã nghỉ", key:1}];

  public ngOnInit(): void {
    this.getHocSinhs();
  }

  public exportExcel(){
    // const exportData:any[]=[];
    // this.hocSinhs.forEach((table)=>{
    //   exportData.push({
    //     tenLop: table.tenLop,
    //     khoiLop:table.khoiLop.tenKhoiLop,
    //     hocPhi:table.hocPhi,
    //     nienHoc:table.nienHoc.tenNienHoc,
    //   });
    // });
    // this.exportService.exportExcel(exportData, 'DanhSachHocSinh');
  }

  public exportPdf(){
    // const exportData:any[]=[];
    // this.hocSinhs.forEach((table)=>{
    //   exportData.push({
    //     tenLop: table.tenLop,
    //     khoiLop:table.khoiLop.tenKhoiLop,
    //     hocPhi:table.hocPhi,
    //     nienHoc:table.nienHoc.tenNienHoc,
    //   });
    // });
    // this.exportService.exportPdf(
    //   {
    //     tenLop: "Tên lớp", 
    //     khoiLop: "Khối lớp", 
    //     hocPhi: "Học phí",
    //     nienHoc: "Niên học",
    //   },
    //   exportData, 
    //   'DanhSachHocSinh'
    // );
  }
  
  public getHocSinhs():void{
    this.loading=true;  
    this.dataService.getHocSinhs().subscribe((data)=>{
      this.hocSinhs=data;
      //this.displayHocSinhs=this.hocSinhs.filter((hocSinh)=>hocSinh.nienHoc.maNienHoc===this.selectedNienHoc?.maNienHoc);
      this.loading=false;
    });
      
    
  }

  public openNew(): void {
    this.hocSinh = Object.assign({}, this.dataService.newHocSinh);
    this.hocSinhDialog = true;
  }

  public editHocSinh(hocSinh: HocSinh): void {
    console.log('edit hocSinh:', hocSinh);
    this.hocSinh = hocSinh;
    this.hocSinhDialog = true;
  }

  public deleteHocSinh(hocSinh: HocSinh) {
    console.log('delete danh muc thuc don', hocSinh);
    this.confirmationService.confirm({
      message: 'Bạn có muốn xóa ' + hocSinh.ho + ' ' + hocSinh.ten +'?',
      header: 'Xác nhận',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.dataService.deleteHocSinh(hocSinh.maHocSinh).subscribe((data)=>{
          this.getHocSinhs();
          this.messageService.add({
            severity: 'success',
            summary: 'Thành công',
            detail: 'Xóa thành công',
            life: 3000,
          });
        });        
      },
    });
  }

  public hideDialog(cancel = true, success = true): void {
    console.log('hideDialog: ');
    this.hocSinhDialog = false;
    if (cancel) {
      this.messageService.add({
        severity: 'info',
        summary: 'Hủy',
        detail: 'Đã hủy',
        life: 3000,
      });
    } else if (success) {
      this.messageService.add({
        severity: 'success',
        summary: 'Thành công',
        detail: 'Lưu thành công',
        life: 3000,
      });
    } else {
      this.messageService.add({
        severity: 'error',
        summary: 'Lỗi',
        detail: 'Lưu không thành công',
        life: 3000,
      });
    }
    this.submitted = false;
  }

  public saveHocSinh() {
    console.log('saveHocSinh: ', this.hocSinh);
    if (this.hocSinh.maHocSinh === "") {
      this.dataService.postHocSinh(this.hocSinh).subscribe(
        (data) => {
          console.log('return data = ', data);
          this.hocSinhs.push(data);
          this.hideDialog(false, true);
          this.getHocSinhs();
        },
        (error) => {
          console.log('error');
          this.hideDialog(false, false);
        }
      );
    } else {
      this.dataService.putHocSinh(this.hocSinh.maHocSinh, this.hocSinh).subscribe(
        (data) => {
          console.log('return data = ', data);
          this.hideDialog(false, true);
          this.getHocSinhs();
        },
        (error) => {
          console.log('error');
          this.hideDialog(false, false);
        }
      );
    }
  }

}
