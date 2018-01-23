using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace AdoNetDataBaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string sCreateDatabase = "Create database Projects";


            string sCreateTableClientData = @"use projects 
	                       Create table ClientData  
	                       ( 
		                    ClientId INTEGER PRIMARY KEY IDENTITY, 
                      		Title NVARCHAR(200) NOT NULL, 
		                    ClientName NVARCHAR(200) NOT NULL, 
	                      	ProjectCost NVARCHAR(200) NOT NULL)";

            string sCreateTableProjectData = @"use projects 
	                       Create table ProjectData  
	                       ( 
		                    ProjectId INTEGER PRIMARY KEY IDENTITY, 
                      		TitleTask NVARCHAR(200) NOT NULL, 
		                    DevName NVARCHAR(200) NOT NULL, 
	                      	DevSurname NVARCHAR(200) NOT NULL,
                            Deadline NVARCHAR(200) NOT NULL)   ";

            string sInsertFirstRow = @"use Projects
                                           INSERT INTO ClientData(Title,ClientName,ProjectCost)
                                           VALUES(N'E-commerce Website',N'Robert Marshal',N'2,0000 Euros'),
                                                 (N'Website for Dental Services',N'Marta Angel',N'1,0000 Euros'),
                                                 (N'Eat & Travel Blog',N'Alex Suanson',N'2,0000 Dollars'),
                                                 (N'Android App for Team Creation',N'Maciej Trendak',N'1,7000 Euros'),
                                                 (N'Laravel Social Network',N'Gregor Zawadski',N'1,500 Dollars'),
                                                 (N'WP Image Processing Plugin ',N'Marsha Han',N'1,0000 Euros')";
            string sInsertSecondRow = @"use Projects
                                           INSERT INTO ProjectData(TitleTask,DevName,DevSurname,Deadline)
                                           VALUES(N'Landing_Page_Design',N'Natalia',N'Setnik',N'1 week'),
                                                 (N'API_creation',N'Dmitry',N'Teshabaev',N'3 weeks'),
                                                 (N'Image_Processing_Libray_Creation ',N'John',N'Smith',N'1 month'),
                                                 (N'Security_Check',N'Tamara',N'Sharp',N'1 week'),
                                                 (N'Package_Updating',N'Stas',N'Mashtailer',N'2 weeks')";


            SqlConnection MyCon = new SqlConnection();
            MyCon.ConnectionString = @"Data Source = (localdb)\MsSqLLocalDb;Initial Catalog = master; Integrated Security = SSPI;";

            SqlCommand MyCommand = new SqlCommand();
            MyCommand.CommandType = CommandType.Text;
            MyCommand.CommandText = sCreateDatabase;
            MyCommand.Connection = MyCon;
            try
            {
                MyCon.Open();
                MyCommand.ExecuteNonQuery();
                Console.WriteLine("Database is created");
                Console.ReadKey();
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();

            }
            finally
            {
                MyCon.Close();

            }
           
            try
            {
                MyCon.Open();

                MyCommand.CommandText = sCreateTableClientData;
                MyCommand.Connection = MyCon;
                MyCommand.ExecuteNonQuery();

                MyCommand.CommandText = sCreateTableProjectData;
                MyCommand.ExecuteNonQuery();

                MyCommand.CommandText = sInsertFirstRow;
                MyCommand.ExecuteNonQuery();
                MyCommand.CommandText = sInsertSecondRow;
                MyCommand.ExecuteNonQuery();

                Console.WriteLine("Table is created and data is inserted");
                Console.ReadKey();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();


            }
            finally
            {
                MyCon.Close();
            }
            MyCon.ConnectionString = @"Data Source = (localdb)\MsSqLLocalDb;Initial Catalog = master; Integrated Security = SSPI;";
            string sSelect = @"use Projects 
                             SELECT Title , ClientName, ProjectCost from ClientData ";
            string sSelect1 = @"use Projects 
                             SELECT TitleTask , DevName, DevSurname , Deadline from ProjectData ";
            MyCommand.CommandText = sSelect;
            MyCommand.Connection = MyCon;
            MyCon.Open();
            using (var reader = MyCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    Console.WriteLine($"{reader[0]}"+"  "+ $"{reader[1]}" + "  " + $"{reader[2]}");
                }
            }
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            MyCommand.CommandText = sSelect1;
            using (var reader1 = MyCommand.ExecuteReader())
            {
                while (reader1.Read())
                {

                    Console.WriteLine($"{reader1[0]}" + "  " + $"{reader1[1]}" + "  " + $"{reader1[2]}"+"        "+ $"{reader1[3]}");
                }
            }
            MyCon.Close();
            Console.ReadKey();
        }

    }
}
    
    

