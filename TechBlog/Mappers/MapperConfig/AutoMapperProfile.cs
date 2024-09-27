using AutoMapper;
using Domain_Models;
using DTOs.CommentDto;
using DTOs.Post;
using DTOs.User;

namespace Mappers.MapperConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();

            CreateMap<Comment, CommentDto>();

            CreateMap<Post, PostDto>()
                .ForMember(x => x.Rating, y => y.MapFrom(z => PostConvertHelper.GetPostRating(z.Stars)));

            CreateMap<PostCreateDto, Post>()
                .ForMember(x => x.Tags, y => y.MapFrom(z => PostConvertHelper.GetPostTags(z.Tags)));

            CreateMap<Post, PostDetailsDto>()
                .ForMember(x => x.Rating, y => y.MapFrom(z => PostConvertHelper.GetPostRating(z.Stars)));
        }
    }
}
