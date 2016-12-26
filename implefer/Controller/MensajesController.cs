using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using implefer.ModelConnection;

namespace implefer.Controller
{
  public class MensajesController : ApiController
  {
    public string obtenerMensajePorId(int id)
    {
      MensajeConnection conect = new MensajeConnection();
      conect.obtenerMensajePorID(id);


      return string.Empty;
    }  
  }
}