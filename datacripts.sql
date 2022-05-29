USE [QuanLyThuVien4.0]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (1, N'29-11-01 Trương Kiệt', NULL, NULL, N'03890283  ', N'Xã Vĩnh Viễn A, 3445-Huyện Long Mỹ, Tỉnh Hậu Giang.')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (2, N'Kiet Truongg', NULL, NULL, NULL, N'Thị trấn Như Quỳnh, 2046-Huyện Văn Lâm, Tỉnh Hưng Yên.')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (3, N'Kiet Truong', NULL, NULL, N'0366798917', N'Xã Bảo Hiệu, 2270-Huyện Yên Thủy, Tỉnh Hòa Bình.')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (4, N'Kiệt Cao', NULL, NULL, N'0366709818', N'Xã Minh Hòa, Huyện Hữu Lũng, Tỉnh Lạng Sơn')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (6, N'Kiet Cao', NULL, NULL, N'0366798917', N'Thị trấn Mường Khương, Huyện Mường Khương, Tỉnh Lào Cai')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (7, N'sda Cas', NULL, NULL, N'0366798917', N'Xã Lăng Yên, Huyện Trùng Khánh, Tỉnh Cao Bằng')
INSERT [dbo].[KhachHang] ([id_kh], [TenKhachHang], [gioitinh], [ngaysinh], [Sdt], [DiaChi]) VALUES (8, N'Kiet Cao', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'104620105072799234499              ', 1, NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'admin                              ', 2, N'12345678      ', NULL, 1, NULL, NULL)
INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'1066880047269906                   ', 3, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'101855537316040894871              ', 4, NULL, NULL, NULL, 3, NULL)
INSERT [dbo].[TAIKHOAN] ([USER_NAME], [ID_TAIKHOAN], [PASSWORD], [SALT], [Role], [id_kh], [PhiShip]) VALUES (N'106967982407742631610              ', 5, NULL, NULL, NULL, 8, NULL)
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
GO
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([ID_HOADON], [CREATEDAT], [UpdatedAt], [USER_NAME], [TongHoaDon], [phiship], [discount], [soluong], [status], [id_kh]) VALUES (13, CAST(N'2022-05-26T15:36:25.753' AS DateTime), CAST(N'2022-05-26T15:36:25.753' AS DateTime), NULL, 1254000.0000, 54700.0000, 0.0000, 3, 1, 7)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
GO
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([MANXB], [ID_NXB], [DIACHI], [SDT], [TENNXB]) VALUES (N'NXB01     ', 1, N'H?m t? 3', N'03890283    ', N'Kim Đồng')
INSERT [dbo].[NXB] ([MANXB], [ID_NXB], [DIACHI], [SDT], [TENNXB]) VALUES (N'NXB02     ', 2, NULL, N'29112001    ', N'Nhà Xuất Bản Thanh Niên')
SET IDENTITY_INSERT [dbo].[NXB] OFF
GO
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MAPHIEUNHAP], [ID_PHIEUNHAP], [SOLUONGNHAP], [GIANHAP], [CREATEDAT], [UpdatedAt]) VALUES (N'PN01      ', 1, 100, 500000.0000, CAST(N'2022-05-25T02:14:43.753' AS DateTime), CAST(N'2022-05-25T02:14:43.753' AS DateTime))
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
GO
SET IDENTITY_INSERT [dbo].[THELOAI] ON 

INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'TL01      ', 1, N'Thiếu Nhi')
INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'TT01      ', 2, N'Trinh Thám')
INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'LT01      ', 3, N'Văn Học')
INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'TL02      ', 6, N'Tâm Lý')
INSERT [dbo].[THELOAI] ([MATHELOAI], [ID_THELOAI], [TENTHELOAI]) VALUES (N'KNS01     ', 7, N'Kỹ Năng Sống')
SET IDENTITY_INSERT [dbo].[THELOAI] OFF
GO
SET IDENTITY_INSERT [dbo].[SACH] ON 

INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S01       ', 3, N'NXB01     ', N'PN01      ', N'TL02      ', N'Đắc Nhân Tâm', 120000.0000, N'sach-hay-dac-nhan-tam.jpg', 95, CAST(N'2022-05-26T10:42:07.543' AS DateTime), CAST(N'2022-05-26T10:42:07.543' AS DateTime), N'Đắc Nhân Tâm (How to Win Friends and Influence People) được mệnh danh là quyển sách hay nhất, nổi tiếng nhất, bán chạy nhất và nó có tầm ảnh hưởng đi xa nhất mọi thời đại, Đắc Nhân Tâm của soạn giả Dale Carnegie là 1 quyển sách hay nên đọc để bạn biết về nghệ thuật thu phục lòng người và làm tất cả mọi người phải yêu mến mình.

Quyển sách này cũng nêu bật lên các nguyên tắc trong việc đối nhân xử thế rất khôn ngoan bắt đầu từ việc thấu hiểu, thành thật với chính bản thân mình cũng như gợi ý cho người đọc cách biết quan tâm đến những người kế bên để cùng hòa nhập, cùng nhau phát triển khả năng của chính mình và mọi người lên 1 tầm cao mới.

