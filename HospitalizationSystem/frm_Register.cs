using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalizationSystem
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void button_enroll_Click(object sender, EventArgs e)
        {
            if (this.txt_No.Text.Trim() == "")                                                      //若用户号文本框为空；
            {
                MessageBox.Show("用户号不能为空！");														//给出错误提示；
                this.txt_No.Focus();                                                                //用户号文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txt_Password.Text.Trim() == "")                                                    //若密码文本框为空；
            {
                MessageBox.Show("密码不能为空！");														//给出错误提示；
                this.txt_Password.Focus();                                                              //密码文本框获得焦点；
                return;                                                                                 //返回；
            }
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=Hospitalization;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                "INSERT tb_User (No,Password) VALUES(@No,@Password);";                 //指定SQL命令的命令文本；命令文本包含参数；
            sqlCommand.Parameters.AddWithValue("@No", this.txt_No.Text.Trim());                     //向SQL命令的参数集合添加参数的名称、值；
            sqlCommand.Parameters.AddWithValue("@Password", this.txt_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                           //将密码参数的类型设为变长字符串；
                                                                                                        //SQL参数自动识别类型；若参数值为字符串，则类型自动设为NVARCHAR，且可在执行时自动转换；但对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            sqlConnection.Open();                                                                       //打开SQL连接；
            int rowAffected = sqlCommand.ExecuteNonQuery();                                             //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            sqlConnection.Close();                                                                      //关闭SQL连接；
            if (rowAffected == 1)                                                                       //若成功写入1行记录；
            {
                MessageBox.Show("注册成功。");															//给出正确提示；
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("注册失败！");															//给出错误提示；
            }
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {

        }

        private void txt_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            frm_login form = new frm_login();
            this.Hide();
            form.ShowDialog();
        }
    }
}
