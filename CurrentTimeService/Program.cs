var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC and check if this works
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

// GET DateTime Now and check if this works
app.MapGet("time/default", () => Results.Ok(DateTime.Now));

await app.RunAsync();
