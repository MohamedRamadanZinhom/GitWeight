using GetWeightVersion3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWeightVersion3.Classes
{
    class DataAccess
    {

        private DBAdapter _do;

        public DataAccess()
        {
            _do = new DBAdapter();
        }



        public Scale ISCleared(Car car)
        {


            Scale scale = new Scale();
            string command = "Select * From  DailyWork  where Car_ID = @carid And Car_char=@carchar And Weighted= '" + 0 + "' And F_Date between @date1 and @date2 ";
            SqlParameter[] param = new SqlParameter[4];


            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@carid", SqlDbType.NVarChar, 50);
                param[0].Value = car.Car_ID;

                param[1] = new SqlParameter("@carchar", SqlDbType.NVarChar, 50);
                param[1].Value = car.Car_Char;

                param[2] = new SqlParameter("@date1", SqlDbType.Date, 50);
                param[2].Value = DateTime.Now.Date.AddDays(-3);


                param[3] = new SqlParameter("@date2", SqlDbType.Date, 50);
                param[3].Value = DateTime.Now.Date;



            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
            DBAdapter.Close();
            DataTable table = _do.getQuery(command, param);

            if (table.Rows.Count > 0)
            {

                //DateTime d = DateTime.Parse(table.Rows[0]["F_Date"].ToString());
                //TimeSpan T = d.Date - DateTime.Now.Date;
                //if (DateTime.Compare(d,DateTime.Now)<3)  //to check if it is completly weighted  
                //{
                    //c.Car_ID = table.Rows[0]["Car_ID"].ToString();
                    //c.Car_Char = table.Rows[0]["Car_char"].ToString();

                    scale.Carid = table.Rows[0]["Car_ID"].ToString();
                    scale.Caridchar = table.Rows[0]["Car_char"].ToString();
                    scale.F_Scale = table.Rows[0]["F_Weight"].ToString();
                    scale.F_Date = table.Rows[0]["F_Date"].ToString();
                    scale.F_Time = table.Rows[0]["F_Tiem"].ToString();
                    scale.Price = table.Rows[0]["Price"].ToString();


                    return scale;
                //}
                //else
                //{
                //    return null;
                //}
            }
            else
            {
                return null;
            }



        }


        public List<Scale> GetAllScale(string date)
        {
            List<Scale> all = new List<Scale>();

            SqlParameter[] param = new SqlParameter[1];
            string command = "Select * from DailyWork where F_Date=@date";
            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@date", SqlDbType.Date, 50);
                param[0].Value = date;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DBAdapter.Close();
            DataTable table = _do.getQuery(command, param);
            Scale scale;
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    scale = new Scale();

                    scale.Emp_Id = table.Rows[i]["Emp_ID"].ToString();
                    scale.Carid = table.Rows[i]["Car_ID"].ToString();
                    scale.Caridchar = table.Rows[i]["Car_char"].ToString();
                    scale.F_Scale = table.Rows[i]["F_Weight"].ToString();
                    scale.S_Scale = table.Rows[i]["S_Weight"].ToString();
                    scale.Price = table.Rows[i]["Price"].ToString();
                    scale.Clear_Scale = table.Rows[i]["C_Weight"].ToString();

                    scale.F_Date = table.Rows[i]["F_Date"].ToString();
                    scale.S_Date = table.Rows[i]["S_Date"].ToString();
                    scale.F_Time = table.Rows[i]["F_Tiem"].ToString();
                    scale.S_Time = table.Rows[i]["S_Time"].ToString();
                    all.Add(scale);
                }
            }

            return all;

        }

        public List<Scale> GetAllScale(string date, string date2)
        {
            List<Scale> all = new List<Scale>();

            SqlParameter[] param = new SqlParameter[2];
            string command = "Select * from DailyWork where F_Date between @date and @date2 ";
            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@date", SqlDbType.Date, 50);
                param[0].Value = date;

                param[1] = new SqlParameter("@date2", SqlDbType.Date, 50);
                param[1].Value = date2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DBAdapter.Close();
            DataTable table = _do.getQuery(command, param);
            Scale scale;
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    scale = new Scale();

                    scale.Emp_Id = table.Rows[i]["Emp_ID"].ToString();
                    scale.Carid = table.Rows[i]["Car_ID"].ToString();
                    scale.Caridchar = table.Rows[i]["Car_char"].ToString();
                    scale.F_Scale = table.Rows[i]["F_Weight"].ToString();
                    scale.S_Scale = table.Rows[i]["S_Weight"].ToString();
                    scale.Price = table.Rows[i]["Price"].ToString();
                    scale.Clear_Scale = table.Rows[i]["C_Weight"].ToString();

                    scale.F_Date = table.Rows[i]["F_Date"].ToString();
                    scale.S_Date = table.Rows[i]["S_Date"].ToString();
                    scale.F_Time = table.Rows[i]["F_Tiem"].ToString();
                    scale.S_Time = table.Rows[i]["S_Time"].ToString();
                    all.Add(scale);
                }
            }

            return all;

        }


        public List<Scale> Search(Car car, DateTime date, DateTime date2)
        {


            List<Scale> all = new List<Scale>();
            SqlParameter[] param = new SqlParameter[4];
            string command = "Select * from DailyWork where Car_ID=@id And Car_char=@char And F_Date between @date and @date2";
            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@date", SqlDbType.Date, 50);
                param[0].Value = (date);

                param[1] = new SqlParameter("@date2", SqlDbType.Date, 50);
                param[1].Value = (date2);

                param[2] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[2].Value = car.Car_ID;

                param[3] = new SqlParameter("@char", SqlDbType.NVarChar, 50);
                param[3].Value = car.Car_Char;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DBAdapter.Close();
            DataTable table = _do.getQuery(command, param);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Scale scale = new Scale();

                    scale.Emp_Id = table.Rows[i]["Emp_ID"].ToString();
                    scale.Carid = table.Rows[i]["Car_ID"].ToString();
                    scale.Caridchar = table.Rows[i]["Car_char"].ToString();
                    scale.F_Scale = table.Rows[i]["F_Weight"].ToString();
                    scale.S_Scale = table.Rows[i]["S_Weight"].ToString();
                    scale.Price = table.Rows[i]["Price"].ToString();
                    scale.Clear_Scale = table.Rows[i]["C_Weight"].ToString();


                    scale.F_Date = table.Rows[i]["F_Date"].ToString();
                    scale.S_Date = table.Rows[i]["S_Date"].ToString();
                    scale.F_Time = table.Rows[i]["F_Tiem"].ToString();
                    scale.S_Time = table.Rows[i]["S_Time"].ToString();
                    all.Add(scale);
                }
            }

            return all;


        }

      
        
        public void ResetScale(Scale scale)
        {

            string command = "Update DailyWork Set Car_ID=@id , Car_char=@char , F_Weight=@fw,S_Weight=@sw ,C_Weight=@cw ,Price=@price where F_Date=@date And Car_ID=@carid And Car_char=@carchar And Emp_ID=@emp And F_Tiem=@time";
            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = scale.Carid;

                param[1] = new SqlParameter("@char", SqlDbType.NVarChar, 50);
                param[1].Value = scale.Caridchar;

                param[2] = new SqlParameter("@fw", SqlDbType.NVarChar, 50);
                param[2].Value = scale.F_Scale;

                param[3] = new SqlParameter("@sw", SqlDbType.NVarChar, 50);
                param[3].Value = scale.S_Scale;

                param[4] = new SqlParameter("@cw", SqlDbType.NVarChar, 50);
                param[4].Value = scale.Clear_Scale;

                param[5] = new SqlParameter("@price", SqlDbType.NVarChar, 50);
                param[5].Value = scale.Price;

                param[6] = new SqlParameter("@date", SqlDbType.Date, 50);
                param[6].Value = scale.F_Date;

                param[7] = new SqlParameter("@carid", SqlDbType.NVarChar, 50);
                param[7].Value = scale.Carid;

                param[8] = new SqlParameter("@carchar", SqlDbType.NVarChar, 50);
                param[8].Value = scale.Caridchar;

                param[9] = new SqlParameter("@emp", SqlDbType.NVarChar, 50);
                param[9].Value = scale.Emp_Id;

                param[10] = new SqlParameter("@time", SqlDbType.NVarChar, 50);
                param[10].Value = scale.F_Time;

                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Scale Reset Successfuly");
            }

        }
        
        public void RemoveScale(Scale scale)
        {

            string command = "Delete From DailyWork where F_Date=@date And Car_ID=@carid And Car_char=@carchar And Emp_ID=@emp And F_Tiem=@time";
            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@date", SqlDbType.Date, 50);
                param[0].Value = scale.F_Date;

                param[1] = new SqlParameter("@carid", SqlDbType.NVarChar, 50);
                param[1].Value = scale.Carid;

                param[2] = new SqlParameter("@carchar", SqlDbType.NVarChar, 50);
                param[2].Value = scale.Caridchar;

                param[3] = new SqlParameter("@emp", SqlDbType.NVarChar, 50);
                param[3].Value = scale.Emp_Id;

                param[4] = new SqlParameter("@time", SqlDbType.NVarChar, 50);
                param[4].Value = scale.F_Time;

                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Scale Deleted Successfuly");
            }

        }

        public void SetFirstScale(Scale scale)
        {

            string command = "Insert Into DailyWork (Emp_ID,Car_ID,Car_char,F_Weight,F_Date,F_Tiem,Price,Weighted) Values(@emp,@CarId,@carchar,@FW,@Fdate,@FT,@price,'" + 0 + "')";
            SqlParameter[] param = new SqlParameter[7];

            try
            {

                DBAdapter.OPen();

                param[0] = new SqlParameter("@emp", SqlDbType.NVarChar, 50);
                param[0].Value = scale.Emp_Id;

                param[1] = new SqlParameter("@CarId", SqlDbType.NVarChar, 50);
                param[1].Value = scale.Carid;

                param[2] = new SqlParameter("@carchar", SqlDbType.NVarChar, 50);
                param[2].Value = scale.Caridchar;

                param[3] = new SqlParameter("@FW", SqlDbType.NVarChar, 50);
                param[3].Value = scale.F_Scale;

                param[4] = new SqlParameter("@Fdate", SqlDbType.Date, 50);
                param[4].Value = scale.F_Date;

                param[5] = new SqlParameter("@FT", SqlDbType.NVarChar, 50);
                param[5].Value = scale.F_Time;

                param[6] = new SqlParameter("@price", SqlDbType.NVarChar, 50);
                param[6].Value = scale.Price;

                _do.Execute_Query(command, param);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Scale Deleted Successfuly");
            }

        }

        public void SetSecondeScale(Scale scale)
        {

            string command = " Update DailyWork set S_Weight=@sw ,C_Weight=@cw ,S_Date=@sdate ,S_Time=@st,Weighted='" + 1 + "' where   Car_ID=@id And Car_char=@char And F_Date=@fdate And Weighted='" + 0 + "' ";
            SqlParameter[] param = new SqlParameter[7];

            try
            {

                DBAdapter.OPen();



                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = scale.Carid;

                param[1] = new SqlParameter("@char", SqlDbType.NVarChar, 50);
                param[1].Value = scale.Caridchar;

                param[2] = new SqlParameter("@sw", SqlDbType.NVarChar, 50);
                param[2].Value = scale.S_Scale;

                param[3] = new SqlParameter("@fdate", SqlDbType.Date, 50);
                param[3].Value = scale.F_Date;

                param[4] = new SqlParameter("@st", SqlDbType.NVarChar, 50);
                param[4].Value = scale.F_Time;

                param[5] = new SqlParameter("@cw", SqlDbType.NVarChar, 50);
                param[5].Value = scale.Clear_Scale;

                param[6] = new SqlParameter("@sdate", SqlDbType.Date, 50);
                param[6].Value = scale.S_Date;

                _do.Execute_Query(command, param);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Scale Deleted Successfuly");
            }


        }


        public void AddExpenses(Expensess expensess)
        {

            string command = "Insert Into T_Epenses (Emp_ID,Expenses,Descreption,Date) Values (@emp,@expenses,@descre,@date)";
            SqlParameter[] param = new SqlParameter[4];

            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@emp", SqlDbType.NVarChar, 50);
                param[0].Value = expensess.Employee_Name;

                param[1] = new SqlParameter("@expenses", SqlDbType.NVarChar, 50);
                param[1].Value = expensess.Cost;

                param[2] = new SqlParameter("@descre", SqlDbType.NVarChar, 50);
                param[2].Value = expensess.DESC;

                param[3] = new SqlParameter("@date", SqlDbType.Date, 50);
                param[3].Value = expensess.Date;
                _do.Execute_Query(command,param);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Expensess Add Successfully");
            }
        
        }

       
        
        
        public List<Expensess> GetAllExpensess(string date1, string date2)
        {
            List<Expensess> all = new List<Expensess>();
            SqlParameter[] param = new SqlParameter[2];
            string command = "Select * from T_Epenses where Date between @date and @date2 ";

            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@date", SqlDbType.Date, 50);
                param[0].Value = date1;

                param[1] = new SqlParameter("@date2", SqlDbType.Date, 50);
                param[1].Value = date2;

              
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DBAdapter.Close();
            DataTable table = _do.getQuery(command, param);

            Expensess expensess =new Expensess();
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    expensess.Employee_Name = table.Rows[i]["Emp_ID"].ToString();
                    expensess.Cost = table.Rows[i]["Expenses"].ToString();
                    expensess.Date = table.Rows[i]["Date"].ToString();
                    expensess.DESC = table.Rows[i]["Descreption"].ToString();
                   
                    all.Add(expensess);
                }
            }


            return all;
        }


       

    }
}
