IF EXISTS (SELECT * FROM sys.objects WHERE name = 'sp_ThanhToan')
	DROP PROC sp_ThanhToan
GO
CREATE PROC sp_ThanhToan
@DatBanID int,
@NhanVienID int,
@KhachHangID int = null
AS
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		DECLARE @HoaDonID int
		INSERT INTO HoaDon VALUES(@NhanVienID, @KhachHangID, GETDATE())
		SELECT @HoaDonID = SCOPE_IDENTITY()
		INSERT INTO ChiTietHoaDon SELECT @HoaDonID, ct.MonAnID, ct.SoLuong, ma.DonGia FROM ChiTietDatBan ct INNER JOIN MonAn ma ON ma.MonanID = ct.MonAnID WHERE ct.DatBanID = @DatBanID

		UPDATE BanAn
		SET TrangThaiID = 0
		WHERE BanAnID = (SELECT db.BanAnID FROM DatBan db WHERE db.DatBanID = @DatBanID)

		DELETE FROM ChiTietDatBan WHERE DatBanID = @DatBanID
		DELETE FROM DatBan WHERE DatBanID = @DatBanID


		SELECT 0 AS KetQua, 'SUCCESS'as [ErrorMessage]
		COMMIT	
	END TRY
	BEGIN CATCH
		SELECT -1 AS KetQua, ERROR_MESSAGE() as [ErrorMessage]
		ROLLBACK
	END CATCH
END