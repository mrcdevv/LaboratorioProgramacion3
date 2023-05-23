using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP1
{
    public class LaboratorioException: Exception
    {
        // 3 constructores estándar
        public LaboratorioException() : base() {}
        public LaboratorioException(String message): base(message) {}
        public LaboratorioException(String message, Exception inner) : base(message, inner) { }
    }
}