Những người đã đọc sách Đắc Nhân Tâm có thể cũng cảm nhận được một tinh thần xuyên suốt mà tác giả muốn thể hiện trong quyển sách hay này. Đấy chính là chữ “nhẫn”. Nếu bạn có chữ “nhẫn” thì tất cả mọi việc sẽ được thay đổi nhìn nhận theo 1 hướng khác mà nơi đó sẽ khiến cho cuộc sống trở nên là một màu xanh hy vọng mãi mãi.')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S02       ', 4, N'NXB01     ', N'PN01      ', N'LT01      ', N'Nhà giả kim', 300000.0000, N'sach-hay-nha-gia-kim.jpg', 88, CAST(N'2022-05-26T10:43:23.180' AS DateTime), CAST(N'2022-05-26T10:43:23.180' AS DateTime), N'Nhà giả kim (The Alchemist) của Paulo Coelho là một cuốn sách hay dành cho những người đã đánh mất đi ước mơ hoặc chưa bao giờ có nó. Nếu bạn đang cần tìm những cuốn sách nên đọc để thành công thì Nhà Giả Kim rất xứng đáng. Thành công như thế nào: thành công trong trong suy nghĩ và hành động.

Cuốn sách này bán chạy thứ 2 trên thế giới chỉ sau Kinh Thánh, và được dịch ra với nhiều ngôn ngữ trên thế giới.

Lời văn tuy bình dị, nhẹ nhàng nhưng đậm chất thơ trong đó, thấm đẫm các triết lý huyền bí của Phương Đông nhưng lại là một động lực vững chắc cho những con người đang tìm kiếm một hoài bão trong tâm hồn, yêu thích và những ai đang trên đường đời thực hiện những ước mơ của bản thân.

Trước đây tôi vẫn thường tự hỏi bản thân mình rằng: Tôi tồn tại có ý nghĩa gì trong cuộc đời này? Tôi không thông minh và dĩ nhiên cũng chẳng đẹp trai chút nào. Tôi không biết mình thích điều gì, muốn cái gì. Thậm chí ước mơ của mình là gì, hoài bão ra sao để mà sống hết mình vì nó. Giống như một người “sống trong bao” không lí tưởng không mục đích toàn vẹn, đơn thuần chỉ là tôi tồn tại.

Vì lẽ đó, tôi sẽ sống những ngày không lí tưởng đấy nếu không vô tình đọc được cuốn tiểu thuyết Nhà giả kim của Paulo Ceolho.

')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S03       ', 5, N'NXB01     ', N'PN01      ', N'LT01      ', N'Ông Già Và Biển Cả', 500000.0000, N'sach-hay-ong-gia-va-bien-ca.jpg', 97, CAST(N'2022-05-26T11:54:10.547' AS DateTime), CAST(N'2022-05-26T11:54:10.547' AS DateTime), N'Ông già và Biển cả (The Old Man and the Sea) là truyện ngắn dạng viễn tưởng cuối cùng được viết bởi Hemingway. Đây cũng là tác phẩm nổi danh và là 1 trong các đỉnh cao trong sự nghiệp sáng tác của nhà văn. Tác phẩm này đoạt giải Pulitzer cho tác phẩm hư cấu năm 1953.

Nó cũng góp phần quan trọng để nhà văn được nhận Giải Nobel văn học năm 1954.

Trong tác phẩm này, ông đã triệt để sử dụng nguyên lý mà ông gọi là “tảng băng trôi”, chỉ mô tả một phần nổi còn lại bảy phần chìm, lúc mô tả sức mạnh của con cá, sự chênh lệch về lực lượng, về cuộc chiến đấu không cân sức giữa con cá hung dữ với ông già. Tác phẩm ca ngợi niềm tin, sức lao động và khát vọng của con người.

Đây là một tác phẩm lý tưởng, nó thật sự mang ý nghĩa rất lớn đặc biệt là đối với những ai đang muốn bỏ cuộc, đang muốn đầu hàng chính bản thân mình, bạn không thể biết được điều gì đang đợi bạn phía trước, hãy tin tưởng vào con đường bạn đã chọn, tin tưởng vào khả năng của chính mình.

Khi bắt đầu chán nản hãy suy nghĩ vì sao mình bắt đầu? Trên con đường đến với thành công không có dấu chân của những kẻ bỏ cuộc.')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S04       ', 6, N'NXB01     ', N'PN01      ', N'TT01      ', N'Mật mã Davinci', 300000.0000, N'mat_ma_da_vinci_600x884.jpg', 99, CAST(N'2022-05-26T13:22:25.043' AS DateTime), CAST(N'2022-05-26T13:22:25.043' AS DateTime), N'Thêm một cuốn tiểu thuyết nổi tiếng của nhà văn Dan Brown được mệnh danh là một trong số cuốn tiểu thuyết trinh thám hay nhất mọi thời đại đó chính là Mật mã Davinci. Vào thời điểm tác phẩm này ra đời đã gây ra cuộc tranh cãi lớn trên văn đàn thế giới bởi việc sử dụng yếu tố thần học trong tác phẩm. Cuốn sách mang đậm phong cách cá nhân của Dan Brown khi có sự đan xen giữa yếu tố trinh thám và yếu tố thần thoại, hai chất liệu hoàn toàn trái ngược nhau.

