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
using System.Data.SqlTypes;

namespace IPsec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Кнопка Украина Старт
        private void UKR_Click(object sender, EventArgs e)
        {
            Logfail.Visible = false;
            PassFail.Visible = false;
            labelIPlogin.Visible = false;
            labelIPpassword.Visible = false;
            textBoxIPlogin.Visible = false;
            textBoxIPpassword.Visible = false;
            labelHistory.Visible = false;
            buttonHistory.Visible = false;
            buttonCopy.Visible = false;
            toolTip1.Active = false;
            BtnUpHist.Visible = false;


            if (LogintextBox.Text != "" && PasswordtextBox.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=SashaPC\SQLExpress;Initial Catalog=IPsec;User ID=IPUser;Password=matador99");

                try
                {
                    con.Open();

                }
                catch
                {
                    MessageBox.Show(@"Ошибка соединения");
                }
                string sqlEnter = "EXECUTE [dbo].[GetUser] @LoginName='" + LogintextBox.Text + "' ,@Password='" + PasswordtextBox.Text + "'";
                SqlCommand cmdEnter = new SqlCommand(sqlEnter, con);
                SqlDataReader drEnter = cmdEnter.ExecuteReader();
                if (drEnter.Read())
                {
                    int UID = drEnter.GetInt32(0);
                    int PersonID = drEnter.GetInt32(2);
                    string Location = "UKR";
                    labelConnect.Text = drEnter[1].ToString();
                    labelUser.Visible = true;
                    labelConnect.Visible = true;
                    BtnUpHist.Visible = true;
                    LogintextBox.Enabled = false; //Login textbox is blocked
                    drEnter.Close();
                    string sqlGetIP = "EXEC [dbo].[GetIP] @UID =" + UID + ", @Location=" + Location;
                    SqlCommand cmdGetIP = new SqlCommand(sqlGetIP, con);
                    SqlDataReader drGetIP = cmdGetIP.ExecuteReader();
                    if (drGetIP.Read())
                    {
                        IPtextBox.Text = drGetIP[0].ToString();
                        buttonCopy.Visible = true;
                        IPtextBox.ForeColor = System.Drawing.Color.Black;
                        if (drGetIP[1].ToString() != "XNULLX") //Показ логина\пароля, если он существует
                        {
                            labelIPlogin.Visible = true;
                            textBoxIPlogin.Visible = true;
                            textBoxIPlogin.Text = drGetIP[1].ToString();
                            labelIPpassword.Visible = true;
                            textBoxIPpassword.Visible = true;
                            textBoxIPpassword.Text = drGetIP[2].ToString();
                        }
                        if (drGetIP[0].ToString() == "Нет свободных адресов")
                        {
                            BtnUpHist.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Нет данных соответствующих условию");
                        BtnUpHist.Visible = false;
                    }
                    int PersonRoleID = 2;//ID пользователя для просмотра истории
                    if (PersonID <= PersonRoleID)
                    {
                        labelHistory.Visible = true;
                        buttonHistory.Visible = true;
                        toolTip1.Active = true;
                    }
                }
                else
                {
                    MessageBox.Show(@"Login\Password введён неверно");
                    LogintextBox.Text = "";
                    PasswordtextBox.Text = "";
                    Logfail.Visible = true;
                    PassFail.Visible = true;
                    labelUser.Visible = false;
                    labelConnect.Visible = false;
                    IPtextBox.Text = "";
                    labelHistory.Visible = false;
                    buttonHistory.Visible = false;

                }
                con.Close();

            }
            else
            {
                MessageBox.Show(@"Не заполнено поле Login\Password");

                Logfail.Visible = true;
                PassFail.Visible = true;
                labelUser.Visible = false;
                labelConnect.Visible = false;
                IPtextBox.Text = "";
                labelHistory.Visible = false;
                buttonHistory.Visible = false;
            }

        }

        //Кнопка Украина Финиш
        //  *******      
        //  *******
        //Кнопка Россия Старт
        private void RUS_Click(object sender, EventArgs e)
        {
            Logfail.Visible = false;
            PassFail.Visible = false;
            labelIPlogin.Visible = false;
            labelIPpassword.Visible = false;
            textBoxIPlogin.Visible = false;
            textBoxIPpassword.Visible = false;
            buttonCopy.Visible = false;
            toolTip1.Active = false;
            BtnUpHist.Visible = false;

            if (LogintextBox.Text != "" && PasswordtextBox.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=SashaPC\SQLExpress;Initial Catalog=IPsec;User ID=IPUser;Password=matador99");
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show(@"Ошибка соединения");
                }
                string sqlEnter = "EXECUTE [dbo].[GetUser] @LoginName='" + LogintextBox.Text + "' ,@Password='" + PasswordtextBox.Text + "'";
                SqlCommand cmdEnter = new SqlCommand(sqlEnter, con);
                SqlDataReader drEnter = cmdEnter.ExecuteReader();
                if (drEnter.Read())
                {
                    int UID = drEnter.GetInt32(0);
                    int PersonID = drEnter.GetInt32(2);
                    string Location = "RUS";
                    labelConnect.Text = drEnter[1].ToString();
                    labelUser.Visible = true;
                    labelConnect.Visible = true;
                    BtnUpHist.Visible = true;
                    LogintextBox.Enabled = false; //Login textbox is blocked
                    drEnter.Close();
                    string sqlGetIP = "EXEC [dbo].[GetIP] @UID =" + UID + ", @Location=" + Location;
                    SqlCommand cmdGetIP = new SqlCommand(sqlGetIP, con);
                    SqlDataReader drGetIP = cmdGetIP.ExecuteReader();
                    if (drGetIP.Read())
                    {
                        IPtextBox.Text = drGetIP[0].ToString();
                        buttonCopy.Visible = true;
                        IPtextBox.ForeColor = System.Drawing.Color.Black;
                        if (drGetIP[1].ToString() != "XNULLX")
                        {
                            labelIPlogin.Visible = true;
                            textBoxIPlogin.Visible = true;
                            textBoxIPlogin.Text = drGetIP[1].ToString();
                            labelIPpassword.Visible = true;
                            textBoxIPpassword.Visible = true;
                            textBoxIPpassword.Text = drGetIP[2].ToString();
                        }
                        if (drGetIP[0].ToString() == "Нет свободных адресов")
                        {
                            BtnUpHist.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Нет данных соответствующих условию");
                        BtnUpHist.Visible = false;
                    }

                    int PersonRoleID = 2;//ID пользователя для просмотра истории
                    if (PersonID <= PersonRoleID)
                    {
                        labelHistory.Visible = true;
                        buttonHistory.Visible = true;
                        toolTip1.Active = true;
                    }
                }
                else
                {
                    MessageBox.Show(@"Login\Password введён неверно");
                    LogintextBox.Text = "";
                    PasswordtextBox.Text = "";
                    Logfail.Visible = true;
                    PassFail.Visible = true;
                    labelUser.Visible = false;
                    labelConnect.Visible = false;
                    IPtextBox.Text = "";
                    labelHistory.Visible = false;
                    buttonHistory.Visible = false;

                }
                con.Close();

            }
            else
            {
                MessageBox.Show(@"Не заполнено поле Login\Password");

                Logfail.Visible = true;
                PassFail.Visible = true;
                labelUser.Visible = false;
                labelConnect.Visible = false;
                IPtextBox.Text = "";
                labelHistory.Visible = false;
                buttonHistory.Visible = false;
            }

        }
        //Кнопка Россия Финиш
        //  *******      
        //  *******
        //Кнопка США Старт
        private void USA_Click(object sender, EventArgs e)
        {
            Logfail.Visible = false;
            PassFail.Visible = false;
            labelIPlogin.Visible = false;
            labelIPpassword.Visible = false;
            textBoxIPlogin.Visible = false;
            textBoxIPpassword.Visible = false;
            buttonCopy.Visible = false;
            toolTip1.Active = false;
            BtnUpHist.Visible = false;

            if (LogintextBox.Text != "" && PasswordtextBox.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=SashaPC\SQLExpress;Initial Catalog=IPsec;User ID=IPUser;Password=matador99");
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show(@"Ошибка соединения");
                }
                string sqlEnter = "EXECUTE [dbo].[GetUser] @LoginName='" + LogintextBox.Text + "' ,@Password='" + PasswordtextBox.Text + "'";
                SqlCommand cmdEnter = new SqlCommand(sqlEnter, con);
                SqlDataReader drEnter = cmdEnter.ExecuteReader();
                if (drEnter.Read())
                {
                    int UID = drEnter.GetInt32(0);
                    int PersonID = drEnter.GetInt32(2);
                    string Location = "USA";
                    labelConnect.Text = drEnter[1].ToString();
                    labelUser.Visible = true;
                    labelConnect.Visible = true;
                    BtnUpHist.Visible = true;
                    LogintextBox.Enabled = false; //Login textbox is blocked
                    drEnter.Close();
                    string sqlGetIP = "EXEC [dbo].[GetIP] @UID =" + UID + ", @Location=" + Location;
                    SqlCommand cmdGetIP = new SqlCommand(sqlGetIP, con);
                    SqlDataReader drGetIP = cmdGetIP.ExecuteReader();
                    if (drGetIP.Read())
                    {
                        IPtextBox.Text = drGetIP[0].ToString();
                        buttonCopy.Visible = true;
                        IPtextBox.ForeColor = System.Drawing.Color.Black;
                        if (drGetIP[1].ToString() != "XNULLX")
                        {
                            labelIPlogin.Visible = true;
                            textBoxIPlogin.Visible = true;
                            textBoxIPlogin.Text = drGetIP[1].ToString();
                            labelIPpassword.Visible = true;
                            textBoxIPpassword.Visible = true;
                            textBoxIPpassword.Text = drGetIP[2].ToString();
                        }
                        if (drGetIP[0].ToString() == "Нет свободных адресов")
                        {
                            BtnUpHist.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Нет данных соответствующих условию");
                        BtnUpHist.Visible = false;
                    }
                    int PersonRoleID = 2;//ID пользователя для просмотра истории
                    if (PersonID <= PersonRoleID)
                    {
                        labelHistory.Visible = true;
                        buttonHistory.Visible = true;
                        toolTip1.Active = true;
                    }
                }
                else
                {
                    MessageBox.Show(@"Login\Password введён неверно");
                    LogintextBox.Text = "";
                    PasswordtextBox.Text = "";
                    Logfail.Visible = true;
                    PassFail.Visible = true;
                    labelUser.Visible = false;
                    labelConnect.Visible = false;
                    IPtextBox.Text = "";
                    labelHistory.Visible = false;
                    buttonHistory.Visible = false;

                }
                con.Close();

            }
            else
            {
                MessageBox.Show(@"Не заполнено поле Login\Password");

                Logfail.Visible = true;
                PassFail.Visible = true;
                labelUser.Visible = false;
                labelConnect.Visible = false;
                IPtextBox.Text = "";
                labelHistory.Visible = false;
                buttonHistory.Visible = false;
            }

        }
        //Кнопка США Финиш
        //  *******      
        //  *******
        //Кнопка Европа Старт
        private void EUR_Click(object sender, EventArgs e)
        {
            Logfail.Visible = false;
            PassFail.Visible = false;
            labelIPlogin.Visible = false;
            labelIPpassword.Visible = false;
            textBoxIPlogin.Visible = false;
            textBoxIPpassword.Visible = false;
            buttonCopy.Visible = false;
            toolTip1.Active = false;
            BtnUpHist.Visible = false;

            if (LogintextBox.Text != "" && PasswordtextBox.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=SashaPC\SQLExpress;Initial Catalog=IPsec;User ID=IPUser;Password=matador99");
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show(@"Ошибка соединения");
                }
                string sqlEnter = "EXECUTE [dbo].[GetUser] @LoginName='" + LogintextBox.Text + "' ,@Password='" + PasswordtextBox.Text + "'";
                SqlCommand cmdEnter = new SqlCommand(sqlEnter, con);
                SqlDataReader drEnter = cmdEnter.ExecuteReader();
                if (drEnter.Read())
                {
                    int UID = drEnter.GetInt32(0);
                    int PersonID = drEnter.GetInt32(2);
                    string Location = "EUR";
                    labelConnect.Text = drEnter[1].ToString();
                    labelUser.Visible = true;
                    labelConnect.Visible = true;
                    BtnUpHist.Visible = true;
                    LogintextBox.Enabled = false; //Login textbox is blocked
                    drEnter.Close();
                    string sqlGetIP = "EXEC [dbo].[GetIP] @UID =" + UID + ", @Location=" + Location;
                    SqlCommand cmdGetIP = new SqlCommand(sqlGetIP, con);
                    SqlDataReader drGetIP = cmdGetIP.ExecuteReader();
                    if (drGetIP.Read())
                    {
                        IPtextBox.Text = drGetIP[0].ToString();
                        buttonCopy.Visible = true;
                        IPtextBox.ForeColor = System.Drawing.Color.Black;
                        if (drGetIP[1].ToString() != "XNULLX")
                        {
                            labelIPlogin.Visible = true;
                            textBoxIPlogin.Visible = true;
                            textBoxIPlogin.Text = drGetIP[1].ToString();
                            labelIPpassword.Visible = true;
                            textBoxIPpassword.Visible = true;
                            textBoxIPpassword.Text = drGetIP[2].ToString();
                        }
                        if (drGetIP[0].ToString() == "Нет свободных адресов")
                        {
                            BtnUpHist.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Нет данных соответствующих условию");
                        BtnUpHist.Visible = false;
                    }
                    int PersonRoleID = 2;//ID пользователя для просмотра истории
                    if (PersonID <= PersonRoleID)
                    {
                        labelHistory.Visible = true;
                        buttonHistory.Visible = true;
                        toolTip1.Active = true;
                    }
                }
                else
                {
                    MessageBox.Show(@"Login\Password введён неверно");
                    LogintextBox.Text = "";
                    PasswordtextBox.Text = "";
                    Logfail.Visible = true;
                    PassFail.Visible = true;
                    labelUser.Visible = false;
                    labelConnect.Visible = false;
                    IPtextBox.Text = "";
                    labelHistory.Visible = false;
                    buttonHistory.Visible = false;

                }
                con.Close();

            }
            else
            {
                MessageBox.Show(@"Не заполнено поле Login\Password");

                Logfail.Visible = true;
                PassFail.Visible = true;
                labelUser.Visible = false;
                labelConnect.Visible = false;
                IPtextBox.Text = "";
                labelHistory.Visible = false;
                buttonHistory.Visible = false;
            }

        }
        //Кнопка Европа Финиш
        //  *******      
        //  *******
        //Кнопка История Старт
        private void buttonHistory_Click(object sender, EventArgs e)
        {

            Form2 f3 = new Form2();
            f3.Show();

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(IPtextBox.Text);
            IPtextBox.ForeColor = System.Drawing.Color.LimeGreen;
        }

        private void BtnUpHist_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SashaPC\SQLExpress;Initial Catalog=IPsec;User ID=IPUser;Password=matador99");

            try
            {
                con.Open();

            }
            catch
            {
                MessageBox.Show(@"Ошибка соединения");
            }

            string Hist = string.Empty;
            string Adress = @"C:\Users\" + LogintextBox.Text + @"\AppData\Roaming\Mozilla\Firefox\Profiles\kpe8hvti.default\sessionstore-backups\recovery.js";
            using (System.IO.StreamReader reader = System.IO.File.OpenText(Adress))
            {
                Hist = reader.ReadToEnd();
            }
            Hist = Hist.Replace("url", "\n");
            

            
/*
            string WriteHist = "INSERT INTO [dbo].[BrowserHistory] ([id],[UserID],[Sites]) VALUES (1, 1,'" + Hist + "')";
            SqlCommand cmdWriteHist = new SqlCommand(WriteHist, con);
            // cmdWriteHist.ExecuteNonQuery();
*/
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\tEST\test.txt"))
            {
                file.Write(Hist);
            }








        }
    }
}
