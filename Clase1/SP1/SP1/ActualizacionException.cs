using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP1
{
    public class ActualizacionException: Exception
    {
        // 3 contructores estándar
        // todos ejecutan el constructor de la clase base
        public ActualizacionException() : base() { }
        public ActualizacionException(String message): base(message) { }
        public ActualizacionException(String message, Exception ex) : base(message, ex) { }
    }
}
