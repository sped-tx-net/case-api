using System.Composition.Hosting;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace System.Text.CodeGeneration
{
    public static class Program
    {
        private const string _openApiUrl = @"https://raw.githubusercontent.com/sped-tx-net/web-assets/main/schemas/openapi/case-v1p0-openapi.json";

        public static async Task Main(string[] args)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://raw.githubusercontent.com/sped-tx-net/web-assets/")
            };
            
            using (var stream = await httpClient.GetStreamAsync("main/schemas/openapi/case-v1p0-openapi.json"))
            {
                var oDoc = new OpenApiStreamReader().Read(stream, out var diagnostic);

                foreach(var kvp in oDoc.Paths)
                {
                    var className = kvp.Key.Split('/', StringSplitOptions.RemoveEmptyEntries)[1] + "Controller";
                    WriteControllerClass(className, kvp.Value);
                    OpenApiResponse r;
                }

            }

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void WriteControllerClass(string className, OpenApiPathItem value)
        {
            foreach (var operation in value.Operations.Select(x => x.Value))
            {
                foreach(var parameter in operation.Parameters)
                {
                    var parameterName = parameter.Name;
                    var description = parameter.Description;
                    switch (parameter.In.Value)
                    {
                        case ParameterLocation.Query:
                            break;
                        case ParameterLocation.Path:
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static OpenApiDocument GetOpenApiDocument()
        {
            var webClient = new WebClient();
            var input = webClient.DownloadString("https://raw.githubusercontent.com/sped-tx-net/web-assets/main/schemas/openapi/case-v1p0-openapi.json");
            var document = new OpenApiStringReader().Read(input, out var diagnostic);
            return document;
        }

        private static async Task<T> GetExportAsync<T>()
        {
            await Task.CompletedTask;

            using (var host = CreateHost())
            {
                return host.GetExport<T>();
            }
        }

        private static CompositionHost CreateHost() =>
            new ContainerConfiguration()
            .WithAssembly(Assembly.GetExecutingAssembly())
            .CreateContainer();
    }

}
