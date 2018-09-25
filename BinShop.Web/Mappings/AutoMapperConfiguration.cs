using AutoMapper;
using BinShop.Model.Models;
using BinShop.Web.Models; 

namespace BinShop.Web.Mappings
{
    public class AutoMapperConfiguration : Profile
    {
        public void Configure()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}