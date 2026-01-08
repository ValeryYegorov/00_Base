namespace Contracts;

public interface IBaseRepository
{
    HelloReply GetHelloReply(string requestName);
}