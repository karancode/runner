using System.Net.Http;
using GitHub.Runner.Sdk;

namespace GitHub.Runner.Common
{
    [ServiceLocator(Default = typeof(HttpClientHandlerFactory))]
    public interface IHttpClientHandlerFactory : IRunnerService
    {
        HttpClientHandler CreateClientHandler(RunnerWebProxy webProxy);
    }

    public class HttpClientHandlerFactory : IHttpClientHandlerFactory
    {
        public HttpClientHandler CreateClientHandler(RunnerWebProxy webProxy)
        {
            return new HttpClientHandler() { Proxy = webProxy };
        }

        public void Initialize(IHostContext context)
        {
        }
    }
}