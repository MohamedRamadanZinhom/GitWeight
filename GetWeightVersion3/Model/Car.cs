using GetWeightVersion3.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWeightVersion3.Model
{
    class Car : OPERATION 
    {


        public string Car_ID   { get; set; }
        public string Car_Char { get; set; }
        public string Date     { get; set; }
        public string Time     { get; set; }


        private DBAdapter _do;

        public Car(string id, string character)
        {
            this.Car_ID = id;
            this.Car_Char = character.ToString();
            _do = new DBAdapter();
        }





        public OPERATION Get_Query()
        {
            SqlParameter[] param = new SqlParameter[2];
            
            Car car = new Car("", "");

            string command = " SELECT * FROM Car where ID=@id And char=@char ";
            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = this.Car_ID;

                param[1] = new SqlParameter("@char", SqlDbType.NVarChar, 50);
                param[1].Value = this.Car_Char;
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
            DBAdapter.Close();

            DataTable table = _do.getQuery(command, param);

            if (table.Rows.Count > 0)
            {
                car.Car_ID = table.Rows[0][0].ToString();
                car.Car_Char = table.Rows[0][1].ToString();
                car.Date = table.Rows[0][2].ToString();
                car.Time = table.Rows[0][3].ToString();
              

                return car ;
            }
            else
            {
                return null;
            }
        }

        public void Set_Query()
        {
            string command = "insert into Car (ID,char,date,time) values (@id,@char,@date,@time) ";

            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = this.Car_ID;

                param[1] = new SqlParameter("@char", SqlDbType.NVarChar, 50);
                param[1].Value = this.Car_Char;

                param[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
                param[2].Value = DateTime.Now.ToShortDateString();

                param[3] = new SqlParameter("@time", SqlDbType.NVarChar, 50);
                param[3].Value = DateTime.Now.ToLongTimeString();

                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
               
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
               
            }


            //-------
        }

        public void Reset_Query( )
        {
            string command = "Update Car set (ID=@id,char=@char,date=@date,time=@time) where ID=@id And char=@char  ";

            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = this.Car_ID;

                param[1] = new SqlParameter("@char", SqlDbType.NVarChar, 50);
                param[1].Value = this.Car_Char;

                param[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
                param[2].Value = this.Date;

                param[3] = new SqlParameter("@time", SqlDbType.NVarChar, 50);
                param[3].Value = this.Time;




                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Car Reset Successfuly");
            }
        }

        public void Remove(  )
        {
            string command = "Delete From Car  where ID=@id And char=@char  ";

            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[2];

                 param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                 param[0].Value = this.Car_ID;

                param[1] = new SqlParameter("@char", SqlDbType.NVarChar, 50);
                param[1].Value = this.Car_Char;

                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Car Removed Successfuly");
            }
        }

        
    }
}
