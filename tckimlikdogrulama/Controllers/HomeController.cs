using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using tckimlikdogrulama.Model;
using static Kimlik.KPSPublicSoapClient;
using tckimlikdogrulama.Service;
using FluentValidation.Results;
using System.Globalization;
using System.Collections;
using System.Linq;

namespace tckimlikdogrulama.Controllers
{
    public class HomeController : Controller
    {
        SignupDal sud = new SignupDal();

        public IActionResult Index()
        {
            //ViewBag.ps = false;
            return View();
        }
       
        [HttpPost]
        public IActionResult Index(signupModel p)
        {
            Validationform validationf = new Validationform();
            ValidationResult results = validationf.Validate(p);



            if (results.IsValid)
            {

                bool? durum;
                long tckimlik = (long)p.TCKimlikNo;
                string name = p.Ad.ToUpper(new CultureInfo("tr-TR", false));

                try
                {
                    var service = new Kimlik.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
                    var tcKimlikDogrulamaServisResponse = service.TCKimlikNoDogrulaAsync(
                             tckimlik,
							 name,
                             p.Soyad.ToUpper(),
                             p.DogumYili.Year
                             ).GetAwaiter().GetResult();
                    durum = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
                }
                catch
                {
                    durum = false;
                }

                if (durum == false)
                {
                    string errormes = "Kimlik Bilgilerinizi Doğru Giriniz!";
                    return Json(new { result = false, error = errormes });

                }
                else
                {
                    sud.Insert(p);
                    ViewBag.ps = true;
                    //return View(ViewBag.ps = true);
                    return Json(new { result = true, error = ""});
                    //return RedirectToAction("Correct", "Home");
                }
            }
            else
            {
                ArrayList arrayList = new ArrayList();
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    arrayList.Add(item.ErrorMessage);
                }
                
                string errormesa = string.Join(" ",arrayList.ToArray());
                return Json(new { result = false, error = errormesa });


            }

        }

        public IActionResult Correct()
        {
            return View();
        }
    }
}
