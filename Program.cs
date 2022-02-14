WebApplication.CreateBuilder(args).Services.AddControllers();
WebApplication.CreateBuilder(args).Services.AddEndpointsApiExplorer();
WebApplication.CreateBuilder(args).Services.AddSwaggerGen();

var app = WebApplication.CreateBuilder(args).Build();

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
