using MediaNote.DataLayer.Repository;
using MediaNote.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNote.DataLayer.Service
{
    public class MediaRepository : IMediaRepository
    {
        private MediaNoteEntities _db;
        public MediaRepository(MediaNoteEntities db)
        {
            _db = db;
        }

        public string GetImageNameById(int MediaID)
        {
            var image = _db.MediaNote.Find(MediaID).MediaImage;


            return image;
        }

        public IEnumerable<AllMediaViewModel> GetMediaNotes(int PersonID)
        {
            var Media = _db.MediaNote.Where(m => m.PersonId == PersonID).Include(m=>m.Type1)
                .Select(m => new AllMediaViewModel()
                {
                    Id = m.MediaId,
                    Information = m.Information,
                    PersianName = m.PersianName,
                    ReleaseYear = (int)m.ReleaseYear,
                    TypeTitle = m.Type1.TypeTitle

                }).ToList();

            return Media;
        }

        public bool SaveMediaImageName(string FileName,int MediaID)
        {
            try
            {
                _db.MediaNote.Find(MediaID).MediaImage = FileName;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
