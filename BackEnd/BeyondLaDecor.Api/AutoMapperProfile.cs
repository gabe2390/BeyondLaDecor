using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyondLaDecor.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMaps();
        }

        private void CreateMaps()
        {
            CreateMap<EventLocation, EventLocationModel>().ReverseMap();
            CreateMap<Event, EventModel>().ReverseMap();
            CreateMap<EventType, EventTypeModel>().ReverseMap();
            CreateMap<Inventory, InventoryModel>().ReverseMap();
            CreateMap<InventoryRecord, InventoryRecordModel>().ReverseMap();
            CreateMap<Location, LocationModel>().ReverseMap();
            CreateMap<Package, PackageModel>().ReverseMap();
            CreateMap<PackageService, PackageServiceModel>().ReverseMap();
            CreateMap<PackageProduct, PackageProductModel>().ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<ProductServiceType, ProductServiceTypeModel>().ReverseMap();
            CreateMap<ProductType, ProductTypeModel>().ReverseMap();
            CreateMap<Service, ServiceModel>().ReverseMap();
            CreateMap<ServiceType, ServiceTypeModel>().ReverseMap();
            CreateMap<ServiceVendor, ServiceVendorModel>().ReverseMap();
            CreateMap<Setting, SettingModel>().ReverseMap();
            CreateMap<SettingType, SettingTypeModel>().ReverseMap();
            CreateMap<Beyond.Data.Models.Task, TaskModel>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<UserSetting, UserSettingModel>().ReverseMap();
            CreateMap<Vendor, VendorModel>().ReverseMap();


        }
    }
}
