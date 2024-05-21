using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademiaDoProgramador.WinApp.ModuloUsuario
{
    public class Usuario
    {
        public string nome {  get; set; }
        public string senha { get; set; }
        public Usuario(string nome, string senha)
        {
            this.nome = nome;
            this.senha = senha;
        }

        public List <string> Validar()
        {
            List<string> erros = new List<string>();

            if (nome.Length < 3)
                erros.Add("O Login de usuário deve conter ao menos 3 caracteres.");
            if (senha.Length < 6)
                erros.Add("A Senha do usuário deve conter ao menos 6 caracteres.");

            return erros;
        }
    }
}
