using API_Vinted.Models;
using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddRazorPages();
builder.Services.AddDbContext<VintedDBContext>(options =>
  options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).UseNpgsql(builder.Configuration.GetConnectionString("VintedDBContextRemote")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<DataManager<Achat>>();
builder.Services.AddScoped<DataManager<Article>>();
builder.Services.AddScoped<DataManager<Client>>();
builder.Services.AddScoped<DataManager<Categorie>>();
builder.Services.AddScoped<ArticleManager>();
builder.Services.AddScoped<VilleManager>();
builder.Services.AddScoped<LangueManager>();
builder.Services.AddScoped<PhotoManager>();
builder.Services.AddScoped<AdresseManager>();
builder.Services.AddScoped<SexeManager>();
builder.Services.AddScoped<CategorieManager>();
builder.Services.AddScoped<DataManager<Caracteristique>>();
builder.Services.AddScoped<DataManager<Couleur>>();
builder.Services.AddScoped<DataManager<FormatColis>>();
builder.Services.AddScoped<IDataRepository<Marque>, MarqueManager>();
builder.Services.AddScoped<IDataRepository<Article>, ArticleManager>();
builder.Services.AddScoped<IDataRepository<Client>, ClientManager>();
builder.Services.AddScoped<IDataRepository<Categorie>, CategorieManager>();
builder.Services.AddScoped<IDataRepository<Caracteristique>, CaracteristiqueManager>();
builder.Services.AddScoped<IDataRepository<FormatColis>, FormatColisManager>();
builder.Services.AddScoped<IDataRepository<Couleur>, CouleurManager>();



var MyAllowSpecificOrigins = "_MyAllowSubdomainPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                          policy.AllowAnyHeader();
                      });
});


builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"])),
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddAuthorization(config =>
{
    config.AddPolicy(Policies.Admin, Policies.AdminPolicy());
    config.AddPolicy(Policies.User, Policies.UserPolicy());
});





var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();
