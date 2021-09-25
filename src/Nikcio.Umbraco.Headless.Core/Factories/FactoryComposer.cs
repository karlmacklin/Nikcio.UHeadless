﻿using Microsoft.Extensions.DependencyInjection;
using Nikcio.Umbraco.Headless.Core.Factories.Sites;
using Nikcio.Umbraco.Headless.Core.Factories.Sites.Pages;
using Nikcio.Umbraco.Headless.Core.Factories.Sites.Pages.PageData;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Nikcio.Umbraco.Headless.Core.Factories
{
    public class FactoryComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddScoped<IPageDataFactory, PageDataFactory>();
            builder.Services.AddScoped<IPageFactory, PageFactory>();
            builder.Services.AddScoped<ISiteFactory, SiteFactory>();
        }
    }
}
