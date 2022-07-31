using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Server.Services;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SinhVienContext>
    (options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddTransient<IBangDiem, BangDiemService>();
builder.Services.AddTransient<ILop, LopService>();
builder.Services.AddTransient<IMonHoc, MonHocService>();
builder.Services.AddTransient<INganh, NganhService>();
builder.Services.AddTransient<ISinhVien, SinhVienService>();
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