Với những tình tiết hấp dẫn, hồi hộp hết sức nhưng không kém thú vị bạn sẽ khám phá được từ bất ngờ này đến bất ngờ khác trong câu chuyện. Tác phẩm kể nhân vật Langdon đang sống yên ổn, bỗng nhiên một ngày lại rơi vào một hoàn cảnh nguy hiểm đến tính mạng. Những may mắn ông đã gặp một người phụ nữ xinh đẹp nhưng không kém phần thông minh đó chính là Sophia. Sau một chuyến chạy trốn đầy nguy hiểm nhờ sự giúp đỡ của một nhà sử học tài ba có tên Teabing cả Langdon và Sophie đã khám phá được một bí mật động trời.')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S05       ', 7, N'NXB01     ', N'PN01      ', N'TT01      ', N'Án mạng trên chuyến tàu tốc hành Phương Đông ', 199000.0000, N'tieu-thuyet-trinh-tham-hay-nhat-khong-nen-bo-qua-an-mang-tren-chuyen-tau-toc-hanh-phuong-dong.jpg', 99, CAST(N'2022-05-26T13:23:50.953' AS DateTime), CAST(N'2022-05-26T13:23:50.953' AS DateTime), N'Được chắp bút bởi Agatha Christe – nữ hoàng truyện trinh thám, tác phẩm mang hơi hướng cổ điển song vẫn còn nguyên sức hút đối với độc giả qua thời gian.

Tác phẩm nói về vụ án mạng kỳ lạ xảy ra trên chuyến tàu tốc hành Phương Đông chạy từ Istambul về Calais mà thám tử Hercule Poirot tình cờ có mặt. Con tàu trở thành một căn phòng kín và hung thủ thì vẫn có mặt trên chuyến tàu trong suốt hành trình phá án. Nạn nhân trong tác phẩm là một kẻ thủ ác, đang bị đe dọa bởi những lá thư vì những tội ác hắn đã làm trong quá khứ, bị giết bởi 12 nhát dao. Nhưng điều kì là là các nhát dao này không phải của cùng 1 người, câu hỏi đặt ra là tại sao lại xuất hiện các vết thương khác nhau trên cùng một nạn nhân đã khiến cho vị thám tử vô cùng đau đầu.

')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S06       ', 8, N'NXB01     ', N'PN01      ', N'TT01      ', N'Đề thi đẫm máu', 755000.0000, N'de-thi-dam-mau-1_600x877.jpg', 99, CAST(N'2022-05-26T13:25:49.063' AS DateTime), CAST(N'2022-05-26T13:25:49.063' AS DateTime), N'Với những vụ án rùng rợn, kinh dị và khủng khiếp qua ngòi bút sắc bén của tác giả Lôi Mễ, “Đề thi đẫm máu” đã trở thành một trong những cuốn tiểu thuyết trinh thám nổi tiếng nhất trên thế giới thu hút được sự quan tâm của hàng triệu độc giả.

Ám ảnh, sợ hãi và bất ngờ, đó là những gì gói gọn trong tác phẩm trinh thám Đề thi đẫm máu nổi tiếng của tác giả Lôi Mễ. Những vụ án ly kì, hậu quả cực kì nghiêm trọng; tên sát nhân với thủ đoạn tàn nhẫn, giết người ghê rợn đều được thể hiện hết sức sinh động qua ngòi bút sắc bén của Lôi Mễ. ')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S07       ', 9, N'NXB01     ', N'PN01      ', N'TL01      ', N'Đời Có Thật Nhạt Nhẽo Hay Do Ta Vô Vị', 65000.0000, N'9717a495221c9c1dcb265fb8c7cad9e0.jpg', 100, CAST(N'2022-05-29T11:43:29.467' AS DateTime), CAST(N'2022-05-29T11:43:29.467' AS DateTime), N'“Đời có thật nhạt nhẽo hay do ta vô vị”, cuốn sách sẽ giúp bạn mở ra các chương của cuộc đời mà trong mỗi chúng ta, ai cũng sẽ đều phải trải qua. Trong những câu chuyện ấy, có lẽ bạn sẽ cảm nhận được rõ ràng hơn những điều mà cuộc sống đã, đang và sẽ mang lại cho mỗi người.

 

Nhiếp Hướng Vinh, tác giả của cuốn sách này đã nói: “Việc đau khổ nhất của đời người chính là biết rõ bản thân không thích cuộc sống hiện tại nhưng lại vẫn kiên trì sống như vậy cả một đời. Muốn làm một người hạnh phúc thì trong lúc còn có thể mơ ước hãy lấy hết nỗ lực ra mà truy cầu mộng tưởng của chính mình”. Vì rằng, nếu bạn sống một cuộc đời theo một bài văn mẫu, thả mình vào trong giữa những đại đa số bình tầm thường thì có phải quá nhạt nhẽo không.')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S08       ', 10, N'NXB01     ', N'PN01      ', N'KNS01     ', N'Xin Bạn Hãy Ôm Lấy Trái Tim Mình Trước Đã', 62400.0000, N'e37103f2a7dd95a64b8df89020fc21be.jpg', 100, CAST(N'2022-05-29T11:45:17.370' AS DateTime), CAST(N'2022-05-29T11:45:17.370' AS DateTime), N'Xin bạn hãy ôm lấy trái tim mình trước đã – cuốn cẩm nang giúp bạn làm chủ cảm xúc TIÊU CỰC của mình

- Cuốn sách tâm lý - kỹ năng tiếp nối thành công của #Tôi_từng_nghĩ_mọi_thứ_sẽ_ổn_khi_trở_thành_người_lớn

- Được viết bởi Dae Hyun Yoon - giáo sư hàng đầu của khoa Sức khỏe Tâm thần, bệnh viện Quốc gia Seoul

- 90% độc giả đánh giá 5* trên khắp các diễn đàn sách online tại Hàn Quốc

- Gần 1 triệu bản đã được bán ra trên 3 quốc gia: Trung Quốc, Nhật Bản và Singapore.

- Rất nhiều phương pháp tâm lý trong sách được các tập đoàn lớn tại Hàn Quốc ứng dụng

Xin bạn hãy ôm lấy trái tim mình trước đã sẽ hướng dẫn người đọc cách khám phá và làm bạn với trái tim mình để quản trị hiệu quả cảm xúc nội tâm trên nền tảng tâm lý, y học tâm thần và khoa học về não bộ.

