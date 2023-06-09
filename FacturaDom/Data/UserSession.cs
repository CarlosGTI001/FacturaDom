using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.Data
{
    public class UserSession
    {
        private static UserSession instance;
        private static readonly object lockObject = new object();

        public string UserName { get; set; }
        public string UserCode { get; set; }
        public string SessionId { get; set; }

        private UserSession()
        {
            // Constructor privado para evitar la creación directa de instancias
        }

        public static UserSession Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new UserSession();
                        }
                    }
                }
                return instance;
            }
        }
    }

}
