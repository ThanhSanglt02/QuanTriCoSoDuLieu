
----------------------------------------------Tạo khoá---------------------------------

Create or alter proc sp_taokhoa
As 
Begin 
	--tạo master key 
	Create master key encryption by password ='Ma$terK&yG4'

	--tạo chứng chỉ 
	create CERTIFICATE Certificate_test with subject = 'Protect my data'

	--tạo khoá đối xứng 
	Create symmetric key SDTProtector
	with algorithm =aes_256
	ENCRYPTION BY CERTIFICATE Certificate_test
End
exec sp_taokhoa
---------------------------------------------MÃ HOÁ--------------------------------------------------------
Go
--thêm cột mã hoá MatKhau bảng account
ALTER TABLE account
add encrypted_matkhau varbinary(max)
--thêm cột mã hoá SDT bảng NHACUNGCAP
alter table nhacungcap
Add encryptedSDT_NCC varbinary(max)
--thêm cột mã hoá SDT bảng DONVIVANCHUYEN
Alter table DONVIVANCHUYEN
Add encryptedSDT_NVC varbinary(max)
--thêm cột mã hoá SDT bảng KHACHHANG
Alter table KHACHHANG
Add encryptedSDT_KH varbinary(max)
--thêm cột mã hoá SDT bảng NHANVIEN
Alter table NHANVIEN
Add encryptedSDT_NV varbinary(max)

------------------------------------------------------------------------------------------------
Go
CREATE OR ALTER PROCEDURE sp_mahoa
AS
BEGIN
    -- Mở khoá
    OPEN SYMMETRIC KEY SDTProtector
    DECRYPTION BY CERTIFICATE Certificate_test
	
    -- Mã hoá
	UPDATE ACCOUNT
    SET encrypted_MatKhau = ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(MatKhau AS NVARCHAR))
    UPDATE NHACUNGCAP
    SET encryptedSDT_NCC = ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(sdt_ncc AS NVARCHAR))
    UPDATE DONVIVANCHUYEN
    SET encryptedSDT_NVC = ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(sdt_nvc AS NVARCHAR))
    UPDATE KHACHHANG
    SET encryptedSDT_KH = ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(sdt_kh AS NVARCHAR))
    UPDATE NHANVIEN
    SET encryptedSDT_NV = ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(sdt_nv AS NVARCHAR))

    -- Đóng khoá
    CLOSE SYMMETRIC KEY SDTProtector

    -- Thực thi câu lệnh động để xóa cột
    EXEC('ALTER TABLE dbo.ACCOUNT DROP COLUMN MatKhau')

    -- Xoá cột SDT_NCC
    DECLARE @uqncc VARCHAR(100)
    SELECT @uqncc = name
    FROM sys.objects
    WHERE type = 'UQ' AND OBJECT_NAME(parent_object_id) = N'NHACUNGCAP'

    -- Thực thi câu lệnh động để xóa ràng buộc và cột
    EXEC('ALTER TABLE dbo.NHACUNGCAP DROP CONSTRAINT ' + @uqncc)
    EXEC('ALTER TABLE dbo.NHACUNGCAP DROP COLUMN sdt_ncc')

    -- Xoá cột SDT_NVC
    DECLARE @uqnvc VARCHAR(100)
    SELECT @uqnvc = name
    FROM sys.objects
    WHERE type = 'UQ' AND OBJECT_NAME(parent_object_id) = N'DONVIVANCHUYEN'

    -- Thực thi câu lệnh động để xóa ràng buộc và cột
    EXEC('ALTER TABLE dbo.DONVIVANCHUYEN DROP CONSTRAINT ' + @uqnvc)
    EXEC('ALTER TABLE dbo.DONVIVANCHUYEN DROP COLUMN sdt_nvc')

    -- Xoá cột SDT_KH
    DECLARE @uqkh VARCHAR(100)
    SELECT @uqkh = name
    FROM sys.objects
    WHERE type = 'UQ' AND OBJECT_NAME(parent_object_id) = N'KHACHHANG'

    -- Thực thi câu lệnh động để xóa ràng buộc và cột
    EXEC('ALTER TABLE dbo.KHACHHANG DROP CONSTRAINT ' + @uqkh)
    EXEC('ALTER TABLE dbo.KHACHHANG DROP COLUMN sdt_kh')

    -- Xoá cột SDT_NV
    DECLARE @uqnv VARCHAR(100)
    SELECT @uqnv = name
    FROM sys.objects
    WHERE type = 'UQ' AND OBJECT_NAME(parent_object_id) = N'NHANVIEN'

    -- Thực thi câu lệnh động để xóa ràng buộc và cột
    EXEC('ALTER TABLE dbo.NHANVIEN DROP CONSTRAINT ' + @uqnv)
    EXEC('ALTER TABLE dbo.NHANVIEN DROP COLUMN sdt_nv')
