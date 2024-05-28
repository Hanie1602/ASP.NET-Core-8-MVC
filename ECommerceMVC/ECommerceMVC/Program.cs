using ECommerceMVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Hshop2023Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HShop"));
});
//AddDbContext: khai báo 1 chỗ, phạm vi là toàn ứng dụng

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//Note: 
//Tool -> NuGet Package Manager -> Package Manager Console
//Scaffold-DbContext "chuỗi kết nối" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -f
// Muốn xuất dữ liệu ra thư mục Data: -OutputDir Data
// -f: Database first thì tất cả mọi thay đổi đều đi từ databases