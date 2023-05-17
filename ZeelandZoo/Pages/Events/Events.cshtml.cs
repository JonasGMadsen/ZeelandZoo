using ZeelandZoo.MockData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZeelandZoo.Pages.Events
{
    public class GetAllEventsModel : PageModel
    {
        public List<Models.Events> Events { get; private set; }
        public void OnGet()
        {
            Events = MockEvents.GetMockEvents();

        }
    }
}