END


Exec sp_mahoa
select * from ACCOUNT
Select * from NHACUNGCAP
Select * from NHANVIEN
Select * from KHACHHANG
------------------------------------------------GIẢI MÃ-----------------------------------
---------------------------------------ACCOUNT---------------------------------------------
Select * from ACCOUNT
Go
create or alter proc sp_giaimaACC @tentaikhoan nvarchar(50)
As
Begin 
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test
	select	Ac_no, 
			TenTK,
			LoaiTK,
			dencryptedSDT_NCC=cast(cast(DECRYPTBYKEY(encrypted_MatKhau) as nvarchar)as varchar(15))
	from ACCOUNT
	where TenTK=@tentaikhoan
	CLOSE SYMMETRIC KEY SDTProtector
End
exec sp_giaimaACC 'ThanhSang'

select * from nhacungcap


---------------------------------NCC-----------------------------------------------
go
CREATE OR ALTER PROCEDURE sp_giaimaNCC 
    @SDT_NCC NVARCHAR(15) = NULL 
AS
BEGIN
    OPEN SYMMETRIC KEY SDTProtector
    DECRYPTION BY CERTIFICATE Certificate_test

    IF @SDT_NCC IS NOT NULL
		BEGIN
			SELECT  MaNCC,
					TenNCC,
					DiaChiNCC,
					decryptedSDT_NCC = CAST(DECRYPTBYKEY(encryptedSDT_NCC) AS NVARCHAR(15))
			FROM NHACUNGCAP
			WHERE CAST(DECRYPTBYKEY(encryptedSDT_NCC) AS NVARCHAR(15)) = @SDT_NCC
		END
    ELSE
		BEGIN
			SELECT  MaNCC,
					TenNCC,
					DiaChiNCC,
					decryptedSDT_NCC = CAST(DECRYPTBYKEY(encryptedSDT_NCC) AS NVARCHAR(15))
			FROM NHACUNGCAP
		END
    CLOSE SYMMETRIC KEY SDTProtector
END
exec sp_giaimaNCC '0346586960'

--------------------DONVIVANCHUYEN---------------------------------------------
CREATE OR ALTER PROCEDURE sp_giaimaDVVC
    @SDT_NVC NVARCHAR(15) = NULL 
AS
BEGIN
    OPEN SYMMETRIC KEY SDTProtector
    DECRYPTION BY CERTIFICATE Certificate_test
    IF @SDT_NVC IS NOT NULL
    BEGIN
        SELECT  MaDVVC,
                TenNVC,
                NgayGiaoHang,
                decryptedSDT_NVC = CAST(DECRYPTBYKEY(encryptedSDT_NVC) AS NVARCHAR(15))
        FROM DONVIVANCHUYEN
        WHERE CAST(DECRYPTBYKEY(encryptedSDT_NVC) AS NVARCHAR(15)) = @SDT_NVC
    END
    ELSE
    BEGIN
        SELECT  MaDVVC,
                TenNVC,
                NgayGiaoHang,
                decryptedSDT_NVC = CAST(DECRYPTBYKEY(encryptedSDT_NVC) AS NVARCHAR(15))
        FROM DONVIVANCHUYEN
    END
    CLOSE SYMMETRIC KEY SDTProtector
