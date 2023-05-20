use QLSV

select * from tblGiaoVen

insert into  tblGiaoVen(Ho,TenDem,Ten,GioiTinh,NgaySinh,DiaChi,Email,DienThoai)
values(N'Trương',N'Văn',N'Thành',1,'12-09-2000',N'Thái Bình','thanh@gmail.com','01122334455'),
(N'Hoàng',N'Mai',N'Hoa',0,'03-01-1992',N'Hà Nội','hoa@gmail.com','01122334455'),
(N'Đỗ',N'Văn',N'Thắng',1,'17-01-1995',N'Thái Nguyên','thang@gmail.com','01122334455'),
(N'Ngô',N'Thị',N'Huyền',0,'16-11-2002',N'Nam Định','huyen@gmail.com','01122334455'),
(N'Đinh',N'Văn',N'Đại',1,'17-06-2000',N'Quảng Ninh','dai@gmail.com','01122334455'),
(N'Trần',N'Thị',N'Tuyết',0,'16-08-2002',N'Thanh Hóa','tuyet@gmail.com','01122334455'),
(N'Lê',N'Xuân',N'Hiếu',1,'26-10-1992',N'Thái Nguyên','hieu@gmail.com','01122334455'),
(N'Trần',N'Văn',N'Hoàng',1,'23-01-2002',N'Thái Nguyên','hoang@gmail.com','01122334455');




insert tblSinhVien(MaSV,Ho,TenDem,Ten,NgaySinh,DiaChi,GioiTinh,DienThoai,Email)
	values
	(
	'SV' + cast(next value for sinhviensq as nvarchar(30)),
	N'Hoàng',
	N'Minh',
	N'Giang',
	'12-01-1995',
	N'Thái Nguyên',
	'0',
	'01122334455',
	'giang@gmail.com'
	)

select * from tblMonHoc
insert into tblMonHoc(TenMH,SoTC) values 
(N'Nhập môn công nghệ phần mềm',3),
(N'Lập trình Java',3),
(N'Thiết kế web',3),
(N'Trí tuệ nhân tạo',3),
(N'Tiếng anh CNTT',7),
(N'Tư tưởng Hồ Chí Minh',2),
(N'Pháp luật đại cương',2);


	select * from tblSinhVien

CREATE PROCEDURE SelectAllSinhVien 
as 
	select 
	MaSV,
	case 
		when len(TenDem) >0 then
			concat(Ho,' ', TenDem,' ',Ten)
		else concat(Ho,' ',Ten)
	end as HoTen,
	convert(varchar(10), NgaySinh,101) as NgaySinh,
	case 
		when GioiTinh = 1 then 'Nam'
		else N'Nữ'
	end as GioiTinh,
	DiaChi,
	DienThoai,
	Email
from tblSinhVien
go;

exec SelectAllSinhVien
drop PROCEDURE SelectAllSinhVien 




