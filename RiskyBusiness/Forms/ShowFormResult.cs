using Npgsql;
using RiskyBusiness.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RiskyBusiness.Forms
{
    public partial class ShowFormResult : Form
    {
        DBConnect dBConnect;
        private string queryCompany = "SELECT publics.\"NameOfCompany\".\"NameCompany\" FROM publics.\"NameOfCompany\";";


        public ShowFormResult()
        {

            InitializeComponent();
            displayNameCompany();
            dataGridView1.RowHeadersVisible = false;

        }
        // comboBox2.Items.Add(data.GetValue(0).ToString() + "%");

        private void displayNameCompany()
        {
            try
            {
                dBConnect = new DBConnect();
                NpgsqlDataReader result = dBConnect.connection(queryCompany);
                while (result.Read())
                {
                    comboBox1.Items.Add(result.GetValue(0).ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нет записей для расчета");
            }
            


        }


        private void ShowFormResult_Load(object sender, EventArgs e)
        {

        }


        //Рассчёт
        private void button1_Click(object sender, EventArgs e)
        {
            string TexTick = comboBox1.Text.ToString();
            string query = $"SELECT \"NameOfCompany\".\"NameCompany\"," +
            $" publics.\"NameOfCompany\".\"KTL\", publics.\"NameOfCompany\".\"KBL\"," +
            $"\r\npublics.\"NameOfCompany\".\"KAL\", publics.\"Non-currentAssets\".\"IntangibleAssets\"," +
            $"\r\npublics.\"Non-currentAssets\".\"FixedAssets\", " +
            $"publics.\"Non-currentAssets\".\"FinancialInvestments\"," +
            $"\r\npublics.\"Non-currentAssets\".\"SumOne\", publics.\"CurrentAssets\".\"Stocks\", " +
            $"publics.\"CurrentAssets\".\"NDS\",\r\npublics.\"CurrentAssets\".\"Debet\", " +
            $"publics.\"CurrentAssets\".\"Financial\", publics.\"CurrentAssets\".\"Other\", " +
            $"\r\npublics.\"CurrentAssets\".\"Obligations\", publics.\"CurrentAssets\".\"SumTwo\", " +
            $"publics.\"Obligations\".\"Loan\", \r\npublics.\"Obligations\".\"Credit\"," +
            $" publics.\"Obligations\".\"Income\", publics.\"Obligations\".\"MarksCommitment\"," +
            $"\r\npublics.\"Obligations\".\"SumThree\" FROM publics.\"NameOfCompany\" \r\n" +
            $"JOIN publics.\"Non-currentAssets\" ON publics.\"NameOfCompany\".\"id_Non\" = publics.\"Non-currentAssets\".\"id\"\r\n" +
            $"JOIN publics.\"CurrentAssets\" ON publics.\"NameOfCompany\".\"id_Cur\" = publics.\"CurrentAssets\".\"id\"\r\n" +
            $"JOIN publics.\"Obligations\" ON publics.\"NameOfCompany\".\"id_obl\" = publics.\"Obligations\".\"id\"\r\n" +
            $"WHERE \"NameOfCompany\".\"NameCompany\" = '{TexTick}'";
            try
            {
                decimal ktl = 0;
                decimal kbl = 0;
                decimal kal = 0;

                dBConnect = new DBConnect();
                NpgsqlDataReader result = dBConnect.connection(query);
                List<string[]> data = new List<string[]>();
                while (result.Read())
                {
                    data.Add(new string[20]);
                    for (int i = 0; i < 20; i++)
                    {
                        data[data.Count - 1][i] = result[i].ToString();


                    }
                    ktl = (decimal)result.GetValue(1);
                    kbl = (decimal)result.GetValue(2);
                    kal = (decimal)result.GetValue(3);
                }

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

                result.Close();

                //КТЛ
                if (ktl <= 1)
                {
                    richTextBox1.Text = "Исходя из коэффициента текущей ликвидности: Предприятие находится в высоком финансовом риске, и не в состоянии оплачивать стабильно текущее счета";
                }
                else if (ktl > 1 && ktl <= 2.5m)
                {
                    richTextBox1.Text = "Исходя из коэффициента текущей ликвидности: Предприятие находится в стабильном состоянии, есть возможность оплачивать стабильно текущее счета";
                }
                else if (ktl > 2.5m)
                {
                    richTextBox1.Text = "Исходя из коэффициента текущей ликвидности: Предприятие находится в низком финансовом состоянии, есть возможность оплачивать стабильно текущее счета";
                }


                //КБЛ
                if (kbl < 0.7m)
                {
                    richTextBox1.Text += "\r\n" +
                        "Исходя из коэффициента быстрой ликвидности: Предприятие находится в высоком финансовом риске, и не в состоянии оплачивать стабильно текущее счета";
                }
                else if (kbl > 0.7m)
                {
                    richTextBox1.Text += "\r\n" +
                        "Исходя из коэффициента быстрой ликвидности: Компания не способна погасить свои текущие обязательства краткосрочными активами";
                }

                //КБЛ
                if (kal < 0.2m)
                {
                    richTextBox1.Text += "\r\n" +
                        "Исходя из коэффициента абсолютной быстрой ликвидности: Предприятие находится в высоком финансовом риске, и не в состоянии покрыть краткосрочные долговые обязательства";
                }
                else if (kal > 0.2m && kal < 0.5m)
                {
                    richTextBox1.Text += "\r\n" +
                        "Исходя из коэффициента абсолютной быстрой ликвидности: Предприятие находится в стабильном финансовом состоянии, и способно покрыть краткосрочные долговые обязательства";
                }
                else if (kal > 0.5m)
                {
                    richTextBox1.Text += "\r\n" +
                        "Исходя из коэффициента абсолютной быстрой ликвидности: У предприятия неоправданно высокий объем свободных денежных средств, которые можно было бы использовать для развития бизнеса.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете компанию для расчёта");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
