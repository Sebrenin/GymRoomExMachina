using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRoomExMachina
{
    public partial class frmMemberData : Form
    {
        public frmMemberData()
        {
            InitializeComponent();
        }

        private void frmMemberData_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatosMiembro()
        {
            // Obtener data
            var lstMembers = _serviceMember.GetAllMembers();
        }

        private void btnGoBack_MouseEnter(object sender, EventArgs e)
        {
            btnGoBack.BackColor = Color.DodgerBlue;
            btnGoBack.ForeColor = Color.White;
        }

        private void btnGoBack_MouseLeave(object sender, EventArgs e)
        {
            btnGoBack.BackColor = Color.DodgerBlue;
            btnGoBack.ForeColor = Color.White;
        }
    }
}
