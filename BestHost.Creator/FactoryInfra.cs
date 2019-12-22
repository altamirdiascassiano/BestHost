using BestHost.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestHost.Creator
{
    public class FactoryInfra
    {
        public object GetRepository(string tecnology, string entity)
        {
            if (tecnology.Equals("mongodb"))
            {
                return new AdminHostRepository();                
            }
            else if (string.IsNullOrEmpty(tecnology))
            {
                throw new Exception(message: "The AbstractFactoryDBClient don't create a new object instance. ClientName empty or NULL");
            }

            throw new Exception(message: string.Concat("The AbstractFactoryDBClient don't create a new object instance. The Factory do not know ", clientName, "."));

        }
    }
}
