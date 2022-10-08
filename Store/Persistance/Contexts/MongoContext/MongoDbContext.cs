﻿using Application.Interfaces.Contexts;
using MongoDB.Driver;

namespace Persistence.Contexts.MongoContext
{
    public class MongoDbContext<T> : IMongoDbContext<T>
    {

        private readonly IMongoDatabase db;
        private readonly IMongoCollection<T> mongoCollection;

        public MongoDbContext()
        {
            var client = new MongoClient(/*Connection String*/);
            db = client.GetDatabase("VisitorDb");
            mongoCollection = db.GetCollection<T>(typeof(T).Name);
        }

        public IMongoCollection<T> GetCollection()
        {
            return mongoCollection;
        }
    }
}
