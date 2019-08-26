using Data.Context;
using Data.Entities;
using Data.Repository.Base;
using Data.Repository.Interfaces;

namespace Data.Repository.Implementation
{
    public class LocationsRepository : EntityBaseRepository<Locations>, ILocationsRepository 
    {
        public LocationsRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
