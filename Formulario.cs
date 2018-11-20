using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBraspag.Solution
{
    public class Formulario
    {
        public Formulario(String email, String nome, int cpf, int numPedido, int chaveAcesso) { }

        String email, nome;
        int cpf, numPedido, chaveAcesso;

        public int Id { get; set; }
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public int NumPedido { get => numPedido; set => numPedido = value; }
        public int ChaveAcesso { get => chaveAcesso; set => chaveAcesso = value; }
        
        
    } 
}
