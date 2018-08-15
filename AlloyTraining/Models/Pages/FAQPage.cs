using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQPage", GUID = "f6508d7c-36bd-490b-b372-e147f77b32c8", Description = "")]
    public class FAQPage : SitePageData
    {
        [Ignore]
        public IList<FAQItem> FAQItems { get; set; }
    }
}