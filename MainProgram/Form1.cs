using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using CommonEntities;

namespace MainProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BusinessLogicLayerManager bLLMngr;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDbType.SelectedIndex = 0;
            bLLMngr = new BusinessLogicLayerManager(CommonEntities.Enums.DALManagerType.SQL);
        }

        private void btnGetEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = bLLMngr.GetEmployeeById(264);
            lblID.Text = emp.Id.ToString();
            lblName.Text = emp.Name;
            lblAge.Text = emp.Age.ToString();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            EmployeeCollection empColl = bLLMngr.GetEmployeesByName("dummy string");
            grdEmployees.DataSource = empColl;
        }

        private void cmbDbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDbType.SelectedIndex)
            {
                case 0:
                    bLLMngr = new BusinessLogicLayerManager(CommonEntities.Enums.DALManagerType.SQL);
                    break;
                case 1:
                    bLLMngr = new BusinessLogicLayerManager(CommonEntities.Enums.DALManagerType.Oracle);
                    break;
            }
        }
    }
}
