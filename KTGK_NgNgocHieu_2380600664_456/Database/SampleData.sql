-- Script t?o d? li?u m?u cho database DTB_QLTinhHinh

-- Thêm d? li?u tr?ng thái (n?u chýa có)
IF NOT EXISTS (SELECT * FROM TrangThai WHERE MaTT = 1)
BEGIN
    INSERT INTO TrangThai (MaTT, TenTT, GhiChu) VALUES (1, N'B?nh thý?ng', N'Tr?ng thái b?nh thý?ng');
END

IF NOT EXISTS (SELECT * FROM TrangThai WHERE MaTT = 2)
BEGIN
    INSERT INTO TrangThai (MaTT, TenTT, GhiChu) VALUES (2, N'Cách ly x? h?i', N'Th?c hi?n cách ly x? h?i');
END

IF NOT EXISTS (SELECT * FROM TrangThai WHERE MaTT = 3)
BEGIN
    INSERT INTO TrangThai (MaTT, TenTT, GhiChu) VALUES (3, N'Khóa ch?t c?ng ð?ng', N'Th?c hi?n khóa ch?t nghiêm ng?t');
END

-- Thêm d? li?u ð?a phýõng m?u (n?u chýa có)
IF NOT EXISTS (SELECT * FROM DiaPhuong WHERE MaDP = 'HNO')
BEGIN
    INSERT INTO DiaPhuong (MaDP, TenDP, SoCaNhiemMoi, MaTT) VALUES ('HNO', N'Hà N?i', 0, 1);
END

IF NOT EXISTS (SELECT * FROM DiaPhuong WHERE MaDP = 'BDU')
BEGIN
    INSERT INTO DiaPhuong (MaDP, TenDP, SoCaNhiemMoi, MaTT) VALUES ('BDU', N'B?nh Dýõng', 521, 1);
END

IF NOT EXISTS (SELECT * FROM DiaPhuong WHERE MaDP = 'DAK')
BEGIN
    INSERT INTO DiaPhuong (MaDP, TenDP, SoCaNhiemMoi, MaTT) VALUES ('DAK', N'Ð?k L?k', 254, 2);
END

IF NOT EXISTS (SELECT * FROM DiaPhuong WHERE MaDP = 'DDN')
BEGIN
    INSERT INTO DiaPhuong (MaDP, TenDP, SoCaNhiemMoi, MaTT) VALUES ('DDN', N'Ð?ng Nai', 499, 3);
END

IF NOT EXISTS (SELECT * FROM DiaPhuong WHERE MaDP = 'SGN')
BEGIN
    INSERT INTO DiaPhuong (MaDP, TenDP, SoCaNhiemMoi, MaTT) VALUES ('SGN', N'TP. HCM', 1140, 1);
END

-- Xem k?t qu?
SELECT dp.MaDP, dp.TenDP, dp.SoCaNhiemMoi, tt.TenTT
FROM DiaPhuong dp
INNER JOIN TrangThai tt ON dp.MaTT = tt.MaTT
ORDER BY dp.SoCaNhiemMoi DESC;
