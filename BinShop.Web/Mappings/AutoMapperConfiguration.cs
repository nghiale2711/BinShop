using AutoMapper;
using BinShop.Model.Models;
using BinShop.Web.Models;
using System.Collections.Generic;

namespace BinShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {

            Mapper.CreateMap<Post, PostViewModel>();

            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();

            Mapper.CreateMap<Tag, TagViewModel>();

            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();

            Mapper.CreateMap<Product, ProductViewModel>();

            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
        }
    }
}