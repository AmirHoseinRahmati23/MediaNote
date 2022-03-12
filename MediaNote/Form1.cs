using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaNote.DataLayer.Context;
using MediaNote.manageMedia;
using MediaNote.Person;
using MediaNote.Utility;
using MediaNote.ViewModel;

namespace MediaNote
{
    public partial class Frm_Home : Form
    {
        public int PersonId;
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            AddAndLoginPersonFrm perLog = new AddAndLoginPersonFrm();
            this.Hide();
            if (perLog.ShowDialog() == DialogResult.OK)
            {
                PersonId = perLog.personId;
                this.Show();
                LblDateTime.Text = DateTime.Now.ToShamsi();
            }
            else
            {
                Application.Exit();
            }
            BindGrid();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblDateTime.Text = DateTime.Now.ToShamsi();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmMedia frmFilm = new FrmMedia();
            frmFilm.TypeId = 1;
            frmFilm.PersonId = PersonId;
            frmFilm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmMedia frmSerial = new FrmMedia();
            frmSerial.TypeId = 2;
            frmSerial.PersonId = PersonId;
            frmSerial.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmMedia frmAnimation = new FrmMedia();
            frmAnimation.TypeId = 3;
            frmAnimation.PersonId = PersonId;
            frmAnimation.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMedia frmMusic = new FrmMedia();
            frmMusic.TypeId = 4;
            frmMusic.PersonId = PersonId;
            frmMusic.ShowDialog();
        }
     
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                IEnumerable<AllMediaViewModel> medias = db.MediaRepository
                   .GetMediaNotes(PersonId);
                dgvAllMedia.Rows.Clear();
                foreach (var item in medias)
                {
                    dgvAllMedia.Rows.Add(item.PersianName, item.TypeTitle, item.ReleaseYear, item.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
