var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();



if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//���������� ��������� ��������� ������ � ���������� (css, js � �.�.)
app.UseStaticFiles();

//���������� ������� �������������
app.UseRouting();

// ������������� ������������� ��������� � �������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
