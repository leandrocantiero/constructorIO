using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Obra
    {
        private int _cod;
        private decimal _valor;
        private Model.Funcionario _funcionario;
        //private Model.Cliente _cliente;
        private DateTime _dtInicio;
        private DateTime _dtFim;
        private DateTime _dtPrevFim;
        private Model.Status _status;
        private Model.Endereco _endereco;
        private string _descricao;

        public Obra()
        {
            _cod = 0;
            _valor = 0;
            _funcionario = null;
            //_cliente = null;
            _dtInicio = new DateTime();
            _dtFim = new DateTime(); ;
            _dtPrevFim = new DateTime(); ;
            _status = null;
            _endereco = null;
            _descricao = "";
        }

        //public Obra(int cod, decimal valor, Funcionario funcionario, Cliente cliente, 
        //    DateTime dtInicio, DateTime dtFim, DateTime dtPrevFim, Status status, Endereco endereco, string descricao)
        //{
        //    _cod = cod;
        //    _valor = valor;
        //    _funcionario = funcionario;
        //    _cliente = cliente;
        //    _dtInicio = dtInicio;
        //    _dtFim = dtFim;
        //    _dtPrevFim = dtPrevFim;
        //    _status = status;
        //    _endereco = endereco;
        //    _descricao = descricao;
        //}

    }
}
