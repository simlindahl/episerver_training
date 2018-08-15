using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.DataAbstraction;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.ViewModels
{
    public class FooterModel
    {
        public bool loggedIn;
        public PageDataCollection productPages;
        public string loginUrl;

        public FooterModel(SitePageData currentPage)
        {
            loginUrl = GetLoginUrl(currentPage.ContentLink);
            loggedIn = HttpContext.Current.User.Identity.IsAuthenticated;
            RetrieveSiteProductPages();
        }

        private void RetrieveSiteProductPages()
        {
            PropertyCriteriaCollection criteria = new PropertyCriteriaCollection();

            PropertyCriteria prodpagecriterion = new PropertyCriteria();
            prodpagecriterion.Condition = EPiServer.Filters.CompareCondition.Equal;
            prodpagecriterion.Name = "PageTypeID";
            prodpagecriterion.Type = PropertyDataType.PageType;
            prodpagecriterion.Value = ServiceLocator.Current.GetInstance<IContentTypeRepository>().Load("ProductPage").ID.ToString();

            prodpagecriterion.Required = true;
            criteria.Add(prodpagecriterion);

            productPages = ServiceLocator.Current.GetInstance<IPageCriteriaQueryService>().FindPagesWithCriteria(PageReference.StartPage, criteria);
        }

        private string GetLoginUrl(ContentReference returnToContentLink)
        {
            var urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            string getUrl = urlResolver.GetUrl(returnToContentLink);

            return getUrl;
        }
    }
}