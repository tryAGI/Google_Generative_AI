using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var openApiDocument = new OpenApiStringReader().Read(yamlOrJson, out var diagnostics);

openApiDocument.Paths["/models/{modelId}:countTokens"]!.Operations[OperationType.Post]!.Parameters![0]!.Required = true;
openApiDocument.Paths["/models/{modelId}:batchEmbedContents"]!.Operations[OperationType.Post]!.Parameters![0]!.Required = true;
openApiDocument.Paths["/models/{modelId}:embedContent"]!.Operations[OperationType.Post]!.Parameters![0]!.Required = true;
openApiDocument.Paths["/models/{modelId}:generateContent"]!.Operations[OperationType.Post]!.Parameters![0]!.Required = true;

// Uses `key` in the query string
openApiDocument.Components.SecuritySchemes.Add("ApiKey", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.ApiKey,
    In = ParameterLocation.Query,
    Name = "key",
});
openApiDocument.SecurityRequirements.Add(new OpenApiSecurityRequirement
{
    [new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Id = "ApiKey",
            Type = ReferenceType.SecurityScheme
        }
    }] = new List<string>()
});

openApiDocument.Servers.Clear();
openApiDocument.Servers.Add(new OpenApiServer
{
    Url = "https://generativelanguage.googleapis.com/v1beta"
});

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

yamlOrJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(yamlOrJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);