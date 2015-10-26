using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PurpleBricksCodeEvaluation.DAL.Models
{
    public class Room
    {
        public RoomTypes Type {get; set;}
        public string Width {get; set;}
        public string Length { get; set; }
    }

    public enum RoomTypes
    { 
        Bedroom,
        SittingRoom,
        LivingRoom,
        Kitchen,
    }


}
