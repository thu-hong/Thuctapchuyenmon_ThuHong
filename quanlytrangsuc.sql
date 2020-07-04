use quanlytrangsuc
go
CREATE proc [dbo].[insertCTPN](@MaPN nchar(50),@SoLuong int,@GiaNhap float,
						@TenTS nvarchar(50),@MaLoai nchar(50),@HinhAnh image,@DonVi nvarchar(50))
as
begin
	DECLARE @MaTS NCHAR(10) 
	IF (SELECT COUNT(MaTS) FROM TrangSuc) = 0
		SET @MaTS = '0'
	ELSE
		SELECT @MaTS = MAX(RIGHT(MaTS, 48)) FROM TrangSuc
		SELECT @MaTS  = CASE
			WHEN @MaTS  >= 0 and @MaTS  < 9 THEN 'TS0' + CONVERT(CHAR, CONVERT(INT, @MaTS ) + 1)
			WHEN @MaTS  >= 9 THEN 'TS' + CONVERT(CHAR, CONVERT(INT,@MaTS ) + 1)
		END
	DECLARE @Dongia float = @gianhap * 0.1 + @gianhap
		insert into TrangSuc values(@MaTS,@TenTS,@SoLuong,@DonGia,@MaLoai, @HinhAnh, @DonVi)		
		insert into ChiTietPN values (@MaPN,@MaTS,@SoLuong,@GiaNhap,@MaLoai,@TenTS,@DonVi)

end
go
use quanlytrangsuc
go
Alter proc [dbo].[deleteNhanVien](@manv nchar(50))
as
begin
	update PhieuNhap set MaNV = null where MaNV = @manv
	declare @user nvarchar(100) = (select UserName from DangNhap where MaNV = @manv)
	update HoaDon set UserName=null where UserName=@user
	delete from DangNhap where MaNV=@manv
	delete from ThuongPhat where MaNV = @manv
	delete from Thang where MaNV = @manv
	delete from NhanVien where MaNV=@manv
end
go
create table DangNhap(
UserName nvarchar(50) primary key,
PassWord nvarchar(50),
MaNV nchar(10)
)
create table NhanVien(
MaNV nchar(10) primary key,
TenNV nvarchar(50),
GioiTinh bit,
CMND int,
DiaChi nvarchar(50),
SDT nvarchar(50),
MaCV nchar(10)
)
create table ChucVu(
MaCV nchar(10) primary key,
TenCV nvarchar(50),
LuongCB float
)
create table ChiTietPN(
MaPN nchar(10),
ManV nchar(10),
SoLuong int ,
GiaNhap float,
primary key (MaPN, MaNV)
)
create table PhieuNhap(
MaPN nchar(10) primary key,
MaNCC nchar(10),
MaNV nchar(10),
ThơiGianLap date
)
create table  NhaCungCap(
MaNCC nchar(10) primary key,
TenNCC nchar(10),
DiaChi nvarchar(50),
SDT nvarchar(50)
)
create table HoaDon(
MaHD nchar(10) primary key,
TGLap date,
TongTien float,
UserName nvarchar(50),
TrangThai nvarchar(50),
MaUD nchar(10)
)
create table ChiTietHD(
MaHD nchar(10),
MaTS nchar(10),
SoLuongBan int,
primary key (MaHD,MaTS)
)
create table TrangSuc(
MaTS nchar(10) primary key,
TenTS nvarchar(10),
SoLuong int,
DonGia float,
MaLoai nchar(10),
HinhAnh image
)
create table LoaiTS(
MaLoai nchar(10) primary key ,
TenLoai nvarchar(10),
)
create table UuDai(
MaUD nchar(10) primary key,
TenUD nvarchar(50),
NgayBD date ,
NgayKT date ,
GiamGia float
)
create table KhachHang(
MaKH nchar(10) primary key,
TenKH nvarchar(50),
DiaChi nvarchar(50),
SDT nvarchar(50),
)
create table Thang(
Thang int ,
MaNV nchar(10) ,
Luong float ,
ThuongPhat float,
primary key (MaNV,Thang)
)
create table ThuongPhat(
MaThuongPhat nchar(10) primary key ,
MaNV nchar(10),
Ngay date ,
SoTien float,
LiDo nvarchar(50)  
)
create table CTPhanQuyen(
MaCV nchar(10),
MaPQ nchar(10),
primary key (MaCV,MaPQ)
)
create table Quyen(
MaPQ nchar(10) primary key,
TenQuyen nvarchar(50)
)
