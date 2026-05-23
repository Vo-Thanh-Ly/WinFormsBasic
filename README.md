# 🖥️ StudentManagement — WinForms CRUD Demo

Đây là dự án demo **Windows Forms** sử dụng **Entity Framework Core** để thực hiện các thao tác **CRUD** (Create, Read, Update, Delete) cơ bản trên **SQL Server 2022+**.

Dự án được phát triển trong thời gian ngắn, mang tính chất **demo**, không có các ràng buộc phức tạp, tập trung vào việc trình bày khả năng thao tác dữ liệu với ứng dụng WinForms.

---

## 🛠️ Công nghệ sử dụng

| Công nghệ | Chi tiết |
|---|---|
| **Framework** | .NET 8.0 (Windows Forms) |
| **ORM** | Entity Framework Core 8.0.25 |
| **Database** | SQL Server 2022+ (Express / Developer / Standard) |
| **Ngôn ngữ** | C# WinForms |

---

## 📁 Cấu trúc dự án

```
StudentManagement/
└── WinFormsBasic/
    └── StudentManagementBasic/
        ├── Data/
        │   └── Data.cs          ← Cấu hình kết nối database
        ├── Forms/               ← Các form giao diện
        ├── Models/              ← Các model dữ liệu
        ├── data.sql             ← Script tạo database và dữ liệu mẫu
        ├── data.bak             ← Backup file database (khôi phục nhanh)
        └── Program.cs
StudentManagement.sln
```

---

## 🚀 Hướng dẫn chạy dự án

### 1. Clone repository

```bash
git clone <đường-dẫn-repo-của-bạn>
```

### 2. Mở project

Mở file solution `StudentManagement.sln` bằng một trong các IDE sau:

- Visual Studio 2022+
- JetBrains Rider
- VS Code (có cài extension C#)

### 3. Cài đặt môi trường

**Yêu cầu:**

- .NET 8 SDK
- SQL Server 2022+ (Express / Developer / Standard)
- SQL Server Management Studio (SSMS) 19+ (khuyến nghị)
- Visual Studio 2022 (có hỗ trợ WinForms)

Kiểm tra phiên bản .NET:

```bash
dotnet --version
```

### 4. Cấu hình kết nối database

Mở file cấu hình:

```
WinFormsBasic\StudentManagementBasic\Data\Data.cs
```

Tìm và cập nhật dòng connection string:

```csharp
optionsBuilder.UseSqlServer("Server=.;Database=StudentManagement;Trusted_Connection=True;TrustServerCertificate=True;");
```
