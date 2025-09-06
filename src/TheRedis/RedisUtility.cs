using StackExchange.Redis;

namespace HelloApp;

public class RedisUtility
    {
        private static Lazy<ConnectionMultiplexer>? lazyConnection=null;

        public static void InitializeConnection(RedisInfo redis)
        {
            lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
                {
                    return ConnectionMultiplexer.Connect(redis.ToString());
                });
            
        }

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection!.Value;
            }
        }
    }
