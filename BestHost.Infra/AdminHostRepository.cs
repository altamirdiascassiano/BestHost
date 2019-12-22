using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace BestHost.Infra
{
    public class AdminHostRepository : IDbRepository<HostAdminDB>
    {
        private IMongoCollection<HostAdminDB> _mongoDbClient = null;
        public AdminHostRepository()
        {
            var connectionString = "mongodb://localhost:27017";
            _mongoDbClient = new MongoClient(connectionString)
                                        .GetDatabase("BestHost")
                                        .GetCollection<HostAdminDB>("HostAdmin");
            
        }

        public void Add(HostAdminDB entity)
        {
            try
            {
                _mongoDbClient.InsertOne(entity);
            }
           catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(HostAdminDB entity)
        {
            try
            {
                _mongoDbClient.DeleteOne(x => x.Id == entity.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(IEnumerable<HostAdminDB> entities)
        {
            // como não tem retorno não vou fazer nada;
        }

        public HostAdminDB FindById(string Id)
        {
            return new HostAdminDB { Name = "Altamir Dias Cassiano", VirtualName = "Altamir", Age = 25, EmailAddress = "altamirdiascassiano@gmail.com", PhoneNumber = "+5532984745731", FacebookPage = "https://www.facebook.com/altamirdiascassiano" };
        }

        public void Update(HostAdminDB entity)
        {
            try
            {
                _mongoDbClient.ReplaceOne(x => x.Id== entity.Id, entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<HostAdminDB> GetAll()
        {
            var listHostAdminDB = new List<HostAdminDB>();
            try
            {
                listHostAdminDB = _mongoDbClient.Find(x => true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listHostAdminDB;
        }
    }
}
