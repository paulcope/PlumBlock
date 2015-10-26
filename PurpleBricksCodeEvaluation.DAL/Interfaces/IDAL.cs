using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleBricksCodeEvaluation.DAL.Models;
using PurpleBricksCodeEvaluation.DAL;

namespace PurpleBricksCodeEvaluation.DAL.Interfaces
{
    public interface IDAL
    {
        List<Property> GetProperties(IFilter filter);
        IResponse MakeOffer(IOffer offer);
    }
}
