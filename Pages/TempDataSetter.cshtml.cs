using CookieMaker2023P3A.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieMaker2023P3A.Pages
{
    public class TempDataSetterModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string Text { get; set; }

        public void OnGet()
        {
            TempData.AddMessage("messagetext", TempDataExtension.MessageType.warning, "Byli jsme na stránce");
        }

        public void OnGetSetName()
        {
            TempData.AddMessage("messagetext", TempDataExtension.MessageType.success, Text);
        }
    }
}
