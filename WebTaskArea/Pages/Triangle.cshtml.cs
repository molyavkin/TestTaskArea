using AreaCalculation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTaskArea.Pages
{
    [IgnoreAntiforgeryToken]
    public class TriangleModel : PageModel
    {
        public string Message { get; set; } = "";
        public void OnGet()
        {
            //Message = "Введите стороны треугольника";
        }
        public void OnPost(double a, double b, double c)
        {
            if (!Area.IsExistTriangle(a, b, c))
            {
                Message = "Треугольник с такими сторонами не существует";
            }
            else
            {
                double areaTriangle = Area.AreaTriangle(a, b, c);
                if (Area.IsRectangularTriangle(a, b, c))
                {
                    Message = "Треугольник прямоугольный. ";
                }
                Message += $"Площадь треугольника = {areaTriangle:#,##0.00}";
            }
                
            
        }
    }
}
