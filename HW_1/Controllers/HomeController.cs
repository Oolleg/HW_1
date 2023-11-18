using HW_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            MainPageData pageData = new()
            {
                day = DateTime.Now.DayOfYear,
                letter = Convert.ToChar(new Random().Next(65, 90))
            };

            return View(pageData);
        }

        public IActionResult Restaurants()
        {
            return View();
        }

        public IActionResult Ricard_Camarena()
        {
            return View();
        }

        public IActionResult La_Gatta()
        {
            return View();
        }
        
        public IActionResult Komori()
        {
            return View();
        }
        
        public IActionResult Anyora()
        {
            return View();
        }

        public IActionResult Countries()
        {
            return View();
        }

        public IActionResult Andorra()
        {
            CountryData andorraData = new()
            {
                CountryName = "Andorra",
                CountryImg = "/img_country/Andorra__Country_portal_shutterstock_1446148013-127_SELECTION.jpg",
                CountryText = "Andorra has a parliamentary system of government and regularly holds free and fair elections. Political rights and civil liberties are generally respected. However, the country has strict naturalization criteria, and more than 50 percent of the population consists of noncitizens who do not have the right to vote. Among other outstanding concerns, abortion remains completely prohibited, and there is a notable wage gap between men and women. Andorra’s small Muslim and Jewish communities lack dedicated cemeteries, and the country has no recognized mosque.",
                Score = 93,
                PrFist = 38,
                PrSecond = 40,
                ClFist = 55,
                ClSecond = 60
            };
            return View(andorraData);
        }
            public IActionResult Angola()
            {
                CountryData angolaData = new()
                {
                    CountryName = "Angola",
                    CountryImg = "/img_country/Angola.jpg",
                    CountryText = "Angola has been ruled by the same party since independence, and authorities have systematically repressed political dissent. Corruption, due process violations, and abuses by security forces remain common. Some restrictions on the press and civil society were eased after President João Lourenço took office in 2017, but that partial opening has since been reversed.",
                    Score = 28,
                    PrFist = 10,
                    PrSecond = 40,
                    ClFist = 18,
                    ClSecond = 60
                };
                return View(angolaData);
            }

        public IActionResult Antigua_and_Barbuda()
        {
            CountryData AntiguaData = new()
            {
                CountryName = "Antigua and Barbuda",
                CountryImg = "/img_country/AntiguaBarbuda_Country_portal_shutterstock_1325928257-110.jpg",
                CountryText = "Antigua and Barbuda is a democracy that holds regular elections. Corruption in government is a concern, and women and LGBT+ people are underrepresented in politics and experience some discrimination. In 2017, Hurricane Irma devastated Barbuda: the entire island was evacuated, and many residents lost their livelihoods. The government has since sought to weaken the island’s longstanding system of communal land rights. The country’s citizenship-by-investment program is a key element of its economy, but its operation has come under international scrutiny.",
                Score = 85,
                PrFist = 33,
                PrSecond = 40,
                ClFist = 52,
                ClSecond = 60
            };
            return View(AntiguaData);
        }
        public IActionResult Argentina()
        {
            CountryData ArgentinaData = new()
            {
                CountryName = "Angola",
                CountryImg = "/img_country/Argentina-fotn2019-countryhero.jpg",
                CountryText = "Argentina is a vibrant representative democracy with competitive elections, lively media and civil society sectors, and unfettered public debate. Economic instability, institutional weakness, corruption and drug-related violence are among the country’s most serious challenges.",
                Score = 85,
                PrFist = 35,
                PrSecond = 40,
                ClFist = 50,
                ClSecond = 60
            };
            return View(ArgentinaData);
        }

        

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}