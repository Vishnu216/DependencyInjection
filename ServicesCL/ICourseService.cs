using EntitiesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesCL
{
    public interface ICourseService
    {
        Course GetCourseByID(long courseID);
    }
}
