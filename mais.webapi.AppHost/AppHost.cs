var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.mais>("mais");

builder.Build().Run();
