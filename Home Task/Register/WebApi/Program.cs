using Infrastructure.Data;
using Infrastructure.InfrastructureProfile;
using Infrastructure.Services.PermissionServices;
using Infrastructure.Services.Role_PermissionServices;
using Infrastructure.Services.RoleServices;
using Infrastructure.Services.User_RoleServices;
using Infrastructure.Services.UserServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conn=builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<DataContext>(conf=>conf.UseNpgsql(conn));
builder.Services.AddAutoMapper(typeof(InfrastructureProfile));
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IPermissionService,PermissionService>();
builder.Services.AddScoped<IRole_PermissionService,Role_PermissionService>();
builder.Services.AddScoped<IRoleService,RoleService>();
builder.Services.AddScoped<IUser_RoleServices,User_RoleService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
