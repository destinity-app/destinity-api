using Grpc.Core;

namespace Destinity.Api.Services;

public class GreeterService : Greeter.GreeterBase {
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context) {
        return Task.FromResult(new HelloReply {
            Message = "Hello " + request.Name
        });
    }
}
