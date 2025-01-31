﻿using AutoMapper;
using Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.BlockList.Models;
using Nikcio.UHeadless.UmbracoContent.Properties.Models;
using Umbraco.Cms.Core.Models.Blocks;

namespace Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.BlockList.Profiles
{
    public class BlockListProfile : Profile
    {
        public BlockListProfile()
        {
            CreateMap<BlockListItem, BlockListItemGraphType<PropertyGraphType>>(); // TODO
        }
    }
}
