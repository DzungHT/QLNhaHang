IF EXISTS (SELECT * FROM sys.objects WHERE name = 'sp_GoiMon')
	DROP PROC sp_GoiMon
GO
CREATE PROC sp_GoiMon
@BanAnID int,
@MonAnID int,
@SoLuong int
AS
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		DECLARE @TrangThai int, @DatBanID int
		SELECT @TrangThai = ba.TrangThaiID FROM BanAn ba WHERE ba.BanAnID = @BanAnID

		IF @TrangThai = 0
		BEGIN
			INSERT INTO DatBan VALUES(@BanAnID, GETDATE())
			SELECT @DatBanID = SCOPE_IDENTITY()
			INSERT INTO ChiTietDatBan VALUES(@DatBanID, @MonAnID,@SoLuong,NULL)
			UPDATE BanAn SET TrangThaiID = 1 WHERE BanAnID = @BanAnID
		END -- END IF
		ELSE
		BEGIN
			SELECT 
				@DatBanID = db.DatBanID 
			FROM 
				DatBan db 
			WHERE
				db.BanAnID = @BanAnID AND
				db.NgayDatBan = (SELECT MAX(db.NgayDatBan) FROM DatBan db WHERE db.BanAnID = @BanAnID)

			IF EXISTS (SELECT * FROM ChiTietDatBan ct WHERE ct.DatBanID = @DatBanID  AND ct.MonAnID = @MonAnID)
			BEGIN
				UPDATE ChiTietDatBan
				SET SoLuong = SoLuong + @SoLuong
				WHERE DatBanID = @DatBanID  AND MonAnID = @MonAnID 
			END -- END IF
			ELSE
			BEGIN
				INSERT INTO ChiTietDatBan VALUES(@DatBanID, @MonAnID,@SoLuong,NULL)
			END
		END


		SELECT 0 AS KetQua, 'SUCCESS'as [ErrorMessage]
		COMMIT	
	END TRY
	BEGIN CATCH
		SELECT -1 AS KetQua, ERROR_MESSAGE() as [ErrorMessage]
		ROLLBACK
	END CATCH
END