using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doanquanlythuvienv2.Controllers
{
    public class tacgiaController : Controller
    {
        private Doanquanlythuvienv2.Models.qlsachEntities dc = new Doanquanlythuvienv2.Models.qlsachEntities();
        // GET: tacgia
        public ActionResult IndexTG()
        {
            return View(dc.TACGIAs.ToList());
        }
        public ActionResult Formthemtacgia()
        {
            return View();
        }
        public ActionResult themTacgia(Doanquanlythuvienv2.Models.TACGIA tACGIA)
        {
            if (ModelState.IsValid)
            {
                dc.TACGIAs.Add(tACGIA);
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTG");
        }
        //public ActionResult Formxoatacgia(string id)
        //{
        //    Doanquanlythuvien.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
        //    return View(tACGIA);
        //}

        public ActionResult xoaTacgia(string id)
        {
            Doanquanlythuvienv2.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            dc.TACGIAs.Remove(tACGIA);
            dc.SaveChanges();
            return RedirectToAction("IndexTG");
        }
        public ActionResult Formsuatacgia(string id)
        {
            Doanquanlythuvienv2.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            return View(tACGIA);
        }
        public ActionResult suaTacgia(Doanquanlythuvienv2.Models.TACGIA tACGIA)
        {
            Doanquanlythuvienv2.Models.TACGIA aCGIA = dc.TACGIAs.Find(tACGIA.MaTacGia);
            if (aCGIA != null)
            {
                aCGIA.MaTacGia = tACGIA.MaTacGia;
                aCGIA.TenTacGia = tACGIA.TenTacGia;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTG");
        }
        public ActionResult xemtg(string id)
        {
            Doanquanlythuvienv2.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            return View(tACGIA);
        }
    }
}