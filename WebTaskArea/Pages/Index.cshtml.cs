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
            //Message = "Введите радиус круга";
        }
        public void OnPost(double radius)
        {
            if (radius < 0)
            {
                Message = "Некорректный ввод";
            }
            else
            {
                double areaCircle = Area.AreaCircle(radius);
                Message = $"Площадь круга = {areaCircle:#,##0.00}";
            }
                     
        }
    }
}
//ViewData["AreaCircle"] = "Площадь круга " + area.ToString("#,##0.00");
