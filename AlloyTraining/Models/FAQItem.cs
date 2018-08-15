using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models
{
    [ContentType(DisplayName = "FAQItem", GUID = "c7f0e007-46f3-4060-82ac-20655e162901", AvailableInEditMode = false, Description = "")]
    public class FAQItem : SitePageData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Question { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString Answer { get; set; }
    }
}