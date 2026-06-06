// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

  // Nhập môn lập trình C# căn bản

// Đặt tên đúng
int tuoiHocVien = 22;
string tenHocVien = "VoPhamKhanhDang";

// Hiển thị thông tin biến ra màn hình Console
Console.WriteLine("tuoiHocVien : " + tuoiHocVien);

int soNguyen = 1000;
long soTo = 111111111111111;
float diemTB = 4.5f;
double diemTK = 5.8888888;

bool inCorrect = true;
bool isRich = false;
char kyTu = 'H';
string fullName = "VoPhamKhanhDang";

// Ép kiểu
int diem = (int) diemTB;
Console.WriteLine("diem = " + diem);
// int ten = (int) fullName ; error!!!
string number = "58";
// int num = (int) number;
int num = int.Parse(number);

// Chú ý phép chia: số nguyn / số nguyên = số nguyên 
int phepChia = 5 / 2;
Console.WriteLine("phepChia = 5/2 " + phepChia);

// Phép gán: =; +=; -=; *=; /=
int x = 0;
int y = 1;
x+=5; // thêm 5 vào x;

// kết quả là biến bool
bool laDung = x == y; // x có bằng y hay không?
Console.WriteLine("laDung = " + laDung);

// Tăng hoặc giảm 1 đơn vị vào biến
x = 100;
Console.WriteLine("x : " + x++);
Console.WriteLine("x : " + x);
        
// Bài 1: Hồ sơ lập trình viên căn bản
        string ten = "VoPhamKhanhDang";
        int tuoi = 22;
        double chieuCao = 1.75;
        char gioiTinh = 'M';
        Console.WriteLine("Ho so: " + ten + ", Tuoi: " + tuoi + ", Chieu cao: " + chieuCao + "m, Gioi tinh: " + gioiTinh);

        // Bài 2: Tự động tính tuổi
        int namSinh = 2004;
        int namHienTai = 2026;
        int tuoiHienTai = namHienTai - namSinh;
        Console.WriteLine("Tuoi hien tai cua ban la: " + tuoiHienTai);

        // Bài 3: Ghép họ và tên chuẩn hóa
        string ho = "Tran";
        string tenDem = "Duc";
        string tenChinh = "Manh";
        string hoTenDayDu = ho + " " + tenDem + " " + tenChinh;
        Console.WriteLine("Ho ten day du: " + hoTenDayDu);

        // Bài 4: Khai báo thông tin sản phẩm
        string tenSP = "Laptop Gaming";
        string maSP = "LAP123";
        int soLuongKho = 15;
        bool conHang = true;
        Console.WriteLine("San pham: " + tenSP + ", Ma: " + maSP + ", So luong: " + soLuongKho + ", Con hang: " + conHang);

        // ================== PHẦN II ==================
        // Bài 5: Chu vi và Diện tích hình vuông
        int c = 8;
        int chuViVuong = 4 * c;
        int dienTichVuong = c * c;
        Console.WriteLine("Chu vi hinh vuong: " + chuViVuong + ", Dien tich: " + dienTichVuong);

        // Bài 6: Hình chữ nhật
        double chieuDai = 14.5;
        double chieuRong = 6.2;
        double chuViCN = 2 * (chieuDai + chieuRong);
        double dienTichCN = chieuDai * chieuRong;
        Console.WriteLine("Chu vi HCN: " + chuViCN + ", Dien tich: " + dienTichCN);

        // Bài 7: Hình tròn
        const double PI = 3.14159;
        double r = 5.5;
        double chuViTron = 2 * PI * r;
        double dienTichTron = PI * r * r;
        Console.WriteLine("Chu vi hinh tron: " + chuViTron + ", Dien tich: " + dienTichTron);

        // Bài 8: Vận tốc di chuyển
        int quangDuong = 105;
        int thoiGian = 2;
        double vanToc = (double)quangDuong / thoiGian;
        Console.WriteLine("Van toc trung binh: " + vanToc + " km/h");

        // Bài 9: Chuyển đổi tiền tệ
        double luongUSD = 120.5;
        int tyGia = 25450;
        double soTienVND = luongUSD * tyGia;
        Console.WriteLine("So tien VND: " + soTienVND);

        // Bài 10: Chia kẹo
        int tongSoKeo = 32;
        int soHocSinh = 6;
        int keoMoiEm = tongSoKeo / soHocSinh;
        int keoDu = tongSoKeo % soHocSinh;
        Console.WriteLine("Moi em nhan: " + keoMoiEm + " keo, Con du: " + keoDu);

        // ================== PHẦN III ==================
        // Bài 11: Phân tách tuần và ngày lẻ
        int tongSoNgay = 45;
        int soTuan = tongSoNgay / 7;
        int ngayLe = tongSoNgay % 7;
        Console.WriteLine("Tong so ngay: " + tongSoNgay + " = " + soTuan + " tuan va " + ngayLe + " ngay le");

        // Bài 12: Quy đổi giây sang Giờ-Phút-Giây
        int tongGiay = 3665;
        int gio = tongGiay / 3600;
        int phut = (tongGiay % 3600) / 60;
        int giay = tongGiay % 60;
        Console.WriteLine("Thoi gian: " + gio + " gio " + phut + " phut " + giay + " giay");

        // Bài 13: Tính điểm tích lũy
        int diemTichLuy = 100;
        diemTichLuy += 50;
        diemTichLuy -= 30;
        diemTichLuy *= 2;
        Console.WriteLine("Diem tich luy cuoi cung: " + diemTichLuy);

        // Bài 14: Tiền tố và Hậu tố
        int a = 10;
        int b = a++;
        int c2 = ++a;
        Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c2);

        // Bài 15: Tính lương thực lĩnh
        double luongCoBan = 12000000;
        double heSoLuong = 1.5;
        double tongLuong = luongCoBan * heSoLuong;
        double baoHiem = tongLuong * 0.105;
        double thucLinh = tongLuong - baoHiem;
        Console.WriteLine("Luong thuc linh: " + thucLinh);

        // ================== PHẦN IV ==================
        // Bài 16: Kiểm tra số chẵn
        int n = 26;
        bool laSoChan = (n % 2 == 0);
        Console.WriteLine("n = " + n + ", La so chan? " + laSoChan);

        // Bài 17: Kiểm tra đạt/trượt
        double diemTrungBinh = 4.8;
        bool laDat = diemTrungBinh >= 5.0;
        Console.WriteLine("Diem TB = " + diemTrungBinh + ", Dat? " + laDat);

        // Bài 18: Kiểm tra số trong khoảng
        int giaTri = 35;
        bool hopLe = (giaTri > 10 && giaTri < 50);
        Console.WriteLine("Gia tri = " + giaTri + ", Hop le? " + hopLe);

        // Bài 19: Điều kiện đi chơi
        bool troiMua = false;
        bool coTien = true;
        bool diChoi = (!troiMua && coTien);
        Console.WriteLine("Di choi? " + diChoi);

        // Bài 20: BMI và thừa cân
        double chieuCao2 = 1.75;
        double canNang = 78.5;
        double bmi = canNang / (chieuCao2 * chieuCao2);
        bool biThuaCan = bmi >= 25.0;
        Console.WriteLine("BMI = " + bmi + ", Bi thua can? " + biThuaCan);
    }
}
