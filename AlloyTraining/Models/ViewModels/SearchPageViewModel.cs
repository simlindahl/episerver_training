using AlloyTraining.Models.Pages;
using EPiServer.Globalization;
using EPiServer.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.ViewModels
{
    public class SearchPageViewModel : IPageViewModel<SearchPage>
    {
        public SearchPage CurrentPage { get; set; }
        public string SearchText { get; set; }
        public List<IndexResponseItem> SearchResult { get; set; }

        public SearchPageViewModel(SearchPage currentPage)
        {
            CurrentPage = currentPage;
        }

        public void Search(string q)
        {
            var culture = ContentLanguage.PreferredCulture.Name;
            SearchResult = new List<IndexResponseItem>();
            var fieldQuery = new EPiServer.Search.Queries.Lucene.FieldQuery(q);
#pragma warning disable CS0618 // Type or member is obsolete
            var fieldQueryResult = SearchHandler.Instance.GetSearchResults(fieldQuery, 1, 40).IndexResponseItems.Where(x => x.Culture.Equals(culture) || string.IsNullOrEmpty(x.Culture)).ToList();
#pragma warning restore CS0618 // Type or member is obsolete
            SearchResult.AddRange(fieldQueryResult);
        }
    }
}