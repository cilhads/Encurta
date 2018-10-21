using System;
using System.Collections.Generic;
using System.Text;

namespace Encurta.iCarros.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        { }   
        
        public int ID_USUARIO { get; set; }
        public string DS_USUARIO { get; set; }
        public string DS_ALIAS { get; set; }
        public string DS_SENHA { get; set; }
    }
}
