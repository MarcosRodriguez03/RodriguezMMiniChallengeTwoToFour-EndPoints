using RodriguezMMiniChallengeTwoToFour_EndPoints.Service.AddTwoNumbers;
using RodriguezMMiniChallengeTwoToFour_EndPoints.Service.GreaterThanLessThan;
using RodriguezMMiniChallengeTwoToFour_EndPoints.Service.TwoQuestions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAddTwoNumbers, AddTwoNumbersService>();
builder.Services.AddScoped<ITwoQuestions, TwoQuestionsService>();
builder.Services.AddScoped<IGreaterThanLessThan, GreaterThanLessThanService>();

var app = builder.Build();


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
