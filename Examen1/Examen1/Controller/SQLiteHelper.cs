using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Examen1.Controller;
using SQLite;
using SQLitePCL;

namespace Examen1.Controller
{
    public class SQLiteHelper
    {
        readonly SQLiteAsyncConnection _conexion;
        public SQLiteHelper()
        {
        }
        public SQLiteHelper(String dbpath)
        {
            _conexion = new SQLiteAsyncConnection(dbpath);

            _conexion.CreateTableAsync<Model.Contactos>().Wait();
        }
        public  Task<int> StoreContac(Model.Contactos Contac)
        {
            if (Contac.IdContacto != 0)
            {
                return _conexion.UpdateAsync(Contac);

            }
            else 
            {
                return _conexion.InsertAsync(Contac);
            }


        }
        public Task<List<Model.Contactos>> GetContactosAsync()
        {
            return _conexion.Table<Model.Contactos>().ToListAsync();
        }
        public Task<Model.Contactos> GetContacto(int IdContacto)
        {
            return _conexion.Table<Model.Contactos>()
                .Where(i => i.IdContacto == IdContacto)
                .FirstOrDefaultAsync();
        }

        public Task<int> Deletecontacto(Model.Contactos Contac)
        {
            return _conexion.DeleteAsync(Contac);
        }
        public Task<int> SaveContacAsync(Model.Contactos Contac)
        {
            if (Contac.IdContacto == 0)
            {
                return _conexion.InsertAsync(Contac);

             }
            else
            {
                return null;
            }
        }
    }
}
