using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "841fa6a9-aae4-429d-b7cb-2292bd3bc153", Description = "")]
    public class NewsPage : StandardPage
    {
        [Display(
            Name = "MainListing",
            GroupName = SystemTabNames.Content,
            Order = 315)]
        public virtual ListingBlock MainListing { get; set; }
    }
}