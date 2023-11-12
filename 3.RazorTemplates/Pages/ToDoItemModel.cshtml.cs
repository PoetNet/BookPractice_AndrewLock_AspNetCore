using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndrewLock_AspNetCore.Pages;
public class ToDoItemModel : PageModel
{
    public List<string> Tasks { get; set; }
    public string Title { get; set; }
    public bool IsComplete { get; set; } = false;
    
    public void OnGet()
    {
        Title = "Tasks for today";
        Tasks = new List<string> { "Buy milk", "Buy eggs", "Buy bread", "<strong>The following tasks remain:</strong>" };
    }
}
