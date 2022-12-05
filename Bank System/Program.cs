
using System.Data.SqlClient;

namespace Bank_System
{
    internal static class Program
    {
        public static Form1 obj;

        public static String AdminId;

        public static String EmployeeId;

        public static String CustomerID;

        [STAThread]

        public static bool checkFill(UserControl userControl)
        {
            bool allField = true;  

            foreach (Control item in userControl.Controls)
            { 
                if (item is TextBox &&item.Text == "")
                { 
                    allField = false;
                    MessageBox.Show("Please Fill All Fields!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            
            return allField;
        }

        public static void retrieveData(DataGridView dataGridView, string _SqlCommand, int colNumber)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + "Database.mdf";

            string _path = AppDomain.CurrentDomain.BaseDirectory;
             
            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\Database.mdf";
              
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");

           // SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\Desktop\Database Project\Bank System\Bank System\Database.mdf;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = _SqlCommand;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            for (int j = 0; sqlDataReader.Read(); j++)
            {
                dataGridView.Rows.Add();
                for (int i = 0; i < colNumber; i++)
                {  
                    dataGridView.Rows[j].Cells[i].Value = sqlDataReader.GetValue(i).ToString();
                } 
            }

            sqlConnection.Close();
        }

        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\Desktop\Database Project\Bank System\Bank System\Database.mdf;Integrated Security=True
        //Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True

        public static bool retrieveData(string _SqlCommand)
        {
            bool userFound = false;

            //string path = AppDomain.CurrentDomain.BaseDirectory + "Database.mdf";


            string _path = AppDomain.CurrentDomain.BaseDirectory;

            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\Database.mdf";


            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ path + ";Integrated Security=True");
             
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\Desktop\Database Project\Bank System\Bank System\Database.mdf;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = _SqlCommand;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                userFound = true;
            }
             
            sqlConnection.Close();
             
            return userFound;
        }
         
        public static void insertData(string _SqlCommand)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + "Database.mdf";
             
            string _path = AppDomain.CurrentDomain.BaseDirectory;

            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\Database.mdf";
             
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");

           // SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\Desktop\Database Project\Bank System\Bank System\Database.mdf;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = _SqlCommand;
               
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        static void Main()
        { 
            ApplicationConfiguration.Initialize();

            obj = new Form1();

            Application.Run(obj);
        }
    }
}