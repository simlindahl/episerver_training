using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "c5425a42-6905-4bde-b9d2-1b251c9d3148", Description = "")]
    public class EditorialBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}