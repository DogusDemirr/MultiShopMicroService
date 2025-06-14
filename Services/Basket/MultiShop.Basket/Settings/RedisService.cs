﻿using StackExchange.Redis;

namespace MultiShop.Basket.Settings
{
    public class RedisService
    {
        private readonly string _host;

        private readonly int _port;

        private ConnectionMultiplexer _connectionMultiplexer; //Redis e bağlanmak için köprü görevi görecek
        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");

        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);

        //public IDatabase GetDb(int dbIndex = 1)
        //{
        //    if (_connectionMultiplexer == null)
        //        throw new Exception("Redis connection is not established.");
        //    return _connectionMultiplexer.GetDatabase(dbIndex);
        //}
    }
}
