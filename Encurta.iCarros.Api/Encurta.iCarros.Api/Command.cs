using FluentValidator;

namespace Encurta.iCarros.Api
{
    public class Command : Notifiable
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
