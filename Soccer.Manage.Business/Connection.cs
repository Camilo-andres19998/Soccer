using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Soccer.Manage.Business
{
   public class Connection
   {
        private string Base;
        private string Server;
        private string User;
        private string Pass;
        private static Connection Con = null;


        private Connection()
        {
            this.Base = "Football";
            this.Server = "LAPTOP-JE5LCMHU";
            this.User = "usuario1";
            this.Pass = "1234567890";


        }


        public SqlConnection Create()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Server+
                                        "; Database=" + this.Base +
                                        "; User Id=" + this.User +
                                        "; Password=" + this.Pass;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }


        public static Connection getInstance()
        {
            if (Con == null)
            {
                Con = new Connection();
            }
            return Con;
        }
    }
}
