using System;
using System.Data;
using System.Data.SqlClient;


namespace Day1_ADO_Basic
{
    class ConnectedArch
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        //function that establishes connection with the database server and returns
        // an object of SqlConnection type
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=LAPTOP-TJJ7D977;initial catalog=InfiniteDB;" +
                "Integrated Security=True");
            con.Open();
            return con;                
        }
        public static void SelectEmployees()
        {
            con = getConnection();
            try
            {
                //cmd = new SqlCommand("select * from employee", con); 
                //or as below
                cmd = new SqlCommand("select * from employee");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4] + " " + dr[5]);
                    //Console.WriteLine("Employee Id :" + dr[0]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine("Error in the Server...");
            }
            
        }
        static void Main(string[] args)
        {
            SelectEmployees();
            Console.Read();
        }
    }
}
