using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
imports System.Data.SqlClient;
namespace viajesPro.Datos
{
    class conexion
    {
        protected cnn As New SqlConnection;
        public idusuario As Integer;

        Protected Function conectado()
            Try
            cnn= new SqlConnection("data source = (local)")
    }
}
