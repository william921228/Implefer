using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace impleferAPI.ModelsClean
{
  public class MensajesPagina
  {
    private string _texto;
    private int _id;

    public string Texto
    {
      get { return _texto; }
      set { _texto = value; }
    }
    public int Id
    {
      get { return _id;  }
      set { _id = value; }
    }
  }
}