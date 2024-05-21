using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        public override string tipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Compromisso"; } }

        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
