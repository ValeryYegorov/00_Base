using Contracts;

namespace DataAccess;

public class BaseRepository : IBaseRepository
{
    public HelloReply GetHelloReply(string requestName)
    {
        return new HelloReply
        {
            Message = "Hello " + requestName
        };
    }
}