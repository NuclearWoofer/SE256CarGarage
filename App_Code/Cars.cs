using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace SE256_Lab_MikeL.App_Code
{
    public class Cars //Cars class
    {
        //Car vars
        private string carMake; //Honda
        private string carModel; //Civic
        private string carStyle; //Hatchback
        private DateTime carYear; //2021
        private int carCylinders; //4 Cylinders
        private double carPurchasePrice; //$18,459

        protected string feedback; //tracks err msgs


        public string CarMake
        {
            get
            {
                return carMake;
            }
            set
            {   //Catching for badwords
                if (!BasicValidation.GotBadWords(value))
                {
                    carMake = value;
                }
                else
                {
                    feedback += "\nERROR: 'Make' Should not include bad words.";
                }
            }
        }

        public string CarModel
        {
            get
            {
                return carModel;
            }
            set
            {   //Catching for badwords
                if (!BasicValidation.GotBadWords(value))
                {
                    carModel = value;
                }
                else
                {
                    feedback += "\nERROR: 'Model' Should not include bad words.";
                }
            }
        }
        public string CarStyle
        {
            get
            {
                return carStyle;
            }
            set
            {   //Catching for badwords
                if (!BasicValidation.GotBadWords(value))
                {
                    carStyle = value;
                }
                else
                {
                    feedback += "\nERROR: 'Style' Should not include bad words.";
                }
            }
        }

        public DateTime CarYear
        {
            get
            {
                return carYear;
            }
            set
            {   //Catching for invalid dates
                if (BasicValidation.IsAFutureDate(value) == false)
                {
                    carYear = value;
                }
                else
                {
                    feedback += "\nERROR: Year cannot be a future date.";
                }
            }
        }

        public int CarCylinders
        {
            get
            {
                return carCylinders;
            }
            set
            {
                if (BasicValidation.IsMinimumAmount(value, 0) == true)
                {
                    carCylinders = value; //Stores amount of Cylinders
                }
                else
                {
                    feedback += "\nERROR: Cylinders is an invalid amount, must be [2, 3, 4, 6, 8 or 10.]";
                }
            }
        }

        public double CarPurchasePrice
        {
            get
            {
                return carPurchasePrice;
            }
            set
            {
                if (BasicValidation.IsMinimumAmount(value, 1) == true)
                {
                    carPurchasePrice = value;
                }
                else
                {
                    feedback += "\nERROR: Price is not sufficient.";
                }
            }
        }



        public string Feedback
        {
            get { return feedback;  }
        }


        public Cars()
        {
            carMake = "";
            carModel = "";
            carStyle = "";
            carYear = DateTime.Parse("1/1/1945");
            carPurchasePrice = 0.0;
            carCylinders = 0;
            feedback = "";
        }

        private string getConnected()
        {
            return @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE245_MLopez;User Id=SE245_MLopez;Password=008008619;";
        }

        public string AddARecord()
        {
            string strResult = "";

            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = @getConnected();

            string strSQL = "INSERT INTO ECars (carMake, carModel, carStyle, carYear, carCylinders, carPurchasePrice) VALUES (@carMake, @carModel, @carStyle, @carYear, @carCylinders, @carPurchasePrice)";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@carMake", CarMake);
            comm.Parameters.AddWithValue("@carModel", CarModel);
            comm.Parameters.AddWithValue("@carStyle", CarStyle);
            comm.Parameters.AddWithValue("@carYear", CarYear);
            comm.Parameters.AddWithValue("@carCylinders", CarCylinders);
            comm.Parameters.AddWithValue("@carPurchasePrice", CarPurchasePrice);

            try
            {
                Conn.Open();

                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";

                Conn.Close();

            }

            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {

            }

            return strResult;



        }


    }
}