END
EXEC sp_giaimaDVVC @SDT_NVC = '0308117568'
EXEC sp_giaimaDVVC
-----------------------------KHACHHANG---------------------------------------------
CREATE OR ALTER PROCEDURE sp_giaimaKH @SDT_KH NVARCHAR(15) = NULL
AS
BEGIN
    OPEN SYMMETRIC KEY SDTProtector
    DECRYPTION BY CERTIFICATE Certificate_test

    IF @SDT_KH IS NOT NULL
    BEGIN
        SELECT  MaKH,
                LoaiKH,
                UuDai,
                decryptedSDT_KH = CAST(DECRYPTBYKEY(encryptedSDT_KH) AS NVARCHAR(15))
        FROM KHACHHANG
        WHERE CAST(DECRYPTBYKEY(encryptedSDT_KH) AS NVARCHAR(15)) = @SDT_KH
    END
    ELSE
    BEGIN
      
        SELECT  MaKH,
                LoaiKH,
                UuDai,
                decryptedSDT_KH = CAST(DECRYPTBYKEY(encryptedSDT_KH) AS NVARCHAR(15))
        FROM KHACHHANG
    END
    CLOSE SYMMETRIC KEY SDTProtector
END

EXEC sp_giaimaKH @SDT_KH = '0135754915'
EXEC sp_giaimaKH

----------------------------NHANVIEN-----------------------------------------------
CREATE OR ALTER PROCEDURE sp_giaimaNV
    @SDT_NV NVARCHAR(15) = NULL 
AS
BEGIN
    OPEN SYMMETRIC KEY SDTProtector
    DECRYPTION BY CERTIFICATE Certificate_test
    IF @SDT_NV IS NOT NULL
    BEGIN
        SELECT  MaNV,
                TenNV,
                decryptedSDT_NV = CAST(DECRYPTBYKEY(encryptedSDT_NV) AS NVARCHAR(15))
        FROM NHANVIEN
        WHERE CAST(DECRYPTBYKEY(encryptedSDT_NV) AS NVARCHAR(15)) = @SDT_NV
    END
    ELSE
    BEGIN
        SELECT  MaNV,
                TenNV,
                decryptedSDT_NV = CAST(DECRYPTBYKEY(encryptedSDT_NV) AS NVARCHAR(15))
        FROM NHANVIEN
    END

    CLOSE SYMMETRIC KEY SDTProtector
END

EXEC sp_giaimaNV @SDT_NV = '0994371363'
EXEC sp_giaimaNV


-------------------------------------------INSERT--------------------------------------
---------------------------------------------ACCOUNT----------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_themAccount	@TenTK NVARCHAR(50),
											@LoaiTK NVARCHAR(50),
											@MatKhau NVARCHAR(50)
AS
BEGIN

    OPEN SYMMETRIC KEY SDTProtector
    DECRYPTION BY CERTIFICATE Certificate_test

    INSERT INTO ACCOUNT ( TenTK, LoaiTK, encrypted_MatKhau)
    VALUES (@TenTK, @LoaiTK, ENCRYPTBYKEY(KEY_GUID('SDTProtector'), CAST(@MatKhau AS NVARCHAR)))

    CLOSE SYMMETRIC KEY SDTProtector
END

EXEC sp_themAccount @TenTK = 'ThuyDuong', @LoaiTK = 'user', @MatKhau = 'abcabc';
select * from ACCOUNT


---------------------------------------------KHACHHANG----------------------------------------------------------


Go
create or alter proc sp_themkh	@loaikh bit,
								@sdt_kh varchar(15),
								@Uudai decimal(4,2)
As
Begin
	declare @makh varchar(50)
	set @makh=(select dbo.getNewIDKH())
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test

	INSERT INTO KHACHHANG (MaKH,LoaiKH,UuDai,encryptedSDT_KH)
    VALUES (@makh, @loaikh,@Uudai,ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(@sdt_kh AS NVARCHAR)))

	CLOSE SYMMETRIC KEY SDTProtector
End
declare @loai bit,
		@sdt varchar(15),
		@ud decimal(4,2)

set	@loai=1
set	@sdt ='0367674438'
set	@ud =0.1

