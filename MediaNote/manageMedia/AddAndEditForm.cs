using MediaNote.DataLayer.Context;
using MediaNote.DataLayer;
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
    public partial class AddAndEditForm : Form
    {
        public int MediaId = 0;
        public int TypeId;
        public int PersonId;
        public AddAndEditForm()
        {
            InitializeComponent();
        }

        private void AddAndEditForm_Load(object sender, EventArgs e)
        {
            if (MediaId != 0)
            {
                this.Text = "ویرایش";
                using(UnitOfWork db = new UnitOfWork())
                {
                    var per = db.MediaGenericRepository.GetById(MediaId);
                    txtPersian.Text = per.PersianName ;
                    txtEnglish.Text = per.EnglishName ;
                    txtCreator.Text = per.CreatedBy ;
                    txtCountry.Text = per.NameInMediaCountry;
                    txtInformation.Text =  per.Information;
                    numerYear.Value = decimal.Parse(per.ReleaseYear.ToString()) ;
                    numerScore.Value = decimal.Parse(per.RateInIMDB.ToString()) ; 
                }
            }
            else
            {
                this.Text = "افزودن";
            }
            if(TypeId == 1 || TypeId == 2 || TypeId == 3)
            {
                LblCreator.Text = "کارگردان";
            }
            else
            {
                LblCreator.Text = "خواننده";
                LblHide.Text = "نمره از ده:";
            }
            
        
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                DataLayer.MediaNote media = new DataLayer.MediaNote()
                {
                    PersianName = txtPersian.Text,
                    EnglishName = txtEnglish.Text,
                    CreatedBy = txtCreator.Text,
                    NameInMediaCountry = txtCountry.Text,
                    Information = txtInformation.Text,
                    TypeId = this.TypeId,
                    RateInIMDB = float.Parse(numerScore.Value.ToString()),
                    ReleaseYear = int.Parse(numerYear.Value.ToString()),
                    PersonId = this.PersonId,
                };
                if (MediaId != 0)
                {
                    media.MediaId = this.MediaId;
                    db.MediaGenericRepository.Update(media);
                }
                else
                {
                    db.MediaGenericRepository.Insert(media);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
