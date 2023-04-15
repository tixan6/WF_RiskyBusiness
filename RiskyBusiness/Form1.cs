using RiskyBusiness.Forms;
using System.Windows.Forms;

namespace RiskyBusiness
{
    public partial class Form1 : Form
    {
        private Form form;
        public Form1()
        {
            InitializeComponent();
        }

        //���������� ����������
        private void button2_Click(object sender, EventArgs e)
        {
            showBank(new addBusiness());
        }

        //��������
        private void button1_Click(object sender, EventArgs e)
        {
            showBank(new ShowFormResult());
        }

        private void showBank(Form fm)
        {
            if (form != null)
                form.Close();
            form = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.PlaceForForms.Controls.Add(fm);
            this.PlaceForForms.Tag = fm;
            fm.BringToFront();
            form.Show();
        }


    }
}