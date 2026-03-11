using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

foreach (var pathKey in new[]
{
    "/models/{modelId}:countTokens",
    "/models/{modelId}:batchEmbedContents",
    "/models/{modelId}:embedContent",
    "/models/{modelId}:generateContent",
})
{
    foreach (var (_, operation) in openApiDocument.Paths![pathKey]!.Operations)
    {
        if (operation.Parameters is { Count: > 0 })
        {
            var param = (OpenApiParameter)operation.Parameters[0]!;
            param.Required = true;
        }
    }
}

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