4 chương sách tập trung khai thác sâu vào các khía cạnh đa dạng của diễn biến cảm xúc con người, cả tiêu cực lẫn tích cực để bạn đọc hiểu được nguyên nhân vì sao bản thân lại gặp phải các vấn đề tâm lý đó. Như cách để yêu thương cảm xúc tiêu cực?; Đâu là những cảm xúc không nên bị dồn nén?; Bắt bệnh tâm lý cho những người dễ nổi nóng; Tại sao trầm cảm không xấu?; Vì sao người hướng nội càng cố gắng hoạt bát thì càng mệt mỏi?

Đặc biệt ở cuối mỗi chương, tác giả cung cấp bài đánh giá tổng quan về hội chứng tâm lý bạn đang mắc phải kèm các phương pháp cụ thể để bạn tự chuyển hóa những cảm xúc tiêu cực trong mình, hướng tới đời sống tinh thần lành mạnh hơn, như Cách tập viết cảm xúc xấu thành câu chữ; Cách ghi chú những điều tích cực; Cách nói chuyện phiếm để giải tỏa tâm trạng; Cách tìm ra phương pháp trị liệu bằng âm nhạc của riêng bạ

Cuốn sách đặc biệt dành cho bạn đọc

- Không biết làm sao để làm chủ cảm xúc và kiểm soát tâm trạng

- Không dám sống thật hoặc không biết bộc lộ cá tính của mình

- Không biết cách để làm bạn và yêu thương bản thân

- Có nhiều thắc mắc hoặc đang tìm kiếm câu trả lời/giải pháp cho những suy nghĩ, cảm xúc tiêu cực đang vướng phải

- Đã hoặc đang mắc phải những vấn đề tâm lý

- Yêu thích và quan tâm tới kiến thức tâm lý nói chung

Chứa đựng nhiều kiến thức chuyên ngành nhưng được viết bằng giọng văn nhẹ nhàng thông qua các ví dụ thực tế. Chạm tới các cảm xúc tiêu cực nhưng lại chứa đựng đầy tinh thần lạc quan, hứa hẹn sẽ đem lại cho độc giả cách tiếp cận dễ dàng, đồng cảm mà không hề kém thú vị.


Giá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S09       ', 11, N'NXB02     ', N'PN01      ', N'TT01      ', N'Phía Sau Nghi Can X ', 70850.0000, N'a538698ead7dc2f693d1e9778417317d.jpg', 100, CAST(N'2022-05-29T11:49:42.890' AS DateTime), CAST(N'2022-05-29T11:49:42.890' AS DateTime), N'“Việc nghĩ ra một bài toán vô cùng khó và việc giải bài toán đó, việc nào khó hơn?”
Khi nhấn chuông cửa nhà nghi can chính của một vụ án mới, điều tra viên Kusanagi không biết rằng anh sắp phải đương đầu với một thiên tài ẩn dật. Kusanagi càng không thể ngờ rằng, chỉ một câu nói vô thưởng vô phạt của anh đã kéo người bạn thân, Manabu Yukawa, một phó giáo sư vật lý tài năng, vào vụ án. Và điều làm sững sờ nhất, đó là vụ án kia chẳng qua cũng chỉ như một bài toán cấp ba đơn giản, tuy nhiên ấn số X khi được phơi bày ra lại không đem đến hạnh phúc cho bất cứ ai…
Với một giọng văn tỉnh táo và dung dị, Higashino Keigo đã đem đến cho độc giả hơn cả một cuốn tiểu thuyết trinh thám. Mô tả tội ác không phải điều hấp dẫn nhất ở đây, mà còn là những giằng xé nội tâm thầm kín, những nhân vật bình dị, và sự quan tâm sâu sa tới con người. Tác phẩm đã đem lại cho Higashino Keigo Giải Naoki lần thứ 134, một giải thưởng văn học lâu đời sánh ngang giải Akutagawa tại Nhật.
Giá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S10       ', 12, N'NXB02     ', N'PN01      ', N'TT01      ', N'Án Mạng Dưới Tầng Hầm', 126.0000, N'98cd282bed4a19e65d666cd43f97256f.jpg', 100, CAST(N'2022-05-29T11:51:27.867' AS DateTime), CAST(N'2022-05-29T11:51:27.867' AS DateTime), N'MỘT BÁC SĨ TÂM THẦN VẬT LỘN VỚI SỰ TỈNH TÁO CỦA CHÍNH MÌNH KHI BẰNG CHỨNG GIẾT NGƯỜI CHỐNG LẠI ANH TA

Điều tra viên Susan Adler sẵn sàng khép lại vụ án về một vụ tai nạn xe hơi chết người, nhưng sau khi văn phòng giám định y khoa phát hiện ra dấu vết còn lưu lại từ hành động gây án trên thi thể nạn nhân, cô biết nó đã trở thành một vụ án giết người. Nạn nhân là người vợ giàu có của Randall Brock, một bác sĩ tâm thần nổi tiếng chuyên điều trị cho những bệnh nhân mắc chứng hoang tưởng tàn bạo. Và cứ thế, những nghi ngờ bắt đầu dấy lên trong đầu Susan.

