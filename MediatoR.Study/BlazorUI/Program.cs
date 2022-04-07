using BlazorUI.Data;
using DemoLibrary.DataAccess;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MediatR;
using DemoLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Using Singleton for Demo effect to persist data
builder.Services.AddSingleton<IDemoDataAccess, DemoDataAccess>();

// Must grab a any class of the DemoDataAccess
// builder.Services.AddMediatR(typeof(DemoDataAccess).Assembly);
// But we create a class DemoLibraryEntrypoint for MediatR Entrypoint to delegate this funcionality onl
builder.Services.AddMediatR(typeof(DemoLibraryEntrypoint).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
