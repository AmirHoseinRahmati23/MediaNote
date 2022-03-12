using MediaNote.DataLayer.Repository;
using MediaNote.DataLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNote.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        MediaNoteEntities db = new MediaNoteEntities();
        #region Generic Reposetories

        private IGenericRepository<MediaNote> _mediaGenericRepository;
        public IGenericRepository<MediaNote> MediaGenericRepository 
        {
            get
            { 
                if(_mediaGenericRepository == null)
                {
                    _mediaGenericRepository = new GenericRepository<MediaNote>(db);
                }
                return _mediaGenericRepository;
            }
        }

        private IGenericRepository<Person> _personGenericRepository;
        public IGenericRepository<Person> PersonGenericRepository
        {
            get
            {
                if (_personGenericRepository == null)
                {
                    _personGenericRepository = new GenericRepository<Person>(db);
                }
                return _personGenericRepository;
            }
        }

        #endregion

        #region Repositories
        private IPersonRepository _personRepository;
        public IPersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(db);
                }
                return _personRepository;
            }
        }


        private IMediaRepository _mediaRepository;
        public IMediaRepository MediaRepository
        {
            get
            {
                if (_mediaRepository == null)
                {
                    _mediaRepository = new MediaRepository(db);
                }
                return _mediaRepository;
            }
        }
        #endregion
        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
