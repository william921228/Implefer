using impleferAPI.ModelsClean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace impleferAPI.ModelConnection
{
  public class MensajeConnection
  {
    public string obtenerMensajePorID(int id)
    {
      string retorno = string.Empty;
      List<MensajesPagina> listaMensajes = new List<MensajesPagina>();
      listaMensajes.Add(new MensajesPagina() { Id = 1, Texto = "Bienbenidos a Implefer" });
      listaMensajes.Add(new MensajesPagina() { Id = 2, Texto = "este es un proyecto creado por mateo miranda y William Guerrero Para llevar la facturacion de implefer" });


      foreach (var msn in listaMensajes)
      {
        if (id == msn.Id)
        {
          retorno = msn.Texto;
        }
      }
      return retorno;
    }
  }
}