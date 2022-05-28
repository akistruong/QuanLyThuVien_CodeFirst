USE [QuanLyThuVien4.0]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (1, N'29-11-01 Trương Kiệt', NULL, NULL, N'03890283  ', N'Xã Vĩnh Viễn A, 3445-Huyện Long Mỹ, Tỉnh Hậu Giang.')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (2, N'Kiet Truongg', NULL, NULL, NULL, N'Thị trấn Như Quỳnh, 2046-Huyện Văn Lâm, Tỉnh Hưng Yên.')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (3, N'Kiet Truong', NULL, NULL, N'0366798917', N'Xã Bảo Hiệu, 2270-Huyện Yên Thủy, Tỉnh Hòa Bình.')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (4, N'Kiệt Cao', NULL, NULL, N'0366709818', N'Xã Minh Hòa, Huyện Hữu Lũng, Tỉnh Lạng Sơn')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (6, N'Kiet Cao', NULL, NULL, N'0366798917', N'Thị trấn Mường Khương, Huyện Mường Khương, Tỉnh Lào Cai')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (7, N'sda Cas', NULL, NULL, N'0366798917', N'Xã Lăng Yên, Huyện Trùng Khánh, Tỉnh Cao Bằng')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'104620105072799234499              ', 1, NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'admin                              ', 2, N'12345678      ', NULL, 1, NULL, NULL)
INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'1066880047269906                   ', 3, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'101855537316040894871              ', 4, NULL, NULL, NULL, 3, NULL)
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([ID_HOADON], [CREATEDAT], [UpdatedAt], [USER_NAME], [TongHoaDon], [phiship], [discount], [soluong], [status], [id_kh]) VALUES (13, CAST(0x0000AEA1010132AE AS DateTime), CAST(0x0000AEA1010132AE AS DateTime), NULL, 1254000.0000, 54700.0000, 0.0000, 3, 1, 7)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([MANXB], [ID_NXB], [DIACHI], [SDT], [TENNXB]) VALUES (N'NXB01     ', 1, N'H?m t? 3', N'03890283    ', N'Kim Đồng')
SET IDENTITY_INSERT [dbo].[NXB] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MAPHIEUNHAP], [ID_PHIEUNHAP], [SOLUONGNHAP], [GIANHAP], [CREATEDAT], [UpdatedAt]) VALUES (N'PN01      ', 1, 100, 500000.0000, CAST(0x0000AEA000250126 AS DateTime), CAST(0x0000AEA000250126 AS DateTime))
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[THELOAI] ON 

INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'TL01      ', 1, N'Hài Hước')
INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'TT01      ', 2, N'Trinh Thám')
INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'LT01      ', 3, N'Văn Học')
INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'TL02      ', 6, N'Tâm Lý')
SET IDENTITY_INSERT [dbo].[THELOAI] OFF
SET IDENTITY_INSERT [dbo].[SACH] ON 

INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S01       ', 3, N'NXB01     ', N'PN01      ', N'TL02      ', N'Đắc Nhân Tâm', 120000.0000, N'sach-hay-dac-nhan-tam.jpg', 95, CAST(0x0000AEA100B05D77 AS DateTime), CAST(0x0000AEA100B05D77 AS DateTime), N'Đắc Nhân Tâm (How to Win Friends and Influence People) được mệnh danh là quyển sách hay nhất, nổi tiếng nhất, bán chạy nhất và nó có tầm ảnh hưởng đi xa nhất mọi thời đại, Đắc Nhân Tâm của soạn giả Dale Carnegie là 1 quyển sách hay nên đọc để bạn biết về nghệ thuật thu phục lòng người và làm tất cả mọi người phải yêu mến mình.

Quyển sách này cũng nêu bật lên các nguyên tắc trong việc đối nhân xử thế rất khôn ngoan bắt đầu từ việc thấu hiểu, thành thật với chính bản thân mình cũng như gợi ý cho người đọc cách biết quan tâm đến những người kế bên để cùng hòa nhập, cùng nhau phát triển khả năng của chính mình và mọi người lên 1 tầm cao mới.

