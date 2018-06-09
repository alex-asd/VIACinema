using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using DataModel;
using DataModel.PocoClasses;
using System.Xml.Serialization;

namespace WebService
{
    /// <summary>
    /// Summary description for VIACinemaWebService
    /// </summary>
    [WebService(Namespace = "http://valentin.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VIACinemaWebService : System.Web.Services.WebService
    {
        private DataContext dataContext;
        
        [WebMethod(Description = "A method that returns all the carousel movies")]
        public CarouselMovie[] getCarouselMovies()
        {
            DataContext dataContext = new DataContext();

            List<CarouselMovie> carouselMovies = (from c in dataContext.CarouselMovies select c).ToList();

            CarouselMovie[] movieArr = new CarouselMovie[1];

            movieArr[0] = new CarouselMovie { MovieDescription = "123", MovieURL = "1234dlfl" };

            return movieArr;
        }
        [WebMethod]
        public int add(int a, int b)
        {
            return a + b;
        }
    }
}
