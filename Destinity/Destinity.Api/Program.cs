using Destinity.Api;
using Destinity.Api.Services;
using Destinity.Persistence;
using GrpcBrowser.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddGrpcBrowser();
builder.Services.AddApplicationDbContext(builder.Configuration, builder.Environment);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>().AddToGrpcBrowserWithClient<Greeter.GreeterClient>();
app.UseRouting();
app.UseGrpcBrowser();
app.MapGrpcBrowser();
app.MapGet("/", context =>
{
    context.Response.StatusCode = 302;
    context.Response.Headers.Add("Location", $"{context.Request.Scheme}://{context.Request.Host}/grpc");
    return Task.CompletedTask;
});
app.Run();
