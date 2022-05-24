using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


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
        public void AñadirPartidoUser(string equipLocal, string equipVisitant, string estatPartit, int golLocal, int golVisitant, string jornada, string temporada, DateTime fechaPartido)
        {
            userDao.AñadirPartido(equipLocal, equipVisitant, estatPartit, golLocal, golVisitant, jornada, temporada, fechaPartido);
        }

        //METODO PARA ELIMINAR PARTIDOS
        public void EliminarPartidoUser(string equipLocal, string equipVisitant, string temporada)
        {
            userDao.EliminarPartido(equipLocal, equipVisitant, temporada);
        }

        //METODO PARA ELIMINAR USUARIO
        public void EliminarUsuarioUser(string user)
        {
            userDao.EliminarUser(user);
        }
    }
}
