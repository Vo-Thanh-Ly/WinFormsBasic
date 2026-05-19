using Microsoft.EntityFrameworkCore;
using StudentManagementBasic.Data;
using StudentManagementBasic.Forms;

namespace StudentManagementBasic
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cách 1: Không dùng DI - Form tự tạo DbContext
           // Application.Run(new Form1());

            // HOẶC Cách 2: Có DI - Inject DbContext vào Form
            Application.Run(new MainForm(new AppDbContext()));
        }
    }
}