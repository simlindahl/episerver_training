using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true, Tags = new string[] { "span8" }, AvailableWithoutTag = false)]
    public class PagePartialWideController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentContent)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView("~/Views/Shared/PagePartial/PagePartialWide.cshtml", currentContent);
        }
    }
}