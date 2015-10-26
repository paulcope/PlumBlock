using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PurpleBricksCodeEvaluation.DAL.Models;

namespace PurpleBricksCodeEvaluation.DalTests
{
    [TestClass]
    public class PropertyTests
    {
        [TestMethod]
        public void NumberofRoomsWorksOK()
        {
            #region Arrange
            House house = new House();
            house.Rooms.Add(new Room { Type = RoomTypes.Bedroom });
            house.Rooms.Add(new Room { Type = RoomTypes.Bedroom });
            int correctRoomNumber = 2;
            int actualRoomCountReturned; 
            #endregion

            #region Act
            actualRoomCountReturned = house.NumberOfRooms(RoomTypes.Bedroom); 
            #endregion

            #region Assert
            Assert.IsTrue(correctRoomNumber == actualRoomCountReturned); 
            #endregion
        }
    }
}