Những người đã đọc sách Đắc Nhân Tâm có thể cũng cảm nhận được một tinh thần xuyên suốt mà tác giả muốn thể hiện trong quyển sách hay này. Đấy chính là chữ “nhẫn”. Nếu bạn có chữ “nhẫn” thì tất cả mọi việc sẽ được thay đổi nhìn nhận theo 1 hướng khác mà nơi đó sẽ khiến cho cuộc sống trở nên là một màu xanh hy vọng mãi mãi.')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S02       ', 4, N'NXB01     ', N'PN01      ', N'LT01      ', N'Nhà giả kim', 300000.0000, N'sach-hay-nha-gia-kim.jpg', 88, CAST(0x0000AEA100B0B61A AS DateTime), CAST(0x0000AEA100B0B61A AS DateTime), N'Nhà giả kim (The Alchemist) của Paulo Coelho là một cuốn sách hay dành cho những người đã đánh mất đi ước mơ hoặc chưa bao giờ có nó. Nếu bạn đang cần tìm những cuốn sách nên đọc để thành công thì Nhà Giả Kim rất xứng đáng. Thành công như thế nào: thành công trong trong suy nghĩ và hành động.

Cuốn sách này bán chạy thứ 2 trên thế giới chỉ sau Kinh Thánh, và được dịch ra với nhiều ngôn ngữ trên thế giới.

Lời văn tuy bình dị, nhẹ nhàng nhưng đậm chất thơ trong đó, thấm đẫm các triết lý huyền bí của Phương Đông nhưng lại là một động lực vững chắc cho những con người đang tìm kiếm một hoài bão trong tâm hồn, yêu thích và những ai đang trên đường đời thực hiện những ước mơ của bản thân.

Trước đây tôi vẫn thường tự hỏi bản thân mình rằng: Tôi tồn tại có ý nghĩa gì trong cuộc đời này? Tôi không thông minh và dĩ nhiên cũng chẳng đẹp trai chút nào. Tôi không biết mình thích điều gì, muốn cái gì. Thậm chí ước mơ của mình là gì, hoài bão ra sao để mà sống hết mình vì nó. Giống như một người “sống trong bao” không lí tưởng không mục đích toàn vẹn, đơn thuần chỉ là tôi tồn tại.

Vì lẽ đó, tôi sẽ sống những ngày không lí tưởng đấy nếu không vô tình đọc được cuốn tiểu thuyết Nhà giả kim của Paulo Ceolho.

')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S03       ', 5, N'NXB01     ', N'PN01      ', N'LT01      ', N'Ông Già Và Biển Cả', 500000.0000, N'sach-hay-ong-gia-va-bien-ca.jpg', 97, CAST(0x0000AEA100C4277C AS DateTime), CAST(0x0000AEA100C4277C AS DateTime), N'Ông già và Biển cả (The Old Man and the Sea) là truyện ngắn dạng viễn tưởng cuối cùng được viết bởi Hemingway. Đây cũng là tác phẩm nổi danh và là 1 trong các đỉnh cao trong sự nghiệp sáng tác của nhà văn. Tác phẩm này đoạt giải Pulitzer cho tác phẩm hư cấu năm 1953.

Nó cũng góp phần quan trọng để nhà văn được nhận Giải Nobel văn học năm 1954.

Trong tác phẩm này, ông đã triệt để sử dụng nguyên lý mà ông gọi là “tảng băng trôi”, chỉ mô tả một phần nổi còn lại bảy phần chìm, lúc mô tả sức mạnh của con cá, sự chênh lệch về lực lượng, về cuộc chiến đấu không cân sức giữa con cá hung dữ với ông già. Tác phẩm ca ngợi niềm tin, sức lao động và khát vọng của con người.

Đây là một tác phẩm lý tưởng, nó thật sự mang ý nghĩa rất lớn đặc biệt là đối với những ai đang muốn bỏ cuộc, đang muốn đầu hàng chính bản thân mình, bạn không thể biết được điều gì đang đợi bạn phía trước, hãy tin tưởng vào con đường bạn đã chọn, tin tưởng vào khả năng của chính mình.

Khi bắt đầu chán nản hãy suy nghĩ vì sao mình bắt đầu? Trên con đường đến với thành công không có dấu chân của những kẻ bỏ cuộc.')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S04       ', 6, N'NXB01     ', N'PN01      ', N'TT01      ', N'Mật mã Davinci', 300000.0000, N'mat_ma_da_vinci_600x884.jpg', 99, CAST(0x0000AEA100DC63F9 AS DateTime), CAST(0x0000AEA100DC63F9 AS DateTime), N'Thêm một cuốn tiểu thuyết nổi tiếng của nhà văn Dan Brown được mệnh danh là một trong số cuốn tiểu thuyết trinh thám hay nhất mọi thời đại đó chính là Mật mã Davinci. Vào thời điểm tác phẩm này ra đời đã gây ra cuộc tranh cãi lớn trên văn đàn thế giới bởi việc sử dụng yếu tố thần học trong tác phẩm. Cuốn sách mang đậm phong cách cá nhân của Dan Brown khi có sự đan xen giữa yếu tố trinh thám và yếu tố thần thoại, hai chất liệu hoàn toàn trái ngược nhau.

