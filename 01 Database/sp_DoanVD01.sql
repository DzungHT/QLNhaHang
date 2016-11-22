-- Loại món ăn
create proc sp_LoaiMonAn_Search
@searchtype nvarchar(50),
@searchcontent nvarchar(100)
AS
BEGIN
	if(@searchtype!='')
		SELECT * from LoaiMonAn where @searchtype like N'%'+@searchcontent+'%'
	else
		SELECT * from LoaiMonAn
END
go

create proc sp_LoaiMonAn_Insert
@tenloaimonan nvarchar(50),
@mota nvarchar(100)
as
begin
	insert into LoaiMonAn values(@tenloaimonan,@mota)
end
go

create proc sp_LoaiMonAn_Update
@loaimonanid int,
@tenloaimonan nvarchar(50),
@mota nvarchar(100)
as
begin
	update LoaiMonAn
	set TenLoaiMonAn=@tenloaimonan,
		MoTa=@mota
	where LoaiMonAnID=@loaimonanid
end
go

create proc sp_LoaiMonAn_Delete
@loaimonanid int
as
begin
	delete from LoaiMonAn where LoaiMonAnID=@loaimonanid
end
go

-- Món ăn
create proc sp_MonAn_Search
@searchtype nvarchar(50),
@searchcontent nvarchar(100)
AS
BEGIN
	if(@searchtype!='')
		if(@searchtype!='LoaiMonAnID')
			SELECT * from MonAn ma
				INNER JOIN LoaiMonAn lma on lma.TenLoaiMonAn like N'%'+@searchcontent+'%'
		else
			SELECT * from MonAn where @searchtype like N'%'+@searchcontent+'%'
	else
		SELECT * from MonAn
END
go

create proc sp_MonAn_Insert
@tenmonan nvarchar(50),
@donvitinh nvarchar(50),
@dongia int,
@loaimonanid int,
@soluongton int,
@tontoithieu nchar(10)
as
begin
	insert into MonAn values(
	@tenmonan,
	@donvitinh,
	@dongia,
	@loaimonanid,
	@soluongton,
	@tontoithieu
	)
end
go

create proc sp_MonAn_Update
@monanid int,
@tenmonan nvarchar(50),
@donvitinh nvarchar(50),
@dongia int,
@loaimonanid int,
@soluongton int,
@tontoithieu nchar(10)
as
begin
	update MonAn
	set 
	TenMonAn= @tenmonan,
	DonViTinh= @donvitinh,
	DonGia= @dongia,
	LoaiMonAnID= @loaimonanid,
	SoLuongTon= @soluongton,
	TonToiThieu= @tontoithieu
	where MonAnID=@monanid
end
go

create proc sp_MonAn_Delete
@monanid int
as
begin
	delete from MonAn where MonAnID=@monanid
end
go

-- Khu vực
create proc sp_KhuVuc_Search
@searchtype nvarchar(50),
@searchcontent nvarchar(100)
AS
BEGIN
	if(@searchtype!='')
		SELECT * from KhuVuc where @searchtype like N'%'+@searchcontent+'%'
	else
		SELECT * from KhuVuc
END
go

create proc sp_KhuVuc_Insert
@tenkhuvuc nvarchar(50),
@mota nvarchar(100)
as
begin
	insert into KhuVuc values(
	@tenkhuvuc,
	@mota
	)
end
go

create proc sp_KhuVuc_Update
@khuvucid int,
@tenkhuvuc nvarchar(50),
@mota nvarchar(100)
as
begin
	update KhuVuc
	set 
	TenKhuVuc=@tenkhuvuc,
	MoTa=@mota
	where KhuVucID=@khuvucid
end
go

create proc sp_KhuVuc_Delete
@khuvucid int
as
begin
	delete from KhuVuc where KhuVucID=@khuvucid
end
go

-- Bàn ăn
create proc sp_BanAn_Search
@searchtype nvarchar(50),
@searchcontent nvarchar(100)
AS
BEGIN
	if(@searchtype!='')
		if(@searchtype!='KhuVucID')
			SELECT * from BanAn ba
				INNER JOIN KhuVuc kv on kv.TenKhuVuc like N'%'+@searchcontent+'%'
		else
			SELECT * from BanAn where @searchtype like N'%'+@searchcontent+'%'
	else
		SELECT * from BanAn
END
go

create proc sp_BanAn_Insert
@tenbanan nvarchar(50),
@khuvucid int,
@trangthai int,
@songuoi int
as
begin
	insert into BanAn values(
	@tenbanan,
	@khuvucid,
	@trangthai,
	@songuoi
	)
end
go

create proc sp_BanAn_Update
@bananid int,
@tenbanan nvarchar(50),
@khuvucid int,
@trangthai int,
@songuoi int
as
begin
	update BanAn
	set 
	TenBan=@tenbanan,
	KhuVucID=@khuvucid,
	TrangThai=@trangthai,
	SoNguoi=@songuoi
	where BanAnID=@bananid
end
go

create proc sp_BanAn_Delete
@bananid int
as
begin
	delete from BanAn where BanAnID=@bananid
end
go