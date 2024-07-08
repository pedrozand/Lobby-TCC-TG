
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuadraAPI.Models
{
    public class Quadra
    {
        [Key]
        public int QuadraId { get; set; }

        [Column(TypeName ="nvarchar(150)")]
        public string Nome { get; set; } = "";

        [Column(TypeName = "nvarchar(300)")]
        public string Descricao { get; set; } = "";

        //mm/yy
        [Column(TypeName = "nvarchar(100)")]
        public string horarioFuncionamento { get; set; } = "";

        [Column(TypeName = "nvarchar(30)")]
        public string modalidades { get; set; } = "";


        [Column(TypeName = "nvarchar(300)")]
        public string endereco { get; set; } = "";

/*
        [Column(TypeName = "nvarchar(3)")]
        public string comentarioUsuario { get; set; } = "";
*/

     //   [Column(TypeName = "nvarchar(5)")]
     //   public double AvaliacaoQuadra { get; set; } // Média das avaliações


       // public int TotalAvaliacoes { get; set; } // Total de avaliações recebidas

        public int avaliacaoQuadra { get; set; }


        [Column(TypeName = "nvarchar(20)")]
        public string horarioLobby { get; set; } = "";


        [Column(TypeName = "nvarchar(350)")]
        public string latitude { get; set; } = "";


        [Column(TypeName = "nvarchar(350)")]
        public string longitude { get; set; } = "";


        [Column(TypeName = "nvarchar(200)")]
        public string imagem { get; set; } = "";

    }
}

