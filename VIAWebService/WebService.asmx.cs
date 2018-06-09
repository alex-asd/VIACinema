using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using DataModel;
using DataModel.PocoClasses;

namespace VIAWebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public CarouselMovie[] GetCarouselMovies()
        {
            DataContext context = new DataContext();

            List<CarouselMovie> carouselMoviesList = (from c in context.CarouselMovies select c).ToList();

            CarouselMovie[] carouselMovies = new CarouselMovie[carouselMoviesList.Count];

            for (int i = 0; i < carouselMoviesList.Count; i++) carouselMovies[i] = carouselMoviesList[i];

            return carouselMovies;
        }
    }
}
