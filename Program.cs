using Microsoft.AspNetCore.Cors;
// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.

// builder.Services.AddControllers();
// builder.Services.AddControllers();
// {
//     OptionsBuilderConfigurationExtensions.AddPolicy("OpenPolicy");
// }
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();


System.Console.WriteLine("Sup.");
// DeleteSong.DropSongTable();
// SaveSong.CreateSongTable();

// ReadSongData theSongs = new ReadSongData();
// theSongs.GetAllSongs();

// Song mySong = new Song(){Title="Sanctuary", Artist="Joji"};
// mySong.Save.CreateSong(mySong);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("OpenPolicy", 
    builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("OpenPolicy");

app.UseRouting();

app.MapControllers();

app.UseEndpoints(endpoints => 
{
    endpoints.MapControllers();
});

app.Run();

