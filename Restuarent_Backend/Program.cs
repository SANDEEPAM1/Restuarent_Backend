using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Restuarent_Backend.Data;
using Restuarent_Backend.Services;
using Restuarent_Backend.Utilities;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddDbContext<ResturantDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnction")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
}
).AddEntityFrameworkStores<ResturantDBContext>()
 .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
   {
       options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
       options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
       options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
   }
   )
    .AddJwtBearer(options =>
    options.TokenValidationParameters = new TokenValidationParameters
    {
       
       ValidateIssuer = true,
       ValidateAudience = true,
       ValidateLifetime = true,
       ValidateIssuerSigningKey = true,
       ValidIssuer = builder.Configuration["Jwt:Issuer"],
       ValidAudience = builder.Configuration["Jwt:Audience"],
       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
       
    }
    );

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
    options.AddPolicy("CustomerPolicy", policy => policy.RequireRole("Customer"));
});

builder.Services.AddScoped<JwtTockenGenerator>(); 

builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactApp", policyBuilder =>
    {
        policyBuilder.WithOrigins("http://localhost:5173");
        policyBuilder.AllowAnyHeader();
        policyBuilder.AllowAnyMethod();
        policyBuilder.AllowCredentials();
    });
});



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("ReactApp");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
