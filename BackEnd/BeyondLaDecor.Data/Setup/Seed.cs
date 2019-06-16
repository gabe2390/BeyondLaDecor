using BeyondLaDecor.Beyond.Data;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Data.Setup
{
    public class Seed
    {
        public void SeedData(BeyondDbContext context)
        {
            SeedDefaultServiceTypes(context);
            SeedDefaultProductTypes(context);
            SeedDefaultEventTypes(context);
        }

        private void SeedDefaultEventTypes(BeyondDbContext context)
        {
            context.EventTypes.Add(CreateEventType("Wedding"));
            context.EventTypes.Add(CreateEventType("Baby Shower"));
            context.EventTypes.Add(CreateEventType("Birthday Party"));
            context.EventTypes.Add(CreateEventType("Social Event"));
            context.EventTypes.Add(CreateEventType("Private Event"));
            context.EventTypes.Add(CreateEventType("Bridal Shower"));
        }

        private EventType CreateEventType(string name)
        {
            return new EventType
            {
                Name = name
            };
        }
        private void SeedDefaultProductTypes(BeyondDbContext context)
        {
            context.ProductTypes.Add(CreateProductType("Center Piece"));
            context.ProductTypes.Add(CreateProductType("Back Drop"));
            context.ProductTypes.Add(CreateProductType("Flower"));
            context.ProductTypes.Add(CreateProductType("Napkin"));
            context.ProductTypes.Add(CreateProductType("Decorative"));
        }

        private ProductType CreateProductType(string name)
        {
            return new ProductType { Name = name };
        }

        private void SeedDefaultServiceTypes(BeyondDbContext context)
        {
            var decorType = context.ServiceTypes.Add(CreateServiceType("Decor"));
            var coordinationType = context.ServiceTypes.Add(CreateServiceType("Coordination"));
            var cateringType = context.ServiceTypes.Add(CreateServiceType("Catering"));
            var mediaType = context.ServiceTypes.Add(CreateServiceType("Media"));
            context.SaveChanges();

            context.ServiceTypes.Add(CreateServiceType("Draping", decorType.Entity.ServiceTypeId));
            context.ServiceTypes.Add(CreateServiceType("Back Drop", decorType.Entity.ServiceTypeId));
            context.ServiceTypes.Add(CreateServiceType("Photography", mediaType.Entity.ServiceTypeId));
            context.ServiceTypes.Add(CreateServiceType("DJ", mediaType.Entity.ServiceTypeId));
            context.ServiceTypes.Add(CreateServiceType("Videography", mediaType.Entity.ServiceTypeId));
            context.SaveChanges();

        }

        private ServiceType CreateServiceType(string name, int? parentServiceTypeId = null)
        {
            return new ServiceType { Name = name, ParentServiceTypeId = parentServiceTypeId };
        }
    }
}
