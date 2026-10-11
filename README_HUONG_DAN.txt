PROJECT MẪU TỪ ĐẦU: PRODUCT ADMIN - TÌM KIẾM, SẮP XẾP, PHÂN TRANG
Công nghệ: ASP.NET MVC 5, C#, .NET Framework 4.8

CHỨC NĂNG
- Tìm kiếm theo tên sản phẩm.
- Sắp xếp theo tên A-Z, tên Z-A, giá tăng dần, giá giảm dần.
- Phân trang.
- Chọn số sản phẩm trên một trang (5, 10 hoặc 20).
- Giữ từ khóa và kiểu sắp xếp khi chuyển trang.

CÁCH MỞ
1. Giải nén ZIP vào một thư mục bình thường, không mở project trực tiếp bên trong ZIP.
2. Mở 25dh110208.sln bằng Visual Studio.
3. Nếu Visual Studio hỏi restore NuGet packages, chọn Restore.
4. Chọn Build > Build Solution.
5. Nhấn Ctrl+F5 để chạy.
6. Trang Product mở tại /Product/Index (trang chủ cũng chuyển đến đó).

LƯU Ý QUAN TRỌNG
- Đây là project mẫu độc lập, dùng dữ liệu mẫu trong bộ nhớ để bạn chạy thử ngay; chưa kết nối SQL Server.
- Hai video bạn gửi nói về tìm kiếm/sắp xếp Product và phân trang kết quả tìm kiếm Product. Gói này triển khai các chức năng đó, nhưng không thể cam kết giống từng dòng code hoặc cấu trúc database của cô nếu chưa có transcript/source của video.
- Nếu đề bài yêu cầu sử dụng database có sẵn, cần thay ProductRepository bằng truy vấn database của lớp.
- Đây là source project để đưa lên GitHub, không phải ZIP để upload nguyên xi vào trang nộp bài. Sau khi chạy thử, commit/push thư mục project lên GitHub.