Với những tình tiết hấp dẫn, hồi hộp hết sức nhưng không kém thú vị bạn sẽ khám phá được từ bất ngờ này đến bất ngờ khác trong câu chuyện. Tác phẩm kể nhân vật Langdon đang sống yên ổn, bỗng nhiên một ngày lại rơi vào một hoàn cảnh nguy hiểm đến tính mạng. Những may mắn ông đã gặp một người phụ nữ xinh đẹp nhưng không kém phần thông minh đó chính là Sophia. Sau một chuyến chạy trốn đầy nguy hiểm nhờ sự giúp đỡ của một nhà sử học tài ba có tên Teabing cả Langdon và Sophie đã khám phá được một bí mật động trời.')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S05       ', 7, N'NXB01     ', N'PN01      ', N'TT01      ', N'Án mạng trên chuyến tàu tốc hành Phương Đông ', 199000.0000, N'tieu-thuyet-trinh-tham-hay-nhat-khong-nen-bo-qua-an-mang-tren-chuyen-tau-toc-hanh-phuong-dong.jpg', 99, CAST(0x0000AEA100DCC8A6 AS DateTime), CAST(0x0000AEA100DCC8A6 AS DateTime), N'Được chắp bút bởi Agatha Christe – nữ hoàng truyện trinh thám, tác phẩm mang hơi hướng cổ điển song vẫn còn nguyên sức hút đối với độc giả qua thời gian.

Tác phẩm nói về vụ án mạng kỳ lạ xảy ra trên chuyến tàu tốc hành Phương Đông chạy từ Istambul về Calais mà thám tử Hercule Poirot tình cờ có mặt. Con tàu trở thành một căn phòng kín và hung thủ thì vẫn có mặt trên chuyến tàu trong suốt hành trình phá án. Nạn nhân trong tác phẩm là một kẻ thủ ác, đang bị đe dọa bởi những lá thư vì những tội ác hắn đã làm trong quá khứ, bị giết bởi 12 nhát dao. Nhưng điều kì là là các nhát dao này không phải của cùng 1 người, câu hỏi đặt ra là tại sao lại xuất hiện các vết thương khác nhau trên cùng một nạn nhân đã khiến cho vị thám tử vô cùng đau đầu.

')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S06       ', 8, N'NXB01     ', N'PN01      ', N'TT01      ', N'Đề thi đẫm máu', 755000.0000, N'de-thi-dam-mau-1_600x877.jpg', 99, CAST(0x0000AEA100DD530F AS DateTime), CAST(0x0000AEA100DD530F AS DateTime), N'Với những vụ án rùng rợn, kinh dị và khủng khiếp qua ngòi bút sắc bén của tác giả Lôi Mễ, “Đề thi đẫm máu” đã trở thành một trong những cuốn tiểu thuyết trinh thám nổi tiếng nhất trên thế giới thu hút được sự quan tâm của hàng triệu độc giả.

Ám ảnh, sợ hãi và bất ngờ, đó là những gì gói gọn trong tác phẩm trinh thám Đề thi đẫm máu nổi tiếng của tác giả Lôi Mễ. Những vụ án ly kì, hậu quả cực kì nghiêm trọng; tên sát nhân với thủ đoạn tàn nhẫn, giết người ghê rợn đều được thể hiện hết sức sinh động qua ngòi bút sắc bén của Lôi Mễ. ')
SET IDENTITY_INSERT [dbo].[SACH] OFF
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([ID_TACGIA], [TENTACGIA]) VALUES (1, N'Huỳnh Giao')
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] ON 

INSERT [dbo].[CHITIETHOADON] ([MASACH], [ID_HOADON], [SLMUA], [THANHTIEN], [DONGIA], [id_cthd]) VALUES (N'S04       ', 13, 1, 300000.0000, 300000.0000, 18)
INSERT [dbo].[CHITIETHOADON] ([MASACH], [ID_HOADON], [SLMUA], [THANHTIEN], [DONGIA], [id_cthd]) VALUES (N'S05       ', 13, 1, 199000.0000, 199000.0000, 19)
INSERT [dbo].[CHITIETHOADON] ([MASACH], [ID_HOADON], [SLMUA], [THANHTIEN], [DONGIA], [id_cthd]) VALUES (N'S06       ', 13, 1, 755000.0000, 755000.0000, 20)
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220523130345_Initial', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220524092517_dbv2', N'5.0.16')
