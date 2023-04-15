using Microsoft.VisualBasic;
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

namespace RiskyBusiness.Forms
{
    public partial class addBusiness : Form
    {
        public addBusiness()
        {
            InitializeComponent();
            ClearData();
        }
        private void ClearData()
        {
            NameCompany.Text = string.Empty;
            IntangibleAssets.Text = string.Empty;
            Stocks.Text = string.Empty;
            FixedAssets.Text = string.Empty;
            NDS.Text = string.Empty;
            Dbet.Text = string.Empty;
            FinancialInvestments.Text = string.Empty;
            OtherActive.Text = string.Empty;
            Loan.Text = string.Empty;
            Credit.Text = string.Empty;
            income.Text = string.Empty;
            MarksCommitment.Text = string.Empty;
            FinancialInvestmentsMain.Text = string.Empty;
            Dolg.Text = string.Empty;
            moneyAndEcvi.Text = string.Empty;
        }
        DBConnect dBConnect = new DBConnect();

        private string nameCompany = string.Empty;
        private decimal _IntangibleAssets = 0;
        private decimal _Stocks = 0;
        private decimal _FixedAssets = 0;
        private decimal _NDS = 0;
        private decimal _Dbet = 0;
        private decimal _FinancialInvestments = 0;
        private decimal _OtherActive = 0;
        private decimal _Loan = 0;
        private decimal _Credit = 0;
        private decimal _income = 0;
        private decimal _MarksCommitment = 0;
        private decimal _FinancialInvestmentsMain = 0;
        private decimal _Dolg = 0;
        private decimal _moneyAndEcvi = 0;


        //Коэф. тек. ликвид.
        private decimal ktl = 0;
        //Коэффициент быстрой ликвидности
        private decimal kbl = 0;
        //Коэффициент абсолютной ликвидности
        private decimal kal = 0;

        //Занести данные в базу данных
        private void PutInData_Click(object sender, EventArgs e)
        {

            try
            {
                //Имя предприятия
                if (NameCompany.Text != string.Empty)
                {
                    nameCompany = NameCompany.Text;
                }
                else
                {
                    throw new Exception();
                }
                //Нематериальные активы
                _IntangibleAssets = Convert.ToDecimal(IntangibleAssets.Text);
                //Запасы
                _Stocks = Convert.ToDecimal(Stocks.Text);
                //Основые средства
                _FixedAssets = Convert.ToDecimal(FixedAssets.Text);
                //НДС
                _NDS = Convert.ToDecimal(NDS.Text);
                //Дебетовая задолжность
                _Dbet = Convert.ToDecimal(Dbet.Text);
                //Фин. вложения без учета
                _FinancialInvestments = Convert.ToDecimal(FinancialInvestments.Text);
                //Другие активы
                _OtherActive = Convert.ToDecimal(OtherActive.Text);
                //Займы
                _Loan = Convert.ToDecimal(Loan.Text);
                //Кредитная задолжность
                _Credit = Convert.ToDecimal(Credit.Text);
                //Доходы
                _income = Convert.ToDecimal(income.Text);
                //Оценочные обязательства
                _MarksCommitment = Convert.ToDecimal(MarksCommitment.Text);
                //Фин. вложения
                _FinancialInvestmentsMain = Convert.ToDecimal(FinancialInvestmentsMain.Text);
                //Денюж обяз
                _Dolg = Convert.ToDecimal(Dolg.Text);
                //Денюж средства и обяз
                _moneyAndEcvi = Convert.ToDecimal(moneyAndEcvi.Text);

                ktl = (ResultSecondStep() + _FinancialInvestments) / (ResultThirdStep() - _income - _MarksCommitment);
                kbl = (_FinancialInvestmentsMain + _moneyAndEcvi + _OtherActive) / (ResultThirdStep() - _income - _MarksCommitment);
                kal = (_FinancialInvestmentsMain + _Loan) / (ResultThirdStep() - _income - _MarksCommitment);

                query();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода днных. ");
            }
        }
        private void query()
        {
            string queryOne = $"INSERT INTO publics.\"Obligations\" (\"Loan\", \"Credit\", \"Income\", \"MarksCommitment\", \"SumThree\") VALUES ('{_Loan}', '{_Credit}', '{_income}', '{_MarksCommitment}', '{ResultThirdStep()}') RETURNING id;";
            NpgsqlDataReader one = dBConnect.connection(queryOne);
            int idOne = 0;
            while (one.Read())
            {
                idOne = one.GetInt32(0);
            }
            string queryTwo = $"INSERT INTO publics.\"CurrentAssets\" (\"Stocks\", \"NDS\", \"Debet\", \"Financial\", \"Other\", \"Obligations\", \"SumTwo\", \"id_obl\") VALUES ('{_Stocks}', '{_NDS}', '{_Dbet}', '{_FinancialInvestments}', '{_OtherActive}', '{_Dolg}', '{ResultSecondStep()}', '{idOne}') RETURNING id;";
            NpgsqlDataReader two = dBConnect.connection(queryTwo);
            int idTwo = 0;
            while (two.Read())
            {
                idTwo = two.GetInt32(0);
            }
            string queryThree = $"INSERT INTO publics.\"Non-currentAssets\" (\"IntangibleAssets\", \"FixedAssets\", \"FinancialInvestments\", \"SumOne\", \"id_Cur\") VALUES ('{_IntangibleAssets}', '{_FixedAssets}', '{_FinancialInvestments}', '{ResultFirstStep()}', '{idTwo}') RETURNING id;";
            NpgsqlDataReader three = dBConnect.connection(queryThree);
            int idThree = 0;
            while (three.Read())
            {
                idThree = three.GetInt32(0);
            }
            string queryFourth = $"INSERT INTO publics.\"NameOfCompany\" (\"NameCompany\", \"id_Cur\", \"id_Non\", \"id_obl\", \"KTL\", \"KBL\", \"KAL\") VALUES ('{nameCompany}', '{idTwo}', '{idThree}', '{idOne}', '{ktl}','{kbl}','{kal}');";
            dBConnect.connection(queryFourth);
            MessageBox.Show("Данные успешно занесены в базу данных");
        }

        //Итоги периудов подсчёта
        private decimal ResultFirstStep()
        {
            return _IntangibleAssets + _FixedAssets + _FinancialInvestments;
        }
        private decimal ResultSecondStep()
        {
            return _Stocks + _NDS + _Dbet + _FinancialInvestmentsMain + _moneyAndEcvi + _OtherActive;
        }
        private decimal ResultThirdStep()
        {
            return _Loan + _Credit + _income + _MarksCommitment;
        }



        //Очистить данные для ввода
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
