using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "StartPage", 
        GUID = "8d1dad12-97ef-4b54-ba8a-5e96a42c03f9", 
        Description = "Alloy Start Page")]
    public class StartPage : PageData
    {
        [Display(
            GroupName =SystemTabNames.Content, 
            Order =0)]
        public virtual String  Heading { get; set; } 


        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}