using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;


namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        
        //METODO COMPROVAR LOGIN USER
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        //METODO PARA AÑADIR PARTIDOS
        public bool AñadirPartidoUser(string equipLocal, string equipVisitant, string estatPartit, int golLocal, int golVisitant, string jornada, string temporada, DateTime fechaPartido)
        {
            return userDao.AñadirPartido(equipLocal, equipVisitant, estatPartit, golLocal, golVisitant, jornada, temporada, fechaPartido);
        }

        //METODO PARA ELIMINAR PARTIDOS
        public bool EliminarPartidoUser(string equipLocal, string equipVisitant, string temporada)
        {
            return userDao.EliminarPartido(equipLocal, equipVisitant, temporada);
        }

        //METODO PARA ELIMINAR USUARIO
        public string EliminarUsuarioUser(string user)
        {
            return userDao.EliminarUser(user);
        }

        //METODO PARA AÑADIR EQUIPO
        public bool AñadirEquipoUser(string nomEquip, string nomEstadi, string municipi)
        {
            return userDao.AñadriEquipo(nomEquip, nomEstadi, municipi);
        }

        //METODO PARA ELIMINAR EQUIPO
        public bool EliminarEquipoUser(string nomEquip)
        {
            return userDao.EliminarEquipo(nomEquip);
        }

        //METODO PARA CREAR USUARIO
        public bool CrearUsuarioUser(string nombre, string apellidos, string alias, string password, string nif)
        {
            return userDao.CrearUsaurio(nombre, apellidos, alias, password, nif);
        }

        //METODO PARA EDITAR UN PARTIDO YA CREADO
        public bool EditarPartidoCreadoUser(string equipLocal, string equipVisitant, string temporada, int golLocal, int golVisitant, string estat)
        {
            return userDao.AccederEditarPartidoCreado(equipLocal, equipVisitant, temporada, golLocal, golVisitant, estat);
        }

        //METODO CREAR PORRA
        public string CrearPorraUser(string alias, int idPartit, int golLocal, int golVisitant)
        {
            return userDao.CrearPorra(alias, idPartit, golLocal, golVisitant);
        }

        //METODO MOSTRAR DATE GRID VIEW / LISTA DE PARTIDOS
        public DataTable ConsultaDT()
        {
            return userDao.ConsultarPartidos();
        }

        //METODO MOSTRAR DATE GRID VIEW / LISTA DE PORRAS
        public DataTable ConsultaDT2()
        {
            return userDao.ConsultarPorras();
        }
    }
}
