using Milton.Model;
using Milton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Milton.Controllers
{


    public class HomeController : Controller
    {
        private readonly BopDb _db = new BopDb();
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public JsonResult acti(string appId, string initialDate, string endDate)
        {
            var rtn = new General();
            var initial = Convert.ToDateTime(initialDate).ToString("yyyy/MM/dd");
            var ending = Convert.ToDateTime(endDate).ToString("yyyy/MM/dd");
            try
            {
                var query = "exec sp_info_usuarios_activos '" + appId + "', '" + initial + "', '" + ending + "'";
                rtn.Activations = _db.Database.SqlQuery<Activations>(query).ToList();
                var queryl = "exec sp_info_usuarios_intervalo '" + appId + "', '" + initial + "', '" + ending + "'";
                rtn.Interval = _db.Database.SqlQuery<Intervalo>(queryl).ToList();
                var querym = "exec sp_info_usuarios_cantidades '" + appId + "', '" + initial + "', '" + ending + "', 1";
                rtn.ActiveUsers = _db.Database.SqlQuery<int>(querym).FirstOrDefault();
                var queryn = "exec sp_info_usuarios_cantidades '" + appId + "', '" + initial + "', '" + ending + "', 3";
                rtn.subcribe = _db.Database.SqlQuery<Subcribe>(queryn).ToList();
                var querys = "exec sp_info_usuarios_cantidades '" + appId + "', '" + initial + "', '" + ending + "', 2";
                rtn.cancellation = _db.Database.SqlQuery<Cancelation>(querys).ToList();
            }
            catch (Exception e)
            {
                //
            }
            return Json(rtn, JsonRequestBehavior.AllowGet);
        }


        [AllowAnonymous]
        [HttpGet]
        public JsonResult Report(string appId, string DateStart)
        {
            var rtn = new General();
            var Strat = Convert.ToDateTime(DateStart).ToString("yyyy/MM/dd");
            try
            {
                var queryq = "exec sp_info_dashboard '" + appId + "', '" + Strat + "'";
                rtn.ReportGeneral = _db.Database.SqlQuery<Tables>(queryq).ToList();

            }
            catch (Exception e)
            {
                //
            }
            return Json(rtn, JsonRequestBehavior.AllowGet);
        }
    }


}










