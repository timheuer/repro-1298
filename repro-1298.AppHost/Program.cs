var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.repro_1298_ApiService>("apiservice");

builder.AddProject<Projects.repro_1298_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
