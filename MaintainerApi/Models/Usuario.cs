using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Usuario : Registro
    {
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public int IndicadorId { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public Usuario UsuarioList { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
