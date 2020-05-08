using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());
            //Application.Run(new IniciarObra());
        }



        /*
         INSERTS -----------------------------------------------------------

         
            insert into cargo(descricao )values ('Engenheiro(a)');
            insert into cargo(descricao )values ('Mestre de Obra');
            insert into cargo(descricao )values ('Secretário(a)');
            insert into cargo(descricao )values ('Servente');
            insert into cargo(descricao )values ('Pedreiro');

            insert into estado(uf, nome) values('PR', 'Paraná');//
            insert into estado(uf, nome) values('MG', 'Minas Gerais');//
            insert into estado(uf, nome) values('AC', 'Acre');
            insert into estado(uf, nome) values('MS', ' Mato Grosso do Sul');
            insert into estado(uf, nome) values('RJ', 'Rio de Janeiro');//

            insert into cidade(uf_estado, nome) values('MS', 'Alcinopolis');
            insert into cidade(uf_estado, nome) values('MS', 'Eldorado');
            insert into cidade(uf_estado, nome) values('MS', 'Iguatemi');
            insert into cidade(uf_estado, nome) values('MS', 'Japora');


            insert into cidade(uf_estado, nome) values('MG', 'Arapua');
            insert into cidade(uf_estado, nome) values('MG', 'Araxa');
            insert into cidade(uf_estado, nome) values('MG', 'Arcos');
            insert into cidade(uf_estado, nome) values('MG', 'Baldim');


            insert into cidade(uf_estado, nome) values('PR', 'Foz do Iguaçu');
            insert into cidade(uf_estado, nome) values('PR', 'Diamante do Sul');
            insert into cidade(uf_estado, nome) values('PR', 'Douradina');
            insert into cidade(uf_estado, nome) values('PR', 'Guaratuba');


            insert into cidade(uf_estado, nome) values('RJ', 'São Gonçalo');
            insert into cidade(uf_estado, nome) values('RJ', 'Duque de Caxias');
            insert into cidade(uf_estado, nome) values('RJ', 'Nova Iguaçu');
            insert into cidade(uf_estado, nome) values('RJ', 'Niterói');

            insert into cidade(uf_estado, nome) values('MG', 'Acrelândia');
            insert into cidade(uf_estado, nome) values('MG', 'Assis Brasil');
            insert into cidade(uf_estado, nome) values('MG', 'Brasileia');
            insert into cidade(uf_estado, nome) values('MG', 'Capixaba');


            insert into cidade(uf_estado, nome) values('AC', 'Capixaba');
            insert into cidade(uf_estado, nome) values('AC', 'Jordao');
            insert into cidade(uf_estado, nome) values('AC', 'Rio Branco');
            insert into cidade(uf_estado, nome) values('AC', 'Tarauaca');




          */
    }
}
