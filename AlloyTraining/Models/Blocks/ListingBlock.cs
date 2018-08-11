using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "0871b496-1b4b-4ef3-9305-00ed860d2ebc", Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 100)]
        public virtual string Heading { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 200)]
        public virtual PageReference RootPage { get; set; }
    }
}