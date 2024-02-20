using HotelRez.DataAccessLayer.Abstract;
using HotelRez.DataAccessLayer.Concrete;
using HotelRez.DataAccessLayer.Repositories;
using HotelRez.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRez.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(Context context):base(context)
        {
            
        }
    }
}
