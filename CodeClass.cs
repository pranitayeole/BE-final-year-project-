using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Security;
using System.Security.Permissions;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GlassStore.classes
{

  
   // [SqlClientPermission(SecurityAction.Demand, ConnectionString = "Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Northwind;")]
   public  class CodeClass
    {
       // public static SqlCommand CMD;
       // public static SqlDataReader DR;
     //  public SqlConnection con=new SqlConnection();
       public SqlCommand CMD;
       public SqlCommand cmd;
       public SqlCommand CMD1;
       public SqlDataAdapter DA;
       public bool del;
       public SqlDataReader DR;
       public SqlDataReader DR1;
       public SqlDataReader DR2;
       public SqlConnection con;
       public DataSet DS;
       public static int COUNTER = 0;
       public static double CT1;
       public static int FIGLEN;
       public static object FIGURE;
       public static string InWords;
       public static string[] tens = new string[10];
       public static string[] WORDs = new string[20];
       

       //[System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]

      // [SqlClientPermission(SecurityAction.Demand, ConnectionString = "Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Northwind;")]

       [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
       public void ConnectToDatabase()
       {
           con = new SqlConnection();
           //EXE
          // FileInfo f = new FileInfo("Database/dbhandges.mdf");
         //Coding
FileInfo f = new FileInfo("../../Database/dbhandges.mdf");
           

        // FileInfo f = new FileInfo("/Database/.mdf");
         // con = new SqlConnection();


         // ==> It is for setup //
         // con.ConnectionString = ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString;

            con.ConnectionString = @"server=.\sqlexpress;attachdbfilename="+f.FullName+";integrated Security=true;User Instance=true";
              // con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database\Electrical.mdf;Integrated Security=True;User Instance=True";

        //  con.ConnectionString = ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString;

               con.Open();
             
           
       }
      
       public void Disconnect()
       {
           if (con != null)
           {
               if (con.State == ConnectionState.Open)
                   con.Close();
           }
       }
      

        public void FillCombo(ComboBox cmb, String sql, String dismemb, String valuemeber)
        {
            DataTable dt = GetTable(sql);

            cmb.DataSource = dt;
            cmb.DisplayMember = dismemb;
            cmb.ValueMember = valuemeber;

            if (cmb.Items.Count > 0) cmb.SelectedIndex = 0;
        }

     
       
        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //SqlDataAdapter da = new SqlDataAdapter("SELECT Bill_id FROM Cust_Bill WHERE Bill_id=" + ComboBox2.SelectedValue,con);
                DataSet ds = new DataSet();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return dt;
            }
        }


        public void FillGrid(DataGridView dv, string sql)
        {
            DataTable dt = GetTable(sql);
            
            dv.DataSource = dt;
           // DataTable dtCountry = dt.DefaultView.ToTable("Cust_Bill", true, "Bill_Id");
           

        }

       
        public void SELECT1(string CmdText)
        {

            cmd = new SqlCommand(CmdText, con);
        }

        public void SELECT2(string CmdText)
        {

            CMD1 = new SqlCommand(CmdText, con);
        }

     
        public void ExecuteSqlCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
          
          //  SqlDataReader reader = cmd.ExecuteReader();
           
            
        }
        
        public void FillListView(ListView lv, string sql)
        {
            DataTable dt = GetTable(sql);
            String[] s = new string[dt.Columns.Count];
            lv.GridLines = true;
            lv.MultiSelect = false;
            lv.FullRowSelect = true;

            lv.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = dr[i].ToString();
                }
                lv.Items.Add(new ListViewItem(s));

            }
           

        }

        public void FillGrid1(DataGridView dv, string sql)
        {
            
            DataTable dt = GetTable(sql);

            dv.DataSource = dt;
            dv.Sort(dv.Columns[0], System.ComponentModel.ListSortDirection.Ascending); 

        }

        public int AutoIncrementNo(string sql)
        {
            int i = 1;
            DataTable dt = GetTable(sql);
            try
            {
                if (dt.Rows[0][0].ToString() != "")
                {
                    i = int.Parse(dt.Rows[0][0].ToString()) + 1;

                }
                else
                {
                    i = 1;
                }
            }
            catch
            {
                i = 1;
            }
            return i;
        }
        public static String InWord(object AMT)
        {
            int num2;
            InWords = "Rupees ";
            WORDs[1] = "One";
            WORDs[2] = "Two";
            WORDs[3] = "Three";
            WORDs[4] = "Four";
            WORDs[5] = "Five";
            WORDs[6] = "Six";
            WORDs[7] = "Seven";
            WORDs[8] = "Eight";
            WORDs[9] = "Nine";
            WORDs[10] = "Ten";
            WORDs[11] = "Eleven";
            WORDs[12] = "Twelve";
            WORDs[13] = "Thirteen";
            WORDs[14] = "Fourteen";
            WORDs[15] = "Fifteen";
            WORDs[0x10] = "Sixteen";
            WORDs[0x11] = "Seventeen";
            WORDs[0x12] = "Eighteen";
            WORDs[0x13] = "Nineteen";
            tens[2] = "Twenty";
            tens[3] = "Thirty";
            tens[4] = "Fourty";
            tens[5] = "Fifty";
            tens[6] = "Sixty";
            tens[7] = "Seventy";
            tens[8] = "Eighty";
            tens[9] = "Ninety";
            FIGURE = RuntimeHelpers.GetObjectValue(AMT);
            FIGURE = Strings.Format(RuntimeHelpers.GetObjectValue(FIGURE), "FIXED");
            FIGLEN = Strings.Len(RuntimeHelpers.GetObjectValue(FIGURE));
            if (FIGLEN < 12)
            {
                FIGURE = Operators.ConcatenateObject(Strings.Space(12 - FIGLEN), FIGURE);
            }
            int num = 1;
            do
            {
                if ((Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) < 20.0) & (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 0.0))
                {
                    InWords = InWords + WORDs[(int)Math.Round(Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)))];
                }
                else if (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 19.0)
                {
                    InWords = InWords + tens[(int)Math.Round(Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 1)))];
                    CT1 = Conversions.ToDouble(Strings.LSet(Conversions.ToString(FIGURE), 2));
                    CT1 = Conversions.ToDouble(Strings.Mid(Conversions.ToString(CT1), 2));
                    InWords = InWords + WORDs[(int)Math.Round(Conversion.Val(Strings.RSet(Conversions.ToString(CT1), 1)))];
                }
                if ((num == 1) & (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 0.0))
                {
                    InWords = InWords + " Crore ";
                }
                else if ((num == 2) & (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 0.0))
                {
                    InWords = InWords + " Lakh ";
                }
                else if ((num == 3) & (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 0.0))
                {
                    InWords = InWords + " Thousand ";
                }
                FIGURE = Strings.Mid(Conversions.ToString(FIGURE), 3);
                num++;
                num2 = 3;
            }
            while (num <= num2);
            if (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 1)) > 0.0)
            {
                InWords = InWords + WORDs[(int)Math.Round(Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 1)))] + " Hundred ";
            }
            FIGURE = Strings.Mid(Conversions.ToString(FIGURE), 2);
            if ((Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) < 20.0) & (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 0.0))
            {
                InWords = InWords + WORDs[(int)Math.Round(Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)))];
            }
            else if (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 19.0)
            {
                InWords = InWords + tens[(int)Math.Round(Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 1)))];
                CT1 = Conversions.ToDouble(Strings.Mid(Conversions.ToString(FIGURE), 2));
                InWords = InWords + WORDs[(int)Math.Round(Conversion.Val(Strings.RSet(Conversions.ToString(CT1), 1)))];
            }
            FIGURE = Strings.Mid(Conversions.ToString(FIGURE), 4);
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(FIGURE)) > 0.0)
            {
                InWords = InWords + " And ";
                if ((Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) < 20.0) & (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 0.0))
                {
                    InWords = InWords + WORDs[(int)Math.Round(Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)))];
                }
                else if (Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 2)) > 19.0)
                {
                    InWords = InWords + tens[(int)Math.Round(Conversion.Val(Strings.LSet(Conversions.ToString(FIGURE), 1)))];
                    CT1 = Conversions.ToDouble(Strings.Mid(Conversions.ToString(FIGURE), 2));
                    InWords = InWords + WORDs[(int)Math.Round(Conversion.Val(Strings.RSet(Conversions.ToString(CT1), 1)))];
                }
                InWords = InWords + " Paise ";
            }
            FIGURE = RuntimeHelpers.GetObjectValue(AMT);
            FIGURE = Strings.Format(RuntimeHelpers.GetObjectValue(FIGURE), "FIXED");
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(FIGURE)) > 0.0)
            {
                InWords = InWords + " Only.";
            }
            return InWords;
        }


        //public void StockDis(TextBox tx1,TextBox tx2)
        //{
        //    DataTable dt = db.GetTable("SELECT SUM(Qty) AS Qty,COUNT(BookTitle_Id) AS BookTitile from Stock_Book_Title");
        //    if (dt.Rows[0][0] != "")
        //    {
        //        tx1.Text = dt.Rows[0][1].ToString();
        //        tx2.Text = dt.Rows[0][0].ToString();

        //    }
        //    else
        //    {
 
        //    }
        //}

        public DataTable DataSource { get; set; }
    }
}
