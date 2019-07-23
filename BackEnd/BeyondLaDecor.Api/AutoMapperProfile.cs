using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Data.Models;
using System.Linq;

namespace BeyondLaDecor.Api
{
    public class AutoMapperProfile : Profile
    {
        private object e;

        public AutoMapperProfile()
        {
            CreateMaps();
        }

        private void CreateMaps()
        {
            CreateMap<EventModel, Event>();
            CreateMap<Event, EventModel>().ForMember(
                dest => dest.Locations, src => src.MapFrom(entity => entity.EventLocations.Select(prop => prop.Location)));

            CreateMap<ProductModel, Product>();
            CreateMap<Product, ProductModel>().ForMember(
                dest => dest.ServiceTypes, src => src.MapFrom(entity => entity.ProductServiceTypes.Select(prop => prop.ServiceType)));

            CreateMap<PackageModel, Package>();
            CreateMap<Package, PackageModel>()
                .ForMember(dest => dest.Services, src => src.MapFrom(entity => entity.PackageServices.Select(prop => prop.Service)))
                .ForMember(dest => dest.Products, src => src.MapFrom(entity => entity.PackageProducts.Select(z => z.Product)));

            CreateMap<ServiceModel, Service>();
            CreateMap<Service, ServiceModel>()
                .ForMember(dest => dest.Vendors, src => src.MapFrom(entity => entity.ServiceVendors.Select(prop => prop.Vendor)));

            CreateMap<Setting, SettingModel>().ReverseMap();
            CreateMap<EventType, EventTypeModel>().ReverseMap();
            CreateMap<Inventory, InventoryModel>().ReverseMap();
            CreateMap<InventoryRecord, InventoryRecordModel>().ReverseMap();
            CreateMap<Location, LocationModel>().ReverseMap();
            CreateMap<EventLocation, EventLocationModel>().ReverseMap();
            CreateMap<PackageService, PackageServiceModel>();
            CreateMap<PackageProduct, PackageProductModel>().ReverseMap();
            CreateMap<ProductServiceType, ProductServiceTypeModel>().ReverseMap();
            CreateMap<ProductType, ProductTypeModel>().ReverseMap();
            CreateMap<ServiceType, ServiceTypeModel>().ReverseMap();
            CreateMap<ServiceVendor, ServiceVendorModel>().ReverseMap();
            CreateMap<SettingType, SettingTypeModel>().ReverseMap();
            CreateMap<Task, TaskModel>().ReverseMap();
            CreateMap<User, UserModel>(MemberList.Destination).ReverseMap();
            CreateMap<UserSetting, UserSettingModel>().ReverseMap();
            CreateMap<Vendor, VendorModel>().ReverseMap();
        }
    }
}