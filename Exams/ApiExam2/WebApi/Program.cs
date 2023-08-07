using Infrustructure.Data;
using Infrustructure.Services.CourseSevices;
using Infrustructure.Services.PostServices;
using Infrustructure.Services.StudentServices;
using Infrustructure.Services.TeacherServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connetion= builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<DataContext>(conf=>conf.UseNpgsql(connetion));
builder.Services.AddScoped<IStudentService,StudentService>();
builder.Services.AddScoped<ITeacherService,TeacherService>();
builder.Services.AddScoped<ICourseSevice,CourseService>();
builder.Services.AddScoped<IPostService,PostService>();
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
