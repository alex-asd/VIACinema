using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataModel.PocoClasses
{
    public class CarouselMovie
    {
        public int CarouselMovieId { get; set; }
        public string MovieURL { get; set; }
        public string MovieDescription { get; set; }
    }
}
