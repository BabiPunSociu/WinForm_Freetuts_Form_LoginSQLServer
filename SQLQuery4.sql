create proc [dbo].[SP_AuthoLogin]
@Username nvarchar(20),
@Password nvarchar(20)
as
begin
    if exists (select * from NhanVien where TaiKhoan = @Username and MatKhau = @Password and IDPer = 1)
        select 1 as code
    else if exists (select * from NhanVien where TaiKhoan = @Username and MatKhau = @Password and IDPer = 0)
        select 0 as code
    else if exists(select * from NhanVien where TaiKhoan = @Username and MatKhau != @Password) 
        select 2 as code
    else select 3 as code
end