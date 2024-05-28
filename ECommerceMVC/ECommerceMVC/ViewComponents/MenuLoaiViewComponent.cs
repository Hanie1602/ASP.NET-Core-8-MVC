using ECommerceMVC.Data;
using ECommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceMVC.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent     //Kế thừa từ ViewComponent
    {
        private readonly Hshop2023Context db;
        public MenuLoaiViewComponent(Hshop2023Context context) => db = context; 

        public IViewComponentResult Invoke()
        {
            //Hiển thị ra dánh sách các loại, tên loại và số lượng sản phẩm thuộc loại đó
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);                 //Sắp xếp theo tên
            return View(data);                          //Default.cshtml
            //return View("Default", data);
        }
    }
}
