using MechanicalWorkshop.Api;
using MechanicalWorkshop.Api.Data.FakeData;
using MechanicalWorkshop.Api.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container .

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddCors(options => options.AddPolicy("AngularUI",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AngularUI");

app.MapControllers();

//using (var context = new ApplicationDbContext())
//{
//    var data = new FakeRepairDataGenerator();

//    var repairsList = data.SeedWithData();

//    context.Repairs.AddRange(repairsList);

//    context.SaveChanges();
//}

app.Run();
