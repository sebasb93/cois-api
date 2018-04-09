using MongoDB.Bson.Serialization.Conventions;
using System;
using System.Collections.Generic;
using System.Text;
using UtilsDB.contracts;
using UtilsDB.convention;

namespace UtilsDB.service
{
    public class ConventionRegistryService : IConventionRegistryService
    {
        public void RegistryConvention()
        {
            ConventionPack pack = new ConventionPack();
            pack.Add(new IgnoreExtraElementsConvention(true));
            pack.Add(new DBConvention());
            pack.Add(new CamelCaseElementNameConvention());

            ConventionRegistry.Register("My Conventions", pack, t => true);
        }

    }
}
