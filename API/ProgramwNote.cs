using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration); //#45
builder.Services.AddIdentityServices(builder.Configuration); //#45

//Transfer to API/Extensions/ApplicationServiceExtensions.cs
//builder.Services.AddDbContext<DataContext>( opt =>
//  {
    // opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
// fix by codepoilot - opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

// builder.Services.AddCors(); //add this line to fix the CORS error

//#41 Token Services
//  builder.Services.AddScoped<ITokenService, TokenService>(); //addTransient, addScoped, addSingleton
//  builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) //#44 -> nuget gallery -> Microsoft.AspNetCore.Authentication.JwtBearer
 //   .AddJwtBearer(opt =>
 //   {
//        opt.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateIssuerSigningKey = true,
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])),
 //           ValidateIssuer = false,
//            ValidateAudience = false
//        };
//    });

var app = builder.Build();

//      Configure the HTTP request pipeline.
//          if (app.Environment.IsDevelopment())
//          {
//              app.UseSwagger();
//              app.UseSwaggerUI();
//           }

//app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200")); //add this line to fix the CORS error

app.UseHttpsRedirection();

//#44
app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
