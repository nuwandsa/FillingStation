using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FillingStation.Data
{
    class DataAccess
    {
        
        internal static MongoClient connect()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("FillingStation");
            return client;        
        }
        
    }
}
