var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World");

app.MapGet("/featureA", () => "This is Feature A");
app.MapGet("/featureB", () => "This is Feature B");
app.MapGet("/featureC", () => "This is Feature C");

app.Run();
