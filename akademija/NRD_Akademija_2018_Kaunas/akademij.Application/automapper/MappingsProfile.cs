using akademij.Application.main.employee.dto;
using akademij.Application.main.inventory.dto;
using akademij.EF.entities;
using AutoMapper;
using System.Linq;

namespace akademij.Application.automapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Employee, EmployeeDto>()
               .ForMember(dto => dto.Inventory,
               opt => opt.MapFrom(x =>
               x.EmployeeInventory.Select(y => y.Inventory).ToList()));
            CreateMap<Inventory, InventoryViewDto>();
            //CreateMap<Inventory, InventoryDto>().ReverseMap();
            //CreateMap<InventoryType, InventoryTypeDto>();
        }
    }
}
