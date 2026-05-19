using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HocKy",
                columns: table => new
                {
                    MaHK = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenHK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HocKyThu = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocKy", x => x.MaHK);
                });

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    MaKhoa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenKhoa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.MaKhoa);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    MaGV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaKhoa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HocVi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.MaGV);
                    table.ForeignKey(
                        name: "FK_GiangVien_Khoa_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaKhoa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    KhoaHoc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SiSo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_Lop_Khoa_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    MaMH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenMH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false),
                    MaKhoa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.MaMH);
                    table.ForeignKey(
                        name: "FK_MonHoc_Khoa_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "MaKhoa");
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaLop = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NamNhapHoc = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_SinhVien_Lop_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "LopHocPhan",
                columns: table => new
                {
                    MaLHP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaMH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaGV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaHK = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PhongHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SiSoToiDa = table.Column<int>(type: "int", nullable: false),
                    SiSoHienTai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocPhan", x => x.MaLHP);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_GiangVien_MaGV",
                        column: x => x.MaGV,
                        principalTable: "GiangVien",
                        principalColumn: "MaGV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_HocKy_MaHK",
                        column: x => x.MaHK,
                        principalTable: "HocKy",
                        principalColumn: "MaHK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_MonHoc_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MonHoc",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiemSo",
                columns: table => new
                {
                    MaDiem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaMH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaHK = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DiemChuyenCan = table.Column<double>(type: "float", nullable: true),
                    DiemGiuaKy = table.Column<double>(type: "float", nullable: true),
                    DiemCuoiKy = table.Column<double>(type: "float", nullable: true),
                    DiemTongKet = table.Column<double>(type: "float", nullable: true),
                    XepLoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemSo", x => x.MaDiem);
                    table.ForeignKey(
                        name: "FK_DiemSo_HocKy_MaHK",
                        column: x => x.MaHK,
                        principalTable: "HocKy",
                        principalColumn: "MaHK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiemSo_MonHoc_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MonHoc",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiemSo_SinhVien_MaSV",
                        column: x => x.MaSV,
                        principalTable: "SinhVien",
                        principalColumn: "MaSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DangKyHocPhan",
                columns: table => new
                {
                    MaDK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaLHP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DiemQuaTrinh = table.Column<double>(type: "float", nullable: true),
                    DiemCuoiKy = table.Column<double>(type: "float", nullable: true),
                    DiemTongKet = table.Column<double>(type: "float", nullable: true),
                    KetQua = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKyHocPhan", x => x.MaDK);
                    table.ForeignKey(
                        name: "FK_DangKyHocPhan_LopHocPhan_MaLHP",
                        column: x => x.MaLHP,
                        principalTable: "LopHocPhan",
                        principalColumn: "MaLHP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKyHocPhan_SinhVien_MaSV",
                        column: x => x.MaSV,
                        principalTable: "SinhVien",
                        principalColumn: "MaSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Khoa",
                columns: new[] { "MaKhoa", "Email", "SoDienThoai", "TenKhoa" },
                values: new object[,]
                {
                    { "CNTT", "cntt@university.edu.vn", "0123456789", "Công nghệ thông tin" },
                    { "KINHTE", "kinhte@university.edu.vn", "0987654321", "Kinh tế" }
                });

            migrationBuilder.InsertData(
                table: "Lop",
                columns: new[] { "MaLop", "KhoaHoc", "MaKhoa", "SiSo", "TenLop" },
                values: new object[,]
                {
                    { "CNTT01", "K42", "CNTT", 0, "Công nghệ thông tin 01" },
                    { "CNTT02", "K42", "CNTT", 0, "Công nghệ thông tin 02" },
                    { "KT01", "K42", "KINHTE", 0, "Kinh tế 01" }
                });

            migrationBuilder.InsertData(
                table: "SinhVien",
                columns: new[] { "MaSV", "DiaChi", "Email", "GioiTinh", "HoTen", "MaLop", "NamNhapHoc", "NgaySinh", "SoDienThoai", "TrangThai" },
                values: new object[,]
                {
                    { "SV001", "Hà Nội", "nguyenvana@example.com", "Nam", "Nguyễn Văn A", "CNTT01", 2020, new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", true },
                    { "SV002", "TP. Hồ Chí Minh", "tranthib@example.com", "Nữ", "Trần Thị B", "CNTT02", 2020, new DateTime(2002, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0923456789", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DangKyHocPhan_MaLHP",
                table: "DangKyHocPhan",
                column: "MaLHP");

            migrationBuilder.CreateIndex(
                name: "IX_DangKyHocPhan_MaSV",
                table: "DangKyHocPhan",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_DiemSo_MaHK",
                table: "DiemSo",
                column: "MaHK");

            migrationBuilder.CreateIndex(
                name: "IX_DiemSo_MaMH",
                table: "DiemSo",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_DiemSo_MaSV",
                table: "DiemSo",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_MaKhoa",
                table: "GiangVien",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MaKhoa",
                table: "Lop",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_MaGV",
                table: "LopHocPhan",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_MaHK",
                table: "LopHocPhan",
                column: "MaHK");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_MaMH",
                table: "LopHocPhan",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_MaKhoa",
                table: "MonHoc",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_MaLop",
                table: "SinhVien",
                column: "MaLop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangKyHocPhan");

            migrationBuilder.DropTable(
                name: "DiemSo");

            migrationBuilder.DropTable(
                name: "LopHocPhan");

            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "HocKy");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
