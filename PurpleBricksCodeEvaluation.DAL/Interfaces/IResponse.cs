using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PurpleBricksCodeEvaluation.DAL.Interfaces
{
    public interface IResponse
    {
        bool Success { get; set; }
        string Message();
    }
}
