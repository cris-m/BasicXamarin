using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasicXamarin.GetStarted.Models
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection _db;
        public NoteDatabase(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<NoteTable>().Wait();
        }
        public Task<List<NoteTable>> GetNotesAsync()
        {
            return _db.Table<NoteTable>().ToListAsync();
        }
        public Task<NoteTable> GetNoteAsync(int id)
        {
            return _db.Table<NoteTable>().Where(x => x.ID == id).FirstOrDefaultAsync();   
        }
        public Task<int> SaveNoteAsync(NoteTable note)
        {
            if(note.ID != 0)
            {
                return _db.UpdateAsync(note);
            }
            return _db.InsertAsync(note);
        }
        public Task<int>DeleteNoteAsync(NoteTable note)
        {
            return _db.DeleteAsync(note);
        }
    }
}
