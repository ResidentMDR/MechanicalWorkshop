using MechanicalWorkshop.Api;
using MechanicalWorkshop.Api.Data.FakeData;
using MechanicalWorkshop.Api.Model;
using MechanicalWorkshop.Api.Pdf;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using System.Diagnostics;

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

var filePath = @"C:\Users\marci\Downloads\SamplePdf";

var model = InvoiceDocumentDataSource.GetInvoiceDetails();
var document = new InvoiceDocument(model);
document.GeneratePdf(filePath);

Process.Start("explorer.exe", filePath);

app.Run();
