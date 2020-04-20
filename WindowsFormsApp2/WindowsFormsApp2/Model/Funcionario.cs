using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class Funcionario : Model.Pessoa
    {
        private DateTime? dtDemissao;
        private DateTime dtAdmissao;
        private Model.ControleAcesso controleAcesso;
        private Model.Cargo cargo;

        public DateTime? DtDemissao { get => dtDemissao; set => dtDemissao = value; }
        public DateTime DtAdmissao { get => dtAdmissao; set => dtAdmissao = value; }
        public ControleAcesso ControleAcesso { get => controleAcesso; set => controleAcesso = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }

        public Funcionario() : base()
        {
            this.dtDemissao = null;
            this.dtAdmissao = DateTime.Now;
            this.controleAcesso = null;
            this.cargo = null;
        }


        public Funcionario(DateTime? dtDemissao,
            DateTime dtAdmissao, ControleAcesso controleAcesso, Model.Cargo cargo) : base()
        {
            this.dtDemissao = dtDemissao;
            this.dtAdmissao = dtAdmissao;
            this.controleAcesso = controleAcesso;
            this.cargo = cargo;
        }

        public void setControleAcesso(Model.ControleAcesso controleAcesso)
        {
            this.controleAcesso = controleAcesso;
        }

        public Model.ControleAcesso getControleAcesso()
        {
            return this.controleAcesso;
        }

        public void setDtDemissao(DateTime? dtDemissao)
        {
            this.dtDemissao = dtDemissao;
        }

        public void setCargo(Model.Cargo cargo)
        {
            this.cargo = cargo;
        }

        public void setDtAdmissao(DateTime dtAdmissao)
        {
            this.dtAdmissao = dtAdmissao;
        }

        public DateTime? getDtDemissao()
        {
            return this.dtDemissao;
        }

        public DateTime getDtAdmissao()
        {
            return this.dtAdmissao;
        }
        public Model.Cargo getCargo()
        {
            return this.cargo;
        }
    }
}