exec sp_themkh @loai,@sdt,@ud 
Exec sp_giaimaKH '0367674438'
Select * from KHACHHANG
where MaKH=10001001
-------------------------------------------------NCC------------------------------------------------
Go
create or alter proc sp_themncc	@tenncc nvarchar(100),
								@diachincc nvarchar(100),
								@SDT_NCC varchar(15)
As
Begin
	declare @mancc varchar(50)
	set @mancc=(select dbo.fGetNewIDNCC())
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test

	INSERT INTO NHACUNGCAP (MaNCC,TenNCC,DiaChiNCC,encryptedSDT_NCC)
    VALUES (@mancc, @tenncc,@diachincc,ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(@sdt_ncc AS NVARCHAR)))

	CLOSE SYMMETRIC KEY SDTProtector
End

DECLARE @ten NVARCHAR(100), 
		@diachi NVARCHAR(50),
		@SDT VARCHAR(15)

set	@ten = N'Công ty TNHH A'
set	@diachi =N'Hà Nội'
set	@SDT ='0987654321'

EXEC sp_themncc @ten, @diachi, @SDT
exec sp_giaimaNCC '0987654321'
Select * from NHACUNGCAP
where MaNCC=00001001
---------------------------------------------------------DONVIVANCHUYEN----------------------------------------------------------------
Go
create or alter proc sp_themdvvc	@tennvc nvarchar(100),
									@ngaygiaohang datetime,
									@SDT_NVC varchar(15)
As
Begin
	declare @manvc char(7)
	set @manvc=(select dbo.fGetNewIDDVVC())
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test

	INSERT INTO DONVIVANCHUYEN(MaDVVC,TenNVC,NgayGiaoHang,encryptedSDT_NVC)
    VALUES (@manvc, @tennvc,@ngaygiaohang,ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(@sdt_nvc AS NVARCHAR)))

	CLOSE SYMMETRIC KEY SDTProtector
End

DECLARE @ten NVARCHAR(100), 
		@ngaygiao datetime,
		@SDT VARCHAR(15)

set	@ten = N'Công ty van chuyen A'
set	@ngaygiao=GETDATE()-1
set	@SDT ='0312345678'

EXEC sp_themdvvc @ten, @ngaygiao, @SDT
exec sp_giaimadvvc '0312345678'
Select * from DONVIVANCHUYEN
where MaDVVC=0001001

------------------------------------------------------NHANVIEN--------------------------------------------------------
Go
create or alter proc sp_themnv	@tennv nvarchar(100),
								@SDT_NV varchar(15)
As
Begin
	declare @manv char(8)
	set @manv=(select dbo.fGetNewIDNV())
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test

	INSERT INTO NHANVIEN(MaNV,TenNV,encryptedSDT_NV)
    VALUES (@manv, @tennv,ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(@sdt_nv AS NVARCHAR)))

	CLOSE SYMMETRIC KEY SDTProtector
End

DECLARE @ten NVARCHAR(100), 
		@SDT VARCHAR(15)
set	@ten = N'Nhan vien C'
set	@SDT ='0706410579'

EXEC sp_themnv @ten, @SDT
EXEC sp_giaimaNV '0706410579'
Select * from NHANVIEN
where MaNV=20001001

----------------------------------------------------------UPDATE-----------------------------------------
-----------------------------------------KHACH HANG-----------------------------------------------------
Go
CREATE OR ALTER PROCEDURE sp_updateKH	@makh VARCHAR(50),
										@loaikh BIT,
										@sdt_kh VARCHAR(15),
										@Uudai DECIMAL(4, 2)
AS
BEGIN
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test


    UPDATE KHACHHANG
    SET LoaiKH = @loaikh,
        UuDai = @Uudai,
        encryptedSDT_KH = ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(@sdt_kh AS NVARCHAR))
    WHERE MaKH = @makh
	CLOSE SYMMETRIC KEY SDTProtector
END

EXEC sp_updateKH '10001000', 1, '0987654321', 0.2
Select * from KHACHHANG

