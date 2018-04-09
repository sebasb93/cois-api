using COIS_Models.item;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using UtilsDB.contracts;
using UtilsJson.contracts;

namespace UtilsDB.service
{
    public class DBService : IDBService
    {
        private MongoClient Client { get; set; }

        private IJsonService _jsonService;

        public string ConnectionString { get; set; }

        public DBService(IJsonService jsonService)
        {
            _jsonService = jsonService;

            ConnectionString = "mongodb://cois_user:cois_sena_2018@cluster0-shard-00-00-mzo9x.mongodb.net:27017,cluster0-shard-00-01-mzo9x.mongodb.net:27017,cluster0-shard-00-02-mzo9x.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin";

            Client = new MongoClient(ConnectionString);
        }

        public string MongoTest()
        {
            GetAllItems();
            return "Test From MongoDB";
        }

        public string GetAllItems()
        {
            var db = Client.GetDatabase("cois");
                        
            var collection = db.GetCollection<Item>("item").Find(x => true).ToList();

            var ser = _jsonService.Serialization(collection);

            var des = _jsonService.Deserialization<List<Item>>(ser);

            return ser;
        }
    }
}
