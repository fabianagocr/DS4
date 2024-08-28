var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Laboratorio1_ApiService>("apiservice");

builder.AddProject<Projects.Laboratorio1_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
