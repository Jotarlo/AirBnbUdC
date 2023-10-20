using AirbnbUdc.Application.Implementation.Implementation.Parameters;
using AirbnbUdC.Application.Contracts.Contracts.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirBnbUdC.GUI.Mappers.Parameters;
using AirBnbUdC.GUI.Models;
using AirBnbUdC.GUI.Models.Parameters;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AirBnbUdC.GUI.Controllers.Parameters
{
    public class CityController : Controller
    {
        private ICityApplication app = new CityImplementationApplication();

        CityMapperGUI mapper = new CityMapperGUI();

        // GET: CityModels
        public ActionResult Index(string filter = "")
        {
            var list = mapper.MapperT1toT2(app.GetAllRecords(filter));
            return View(list);
        }

        // GET: CityModels/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityModel cityModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (cityModel == null)
            {
                return HttpNotFound();
            }
            return View(cityModel);
        }

        // GET: CityModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] CityModel cityModel)
        {
            if (ModelState.IsValid)
            {
                CityDTO cityDTO = mapper.MapperT2toT1(cityModel);
                app.CreateRecord(cityDTO);
                return RedirectToAction("Index");
            }

            return View(cityModel);
        }

        // GET: CityModels/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityModel cityModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (cityModel == null)
            {
                return HttpNotFound();
            }
            return View(cityModel);
        }

        // POST: CityModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] CityModel cityModel)
        {
            if (ModelState.IsValid)
            {
                CityDTO cityDTO = mapper.MapperT2toT1(cityModel);
                app.UpdateRecord(cityDTO);
                return RedirectToAction("Index");
            }
            return View(cityModel);
        }

        // GET: CityModels/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityModel cityModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (cityModel == null)
            {
                return HttpNotFound();
            }
            return View(cityModel);
        }

        // POST: CityModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            app.DeleteRecord(id);
            return RedirectToAction("Index");
        }

    }
}