Randall có một quá khứ bạo lực nhưng anh biết mình không giết vợ. Trong nỗi đau buồn tột cùng sau sự ra đi của người vợ thân yêu, anh nhận được lời thăm hỏi từ một người lạ và thông tin chia sẻ về cái chết của vợ anh. Nhưng có một điều kiện: để đổi lấy thông tin từ người đàn ông lạ mặt đó, Randall phải tiết lộ những bí mật đen tối mà anh đã giấu kín trong nhiều năm. Khi hắn gây thêm áp lực và Susan đến gần hơn với những manh mối, Randall bắt đầu nghi ngờ bản thân, tuyệt vọng bám lấy những mảnh ghép trong sự tỉnh táo của mình.

Những tiết lộ và những sự trùng hợp đáng ngờ đặt ra nhiều câu hỏi trong suốt quá trình điều tra, và các tình tiết ngày càng trở nên mất kiểm soát. Nữ điều tra viên Susan phải chạy đua với thời gian để tổng hợp lại tất cả những tình tiết trước khi quá muộn – trước khi vụ giết người tiếp theo đang đến rất gần nhà cô…

Những đánh giá về truyện:

“ Câu chuyện với tiết tấu nhanh dần đi vào lãnh thổ của những sự ngạc nhiên và đáng sợ trước khi lao vào vén màn cái kết thực sự ớn lạnh. Farrell đưa người đọc đi vào một con đường tối tăm và ngoằn ngoèo.” – Pulishers Weekly.

“Cuốn tiểu thuyết “nham hiểm này” là một tác phẩm hoàn hảo cho những người hâm mộ yêu quý Dirty John” – W

“Kỹ năng kể chuyện của Matthew Farrell được thể hiện rõ ngay từ những trang đầu tiên của cuốn tiểu thuyết này. Tác giả thu hút người đọc, đảm bảo câu chuyện là một bí ẩn giết người điển hình theo khuôn mẫu thông thường, sau đó xé bỏ bản phác thảo và ném đi” – New York Journal of Books

“Án mạng dưới tầng hầm diễn ra như một phát súng, nhịp độ nhanh không ngừng nghỉ. Những người hâm mộ John Sandford và Lawrence Block sẽ “đổ xô” đến Matthew Farrell” – Wenday Corsi Staub, tác giả bán chạy nhất của New York Times

“Đen tối và liên tục gây ngạc nhiên, đây là một tác phẩm phải đọc đối với những người hâm mộ thể loại trinh thám thông minh, phức tạp.” – Mark Edwards, tác giả bán chạy nhất với The Magpies

“Không thể ngừng lật giở. Hãy hít thở sâu và cứ tiếp tục như vậy – bộ phim kinh dị không ngừng nghỉ này sẽ khiến bạn phải đoán già đoán non cho đến tận những khúc quanh cuối cùng” – Jennifer Hillier, tác giả của Jar of Hearts

“Ám ảnh kinh hoàng” – Betches

Trích đoạn hấp dẫn:

Những vết thương do vụ nổ súng ngắn có vẻ chí mạng. Hắn sắp chết. Rõ ràng là thế. Không ai biết hắn đang ở đâu, và ngay lúc này, hắn không biết họ đã ngừng tìm kiếm hay chưa. Về lâu dài, điều đó không quan trọng. Hắn chẳng biết gì ngoài việc hắn sẽ trở thành thi thể thứ ba trên nền bê tông lạnh lẽo, bên cạnh người phụ nữ và con gái của bà ta. Đây sẽ là kết cục, là số phận của hắn. Tầng hầm tối tăm này sẽ là thế giới cuối cùng mà hắn biết. Hắn đã sẵn sàng. Nói đúng ra, hắn đang mong đợi nó đến.

Giá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S11       ', 13, N'NXB02     ', N'PN01      ', N'LT01      ', N'Một Lời Nói Dối', 105000.0000, N'62969cf2f369d020a36315c974353be1.jpg', 100, CAST(N'2022-05-29T11:53:40.623' AS DateTime), CAST(N'2022-05-29T11:53:40.623' AS DateTime), N'Một Lời Nói Dối
Một Lời Nói Dối
Họ tiến lại gần căn nhà cho đến khi đến đường giao giữa rừng cây và bãi cỏ. Âm thanh ban đêm bao bọc lấy họ: tiếng ếch ộp oạp, tiếng cá quẫy mình trong nước, tiếng muỗi vo ve bên tai và tiếng diều hâu từ xa kèm theo tiếng rít sợ hãi của một chú chuột. Kẻ đi săn hay kẻ bị săn. Đêm nay, họ là ai?

Một loạt vụ án mạng, bắt cóc liên tiếp xảy ra ở thị trấn sau khi Jane Hardy được kế nhiệm vị trí cảnh sát trưởng của cha mình ở Cảng Pelican, Alabama. Sau khi cha bị buộc tội trộm cắp và có dính líu đến một vụ án mạng, Jane phải đối mặt với sự giám sát của công chúng trong khi cố gắng làm rõ sự trong sạch cho cha mình và chứng minh rằng phụ nữ có thể làm tốt trong những công việc thường mặc định dành cho nam giới".

Liệu có phải kẻ đến từ quá khứ khủng khiếp đang cố gắng phá hủy gia đình duy nhất mà cô có - sau khi cha đưa cô trốn thoát khỏi hội cuồng giáo mười lăm năm trước?

Dối trá, bí mật, giết người, cảnh giác, báo thù và xen lẫn lãng mạn, tất cả tạo nên tác phẩm MỘT LỜI NÓI DỐI hồi hộp nguyên bản và hấp dẫn.

*Những đánh giá về truyện:

_ “Colleen Coble lại một lần nữa khẳng định mình đang đạt đến phong độ đỉnh cao với dòng văn học kịch tính lãng mạn Ki-tô giáo. Tác phẩm gồm những nhân vật sẽ khiến bạn yêu thích, nghi ngờ rồi lại tin tưởng và những khung cảnh sẽ khiến bạn phải nín thở. Câu chuyện của Jane Hardy là hành trình khám phá mạng nhện phức tạp và rối rắm được dệt nên bằng một lời nói dối nhỏ bé.”

Lisa Wingate, tác giả bán chạy nhất New Yorks Times với cuốn Before We Were Yours, nhận xét về Một lời nói dối
_ “Colleen Coble luôn đưa dòng văn học hồi hộp lãng mạn lên một tầm cao mới. Tôi rất thích Một lời nói dối! Cuốn sách đã đưa tôi vào một chuyến hành trình hoang dại và tuyệt vời.”_ DiAnn Mills, tác giả bán chạy nhất

_ “Một lời nói dối, cuốn sách mới nhất của Coble, là một tác phẩm giàu sức nặ Đây chắc chắn là một trong số những cuốn sách hay nhất của cô ấy. Tôi đã thức tới khuya để đọc xong cuốn sách này, vì không tài nào ngủ nổi nếu không được biết chuyện gì sẽ xảy ra tiếp theo. Một cuốn sách mà bạn nhất định phải đọc! Rất đáng khen!”_ Robin Caroll, tác giả bán chạy nhất với tiểu thuyết Xaga Darkwater Inn

_ “Tôi đã luôn mong ngóng tác phẩm mới của Colleen Coble. Một lời nói dối là một hiện tượng mới. Tôi không biết cô ấy đã làm thế nào nhưng tài năng của cô ấy đang tỏa sáng. Chắc chắn bạn sẽ dành nhiều thời gian để đọc vì bạn sẽ không nỡ đặt sách xuống. Tôi đã ngấu nghiến cuốn sách này! Cảm ơn Colleen vì những giờ giải trí đỉnh cao. Tôi sẽ đón đọc tác phẩm tiếp theo!”_ Lynette Eason, tác giả đạt giải thưởng và bán chạy nhất với bộ sách Blue Justice

_ “Ngay từ khi Colleen nhắc đến ý tưởng về Một lời nói dối, tôi đã rất muốn đọc. Cô ấy là một tác giả tuyệt vời và rất giỏi chơi đùa với câu chuyện hồi hộp trên từng trang sách. Tôi cho rằng đây là tác phẩm hay nhất của cô ấy, một lời khen rất đáng kể đấy!” _ Carrie Stuart Parks, tác giả Fragments of Fear

_ “Trong Một lời nói dối, hậu quả của một lời nói dối len lỏi khắp thị trấn Cảng Pelican, tạo nên một mớ hỗn loạn và căng thẳng. Ai sẽ là người thoát ra được khỏi những nghi vấn? Một lời nói dối là tác phẩm mới nhất của Colleen Coble. Câu chuyện diễn ra ở vùng vịnh biển Alabama, với Jane Hardy là cảnh sát trưởng mới nhận chức, đang nỗ lực vì cha mình. Reid Dixon bám theo Jane để quay phim tài liệu, nhưng anh ta cũng có bí mật của riêng mình. Họ cùng nhau đối mặt với những bí mật của bản thân và liệu rằng bí mật có trở thành lời nói dối? Có lẽ nào đã quá muộn để được tha thứ?” _Cara Putman, tác giả bán chạy nhất và đạt giải thưởng

*Về tác giả:

Colleen Coble là tác giả bán chạy nhất USA TODAY và lọt vào vòng chung kết của RITA được biết đến nhiều nhất với các tiểu thuyết hồi hộp lãng mạn ven biển, bao gồm The Inn at Ocean’s Edge, Twilight at Blueberry Barrens, và loạt Lavender Tides, Sunset Cove, Hope Beach, và Rock Harbour.

Giá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S12       ', 14, N'NXB01     ', N'PN01      ', N'LT01      ', N'Thiên Tài Bên Trái, Kẻ Điên Bên Phải', 122000.0000, N'4d3636aadb471cad0bf2f45d681e4f23.jpg', 100, CAST(N'2022-05-29T11:55:19.070' AS DateTime), CAST(N'2022-05-29T11:55:19.070' AS DateTime), N'NẾU MỘT NGÀY ANH THẤY TÔI ĐIÊN, THỰC RA CHÍNH LÀ ANH ĐIÊN ĐẤY!
Hỡi những con người đang oằn mình trong cuộc sống, bạn biết gì về thế giới của mình? Là vô vàn thứ lý thuyết được các bậc vĩ nhân kiểm chứng, là luật lệ, là cả nghìn thứ sự thật bọc trong cái lốt hiển nhiên, hay những triết lý cứng nhắc của cuộc đời?

Lại đây, vượt qua thứ nhận thức tẻ nhạt bị đóng kín bằng con mắt trần gian, khai mở toàn bộ suy nghĩ, để dòng máu trong bạn sục sôi trước những điều kỳ vĩ, phá vỡ mọi quy tắc. Thế giới sẽ gọi bạn là kẻ điên, nhưng vậy thì có sao? Ranh giới duy nhất giữa kẻ điên và thiên tài chẳng qua là một sợi chỉ mỏng manh: Thiên tài chứng minh được thế giới của mình, còn kẻ điên chưa kịp làm điều đó. Chọn trở thành một kẻ điên để vẫy vùng giữa nhân gian loạn thế hay khóa hết chúng lại, sống mãi một cuộc đời bình thường khiến bạn cảm thấy hạnh phúc hơn?