----------------------------------------------------------ACCOUNT-----------------------------------------------------
Go
CREATE OR ALTER PROCEDURE sp_updateAccount	@Ac_no VARCHAR(50),      
											@TenTK NVARCHAR(50),     
											@LoaiTK NVARCHAR(50),    
											@MatKhau NVARCHAR(50)    
AS
BEGIN

    OPEN SYMMETRIC KEY SDTProtector
    DECRYPTION BY CERTIFICATE Certificate_test

    UPDATE ACCOUNT
    SET TenTK = @TenTK,
        LoaiTK = @LoaiTK,
        encrypted_MatKhau = ENCRYPTBYKEY(KEY_GUID('SDTProtector'), CAST(@MatKhau AS NVARCHAR))
    WHERE Ac_no = @Ac_no
    CLOSE SYMMETRIC KEY SDTProtector
END

EXEC sp_updateAccount	@Ac_no = 11,
						@TenTK = 'Thanh',
						@LoaiTK = 'User',
						@MatKhau = 'NewPa$$w0rd'

-------------------------------------------------NHACUNGCAP-------------------------
Go
CREATE OR ALTER PROCEDURE sp_updateNCC	@mancc VARCHAR(50),
										@tenncc varchar(60),
										@diachiNCC VARCHAR(60),
										@sdt_ncc VARCHAR(15)
AS
BEGIN
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test


    UPDATE NHACUNGCAP
    SET TenNCC = @tenncc,
        DiaChiNCC = @diachiNCC,
        encryptedSDT_NCC = ENCRYPTBYKEY(key_guid('SDTProtector'), CAST(@sdt_ncc AS NVARCHAR))
    WHERE MaNCC = @mancc
	CLOSE SYMMETRIC KEY SDTProtector
END

----- giải mã sdt khi truyền vào
CREATE PROCEDURE GetMaKHBySDT
    @SoDienThoai NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    -- Mở khóa giải mã
    OPEN SYMMETRIC KEY SDTProtector 
    DECRYPTION BY CERTIFICATE Certificate_test;

    -- Truy vấn mã khách hàng
    SELECT MaKH
    FROM KhachHang
    WHERE CAST(DECRYPTBYKEY(encryptedSDT_KH) AS NVARCHAR(15)) = @SoDienThoai;

    -- Đóng khóa
    CLOSE SYMMETRIC KEY SDTProtector;
END;



CREATE PROCEDURE SearchKhachHang
    @Keyword NVARCHAR(50)
AS
BEGIN

    OPEN SYMMETRIC KEY SDTProtector 
    DECRYPTION BY CERTIFICATE Certificate_test;

    SELECT *
    FROM KhachHang
    WHERE CONVERT(VARCHAR, DECRYPTBYKEY(encryptedSDT_KH)) LIKE '%' + @Keyword + '%'
       OR MaKH LIKE '%' + @Keyword + '%';

    CLOSE SYMMETRIC KEY SDTProtector;
END;
select * from KHACHHANG

exec sp_giaimaKH


CREATE or alter PROCEDURE SearchNCC
    @Keyword NVARCHAR(50)
AS
BEGIN

    OPEN SYMMETRIC KEY SDTProtector 
    DECRYPTION BY CERTIFICATE Certificate_test;

    SELECT *
    FROM NHACUNGCAP
    WHERE CONVERT(VARCHAR, DECRYPTBYKEY(encryptedSDT_NCC)) LIKE '%' + @Keyword + '%'
       OR MaNCC LIKE '%' + @Keyword + '%' Or TenNCC LIKE '%' + @Keyword + '%' ;

    CLOSE SYMMETRIC KEY SDTProtector;
END;


-------------------Kiem tra account------------------
Go
create or alter proc sp_giaimaACC @tentaikhoan nvarchar(50)
As
Begin 
	OPEN SYMMETRIC KEY SDTProtector
	DECRYPTION BY CERTIFICATE Certificate_test
	select	Ac_no, 
			TenTK,
			LoaiTK,
			dencryptedSDT_NCC=cast(cast(DECRYPTBYKEY(encrypted_MatKhau) as nvarchar)as varchar(15))
	from ACCOUNT
	where TenTK=@tentaikhoan
	CLOSE SYMMETRIC KEY SDTProtector
End