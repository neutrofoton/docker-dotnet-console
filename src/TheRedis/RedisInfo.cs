namespace HelloApp;

public class RedisInfo
{
    public string Host{ get; set; }
    public int Port{ get; set; }

    public override string ToString()
    {
        //"localhost:6379"
        return $"{Host}:{Port}";
    }
}
