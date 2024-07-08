using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsuarioAPI.Models
{
     public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string Nome { get; set; } = "";

        [Column(TypeName ="nvarchar(20)")]
        public string sobrenome { get; set; } = "";

        [Column(TypeName ="nvarchar(100)")]
        public string email { get; set; } = "";

        [Column(TypeName ="nvarchar(30)")]
        public string senha { get; set; } = "";

        public bool ADM { get; set; }
        public int telefone { get; set; }

    }
}