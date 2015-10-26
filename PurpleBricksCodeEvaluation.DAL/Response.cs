using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleBricksCodeEvaluation.DAL.Interfaces;

namespace PurpleBricksCodeEvaluation.DAL
{
    public class Response : IResponse
    {
        public bool Success {get; set;}

        public string Message()
        {
            return null;
        }
    }
}
