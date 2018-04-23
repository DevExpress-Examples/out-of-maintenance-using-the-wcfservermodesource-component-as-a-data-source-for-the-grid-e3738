using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WcfServerModeSourceDemo.ServiceReference1;
using DevExpress.Data.WcfLinq;

namespace WcfServerModeSourceDemo
{
    public partial class Form1 : Form
    {
        AdventureWorksEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new AdventureWorksEntities(new Uri("http://localhost:61617/WcfDataService1.svc"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = new WcfServerModeSource()
            {
                KeyExpression = "EmployeeID",
                Query = db.Employee
            };
        }
    }
}
