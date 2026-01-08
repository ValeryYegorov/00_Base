using Contracts;
using Grpc.Core;

namespace TestWebApp.Services;

public class GreeterService(ILogger<GreeterService> logger, IBaseRepository baseRepository)
    : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger = logger;

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        
        return Task.FromResult(baseRepository.GetHelloReplyTest(request.Name));
    }
}