Thiên tài bên trái, kẻ điên bên phải là cuốn sách dành cho những người điên rồ, những kẻ gây rối, những người chống đối, những mảnh ghép hình tròn trong những ô vuông không vừa vặn… những người nhìn mọi thứ khác biệt, không quan tâm đến quy tắc. Bạn có thể đồng ý, có thể phản đối, có thể vinh danh hay lăng mạ họ, nhưng điều duy nhất bạn không thể làm là phủ nhận sự tồn tại của họ. Đó là những người luôn tạo ra sự thay đổi trong khi hầu hết con người chỉ sống rập khuôn như một cái máy. Đa số đều nghĩ họ thật điên rồ nhưng nếu nhìn ở góc khác, ta lại thấy họ thiên tài. Bởi chỉ những người đủ điên nghĩ rằng họ có thể thay đổi thế giới mới là những người làm được điều đó.

Chào mừng đến với thế giới của những kẻ điên.

Giá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S14       ', 16, N'NXB02     ', N'PN01      ', N'TL02      ', N'Hôm Nay Tôi Học Cách Yêu Thương Chính Mình', 105000.0000, N'c5acda35d8dfe4753f9b7932b3bc7749.jpg', 100, CAST(N'2022-05-29T12:10:19.987' AS DateTime), CAST(N'2022-05-29T12:10:19.987' AS DateTime), N'“Tôi muốn tư vấn cho bạn điều gì đó nhưng một người còn nhiều thiếu sót như tôi không đủ khả năng làm việc này. Thế nên tôi chỉ có thể viết ra những tâm tình thời còn nông nổi của mình, rằng tôi cũng đã từng như thế. Chỉ vậy thôi. Tôi từng như thế và vẫn đang sống, cho nên bạn nhất định sẽ sống sót.

Tôi và bạn, chúng ta sẽ cùng nhau học cách sống cho mình. Học cách hiểu mình. Và học cả cách nói yêu thương bản thân mình nữa. Vì ở một khía cạnh nào đó, chúng ta đều là những người vụng về. Những người cần được gọt giũa nhiều hơn.”

--- Hôm Nay Tôi Học Cách Yêu Thương Chính Mình, Jeong Youngwook.

-Các tác phẩm chính của anh ấy bao gồm “Chỉ Cần Biết Rằng Bạn Đã Nỗ Lực Hết Mình”, “Tôi Sẽ Viết Thư Cho Bạn”, “Hôm Nay Tôi Học Cách Yêu Thương Chính Mình”…

Các trích dẫn hay trong sách:

- Bạn đủ tư cách để được yêu thương. Nỗi sợ hãi mà bạn từng đối mặt chỉ là ảo ảnh bạn tự tạo ra cho mình mà thôi. Mong rằng chẳng ai trong chúng ta bám víu vào một tình yêu đau khổ nữa. 

-Điều trước tiên bạn cần làm cho chính mình là trở thành người tốt. Nếu có thể, hãy tránh xa những cuộc gặp gỡ không đáng có. Và trở thành người biết quý trọng mọi thứ xung quanh. Hãy trở thành người có thể khắc ghi những điều nhỏ nhặt. Người biết cách san sẻ niềm vui và nỗi buồn với người khác thật lòng. Đừng đối xử tốt với người khác để giúp mình tốt hơn, hãy đối xử tốt với họ vì bạn yêu thương họ.

- Những suy nghĩ và cảm xúc hỗn độn đang gặm nhấm tâm hồn bạn, đừng để chúng đọng lại, hãy để chúng trôi đi và sống một cuộc đời tươi mới. Vì những tồn đọng không được khơi thông đều bốc mùi theo thời gian. 

- Bạn luôn là duy nhất từ khoảnh khắc được sinh ra đời. Kim cương không được đánh giá cao vì chúng hữu dụng, mà do chúng kiếm có khó tìm. Bạn cũng đặc biệt theo cách đó, vì bạn chỉ có một trên đời. Bạn luôn đặc biệt như thế dù có so sánh với bất kỳ ai. Ngay thời khắc chào đời, ai  trong chúng ta cũng đều là người đặc biệt nhất trên thế gian này.

-Bạn cũng giống như những vì sao đó, những vì sao trên bầu trời đêm kia. Bạn tỏa sáng theo cách bản thân mình chẳng hề hay biết, cho nên bạn sẽ càng tỏa sáng hơn khi đêm đen quây kín quanh mình. Bạn sẽ lấp lánh trong bóng tối vì bạn đã sống cuộc đời chăm chỉ. Những người đã từng phớt lờ sẽ ngẩng cao đầu nhìn lên bạn, trông lên người đã nỗ lực rất nhiều để có được ngày hôm nay, và nói rằng bạn thật đẹp.

-Dù giờ đây, ngay khoảnh khắc này, bạn chưa cảm nhận được sự rực rỡ của bản thân cũng chẳng  sao cả. Chưa tỏa sáng cũng chẳng sao cả. Nếu bạn cứ tiếp tục nỗ lực, thời điểm khiến bạn tỏa sáng sẽ đến, và bạn sẽ rực rỡ hơn thế nữa. Như những vì sao trên bầu trời đêm kia.

