using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doanquanlythuvienv2_Htmlhelper.Controllers
{
    public class theloaiController : Controller
    {
        private Doanquanlythuvienv2.Models.qlsachEntities dc = new Doanquanlythuvienv2.Models.qlsachEntities();
        // GET: theloai
        public ActionResult IndexTL()
        {
            return View(dc.THELOAIs.ToList());
        }
        public ActionResult Fromthemtheloai()
        {
            return View();
        }
        public ActionResult themTheloai(Doanquanlythuvienv2.Models.THELOAI tHELOAI)
        {
            if (ModelState.IsValid)
            {
                dc.THELOAIs.Add(tHELOAI);
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTL");
        }
        //public ActionResult Formxoatacgia(string id)
        //{
        //    Doanquanlythuvien.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
        //    return View(tACGIA);
        //}

        public ActionResult xoaTheloai(string id)
        {
            Doanquanlythuvienv2.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            dc.THELOAIs.Remove(tHELOAI);
            dc.SaveChanges();
            return RedirectToAction("IndexTL");
        }
        public ActionResult Formsuatheloai(string id)
        {
            Doanquanlythuvienv2.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            return View(tHELOAI);
        }
        public ActionResult suaTheloai(Doanquanlythuvienv2.Models.THELOAI tHELOAI)
        {
            Doanquanlythuvienv2.Models.THELOAI hELOAI = dc.THELOAIs.Find(tHELOAI.MaTheLoai);
            if (hELOAI != null)
            {
                hELOAI.MaTheLoai = tHELOAI.MaTheLoai;
                hELOAI.TenTheLoai = tHELOAI.TenTheLoai;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTL");
        }
        public ActionResult xemTheloai(string id)
        {
            Doanquanlythuvienv2.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            return View(tHELOAI);
        }


    }
}