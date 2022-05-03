using AreaCalculation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTaskArea.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = ""; 
        public void OnGet()
        {
            //Message = "������� ������ �����";
        }
        public void OnPost(double radius)
        {
            if (radius < 0)
            {
                Message = "������������ ����";
            }
            else
            {
                double areaCircle = Area.AreaCircle(radius);
                Message = $"������� ����� = {areaCircle:#,##0.00}";
            }
                     
        }
    }
}
//ViewData["AreaCircle"] = "������� ����� " + area.ToString("#,##0.00");
