using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleBricksCodeEvaluation.DAL.Interfaces;
using PurpleBricksCodeEvaluation.DAL.Models;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PurpleBricksCodeEvaluation.DAL
{
    public class DAL
    {

        public void MakeOffer(Property properyToMakeOfferOn)
        {
            //Sends property to storprocs which in turn updates the offer table on the property which is picked up the user.
        }

        public void AddProperty(Property propertyToAdd)
        {

            SqlConnection sqlConnection1 =
             new SqlConnection(@"Server=COPEY-PC;Database=;Integrated Security=True;Asynchronous Processing=True;");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "INSERT_PROPERTY";

            cmd.Parameters.Add(new SqlParameter("@UserID", 5));
            cmd.Parameters.Add(new SqlParameter("@Valuation", propertyToAdd.AskingPrice));
            cmd.Parameters.Add(new SqlParameter("@LowestPrice", 5000));
            cmd.Parameters.Add(new SqlParameter("@Address1", propertyToAdd.Address.AddressLine1));
            cmd.Parameters.Add(new SqlParameter("@Address2", propertyToAdd.Address.AddressLine2));
            cmd.Parameters.Add(new SqlParameter("@Address3", propertyToAdd.Address.AddressLine3));
            cmd.Parameters.Add(new SqlParameter("@Address4", propertyToAdd.Address.AddressLine4));
            cmd.Parameters.Add(new SqlParameter("@Address5", propertyToAdd.Address.AddressLine5));
            cmd.Parameters.Add(new SqlParameter("@PostCode", propertyToAdd.Address.PostCode));
            cmd.Connection = sqlConnection1;
            

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            
        }

        public List<Property> GetProperties(IFilter PropertyFilter)
        {
            List<Property> properties = new List<Property>();
            properties.Add(
                new House
            {
                Address = new Address
                {
                    AddressLine1 = "1 A street",
                    AddressLine2 = "Cheltenham",
                    AddressLine3 = "Gloucester",
                    PostCode = "GL23 3RT"
                },
                AskingPrice = 10000,
                
            }
            );
            return properties;
        }

        public List<IOffer> GetOffers()
        {

            return null;
        }
    }
}
