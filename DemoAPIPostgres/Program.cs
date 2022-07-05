
using Microsoft.EntityFrameworkCore;
using DemoAPIPostgres.Data;

var builder = WebApplication.CreateBuilder(args);

/// Add services to the container.
/// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
///builder.Services.AddEndpointsApiExplorer();
///builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ProductDataContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("magicDB"))
    );


builder.Services.AddMvc(o => o.EnableEndpointRouting = false);

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

/// Configure the HTTP request pipeline.
///if (app.Environment.IsDevelopment())
///{
///    app.UseSwagger();
///    app.UseSwaggerUI();
///}


app.MapDefaultControllerRoute();

app.MapGet("/", () => "Hello World!");

app.Run();
