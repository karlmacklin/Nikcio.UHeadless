﻿using HotChocolate;
using HotChocolate.Types;
using Nikcio.UHeadless.UmbracoElements.Properties.Bases.Models;
using Nikcio.UHeadless.UmbracoElements.Properties.Commands;

namespace Nikcio.UHeadless.UmbracoElements.Properties.EditorsValues.Fallback.Models {
    /// <summary>
    /// Represents a basic property value
    /// </summary>
    [GraphQLDescription("Represents a basic property value.")]
    public class BasicPropertyValue : PropertyValue {
        /// <summary>
        /// Gets the value of the property
        /// </summary>
        [GraphQLType(typeof(AnyType))]
        [GraphQLDescription("Gets the value of the property.")]
        public virtual object Value { get; set; }

        /// <inheritdoc/>
        public BasicPropertyValue(CreatePropertyValue createPropertyValue) : base(createPropertyValue) {
            Value = createPropertyValue.Property.GetValue(createPropertyValue.Culture);
        }
    }
}
