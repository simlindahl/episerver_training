using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "7d911efe-68ab-4fb6-8287-7dc73266fe45", Description = "Alloy Product Page")]
    public class ProductPage : StandardPage
    {
        [Display(GroupName = SystemTabNames.Content, Order = 305)]
        [UIHint(UIHint.Textarea)]
        public string UniqueSellingPoints { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        public ContentArea MainContentArea { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 330)]
        public ContentArea RelatedContentArea { get; set; }
    }
}