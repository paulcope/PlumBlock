using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PurpleBricksCodeEvaluation.DAL.Interfaces;
using System.ComponentModel;
using System.Web;
using System.Web.Mvc;

namespace PurpleBricksCodeEvaluation.DAL.Models
{
    public abstract class Property
    {

        public Property()
        {
            Rooms = new List<Room>();

        }

        [HiddenInput(DisplayValue = false)]
        public int PropertyID { get; set; }

        [DisplayName("Rooms")]
        public List<Room> Rooms {get; set; }

        [DisplayName("Asking Price")]
        public int AskingPrice { get; set; }

        [DisplayName("Address")]
        public Address Address { get; set; }


        public int NumberOfRooms(RoomTypes roomType)
        {
            return Rooms.Where(a => a.Type == roomType).Count();
        }

        public PurpleBricksCodeEvaluation.DAL.Interfaces.IOffer offer {get; set;}

    }
}