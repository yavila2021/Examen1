using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen1.Model
{
    public class Contactos
    {
     [PrimaryKey, AutoIncrement]
        public int IdContacto { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }
        public String Pais { get; set; }
        public string Nota { get; set; }

       /// public static implicit operator Contatos(Contatos v)
      ///  {
        ///    throw new NotImplementedException();
      ///  }
    }

}
