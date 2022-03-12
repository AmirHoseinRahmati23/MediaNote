using MediaNote.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNote.DataLayer.Repository
{
    public interface IMediaRepository
    {
        IEnumerable<AllMediaViewModel> GetMediaNotes(int PersonID);
        bool SaveMediaImageName(string FileName,int MediaID);
        string GetImageNameById(int MediaID);
    }
}
