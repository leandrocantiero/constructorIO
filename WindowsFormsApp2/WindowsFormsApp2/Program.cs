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

            //Application.Run(new Login());
            Application.Run(new LancarMateriaisServicos());

            /*
                ****************************************************************************************
                //OPCIONAL
                insert into parametro(cnpj, razao, fantasia, inscricao_estadual, 
                                          cod_contato, cod_endereco, logo_menor, logo_maior, email, site)
                    values('123123123', 'asdasdasd', 'asdasdasd', 123123123, 1,1,'123123123','123123123','123123123','123123123');


             INSERTS ---------------------------------------------------------------------------------------------------------

                -- excluir todas TABELAS;
                 
                drop schema public cascade;

                create schema public;

                 * *****

              ***********************************************  SQL NECESSÁRIOS!! ***************************



                insert into status(descricao) values('Parada');
                insert into status(descricao) values('Em execução');
                insert into status(descricao) values('Finalizado');

                insert into contato(ddd_padrao, numero_padrao, ddd_alt, numero_alt) values('123','123123', '123', '123123');

                insert into endereco(cep, rua, numero,bairro, cod_cidade) values('123123','123123',123,'3123',1);

                


                insert into cargo(descricao )values ('Engenheiro(a)');
                insert into cargo(descricao )values ('Mestre de Obra');
                insert into cargo(descricao )values ('Secretário(a)');
                insert into cargo(descricao )values ('Servente');
                insert into cargo(descricao )values ('Pedreiro');

                insert into estado(uf, nome) values('PR', 'Paraná');
                insert into estado(uf, nome) values('MG', 'Minas Gerais');
                insert into estado(uf, nome) values('AC', 'Acre');
                insert into estado(uf, nome) values('MS', ' Mato Grosso do Sul');
                insert into estado(uf, nome) values('RJ', 'Rio de Janeiro');

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


                insert into etapa(descricao) values('Serviços Preliminares');


                insert into tarefa(cod_etapa, descricao) values(1, 'Sondagem');
                insert into tarefa(cod_etapa, descricao) values(1, 'Construção do depósito');
                insert into tarefa(cod_etapa, descricao) values(1, 'Construção do tapume');
                insert into tarefa(cod_etapa, descricao) values(1, 'Instalação provisória de água');
                insert into tarefa(cod_etapa, descricao) values(1, 'Instalação provisória de energia');
                insert into tarefa(cod_etapa, descricao) values(1, 'Lâmpada, vaso sanitário para trabalhadores');

                insert into etapa(descricao) values('Infra-estrutura (fundação e laje)');

                insert into tarefa(cod_etapa, descricao) values(2, 'Sapata ou estaca');
                insert into tarefa(cod_etapa, descricao) values(2, 'Viga Baldrame');
                insert into tarefa(cod_etapa, descricao) values(2, 'Coluna');
                insert into tarefa(cod_etapa, descricao) values(2, 'Laje');
                insert into tarefa(cod_etapa, descricao) values(2, 'Escada');


                insert into etapa(descricao) values('Supra Estrutura (vedação)');

                insert into tarefa(cod_etapa, descricao) values(3, 'Pilar;');
                insert into tarefa(cod_etapa, descricao) values(3, 'Parede;');
                insert into tarefa(cod_etapa, descricao) values(3, 'Verga e contra-verga');
                insert into tarefa(cod_etapa, descricao) values(3, 'Torre caixa d’água');


                insert into etapa(descricao) values('Cobertura');

                insert into tarefa(cod_etapa, descricao) values(4, 'Forro (pré-moldado, madeira, PVC ou gesso);');
                insert into tarefa(cod_etapa, descricao) values(4, 'Oitão');
                insert into tarefa(cod_etapa, descricao) values(4, 'Telhado (pré-moldado, madeira, PVC)');
                insert into tarefa(cod_etapa, descricao) values(4, 'Telha (cerâmica, concreto, etc)');


                insert into etapa(descricao) values('Esquadrias (Madeira, alumínio ou PVC)');

                insert into tarefa(cod_etapa, descricao) values(5, 'Guarnição');
                insert into tarefa(cod_etapa, descricao) values(5, 'Batente');
                insert into tarefa(cod_etapa, descricao) values(5, 'Folha');
                insert into tarefa(cod_etapa, descricao) values(5, 'Vista');

                insert into etapa(descricao) values('Revestimento');

                insert into tarefa(cod_etapa, descricao) values(6, 'Chapisco');
                insert into tarefa(cod_etapa, descricao) values(6, 'Emboço');
                insert into tarefa(cod_etapa, descricao) values(6, 'Reboco');

                insert into etapa(descricao) values('Instalações Hidrossanitárias');

                insert into tarefa(cod_etapa, descricao) values(7, 'Canos');
                insert into tarefa(cod_etapa, descricao) values(7, 'Tubos');
                insert into tarefa(cod_etapa, descricao) values(7, 'Registros');
                insert into tarefa(cod_etapa, descricao) values(7, 'Caixa d’água');
                insert into tarefa(cod_etapa, descricao) values(7, 'Bóia');
                insert into tarefa(cod_etapa, descricao) values(7, 'Caixa de gordura');
                insert into tarefa(cod_etapa, descricao) values(7, 'Caixa sifonada');
                insert into tarefa(cod_etapa, descricao) values(7, 'Caixa de inspeção');
                insert into tarefa(cod_etapa, descricao) values(7, 'Tanque séptico');
                insert into tarefa(cod_etapa, descricao) values(7, 'Filtro anaeróbico');
                insert into tarefa(cod_etapa, descricao) values(7, 'Metais');


                insert into etapa(descricao) values('Instalações elétricas');

                insert into tarefa(cod_etapa, descricao) values(8, 'Tubulações');
                insert into tarefa(cod_etapa, descricao) values(8, 'Caixas');
                insert into tarefa(cod_etapa, descricao) values(8, 'Fios');
                insert into tarefa(cod_etapa, descricao) values(8, 'Tomadas/disjuntores');


                insert into etapa(descricao) values('Pintura Interna e Externa');

                insert into tarefa(cod_etapa, descricao) values(9, 'Selador');
                insert into tarefa(cod_etapa, descricao) values(9, 'Massa corrida;');
                insert into tarefa(cod_etapa, descricao) values(9, 'Lixa');
                insert into tarefa(cod_etapa, descricao) values(9, 'Tinta');
                insert into tarefa(cod_etapa, descricao) values(9, 'Solvente');


                insert into etapa(descricao) values('Cerâmica');

                insert into tarefa(cod_etapa, descricao) values(10, 'Piso');
                insert into tarefa(cod_etapa, descricao) values(10, 'Azulejo');
                insert into tarefa(cod_etapa, descricao) values(10, 'Soleira');
                insert into tarefa(cod_etapa, descricao) values(10, 'Rodapé');
              */
        }
    }
}
