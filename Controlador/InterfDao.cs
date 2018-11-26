    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public interface InterfDao
    {
       
        void add(Distrito obj);
        void add(Proveedor obj);
        void add(Usuario obj);
        void add(Entrada obj);
        void add(Salida obj);
        void refresh(Proveedor obj);
        void refresh(Usuario obj);
        void refresh(Entrada obj);
        void refresh(Salida obj);
        void delete(object cod);    
        DataTable getCargarLista(object bus);
    }
}
