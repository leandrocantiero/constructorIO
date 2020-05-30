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
        private Model.Cliente _cliente;
        private DateTime _dtInicio;
        private DateTime? _dtFim;
        private DateTime _dtPrevFim;
        private Model.Status _status;
        private Model.Endereco _endereco;
        private string _descricao;

        public int Cod { get => _cod; set => _cod = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public Funcionario Funcionario { get => _funcionario; set => _funcionario = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public DateTime DtInicio { get => _dtInicio; set => _dtInicio = value; }
        public DateTime? DtFim { get => _dtFim; set => _dtFim = value; }
        public DateTime DtPrevFim { get => _dtPrevFim; set => _dtPrevFim = value; }
        public Status Status { get => _status; set => _status = value; }
        public Endereco Endereco { get => _endereco; set => _endereco = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }

        public Obra()
        {
            _cod = 0;
            _valor = 0;
            _funcionario = null;
            _cliente = null;
            _dtInicio = new DateTime();
            _dtFim = new DateTime(); ;
            _dtPrevFim = new DateTime(); ;
            _status = null;
            _endereco = null;
            _descricao = "";
        }

        public int getCod()
        {
            return this._cod;
        }

        public void setCod(int cod)
        {
            this._cod = cod;
        }

        public decimal getValor()
        {
            return this._valor;
        }

        public void setValor(decimal valor)
        {
            this._valor = valor;
        }

        public Model.Funcionario getFuncionario()
        {
            return this._funcionario;
        }

        public void setFuncionario(Model.Funcionario funcionario)
        {
            this._funcionario = funcionario;
        }

        public Model.Cliente getCliente()
        {
            return this._cliente;
        }

        public void setCliente(Model.Cliente cliente)
        {
            this._cliente = cliente;
        }

        public DateTime getDataInicio()
        {
            return this._dtInicio;
        }

        public void setDataInicio(DateTime dataInicio)
        {
            this._dtInicio = dataInicio;
        }

        public DateTime getDataPrevFim()
        {
            return this._dtPrevFim;
        }

        public void setDataPrevFim(DateTime dataPrevFim)
        {
            this._dtPrevFim = dataPrevFim;
        }

        public DateTime? getDataFim()
        {
            return this._dtFim;
        }

        public void setDataFim(DateTime? dataFim)
        {
            this._dtFim = dataFim;
        }

        public Model.Status getStatus()
        {
            return this._status;
        }

        public void setStatus(Model.Status status)
        {
            this._status = status;
        }

        public Model.Endereco getEndereco()
        {
            return this._endereco;
        }

        public void setEndereco(Model.Endereco endereco)
        {
            this._endereco = endereco;
        }

        public string getDescricao()
        {
            return this._descricao;
        }

        public void setDescricao(string descricao)
        {
            this._descricao = descricao;
        }


        public override string ToString()
        {
            return this.getEndereco().getRua() + ", Nº " + this.getEndereco().getNumero();
        }

    }
}
