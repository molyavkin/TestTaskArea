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
            //Message = "������� ������� ������������";
        }
        public void OnPost(double a, double b, double c)
        {
            if (!Area.IsExistTriangle(a, b, c))
            {
                Message = "����������� � ������ ��������� �� ����������";
            }
            else
            {
                double areaTriangle = Area.AreaTriangle(a, b, c);
                if (Area.IsRectangularTriangle(a, b, c))
                {
                    Message = "����������� �������������. ";
                }
                Message += $"������� ������������ = {areaTriangle:#,##0.00}";
            }
                
            
        }
    }
}
