using RycAuth.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Get database connection string
string? dbConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add the dependencies
builder.Services.AddInfrastructureDependency(dbConnectionString);

// Add the controllers
builder.Services.AddControllers();

// Add the Swagger API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();