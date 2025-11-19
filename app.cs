var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World");

app.MapGet("/featureA", () => "This is Feature A");
app.MapGet("/featureB", () => "This is Feature B");

app.Run();
