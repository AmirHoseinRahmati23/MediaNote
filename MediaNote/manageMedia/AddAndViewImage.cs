using MediaNote.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNote.manageMedia
{
    public partial class AddAndViewImage : Form
    {
        public int MediaID;
        public AddAndViewImage()
        {
            InitializeComponent();
        }

        private void btnChoiseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                PictureMedia.ImageLocation = openFile.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageName = Guid.NewGuid() + Path.GetExtension(PictureMedia.ImageLocation); ;
            string path = Application.StartupPath + "/Images/";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            PictureMedia.Image.Save(path + imageName);
            using (UnitOfWork db = new UnitOfWork())
            {
                db.MediaRepository.SaveMediaImageName(imageName , MediaID);
                db.Save();
            }
            DialogResult = DialogResult.OK;
        }

        private void AddAndViewImage_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var FileName = db.MediaRepository.GetImageNameById(MediaID);
                if (FileName != null )
                {
                    PictureMedia.ImageLocation = Application.StartupPath + "/Images/" + FileName;
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
