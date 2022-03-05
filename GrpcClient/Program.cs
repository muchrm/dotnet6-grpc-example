using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcClient;

// The port number must match the port of the gRPC server.
// connect grpc without tls should not use in production
using var channel = GrpcChannel.ForAddress("http://localhost:5000");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();