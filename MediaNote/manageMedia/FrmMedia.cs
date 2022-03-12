using MediaNote.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNote.manageMedia
{
    public partial class FrmMedia : Form
    {
        public int TypeId;
        public int PersonId;
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void FrmMedia_Load(object sender, EventArgs e)
        {
            dgvMedia.AutoGenerateColumns = false;
            BindGrid(TypeId);
            switch (TypeId)
            {
                case 1:
                    {
                        this.Text = "فیلم ها";
                        break;
                    }
                case 2:
                    {
                        this.Text = "سریال ها";
                        break;
                    }
                case 3:
                    {
                        this.Text = "انیمشین ها";
                        break;
                    }
                case 4:
                    {
                        this.Text = "آهنگ ها";
                        break;
                    }
            }
        }

        void BindGrid(int typeID)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMedia.DataSource
                            = db.MediaGenericRepository
                            .GetAll(a => a.TypeId == typeID && a.PersonId == this.PersonId);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BindGrid(TypeId);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (RtlMessageBox.Show("آیا از حذف این شخص مطمئنید؟", "هشدار"
                   , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                   DialogResult.OK)
                {
                    var row = dgvMedia.CurrentRow.Cells[0].Value.ToString();
                    if (row != null)
                    {
                        db.MediaGenericRepository
                    .Delete(int.Parse(row));
                        db.Save();
                        BindGrid(TypeId);
                    }
                    

                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AddAndEditForm edit = new AddAndEditForm();
            edit.TypeId = TypeId;
            edit.PersonId = this.PersonId;
            edit.MediaId = int.Parse(dgvMedia.CurrentRow.Cells[0].Value.ToString());
            if (edit.ShowDialog() == DialogResult.OK)
            {
                BindGrid(TypeId);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AddAndEditForm add = new AddAndEditForm();
            add.MediaId = 0;
            add.TypeId = TypeId;
            add.PersonId = this.PersonId;
            if (add.ShowDialog() == DialogResult.OK)
            {
                BindGrid(TypeId);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            AddAndViewImage addAndView = new AddAndViewImage();
            addAndView.MediaID = (int)dgvMedia.CurrentRow.Cells[0].Value;
            addAndView.ShowDialog();
        }
    }
}
