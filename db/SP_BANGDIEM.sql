USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[SP_BANGDIEM]    Script Date: 8/5/2018 11:10:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_BANGDIEM]
@malop char(8), @mamh char(6), @lan int
AS
BEGIN
	IF EXISTS(SELECT MALOP FROM LOP WHERE MALOP=@malop)
		BEGIN
			SELECT HO+' '+TEN AS HOTEN, DIEM
			FROM (SELECT MASV, DIEM FROM DIEM WHERE MAMH=@mamh AND LAN=@lan) DIEMMH, (SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP=@malop) AS LOPSV
			WHERE DIEMMH.MASV = LOPSV.MASV
		END
	ELSE
		BEGIN
			SELECT HO+' '+TEN AS HOTEN, DIEM 
			FROM (SELECT MASV, DIEM FROM LINK0.QLDSV.DBO.DIEM WHERE MAMH=@mamh AND LAN=@lan) DIEMMH, (SELECT MASV, HO, TEN FROM LINK0.QLDSV.DBO.SINHVIEN WHERE MALOP=@malop) AS LOPSV
			WHERE DIEMMH.MASV = LOPSV.MASV
		END
END