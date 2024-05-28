using Microsoft.AspNetCore.Mvc;

namespace ECommerceMVC.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? loai)                //loai gắn cho bên Default.cshtml
        {
            return View();
        }
    }
}

//Bước 1: Copy những thành phần ở Web Hàng Hóa dạng html (cụ thể là shop.html), bỏ vào View index.cshtml của HangHoa