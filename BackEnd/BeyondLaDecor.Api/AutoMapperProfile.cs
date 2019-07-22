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
            CreateMap<User, UserModel>(MemberList.Destination).ReverseMap();
            CreateMap<UserSetting, UserSettingModel>().ReverseMap();
            CreateMap<Vendor, VendorModel>().ReverseMap();

            //reduce mapping table to dependent entity
            CreateMap<PackageService, Service>().ForMember(s => s, opt => opt.MapFrom(ps => ps.Service));
            CreateMap<PackageProduct, Product>().ForMember(p => p, opt => opt.MapFrom(pp => pp.Product));
            CreateMap<ServiceVendor, Vendor>().ForMember(v => v, opt => opt.MapFrom(sv => sv.Vendor));


        }
    }
}
