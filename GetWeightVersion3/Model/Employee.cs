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
    class Employee : OPERATION
    {


        public string Name  { get; set; }
        public string Code  { get; set; }
        public string Date  { get; set; }
        public string Time  { get; set; }
        public string power { get; set; }
        public string Phone { get; set; }
        public string Salary{ get; set; }
        private DBAdapter _do;

        public Employee(string name, string Code)
        {


            this.Code = Code;
            this.Name = name;
            _do = new DBAdapter();

        }




        public OPERATION Get_Query()
        {
            SqlParameter[] param = new SqlParameter[2];
            Employee emp = new Employee("","");

            string command = "SELECT * FROM Employee where Emp_ID=@name And Emp_code=@pass";
            try
            {
                DBAdapter.OPen();
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                param[0].Value = this.Name;

                param[1] = new SqlParameter("@pass", SqlDbType.NVarChar, 50);
                param[1].Value = this.Code;
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
            DBAdapter.Close();
            
            DataTable table = _do.getQuery(command,param);
            if (table.Rows.Count > 0)
            {
                emp.Name  = table.Rows[0][0].ToString();
                emp.Code  = table.Rows[0][1].ToString();
                emp.Date  = table.Rows[0][2].ToString();
                emp.Time  = table.Rows[0][3].ToString();
                emp.power = table.Rows[0][4].ToString();
                emp.Phone = table.Rows[0][5].ToString();
                emp.Salary =table.Rows[0][6].ToString();

                return emp;
            }
            else
            {
                return null;
            }


        }

        public void Set_Query()
        {
           
            //---------

            string command = "insert into Employee (Emp_ID,Emp_code,Date,time,Power,Phone,Salary) values ( @name, @code , @date , @time , @power , @phone , @salary ) ";

            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                param[0].Value = this.Name;

                param[1] = new SqlParameter("@code", SqlDbType.NVarChar, 50);
                param[1].Value = this.Code;

                param[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
                param[2].Value = DateTime.Now.ToShortDateString();

                param[3] = new SqlParameter("@time", SqlDbType.NVarChar, 50);
                param[3].Value = DateTime.Now.ToLongTimeString();

                param[4] = new SqlParameter("@power", SqlDbType.NVarChar, 50);
                param[4].Value = this.power;

                param[5] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
                param[5].Value = this.Phone;

                param[6] = new SqlParameter("@salary", SqlDbType.NVarChar, 50);
                param[6].Value = this.Salary;

                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
                Alert.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Employee Added Successfuly");
            }


            //-------
        }

        public void Reset_Query( )
        {

            string command = "Update Employee set Emp_ID =@ID , Emp_code=@code,Date=@date,time =@time,Power =@power,Phone =@phone ,Salary=@salary where Emp_ID=@ID_old And Emp_code=@code_old  ";

            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@ID_old", SqlDbType.NVarChar, 50);
                param[0].Value = Properties.Settings.Default.Logedin_Name;

                param[1] = new SqlParameter("@code_old", SqlDbType.NVarChar, 50);
                param[1].Value = Properties.Settings.Default.Logedin_Pass;


                param[2] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                param[2].Value = this.Name;

                param[3] = new SqlParameter("@code", SqlDbType.NVarChar, 50);
                param[3].Value = this.Code;

                param[4] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
                param[4].Value = DateTime.Now.ToShortDateString();

                param[5] = new SqlParameter("@time", SqlDbType.NVarChar, 50);
                param[5].Value = DateTime.Now.ToLongTimeString();

                param[6] = new SqlParameter("@power", SqlDbType.NVarChar, 50);
                param[6].Value = this.power;

                param[7] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
                param[7].Value = this.Phone;

                param[8] = new SqlParameter("@salary", SqlDbType.NVarChar, 50);
                param[8].Value = this.Salary;




                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
                //Alert.Show(ex.Message);
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Employee Reset Successfuly");
            }

        }
        public void Remove( )
        {
            string command = "Delete From Employee  where Emp_ID=@oldId And Emp_code=@oldcode  ";

            try
            {

                DBAdapter.OPen();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@oldId", SqlDbType.NVarChar, 50);
                param[0].Value =this.Name;

                param[1] = new SqlParameter("@oldcode", SqlDbType.NVarChar, 50);
                param[1].Value = this.Code;

                _do.Execute_Query(command, param);


            }
            catch (SqlException ex)
            {
                Alert.Show(ex.Message);

            }
            finally
            {
                DBAdapter.Close();
                Alert.Show("Employee Removed Successfuly");
            }
        }
       
        public  List<Employee> GetAll()
        {


            List<Employee> all = new List<Employee>();
           
             DataTable table;
            
            string command = "SELECT * FROM Employee ";

            try
            {
                DBAdapter.OPen();
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
            DBAdapter.Close();

            table = _do.getQuery(command, null);

            for (int i = 0; i < table.Rows.Count;i++ )
            {
                Employee emp = new Employee("", "");
                emp.Name = table.Rows[i]["Emp_ID"].ToString();
                emp.Code = table.Rows[i]["Emp_code"].ToString();
                emp.Date = table.Rows[i]["Date"].ToString();
                emp.power = table.Rows[i]["Power"].ToString();
                emp.Phone = table.Rows[i]["Phone"].ToString();
                emp.Time = table.Rows[i]["time"].ToString();
                emp.Salary = table.Rows[i]["Salary"].ToString();

                all.Add(emp);

            }


                return all;
        }


    }
}
