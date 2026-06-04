using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class customersForm : UserControl
    {
        public customersForm()
        {
            InitializeComponent();
            displayCustomers();
        }

        public void displayCustomers()
        {
            //customersList cData = new customersList();
            //List<customersList> listData = cData.customersListData();

           // dataGridView1.DataSource = listData;

        }
    }
}
