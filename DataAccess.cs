using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DiabetesPredictionWinForms
{
    public static class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DiabetesDb"].ConnectionString;


        public static List<DiabetesData> GetDataFromDatabase()
        {
            var dataList = new List<DiabetesData>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM DiabetesData", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataList.Add(new DiabetesData
                    {
                        Pregnancies = reader.GetInt32(0),
                        Glucose = reader.GetInt32(1),
                        BloodPressure = reader.GetInt32(2),
                        SkinThickness = reader.GetInt32(3),
                        Insulin = reader.GetInt32(4),
                        BMI = (float)reader.GetDouble(5),
                        DiabetesPedigreeFunction = (float)reader.GetDouble(6),
                        Age = reader.GetInt32(7),
                        Outcome = reader.GetBoolean(8)
                    });
                }
            }

            return dataList;
        }
    }
    public class DiabetesData
    {
        public int Pregnancies { get; set; }
        public int Glucose { get; set; }
        public int BloodPressure { get; set; }
        public int SkinThickness { get; set; }
        public int Insulin { get; set; }
        public float BMI { get; set; }
        public float DiabetesPedigreeFunction { get; set; }
        public int Age { get; set; }
        public bool Outcome { get; set; }
    }
}

