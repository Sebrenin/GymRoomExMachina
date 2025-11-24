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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmMycostumers frmMycostumers = new frmMycostumers();
            frmMycostumers.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRoutine frmRoutine = new frmRoutine();
            frmRoutine.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMealtable frmMealtable = new frmMealtable();
            frmMealtable.Show();
            this.Hide();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {

        }
    }
}
