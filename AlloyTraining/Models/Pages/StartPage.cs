using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "f90b0675-bcca-4392-a3b0-3af0aed74de5", Description = "Alloy Start Page")]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
                Name = "Main body",
                Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                GroupName = SystemTabNames.Content,
                Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
                Name = "Heading",
                GroupName = SystemTabNames.Content,
                Order = 0)]
        public virtual String Heading { get; set; }

        [Display(
        Name = "MainContentArea",
        GroupName = SystemTabNames.Content,
        Order = 300)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}