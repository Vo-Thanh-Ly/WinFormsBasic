using Microsoft.EntityFrameworkCore;
using StudentManagementBasic.Models;

namespace StudentManagementBasic.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Thay đổi connection string phù hợp với máy bạn
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình thêm cho bảng SinhVien
            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasIndex(e => e.MaSinhVien).IsUnique(); // Mã sinh viên là duy nhất
                entity.Property(e => e.HoTen).IsRequired();
            });
        }
    }
}