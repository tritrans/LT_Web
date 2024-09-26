CREATE PROC SP_GETDATA3TABLE
AS
SELECT Masp,TenSP,DuongDan,Gia,Mota,LOAI.Maloai,Tenloai
FROM Loai JOIN SanPham ON Loai.MaLoai=SanPham.MaLoai

SP_GETDATA3TABLE
select* from SanPham order by TenSP ASC
select* from SanPham order by Gia DESC