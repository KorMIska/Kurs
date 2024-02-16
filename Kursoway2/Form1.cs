using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Button = System.Windows.Forms.Button;

namespace Kursoway2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static DataSet ds;
        public Conector conector = new Conector();

        public string curent_table;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void updata(string com)
        {
            dataGridView1.Columns[0].Visible = false;
            curent_table = com;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ALL");
            comboBox1.SelectedIndex = 0;
        }
        public class Conector
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\яяяяяяяя\Desktop\SAASZ\C#\Kur_5_Semestr\Kursoway2\Database1.mdf;Integrated Security=True";

            public SqlDataAdapter adapter;
            public string nameTable;
            public string reqvest_sql;

            public void Updata(string curent_table)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = reqvest_sql;
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                }
            }

            public List<string> Reqwest(string query)
            {
                List<string> strings = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        strings.Add(reader.GetString(0).ToString());
                    }
                }


                return strings;

            }
            public void Conect(string reqvest_sql, DataGridView dataView)
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    this.reqvest_sql = reqvest_sql;
                    connection.Open();
                    adapter = new SqlDataAdapter(reqvest_sql, connection);

                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataView.DataSource = ds.Tables[0];
                }
            }
            public Conector()
            {
            }
        }


        string[] NameTables = {
            "Account",
            "Bank",
            "Bank_Operations",
            "Client",
            "Currency",
            "Deposit",
            "Internet_Banking",
            "Payment_Card"
        };
        public Dictionary<string, string> db_unic_combo = new Dictionary<string, string>()
        {
            ["Client"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Bank"] = "SELECT DISTINCT  Bank_Name  FROM Bank",
            ["Account"] = "SELECT DISTINCT Client_Name FROM Client",
            ["Deposit"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Internet_Banking"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Payment_Card"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Bank_Operations"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Currency"] = "SELECT DISTINCT Client_Name FROM Client",

        };
        public Dictionary<string, string> db_disting_combo = new Dictionary<string, string>()
        {
            ["Account"] = "SELECT DISTINCT Client_Name FROM Client",
            ["Deposit"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Internet_Banking"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Payment_Card"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Bank_Operations1"] = "SELECT DISTINCT  Client_Name FROM Client",
            ["Bank_Operations2"] = "SELECT DISTINCT  Bank_Name FROM Bank",
            ["Currency1"] = "SELECT DISTINCT Client_Name FROM Client",
            ["Currency2"] = "SELECT DISTINCT  Bank_Name FROM Bank"
        };
        public Dictionary<string, string> db_ad_combo = new Dictionary<string, string>()
        {
            ["Client"] = "INSERT INTO Client (Client_ID) SELECT COALESCE(MAX(Client_ID), 0) + 1 FROM Client",
            ["Bank"] = "INSERT INTO Bank (Bank_ID) SELECT COALESCE(MAX(Bank_ID), 0) + 1 FROM Bank",
            ["Account"] = "INSERT INTO Account (Account_ID, Client_ID) VALUES (COALESCE((SELECT MAX(Account_ID) FROM Account), 0) + 1 ," +
            " (SELECT Client_ID FROM Client WHERE Client_Name = '{0}')) ",

            ["Deposit"] = "INSERT INTO Deposit (Deposit_ID, Client_ID) VALUES (COALESCE((SELECT MAX(Deposit_ID) FROM Deposit), 0) + 1 ," +
            "(SELECT Client_ID FROM Client WHERE Client_Name = '{0}'))",
            ["Internet_Banking"] = "INSERT INTO Internet_Banking(Internet_Banking_ID, Client_ID)" +
            "VALUES(COALESCE((SELECT MAX(Internet_Banking_ID) FROM Internet_Banking), 0) + 1," + 
            "(SELECT Client_ID FROM Client WHERE Client_Name = '{0}'))",
            ["Payment_Card"] = "INSERT INTO Payment_Card(Card_ID, Client_ID)" +
            "VALUES(COALESCE((SELECT MAX(Card_ID) FROM Payment_Card), 0) + 1," +
            "(SELECT Client_ID FROM Client WHERE Client_Name = '{0}'))",
            ["Bank_Operations"] = "INSERT INTO Bank_Operations(Operation_ID, Client_ID, Bank_ID) VALUES " +
            "(COALESCE((SELECT MAX(Operation_ID) FROM Bank_Operations), 0) + 1, " +
            "(SELECT Client_ID FROM Client WHERE Client_Name = '{0}'), " +
            "(SELECT Bank_ID FROM Bank WHERE Bank_Name = '{1}'))",
            ["Currency"] = "INSERT INTO Currency (Currency_ID, Client_ID, Bank_ID) VALUES " +
            "(COALESCE((SELECT MAX(Currency_ID) FROM Currency), 0) + 1, " +
            "(SELECT Client_ID FROM Client WHERE Client_Name = '{0}'), " +
            "(SELECT Bank_ID FROM Bank WHERE Bank_Name = '{1}'))"
    };
        public Dictionary<string, string> db_sql_for_serch_table = new Dictionary<string, string>()
        {
            ["Client"] = "SELECT *  FROM Client WHERE Client_Name = '{0}'",
            ["Bank"] = "SELECT *  FROM Bank WHERE Bank_Name = '{0}'",
            ["Account"] = "SELECT  Account.Account_ID, Account.Account_Number, Account.Account_Balance FROM Account " +
            "JOIN Client ON Account.Client_ID = Client.Client_ID WHERE Client_Name = '{0}'",
            ["Deposit"] = "SELECT  Deposit_ID , Deposit_Type ,Interest_Rate ,Deposit_Term FROM Deposit" +
            " JOIN Client ON Deposit.Client_ID = Client.Client_ID WHERE Client_Name = '{0}'",
            ["Internet_Banking"] = "SELECT  Internet_Banking_ID , Login, Password, Available_Operations FROM Internet_Banking " +
            "JOIN Client ON Internet_Banking.Client_ID = Client.Client_ID WHERE Client_Name = '{0}'",
            ["Payment_Card"] = "SELECT Card_ID , Card_Number, Card_Type FROM Payment_Card " +
            "JOIN Client ON Payment_Card.Client_ID = Client.Client_ID  WHERE Client_Name = '{0}'",
            ["Bank_Operations"] = "SELECT  Operation_ID,Operation_Type,Operation_Amount ,Operation_Date  FROM Bank_Operations" +
            " JOIN Client ON Bank_Operations.Client_ID = Client.Client_ID  WHERE Client_Name = '{0}'",
            ["Currency"] = "SELECT  * FROM Currency JOIN Client ON Currency.Client_ID = Client.Client_ID  WHERE Client_Name = '{0}'",
        };
        public static Dictionary<string, string> db_sql_recvests = new Dictionary<string, string>()
        {
            ["Client"] = "SELECT *  FROM Client",
            ["Bank"] = "SELECT *  FROM Bank",
            ["Account"] = "SELECT  Account.Account_ID, Account.Account_Number, Account.Account_Balance FROM Account",
            ["Deposit"]       = "SELECT Deposit_ID , Deposit_Type ,Interest_Rate ,Deposit_Term FROM Deposit;",
            ["Internet_Banking"]          = "SELECT  Internet_Banking_ID , Login, Password, Available_Operations FROM Internet_Banking",
            ["Payment_Card"] = "SELECT  Card_ID , Card_Number, Card_Type FROM Payment_Card",
            ["Bank_Operations"]         = "SELECT Operation_ID,Operation_Type,Operation_Amount ,Operation_Date  FROM Bank_Operations",
            ["Currency"]        = "SELECT Currency_ID , Currency_Name FROM Currency",

        };

        public void SplitContainerUpdate(string comand)
        {
            
            conector.Conect(db_sql_recvests[comand], dataGridView1);
            updata(comand);
            FiilCombobox(db_unic_combo[comand], comboBox1);
        }
        public void FiilCombobox(string qwest , System.Windows.Forms.ComboBox comboBox1)
        {
           var itm = conector.Reqwest(qwest);
           foreach(string indexer in itm)
           {
                comboBox1.Items.Add(indexer);
           }
        }

        public void serch(object comand)
        {
            conector.Conect(string.Format(db_sql_for_serch_table[curent_table], comand), dataGridView1);
        }


        private void button9_Click(object sender, EventArgs e)
        {

            Button CLOS = new Button
            {
                Location = new Point(35, 100),
                Text = "OK",

            };

            if (curent_table == "Client" || curent_table == "Bank")
            { 
              conector.Reqwest(db_ad_combo[curent_table]);
              conector.Conect(db_sql_recvests[curent_table], dataGridView1); 
            }
            else
            if (curent_table == "Currency" || curent_table == "Bank_Operations")
            {
                var form = new Form
                {
                    Text = "Добавление записей",
                    Size = new Size(200, 200),
                    StartPosition = FormStartPosition.CenterScreen
                };

                System.Windows.Forms.ComboBox combo1 = new System.Windows.Forms.ComboBox();
                combo1.Location = new Point(35, 50);

                System.Windows.Forms.ComboBox combo2 = new System.Windows.Forms.ComboBox();
                combo2.Location = new Point(35, 25);

                var itm1 = conector.Reqwest(db_disting_combo[curent_table+1]);
                var itm2 = conector.Reqwest(db_disting_combo[curent_table+2]);

                foreach (string indexer in itm1)
                {
                    combo1.Items.Add(indexer);
                }
                combo1.SelectedIndex = 0;
                form.Controls.Add(combo1);

                foreach (string indexer in itm2)
                {
                    combo2.Items.Add(indexer);
                }
                combo2.SelectedIndex = 0;
                form.Controls.Add(combo2);
                form.Controls.Add(CLOS);
                CLOS.Click += (s, r) =>
                {
                    form.Close();
                };

                form.ShowDialog();

                conector.Reqwest(string.Format(db_ad_combo[curent_table], combo1.Items[combo1.SelectedIndex], combo2.Items[combo2.SelectedIndex]));
                conector.Conect(db_sql_recvests[curent_table], dataGridView1);

            }
            else
            {
                var form = new Form
                {
                    Text = "Добавление записей",
                    Size = new Size(200, 200),
                    StartPosition = FormStartPosition.CenterScreen
                };

                System.Windows.Forms.ComboBox combo = new System.Windows.Forms.ComboBox();
                combo.Location = new Point(35, 50);

                var itm = conector.Reqwest(db_disting_combo[curent_table]);


                foreach (string indexer in itm)
                {
                    combo.Items.Add(indexer);
                }
                combo.SelectedIndex = 0;
                form.Controls.Add(combo);
                form.Controls.Add(CLOS);
                CLOS.Click += (s, r) =>
                {
                    form.Close();
                };

                form.ShowDialog();

                conector.Reqwest(string.Format(db_ad_combo[curent_table], combo.Items[combo.SelectedIndex]));
                conector.Conect(db_sql_recvests[curent_table], dataGridView1);



            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                serch(comboBox1.Items[comboBox1.SelectedIndex]);
            }
            else
                conector.Conect(db_sql_recvests[curent_table], dataGridView1);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            conector.Updata(curent_table);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SplitContainerUpdate(NameTables[comboBox2.SelectedIndex]);
        }
    }
}
