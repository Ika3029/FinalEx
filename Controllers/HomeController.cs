using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // 計算陣列總合
        public string ShowAry()
        {
            int[] score = new int[] { 78, 89, 30, 100, 66 };
            string show = "";
            int sum = 0;
            foreach (var m in score)
            {
                show += m + ", ";
                sum += m;
            }
            show = show.TrimEnd(',', ' ') + "<br />";
            show += $"<strong>總合：</strong>{sum}";
            return show;
        }

        // name字串陣列存放8張圖的名稱
        string[] name = new string[]
        {
            "大甲鎮瀾宮", "竹田車站", "西螺大橋", "萬金天主堂",
            "萬巒豬腳街", "潮州戲曲故事館", "貓鼻頭", "頭城搶孤"
        };

        // 傳回顯示name字串陣列八張圖檔的HTML字串（加上Bootstrap美化）
 public string ShowImages()
{
    string show = @"
<link href='https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css' rel='stylesheet'>
<div class='bg-gradient-star py-5 min-vh-100'>
    <div class='container'>
        <h2 class='text-center mb-5 fw-bold display-5 text-light fancy-title'>
            台灣在地旅行手札
        </h2>
        <div class='row g-4'>
";

    for (int i = 0; i < name.Length; i++)
    {
        show += $@"
            <div class='col-6 col-md-3'>
                <div class='card h-100 shadow-lg border-0'>
                    <img src='../images/{name[i]}.jpg' class='card-img-top img-fluid hover-zoom' alt='{name[i]}'>
                    <div class='card-body text-center'>
                        <p class='card-text fw-semibold'>{name[i]}</p>
                    </div>
                </div>
            </div>";
    }

    show += @"
        </div>
    </div>
</div>

<style>
    /* 星空深藍紫漸層背景 */
    .bg-gradient-star {
        background: linear-gradient(135deg, #1f1c2c, #928DAB);
    }

    /* 標題特殊字型與樣式 */
    .fancy-title {
        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        letter-spacing: 1px;
        text-shadow: 0 2px 8px rgba(255, 255, 255, 0.2);
    }

    /* 圖片hover微縮放 */
    .hover-zoom {
        transition: transform 0.3s ease;
    }
    .hover-zoom:hover {
        transform: scale(1.05);
    }

    /* 卡片風格 */
    .card {
        border-radius: 1rem;
        overflow: hidden;
    }

    .card-body {
        background-color: #ffffffcc;
        border-top: 1px solid #eee;
    }
</style>
";
    return show;
}

    }
}
