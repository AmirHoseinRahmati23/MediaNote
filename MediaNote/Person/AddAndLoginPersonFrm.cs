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

namespace MediaNote.Person
{
    public partial class AddAndLoginPersonFrm : Form
    {
        public int personId;
        public AddAndLoginPersonFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                if (db.PersonRepository
                    .IsExistByEmailAndUserName(txtUserName.Text, txtInfo.Text , txtPassword.Text ))
                {
                    var person = db.PersonRepository
                        .GetPersonByUserNameAndEmail(txtUserName.Text, txtInfo.Text);
                    personId = person.PersonId;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    db.PersonGenericRepository.Insert(new DataLayer.Person()
                    {
                        PersonName = txtUserName.Text,
                        Password = txtPassword.Text,
                        EmailOrMobile = txtInfo.Text
                    });
                    db.Save();
                    var person = db.PersonRepository
                        .GetPersonByUserNameAndEmail(txtUserName.Text, txtInfo.Text);
                    personId = person.PersonId;

                    DialogResult = DialogResult.OK;
                }

            }
        }
    }
}
