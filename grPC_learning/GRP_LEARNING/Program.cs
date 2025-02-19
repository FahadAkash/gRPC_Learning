using GRP_LEARNING.DBContext;
using GRP_LEARNING.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints => {

    endpoints.MapGrpcService<EcommerceServiceImpl>();

});
// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