Giá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....')
INSERT [dbo].[SACH] ([MASACH], [ID_SACH], [MANXB], [MAPHIEUNHAP], [MATHELOAI], [TENSACH], [GIABAN], [IMG], [SLTON], [CREATEDAT], [UpdatedAt], [Mota]) VALUES (N'S13       ', 15, N'NXB02     ', N'PN01      ', N'TL01      ', N'Hoàng Tử Bé (Tái Bản 2019)', 65000.0000, N'26838e18d7f96d562d828980520019d2.jpg', 100, CAST(N'2022-05-29T12:05:04.503' AS DateTime), CAST(N'2022-05-29T12:05:04.503' AS DateTime), N'Hoàng tử bé được viết ở New York trong những ngày tác giả sống lưu vong và được xuất bản lần đầu tiên tại New York vào năm 1943, rồi đến năm 1946 mới được xuất bản tại Pháp. Không nghi ngờ gì, đây là tác phẩm nổi tiếng nhất, được đọc nhiều nhất và cũng được yêu mến nhất của Saint-Exupéry. Cuốn sách được bình chọn là tác phẩm hay nhất thế kỉ 20 ở Pháp, đồng thời cũng là cuốn sách Pháp được dịch và được đọc nhiều nhất trên thế giới. Với 250 ngôn ngữ dịch khác nhau kể cả phương ngữ cùng hơn 200 triệu bản in trên toàn thế giới, Hoàng tử bé được coi là một trong những tác phẩm bán chạy nhất của nhân loại.

Ở Việt Nam, Hoàng tử bé được dịch và xuất bản khá sớm. Từ năm 1966 đã có đồng thời hai bản dịch: Hoàng tử bé của Bùi Giáng do An Tiêm xuất bản và Cậu hoàng con của Trần Thiện Đạo do Khai Trí xuất bản. Từ đó đến nay đã có thêm nhiều bản dịch Hoàng tử bé mới của các dịch giả khác nhau. Bản dịch Hoàng tử bé lần này, xuất bản nhân dịp kỷ niệm 70 năm Hoàng tử bé ra đời, cũng là ấn bản đầu tiên được Gallimard chính thức chuyển nhượng bản quyền tại Việt Nam, hy vọng sẽ góp phần làm phong phú thêm việc dịch và tiếp nhận tác phẩm quan trọng này với các thế hệ độc giả.

Tôi cứ sống cô độc như vậy, chẳng có một ai để chuyện trò thật sự, cho tới một lần gặp nạn ở sa mạc Sahara cách đây sáu năm. Có thứ gì đó bị vỡ trong động cơ máy bay. Và vì ở bên cạnh chẳng có thợ máy cũng như hành khách nào nên một mình tôi sẽ phải cố mà sửa cho bằng được vụ hỏng hóc nan giải này. Với tôi đó thật là một việc sống còn. Tôi chỉ có vừa đủ nước để uống trong tám ngày.

Thế là đêm đầu tiên tôi ngủ trên cát, cách mọi chốn có người ở cả nghìn dặm xa. Tôi cô đơn hơn cả một kẻ đắm tàu sống sót trên bè giữa đại dương. Thế nên các bạn cứ tưởng tượng tôi đã ngạc nhiên làm sao, khi ánh ngày vừa rạng, thì một giọng nói nhỏ nhẹ lạ lùng đã đánh thức tôi. Giọng ấy nói:
“Ông làm ơn… vẽ cho tôi một con cừu!”
- Trích "Hoàng tử bé"
Giá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....')
SET IDENTITY_INSERT [dbo].[SACH] OFF
GO
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([ID_TACGIA], [TENTACGIA]) VALUES (1, N'Huỳnh Giao')
INSERT [dbo].[TACGIA] ([ID_TACGIA], [TENTACGIA]) VALUES (2, N'Antoine De Saint-Exupéry')
INSERT [dbo].[TACGIA] ([ID_TACGIA], [TENTACGIA]) VALUES (3, N'Eran Katz')
INSERT [dbo].[TACGIA] ([ID_TACGIA], [TENTACGIA]) VALUES (4, N'Nassim Nicholas Taleb')
INSERT [dbo].[TACGIA] ([ID_TACGIA], [TENTACGIA]) VALUES (6, N'Beth Kempton')
INSERT [dbo].[TACGIA] ([ID_TACGIA], [TENTACGIA]) VALUES (5, N'Albert Rutherford')
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
GO
INSERT [dbo].[CHITIETTACGIA] ([MASACH], [ID_TACGIA]) VALUES (N'S01       ', 1)
INSERT [dbo].[CHITIETTACGIA] ([MASACH], [ID_TACGIA]) VALUES (N'S03       ', 2)
INSERT [dbo].[CHITIETTACGIA] ([MASACH], [ID_TACGIA]) VALUES (N'S03       ', 4)
INSERT [dbo].[CHITIETTACGIA] ([MASACH], [ID_TACGIA]) VALUES (N'S05       ', 5)
INSERT [dbo].[CHITIETTACGIA] ([MASACH], [ID_TACGIA]) VALUES (N'S08       ', 5)
INSERT [dbo].[CHITIETTACGIA] ([MASACH], [ID_TACGIA]) VALUES (N'S13       ', 6)
GO
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] ON 

INSERT [dbo].[CHITIETHOADON] ([MASACH], [ID_HOADON], [SLMUA], [THANHTIEN], [DONGIA], [id_cthd]) VALUES (N'S04       ', 13, 1, 300000.0000, 300000.0000, 18)
INSERT [dbo].[CHITIETHOADON] ([MASACH], [ID_HOADON], [SLMUA], [THANHTIEN], [DONGIA], [id_cthd]) VALUES (N'S05       ', 13, 1, 199000.0000, 199000.0000, 19)
INSERT [dbo].[CHITIETHOADON] ([MASACH], [ID_HOADON], [SLMUA], [THANHTIEN], [DONGIA], [id_cthd]) VALUES (N'S06       ', 13, 1, 755000.0000, 755000.0000, 20)
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] OFF
GO
