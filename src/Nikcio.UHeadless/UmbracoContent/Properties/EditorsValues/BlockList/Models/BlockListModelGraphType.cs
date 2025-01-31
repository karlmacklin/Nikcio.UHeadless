﻿using HotChocolate;
using Nikcio.UHeadless.Reflection.Factories;
using Nikcio.UHeadless.UmbracoContent.Properties.Bases.Models;
using Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.BlockList.Commands;
using Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.Default.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core.Models.Blocks;

namespace Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.BlockList.Models
{
    [GraphQLDescription("Represents a block list model.")]
    public class BlockListModelGraphType<T> : PropertyValueBaseGraphType
        where T : BlockListItemBaseGraphType
    {
        [GraphQLDescription("Gets the blocks of a block list model.")]
        public List<T> Blocks { get; set; }

        public BlockListModelGraphType(CreatePropertyValue createPropertyValue, IDependencyReflectorFactory dependencyReflectorFactory) : base(createPropertyValue)
        {
            var value = (BlockListModel)createPropertyValue.Property.GetValue();
            Blocks = value.ToList()
                ?.Select(blockListItem =>
                {
                    var propertyTypeAssemblyQualifiedName = typeof(T).AssemblyQualifiedName;
                    var type = Type.GetType(propertyTypeAssemblyQualifiedName);
                    return dependencyReflectorFactory.GetReflectedType<T>(type, new object[] { new CreateBlockListItem(createPropertyValue.Content, blockListItem, createPropertyValue.Culture) });
                }).ToList();
        }
    }
}
