using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "616530d9-e8b4-4aac-b3fc-1ff6fe117f61", Description = "Alloy Image File")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class ImageFile : ImageData
    {
        /*     
                [CultureSpecific]
                [Editable(true)]
                [Display(
                    Name = "Description",
                    Description = "Description field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        */
        public virtual string Description { get; set; }
    }
}