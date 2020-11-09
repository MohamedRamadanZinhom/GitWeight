using GetWeightVersion3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWeightVersion3.Classes
{
    class DBAdapter
    {
        private static readonly string _SERVER_NAME = Properties.Settings.Default.Server;



        private static readonly string _DataBase_NAME = Properties.Settings.Default.DB;
        private static readonly string _MODE = Properties.Settings.Default.Mod;

        private static readonly string _USER_NAME = Properties.Settings.Default.UserName;
        private static readonly string _PASSWORD = Properties.Settings.Default.Password;

        private static readonly string _WINDOWS_CONNECTION = @"server = " + _SERVER_NAME + " ; Database=" + _DataBase_NAME + " ; Integrated Security=true";
        private static readonly string _AUTHORNECATION_CONNECTION = @"server = " + _SERVER_NAME + " ; Database=" + _DataBase_NAME + ";Integrated Security=false ; User ID = " + _USER_NAME + " ;Password = " + _PASSWORD + " ";

        private static readonly SqlConnection connector;




        static DBAdapter()
        {

            switch (_MODE)
            {

                case "Windows":
                    connector = new SqlConnection(_WINDOWS_CONNECTION);
                    break;
                case "Authornecation":
                    connector = new SqlConnection(_AUTHORNECATION_CONNECTION);
                    break;
                default: throw new Exception("You have being enterd the conection Mode in wrong way");

            }

        }



        public static SqlConnection Connector
        {
            get { return connector; }
        }

        //-----------

        public static string Server
        {
            get { return _SERVER_NAME; }
        }

        public static string Database
        {
            get { return _DataBase_NAME; }
        }

        public static string UserName
        {
            get { return _USER_NAME; }
        }

        public static string Password
        {
            get { return _PASSWORD; }
        }

        //----------

        public static void OPen()
        {
            if (connector.State != ConnectionState.Open)
            {
                connector.Open();
            }
        }

        public static void Close()
        {
            if (connector.State == ConnectionState.Open)
            {
                connector.Close();
            }
        }

        public DataTable getQuery(string command, SqlParameter[] paramter)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            cmd.Connection = DBAdapter.Connector;


            if (paramter != null)
            {
                cmd.Parameters.AddRange(paramter);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);

            return table;
       
           

        
        }

        public void Execute_Query(string command, SqlParameter[] paramter)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            cmd.Connection = DBAdapter.Connector;


            if (paramter != null)
            {
                cmd.Parameters.AddRange(paramter);
            }

            cmd.ExecuteNonQuery();
        
        }

    }
}
