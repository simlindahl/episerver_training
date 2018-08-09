using AlloyDemoKit.Business;
using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; set; }
        public IContent Section { get; set; }

        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = ContentExtensions.Get<T>(currentPage.ContentLink);
        }
    }
}