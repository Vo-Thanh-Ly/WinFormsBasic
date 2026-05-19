using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using StudentManagementBasic.Models;

namespace StudentManagementBasic.Data
{
    public class AppDbContext : DbContext
    {
        //    public DbSet<SinhVien> SinhViens { get; set; }

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        if (!optionsBuilder.IsConfigured)
        //        {
        //            // Thay đổi connection string phù hợp với máy bạn
        //            optionsBuilder.UseSqlServer(@"Server=localhost;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True;");
        //        }
        //    }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        base.OnModelCreating(modelBuilder);

        //        // Cấu hình thêm cho bảng SinhVien
        //        modelBuilder.Entity<SinhVien>(entity =>
        //        {
        //            entity.HasIndex(e => e.MaSinhVien).IsUnique(); // Mã sinh viên là duy nhất
        //            entity.Property(e => e.HoTen).IsRequired();
        //        });
        //    }


        // Constructor không tham số - BẮT BUỘC cho EF Tools design-time
        public AppDbContext() { }

        // Constructor có tham số - Dùng khi inject từ DI container
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Khai báo các DbSet
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<HocKy> HocKys { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DbSet<DangKyHocPhan> DangKyHocPhans { get; set; }
        public DbSet<DiemSo> DiemSos { get; set; }

        // Phương thức này cung cấp chuỗi kết nối cho EF Tools khi chạy design-time
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // THAY ĐỔI CHUỖI KẾT NỐI NÀY CHO ĐÚNG VỚI MÁY BẠN
                optionsBuilder.UseSqlServer("Server=localhost;Database=StudentManagement;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình quan hệ SinhVien - Lop (N-1)
            modelBuilder.Entity<SinhVien>()
                .HasOne(s => s.Lop)
                .WithMany(l => l.SinhViens)
                .HasForeignKey(s => s.MaLop)
                .OnDelete(DeleteBehavior.SetNull);

            // Cấu hình quan hệ Lop - Khoa (N-1)
            modelBuilder.Entity<Lop>()
                .HasOne(l => l.Khoa)
                .WithMany(k => k.Lops)
                .HasForeignKey(l => l.MaKhoa)
                .OnDelete(DeleteBehavior.Restrict);

            // Cấu hình quan hệ GiangVien - Khoa (N-1)
            modelBuilder.Entity<GiangVien>()
                .HasOne(g => g.Khoa)
                .WithMany(k => k.GiangViens)
                .HasForeignKey(g => g.MaKhoa)
                .OnDelete(DeleteBehavior.SetNull);

            // Cấu hình quan hệ LopHocPhan - MonHoc (N-1)
            modelBuilder.Entity<LopHocPhan>()
                .HasOne(lhp => lhp.MonHoc)
                .WithMany(mh => mh.LopHocPhans)
                .HasForeignKey(lhp => lhp.MaMH)
                .OnDelete(DeleteBehavior.Restrict);

            // Cấu hình quan hệ LopHocPhan - GiangVien (N-1)
            modelBuilder.Entity<LopHocPhan>()
                .HasOne(lhp => lhp.GiangVien)
                .WithMany(gv => gv.LopHocPhans)
                .HasForeignKey(lhp => lhp.MaGV)
                .OnDelete(DeleteBehavior.Restrict);

            // Cấu hình quan hệ DangKyHocPhan - SinhVien (N-1)
            modelBuilder.Entity<DangKyHocPhan>()
                .HasOne(dk => dk.SinhVien)
                .WithMany(s => s.DangKyHocPhans)
                .HasForeignKey(dk => dk.MaSV)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình quan hệ DangKyHocPhan - LopHocPhan (N-1)
            modelBuilder.Entity<DangKyHocPhan>()
                .HasOne(dk => dk.LopHocPhan)
                .WithMany(lhp => lhp.DangKyHocPhans)
                .HasForeignKey(dk => dk.MaLHP)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình quan hệ DiemSo - SinhVien (N-1)
            modelBuilder.Entity<DiemSo>()
                .HasOne(d => d.SinhVien)
                .WithMany(s => s.DiemSos)
                .HasForeignKey(d => d.MaSV)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed Data mẫu (dữ liệu khởi tạo)
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Khoa
            modelBuilder.Entity<Khoa>().HasData(
                new Khoa { MaKhoa = "CNTT", TenKhoa = "Công nghệ thông tin", SoDienThoai = "0123456789", Email = "cntt@university.edu.vn" },
                new Khoa { MaKhoa = "KINHTE", TenKhoa = "Kinh tế", SoDienThoai = "0987654321", Email = "kinhte@university.edu.vn" }
            );

            // Seed Lop
            modelBuilder.Entity<Lop>().HasData(
                new Lop { MaLop = "CNTT01", TenLop = "Công nghệ thông tin 01", MaKhoa = "CNTT", KhoaHoc = "K42", SiSo = 0 },
                new Lop { MaLop = "CNTT02", TenLop = "Công nghệ thông tin 02", MaKhoa = "CNTT", KhoaHoc = "K42", SiSo = 0 },
                new Lop { MaLop = "KT01", TenLop = "Kinh tế 01", MaKhoa = "KINHTE", KhoaHoc = "K42", SiSo = 0 }
            );

            // Seed SinhVien
            modelBuilder.Entity<SinhVien>().HasData(
                new SinhVien
                {
                    MaSV = "SV001",
                    HoTen = "Nguyễn Văn A",
                    NgaySinh = new DateTime(2002, 5, 15),
                    GioiTinh = "Nam",
                    DiaChi = "Hà Nội",
                    SoDienThoai = "0912345678",
                    Email = "nguyenvana@example.com",
                    MaLop = "CNTT01",
                    NamNhapHoc = 2020,
                    TrangThai = true
                },
                new SinhVien
                {
                    MaSV = "SV002",
                    HoTen = "Trần Thị B",
                    NgaySinh = new DateTime(2002, 8, 20),
                    GioiTinh = "Nữ",
                    DiaChi = "TP. Hồ Chí Minh",
                    SoDienThoai = "0923456789",
                    Email = "tranthib@example.com",
                    MaLop = "CNTT02",
                    NamNhapHoc = 2020,
                    TrangThai = true
                }
            );
        }
    }
}