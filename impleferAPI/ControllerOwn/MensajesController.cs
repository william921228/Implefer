using impleferAPI.ModelConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace impleferAPI.ControllerOwn
{
  [RoutePrefix("MensajesController")]
  public class MensajesController : ApiController
  {
    [HttpGet]
    [Route("obtenerMensajePorId")]
    public string obtenerMensajePorId(int id)
    {
      MensajeConnection conect = new MensajeConnection();
      return conect.obtenerMensajePorID(id);
    }
  }
}
