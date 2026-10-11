using System;
using System.Linq;
using System.Web.Mvc;
using 25dh110208.Models;

namespace 25dh110208.Controllers
{
    public class ProductController : Controller
    {
        // Hiển thị danh sách Product, tìm kiếm, sắp xếp và phân trang.
        public ActionResult Index(string searchString, string sortOrder, int page = 1, int pageSize = 5)
        {
            if (page < 1)
                page = 1;

            if (pageSize != 5 && pageSize != 10 && pageSize != 20)
                pageSize = 5;

            // Lấy danh sách sản phẩm ban đầu.
            var products = ProductRepository.GetAll().AsQueryable();

            // Tìm theo tên sản phẩm hoặc mô tả.
            if (!String.IsNullOrWhiteSpace(searchString))
            {
                products = products.Where(p =>
                    p.ProductName.Contains(searchString) ||
                    p.ProductDescription.Contains(searchString));
            }

            // Sắp xếp kết quả sau khi tìm kiếm.
            ViewBag.NameSortParm = sortOrder == "name" ? "name_desc" : "name";
            ViewBag.PriceSortParm = sortOrder == "price" ? "price_desc" : "price";

            switch (sortOrder)
            {
                case "name":
                    products = products.OrderBy(p => p.ProductName);
                    break;
                case "name_desc":
                    products = products.OrderByDescending(p => p.ProductName);
                    break;
                case "price":
                    products = products.OrderBy(p => p.UnitPrice);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.UnitPrice);
                    break;
                default:
                    products = products.OrderBy(p => p.ProductID);
                    break;
            }

            // Tính tổng số dòng và số trang.
            int totalItems = products.Count();
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            if (totalPages > 0 && page > totalPages)
                page = totalPages;

            // Chỉ lấy dữ liệu thuộc trang hiện tại.
            var pageProducts = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.SearchString = searchString;
            ViewBag.SortOrder = sortOrder;
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalItems = totalItems;
            ViewBag.TotalPages = totalPages;

            return View(pageProducts);
        }
    }
}
