-- Database generated with pgModeler (PostgreSQL Database Modeler).
-- pgModeler  version: 0.9.2
-- PostgreSQL version: 10.0
-- Project Site: pgmodeler.io
-- Model Author: ---


-- Database creation must be done outside a multicommand file.
-- These commands were put in this file only as a convenience.
-- -- object: constructorio | type: DATABASE --
-- -- DROP DATABASE IF EXISTS constructorio;
-- CREATE DATABASE constructorio;
-- -- ddl-end --
-- 

-- object: public.obra | type: TABLE --
-- DROP TABLE IF EXISTS public.obra CASCADE;
CREATE TABLE public.obra (
	cod serial NOT NULL,
	valor_total decimal(10,2) NOT NULL,
	pes_cod_funcionario integer NOT NULL,
	pes_cod_cliente integer NOT NULL,
	data_inicio date NOT NULL,
	data_conclusao date,
	data_previsao date NOT NULL,
	cod_status integer NOT NULL,
	cod_endereco integer NOT NULL,
	descricao varchar(200),
	CONSTRAINT obra_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.obra OWNER TO postgres;
-- ddl-end --

-- object: public.etapa | type: TABLE --
-- DROP TABLE IF EXISTS public.etapa CASCADE;
CREATE TABLE public.etapa (
	cod serial NOT NULL,
	descricao varchar(100) NOT NULL,
	CONSTRAINT etapa_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.etapa OWNER TO postgres;
-- ddl-end --

-- object: public.material | type: TABLE --
-- DROP TABLE IF EXISTS public.material CASCADE;
CREATE TABLE public.material (
	cod serial NOT NULL,
	cod_categoria_mat integer NOT NULL,
	unidade varchar(20) NOT NULL,
	descricao varchar(100) NOT NULL,
	estoque integer NOT NULL,
	nome varchar(100) NOT NULL,
	valor numeric(10,4),
	CONSTRAINT material_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.material OWNER TO postgres;
-- ddl-end --

-- object: public.servico | type: TABLE --
-- DROP TABLE IF EXISTS public.servico CASCADE;
CREATE TABLE public.servico (
	cod serial NOT NULL,
	nome varchar(30) NOT NULL,
	quant_homem integer NOT NULL,
	observacao varchar(150) NOT NULL,
	CONSTRAINT servico_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.servico OWNER TO postgres;
-- ddl-end --

-- object: public.endereco | type: TABLE --
-- DROP TABLE IF EXISTS public.endereco CASCADE;
CREATE TABLE public.endereco (
	cod serial NOT NULL,
	cep character(11) NOT NULL,
	complemento varchar(30),
	rua varchar(50) NOT NULL,
	numero integer NOT NULL,
	bairro varchar(40) NOT NULL,
	cod_cidade integer NOT NULL,
	CONSTRAINT endereco_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.endereco OWNER TO postgres;
-- ddl-end --

-- object: public.tarefa | type: TABLE --
-- DROP TABLE IF EXISTS public.tarefa CASCADE;
CREATE TABLE public.tarefa (
	cod serial NOT NULL,
	cod_etapa integer NOT NULL,
	descricao varchar(100) NOT NULL,
	CONSTRAINT tarefa_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.tarefa OWNER TO postgres;
-- ddl-end --

-- object: public.tarefa_obra | type: TABLE --
-- DROP TABLE IF EXISTS public.tarefa_obra CASCADE;
CREATE TABLE public.tarefa_obra (
	cod_obra integer NOT NULL,
	cod_tarefa integer NOT NULL,
	CONSTRAINT tarefa_obra_pk PRIMARY KEY (cod_obra,cod_tarefa)

);
-- ddl-end --
-- ALTER TABLE public.tarefa_obra OWNER TO postgres;
-- ddl-end --

-- object: obra_fk | type: CONSTRAINT --
-- ALTER TABLE public.tarefa_obra DROP CONSTRAINT IF EXISTS obra_fk CASCADE;
ALTER TABLE public.tarefa_obra ADD CONSTRAINT obra_fk FOREIGN KEY (cod_obra)
REFERENCES public.obra (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: etapa_fk | type: CONSTRAINT --
-- ALTER TABLE public.tarefa DROP CONSTRAINT IF EXISTS etapa_fk CASCADE;
ALTER TABLE public.tarefa ADD CONSTRAINT etapa_fk FOREIGN KEY (cod_etapa)
REFERENCES public.etapa (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.pessoa | type: TABLE --
-- DROP TABLE IF EXISTS public.pessoa CASCADE;
CREATE TABLE public.pessoa (
	pes_cod serial NOT NULL,
	nome varchar(30) NOT NULL,
	registro varchar(30) NOT NULL,
	dtnasc date NOT NULL,
	cod_endereco integer NOT NULL,
	cod_contato integer NOT NULL,
	CONSTRAINT pessoa_pk PRIMARY KEY (pes_cod)

);
-- ddl-end --
-- ALTER TABLE public.pessoa OWNER TO postgres;
-- ddl-end --

-- object: public.funcionario | type: TABLE --
-- DROP TABLE IF EXISTS public.funcionario CASCADE;
CREATE TABLE public.funcionario (
	dt_demissao date,
	cod_controle_acesso integer NOT NULL,
	dt_admissao date NOT NULL,
	rg varchar(15) NOT NULL,
	cod_cargo integer NOT NULL,
	cpf varchar(11) NOT NULL,

-- 	pes_cod integer NOT NULL,
-- 	nome varchar(30) NOT NULL,
-- 	registro varchar(30) NOT NULL,
-- 	dtnasc date NOT NULL,
	CONSTRAINT funcionario_pk PRIMARY KEY (pes_cod)

)
 INHERITS(public.pessoa);
-- ddl-end --
-- ALTER TABLE public.funcionario OWNER TO postgres;
-- ddl-end --

-- object: public.cliente | type: TABLE --
-- DROP TABLE IF EXISTS public.cliente CASCADE;
CREATE TABLE public.cliente (
	email varchar(30) NOT NULL,
	ativo boolean NOT NULL,

-- 	pes_cod integer NOT NULL,
-- 	nome varchar(30) NOT NULL,
-- 	registro varchar(30) NOT NULL,
-- 	dtnasc date NOT NULL,
	CONSTRAINT cliente_pk PRIMARY KEY (pes_cod)

)
 INHERITS(public.pessoa);
-- ddl-end --
-- ALTER TABLE public.cliente OWNER TO postgres;
-- ddl-end --

-- object: public.fornecedor | type: TABLE --
-- DROP TABLE IF EXISTS public.fornecedor CASCADE;
CREATE TABLE public.fornecedor (
	cod serial NOT NULL,
	fantasia varchar(50) NOT NULL,
	cnpj character(18) NOT NULL,
	cod_endereco integer NOT NULL,
	cod_contato integer NOT NULL,
	inscricao varchar(15) NOT NULL,
	razao varchar(50) NOT NULL,
	site varchar(40),
	facebook varchar(40),
	linkdin varchar(40),
	instagram varchar(50),
	email varchar(50) NOT NULL,
	CONSTRAINT fornecedor_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.fornecedor OWNER TO postgres;
-- ddl-end --

-- object: public.contato | type: TABLE --
-- DROP TABLE IF EXISTS public.contato CASCADE;
CREATE TABLE public.contato (
	cod serial NOT NULL,
	ddd_padrao varchar(5) NOT NULL,
	numero_padrao varchar(20) NOT NULL,
	numero_alt varchar(20),
	ddd_alt varchar(5),
	CONSTRAINT contato_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.contato OWNER TO postgres;
-- ddl-end --

-- object: public.agendamento | type: TABLE --
-- DROP TABLE IF EXISTS public.agendamento CASCADE;
CREATE TABLE public.agendamento (
	cod serial NOT NULL,
	pes_cod_cliente integer NOT NULL,
	pes_cod_funcionario integer NOT NULL,
	data date NOT NULL,
	hora_final time NOT NULL,
	hora_inicial time NOT NULL,
	observacao varchar(255) NOT NULL,
	CONSTRAINT agendamento_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.agendamento OWNER TO postgres;
-- ddl-end --

-- object: cliente_fk | type: CONSTRAINT --
-- ALTER TABLE public.agendamento DROP CONSTRAINT IF EXISTS cliente_fk CASCADE;
ALTER TABLE public.agendamento ADD CONSTRAINT cliente_fk FOREIGN KEY (pes_cod_cliente)
REFERENCES public.cliente (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: funcionario_fk | type: CONSTRAINT --
-- ALTER TABLE public.agendamento DROP CONSTRAINT IF EXISTS funcionario_fk CASCADE;
ALTER TABLE public.agendamento ADD CONSTRAINT funcionario_fk FOREIGN KEY (pes_cod_funcionario)
REFERENCES public.funcionario (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: funcionario_fk | type: CONSTRAINT --
-- ALTER TABLE public.obra DROP CONSTRAINT IF EXISTS funcionario_fk CASCADE;
ALTER TABLE public.obra ADD CONSTRAINT funcionario_fk FOREIGN KEY (pes_cod_funcionario)
REFERENCES public.funcionario (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: cliente_fk | type: CONSTRAINT --
-- ALTER TABLE public.obra DROP CONSTRAINT IF EXISTS cliente_fk CASCADE;
ALTER TABLE public.obra ADD CONSTRAINT cliente_fk FOREIGN KEY (pes_cod_cliente)
REFERENCES public.cliente (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.consumo_material | type: TABLE --
-- DROP TABLE IF EXISTS public.consumo_material CASCADE;
CREATE TABLE public.consumo_material (
	quant integer NOT NULL,
	cod_material integer NOT NULL,
	cod_consumo_mat_serv integer NOT NULL,
	data_consumo_mat_serv date NOT NULL,
	CONSTRAINT consumo_material_pk PRIMARY KEY (cod_material,cod_consumo_mat_serv,data_consumo_mat_serv)

);
-- ddl-end --
-- ALTER TABLE public.consumo_material OWNER TO postgres;
-- ddl-end --

-- object: public.consumo_servico | type: TABLE --
-- DROP TABLE IF EXISTS public.consumo_servico CASCADE;
CREATE TABLE public.consumo_servico (
	quant_homem integer NOT NULL,
	quant_m2 decimal(10,2),
	cod_servico integer NOT NULL,
	cod_consumo_mat_serv integer NOT NULL,
	data_consumo_mat_serv date NOT NULL,
	CONSTRAINT consumo_servico_pk PRIMARY KEY (cod_servico,cod_consumo_mat_serv,data_consumo_mat_serv)

);
-- ddl-end --
-- ALTER TABLE public.consumo_servico OWNER TO postgres;
-- ddl-end --

-- object: servico_fk | type: CONSTRAINT --
-- ALTER TABLE public.consumo_servico DROP CONSTRAINT IF EXISTS servico_fk CASCADE;
ALTER TABLE public.consumo_servico ADD CONSTRAINT servico_fk FOREIGN KEY (cod_servico)
REFERENCES public.servico (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: material_fk | type: CONSTRAINT --
-- ALTER TABLE public.consumo_material DROP CONSTRAINT IF EXISTS material_fk CASCADE;
ALTER TABLE public.consumo_material ADD CONSTRAINT material_fk FOREIGN KEY (cod_material)
REFERENCES public.material (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: public.escala_trabalho | type: TABLE --
-- DROP TABLE IF EXISTS public.escala_trabalho CASCADE;
CREATE TABLE public.escala_trabalho (
	cod serial NOT NULL,
	cod_obra integer NOT NULL,
	pes_cod_funcionario integer NOT NULL,
	data_inicial date NOT NULL,
	data_final date NOT NULL,
	hora_inicial time NOT NULL,
	hora_final time NOT NULL,
	CONSTRAINT escala_trabalho_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.escala_trabalho OWNER TO postgres;
-- ddl-end --

-- object: obra_fk | type: CONSTRAINT --
-- ALTER TABLE public.escala_trabalho DROP CONSTRAINT IF EXISTS obra_fk CASCADE;
ALTER TABLE public.escala_trabalho ADD CONSTRAINT obra_fk FOREIGN KEY (cod_obra)
REFERENCES public.obra (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: funcionario_fk | type: CONSTRAINT --
-- ALTER TABLE public.escala_trabalho DROP CONSTRAINT IF EXISTS funcionario_fk CASCADE;
ALTER TABLE public.escala_trabalho ADD CONSTRAINT funcionario_fk FOREIGN KEY (pes_cod_funcionario)
REFERENCES public.funcionario (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.medicao | type: TABLE --
-- DROP TABLE IF EXISTS public.medicao CASCADE;
CREATE TABLE public.medicao (
	cod serial NOT NULL,
	pes_cod integer NOT NULL,
	cod_obra integer NOT NULL,
	data_inicial date NOT NULL,
	data_final date NOT NULL,
	valor_cobrado decimal(10,2) NOT NULL,
	forma_recebe varchar(10) NOT NULL,
	total_mat decimal(10,2) NOT NULL,
	total_serv decimal(10,2) NOT NULL,
	total decimal(10,2) NOT NULL,
	CONSTRAINT medicao_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.medicao OWNER TO postgres;
-- ddl-end --

-- object: obra_fk | type: CONSTRAINT --
-- ALTER TABLE public.medicao DROP CONSTRAINT IF EXISTS obra_fk CASCADE;
ALTER TABLE public.medicao ADD CONSTRAINT obra_fk FOREIGN KEY (cod_obra)
REFERENCES public.obra (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: funcionario_fk | type: CONSTRAINT --
-- ALTER TABLE public.medicao DROP CONSTRAINT IF EXISTS funcionario_fk CASCADE;
ALTER TABLE public.medicao ADD CONSTRAINT funcionario_fk FOREIGN KEY (pes_cod)
REFERENCES public.funcionario (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.medicao_serv | type: TABLE --
-- DROP TABLE IF EXISTS public.medicao_serv CASCADE;
CREATE TABLE public.medicao_serv (
	cod_medicao integer NOT NULL,
	cod_servico integer NOT NULL,
	qtde integer NOT NULL,
	valor decimal(10,2) NOT NULL,
	CONSTRAINT medicao_serv_pk PRIMARY KEY (cod_medicao,cod_servico)

);
-- ddl-end --
-- ALTER TABLE public.medicao_serv OWNER TO postgres;
-- ddl-end --

-- object: public.medicao_mat | type: TABLE --
-- DROP TABLE IF EXISTS public.medicao_mat CASCADE;
CREATE TABLE public.medicao_mat (
	cod_material integer NOT NULL,
	cod_medicao integer NOT NULL,
	qtde integer NOT NULL,
	valor decimal(10,2) NOT NULL,
	CONSTRAINT medicao_mat_pk PRIMARY KEY (cod_material,cod_medicao)

);
-- ddl-end --
-- ALTER TABLE public.medicao_mat OWNER TO postgres;
-- ddl-end --

-- object: medicao_fk | type: CONSTRAINT --
-- ALTER TABLE public.medicao_serv DROP CONSTRAINT IF EXISTS medicao_fk CASCADE;
ALTER TABLE public.medicao_serv ADD CONSTRAINT medicao_fk FOREIGN KEY (cod_medicao)
REFERENCES public.medicao (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: servico_fk | type: CONSTRAINT --
-- ALTER TABLE public.medicao_serv DROP CONSTRAINT IF EXISTS servico_fk CASCADE;
ALTER TABLE public.medicao_serv ADD CONSTRAINT servico_fk FOREIGN KEY (cod_servico)
REFERENCES public.servico (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: material_fk | type: CONSTRAINT --
-- ALTER TABLE public.medicao_mat DROP CONSTRAINT IF EXISTS material_fk CASCADE;
ALTER TABLE public.medicao_mat ADD CONSTRAINT material_fk FOREIGN KEY (cod_material)
REFERENCES public.material (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: medicao_fk | type: CONSTRAINT --
-- ALTER TABLE public.medicao_mat DROP CONSTRAINT IF EXISTS medicao_fk CASCADE;
ALTER TABLE public.medicao_mat ADD CONSTRAINT medicao_fk FOREIGN KEY (cod_medicao)
REFERENCES public.medicao (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: public.parcelas_medicao | type: TABLE --
-- DROP TABLE IF EXISTS public.parcelas_medicao CASCADE;
CREATE TABLE public.parcelas_medicao (
	cod serial NOT NULL,
	cod_medicao integer NOT NULL,
	valor decimal(10,2) NOT NULL,
	valor_recebido decimal(10,2),
	data_recebido date,
	data_vencimento date NOT NULL,
	CONSTRAINT parcelas_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.parcelas_medicao OWNER TO postgres;
-- ddl-end --

-- object: medicao_fk | type: CONSTRAINT --
-- ALTER TABLE public.parcelas_medicao DROP CONSTRAINT IF EXISTS medicao_fk CASCADE;
ALTER TABLE public.parcelas_medicao ADD CONSTRAINT medicao_fk FOREIGN KEY (cod_medicao)
REFERENCES public.medicao (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.pedido | type: TABLE --
-- DROP TABLE IF EXISTS public.pedido CASCADE;
CREATE TABLE public.pedido (
	cod smallint NOT NULL,
	cod_fornecedor integer NOT NULL,
	cod_obra integer NOT NULL,
	data_pedido date NOT NULL,
	data_entregue date,
	CONSTRAINT pedir_material_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.pedido OWNER TO postgres;
-- ddl-end --

-- object: fornecedor_fk | type: CONSTRAINT --
-- ALTER TABLE public.pedido DROP CONSTRAINT IF EXISTS fornecedor_fk CASCADE;
ALTER TABLE public.pedido ADD CONSTRAINT fornecedor_fk FOREIGN KEY (cod_fornecedor)
REFERENCES public.fornecedor (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: obra_fk | type: CONSTRAINT --
-- ALTER TABLE public.pedido DROP CONSTRAINT IF EXISTS obra_fk CASCADE;
ALTER TABLE public.pedido ADD CONSTRAINT obra_fk FOREIGN KEY (cod_obra)
REFERENCES public.obra (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.pedido_material | type: TABLE --
-- DROP TABLE IF EXISTS public.pedido_material CASCADE;
CREATE TABLE public.pedido_material (
	cod_material integer NOT NULL,
	cod_pedido smallint NOT NULL,
	quant integer NOT NULL,
	CONSTRAINT pedido_material_pk PRIMARY KEY (cod_material,cod_pedido)

);
-- ddl-end --
-- ALTER TABLE public.pedido_material OWNER TO postgres;
-- ddl-end --

-- object: material_fk | type: CONSTRAINT --
-- ALTER TABLE public.pedido_material DROP CONSTRAINT IF EXISTS material_fk CASCADE;
ALTER TABLE public.pedido_material ADD CONSTRAINT material_fk FOREIGN KEY (cod_material)
REFERENCES public.material (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: pedido_fk | type: CONSTRAINT --
-- ALTER TABLE public.pedido_material DROP CONSTRAINT IF EXISTS pedido_fk CASCADE;
ALTER TABLE public.pedido_material ADD CONSTRAINT pedido_fk FOREIGN KEY (cod_pedido)
REFERENCES public.pedido (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: public.compra | type: TABLE --
-- DROP TABLE IF EXISTS public.compra CASCADE;
CREATE TABLE public.compra (
	cod serial NOT NULL,
	cod_pedido smallint NOT NULL,
	cod_fornecedor integer NOT NULL,
	data_entrega date NOT NULL,
	forma_pagamento varchar(10) NOT NULL,
	valor decimal(10,2) NOT NULL,
	CONSTRAINT compra_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.compra OWNER TO postgres;
-- ddl-end --

-- object: public.parcela_compra | type: TABLE --
-- DROP TABLE IF EXISTS public.parcela_compra CASCADE;
CREATE TABLE public.parcela_compra (
	cod serial NOT NULL,
	cod_compra integer NOT NULL,
	valor decimal(10) NOT NULL,
	valor_pago decimal(10,2),
	date_pago date,
	data_vencimento date NOT NULL,
	CONSTRAINT parcela_compra_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.parcela_compra OWNER TO postgres;
-- ddl-end --

-- object: compra_fk | type: CONSTRAINT --
-- ALTER TABLE public.parcela_compra DROP CONSTRAINT IF EXISTS compra_fk CASCADE;
ALTER TABLE public.parcela_compra ADD CONSTRAINT compra_fk FOREIGN KEY (cod_compra)
REFERENCES public.compra (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: pedido_fk | type: CONSTRAINT --
-- ALTER TABLE public.compra DROP CONSTRAINT IF EXISTS pedido_fk CASCADE;
ALTER TABLE public.compra ADD CONSTRAINT pedido_fk FOREIGN KEY (cod_pedido)
REFERENCES public.pedido (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.compra_material | type: TABLE --
-- DROP TABLE IF EXISTS public.compra_material CASCADE;
CREATE TABLE public.compra_material (
	cod_material integer NOT NULL,
	cod_compra integer NOT NULL,
	valor decimal(10,2) NOT NULL,
	qntd_entregue integer NOT NULL,
	CONSTRAINT compra_material_pk PRIMARY KEY (cod_material,cod_compra)

);
-- ddl-end --
-- ALTER TABLE public.compra_material OWNER TO postgres;
-- ddl-end --

-- object: material_fk | type: CONSTRAINT --
-- ALTER TABLE public.compra_material DROP CONSTRAINT IF EXISTS material_fk CASCADE;
ALTER TABLE public.compra_material ADD CONSTRAINT material_fk FOREIGN KEY (cod_material)
REFERENCES public.material (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: compra_fk | type: CONSTRAINT --
-- ALTER TABLE public.compra_material DROP CONSTRAINT IF EXISTS compra_fk CASCADE;
ALTER TABLE public.compra_material ADD CONSTRAINT compra_fk FOREIGN KEY (cod_compra)
REFERENCES public.compra (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: public.despesa | type: TABLE --
-- DROP TABLE IF EXISTS public.despesa CASCADE;
CREATE TABLE public.despesa (
	cod serial NOT NULL,
	pes_cod_funcionario integer NOT NULL,
	tipo varchar(10) NOT NULL,
	descricao varchar(255) NOT NULL,
	data_lanc date NOT NULL,
	CONSTRAINT despesa_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.despesa OWNER TO postgres;
-- ddl-end --

-- object: funcionario_fk | type: CONSTRAINT --
-- ALTER TABLE public.despesa DROP CONSTRAINT IF EXISTS funcionario_fk CASCADE;
ALTER TABLE public.despesa ADD CONSTRAINT funcionario_fk FOREIGN KEY (pes_cod_funcionario)
REFERENCES public.funcionario (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.parcela_despesa | type: TABLE --
-- DROP TABLE IF EXISTS public.parcela_despesa CASCADE;
CREATE TABLE public.parcela_despesa (
	cod smallint NOT NULL,
	cod_despesa integer NOT NULL,
	valor decimal(10,2) NOT NULL,
	valor_pago decimal(10,2),
	data_pagamento date,
	data_vencimento date NOT NULL,
	CONSTRAINT parecela_despesa_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.parcela_despesa OWNER TO postgres;
-- ddl-end --

-- object: despesa_fk | type: CONSTRAINT --
-- ALTER TABLE public.parcela_despesa DROP CONSTRAINT IF EXISTS despesa_fk CASCADE;
ALTER TABLE public.parcela_despesa ADD CONSTRAINT despesa_fk FOREIGN KEY (cod_despesa)
REFERENCES public.despesa (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.consumo_mat_serv | type: TABLE --
-- DROP TABLE IF EXISTS public.consumo_mat_serv CASCADE;
CREATE TABLE public.consumo_mat_serv (
	cod serial NOT NULL,
	data date NOT NULL,
	cod_obra_tarefa_obra integer NOT NULL,
	cod_tarefa_tarefa_obra integer NOT NULL,
	CONSTRAINT consumo_mat_serv_pk PRIMARY KEY (cod,data)

);
-- ddl-end --
-- ALTER TABLE public.consumo_mat_serv OWNER TO postgres;
-- ddl-end --

-- object: consumo_mat_serv_fk | type: CONSTRAINT --
-- ALTER TABLE public.consumo_material DROP CONSTRAINT IF EXISTS consumo_mat_serv_fk CASCADE;
ALTER TABLE public.consumo_material ADD CONSTRAINT consumo_mat_serv_fk FOREIGN KEY (cod_consumo_mat_serv,data_consumo_mat_serv)
REFERENCES public.consumo_mat_serv (cod,data) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: consumo_mat_serv_fk | type: CONSTRAINT --
-- ALTER TABLE public.consumo_servico DROP CONSTRAINT IF EXISTS consumo_mat_serv_fk CASCADE;
ALTER TABLE public.consumo_servico ADD CONSTRAINT consumo_mat_serv_fk FOREIGN KEY (cod_consumo_mat_serv,data_consumo_mat_serv)
REFERENCES public.consumo_mat_serv (cod,data) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: public.hora_extra | type: TABLE --
-- DROP TABLE IF EXISTS public.hora_extra CASCADE;
CREATE TABLE public.hora_extra (
	cod serial NOT NULL,
	cod_obra integer NOT NULL,
	pes_cod_funcionario integer NOT NULL,
	hora_final time NOT NULL,
	hora_inicial time NOT NULL,
	data date NOT NULL,
	CONSTRAINT hora_extra_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.hora_extra OWNER TO postgres;
-- ddl-end --

-- object: obra_fk | type: CONSTRAINT --
-- ALTER TABLE public.hora_extra DROP CONSTRAINT IF EXISTS obra_fk CASCADE;
ALTER TABLE public.hora_extra ADD CONSTRAINT obra_fk FOREIGN KEY (cod_obra)
REFERENCES public.obra (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: funcionario_fk | type: CONSTRAINT --
-- ALTER TABLE public.hora_extra DROP CONSTRAINT IF EXISTS funcionario_fk CASCADE;
ALTER TABLE public.hora_extra ADD CONSTRAINT funcionario_fk FOREIGN KEY (pes_cod_funcionario)
REFERENCES public.funcionario (pes_cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.categoria_mat | type: TABLE --
-- DROP TABLE IF EXISTS public.categoria_mat CASCADE;
CREATE TABLE public.categoria_mat (
	cod serial NOT NULL,
	descricao varchar(30) NOT NULL,
	CONSTRAINT categoria_mat_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.categoria_mat OWNER TO postgres;
-- ddl-end --

-- object: categoria_mat_fk | type: CONSTRAINT --
-- ALTER TABLE public.material DROP CONSTRAINT IF EXISTS categoria_mat_fk CASCADE;
ALTER TABLE public.material ADD CONSTRAINT categoria_mat_fk FOREIGN KEY (cod_categoria_mat)
REFERENCES public.categoria_mat (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: fornecedor_fk | type: CONSTRAINT --
-- ALTER TABLE public.compra DROP CONSTRAINT IF EXISTS fornecedor_fk CASCADE;
ALTER TABLE public.compra ADD CONSTRAINT fornecedor_fk FOREIGN KEY (cod_fornecedor)
REFERENCES public.fornecedor (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.controle_acesso | type: TABLE --
-- DROP TABLE IF EXISTS public.controle_acesso CASCADE;
CREATE TABLE public.controle_acesso (
	cod serial NOT NULL,
	login varchar(30) NOT NULL,
	senha varchar(30) NOT NULL,
	usuario_ativo bool NOT NULL,
	nivel_acesso integer NOT NULL,
	CONSTRAINT controle_login_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.controle_acesso OWNER TO postgres;
-- ddl-end --

-- object: controle_acesso_fk | type: CONSTRAINT --
-- ALTER TABLE public.funcionario DROP CONSTRAINT IF EXISTS controle_acesso_fk CASCADE;
ALTER TABLE public.funcionario ADD CONSTRAINT controle_acesso_fk FOREIGN KEY (cod_controle_acesso)
REFERENCES public.controle_acesso (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: endereco_fk | type: CONSTRAINT --
-- ALTER TABLE public.pessoa DROP CONSTRAINT IF EXISTS endereco_fk CASCADE;
ALTER TABLE public.pessoa ADD CONSTRAINT endereco_fk FOREIGN KEY (cod_endereco)
REFERENCES public.endereco (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.cargo | type: TABLE --
-- DROP TABLE IF EXISTS public.cargo CASCADE;
CREATE TABLE public.cargo (
	cod serial NOT NULL,
	descricao varchar(30) NOT NULL,
	CONSTRAINT cargo_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.cargo OWNER TO postgres;
-- ddl-end --

-- object: cargo_fk | type: CONSTRAINT --
-- ALTER TABLE public.funcionario DROP CONSTRAINT IF EXISTS cargo_fk CASCADE;
ALTER TABLE public.funcionario ADD CONSTRAINT cargo_fk FOREIGN KEY (cod_cargo)
REFERENCES public.cargo (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.cidade | type: TABLE --
-- DROP TABLE IF EXISTS public.cidade CASCADE;
CREATE TABLE public.cidade (
	cod serial NOT NULL,
	uf_estado varchar(2) NOT NULL,
	nome varchar(30) NOT NULL,
	CONSTRAINT cidade_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.cidade OWNER TO postgres;
-- ddl-end --

-- object: public.estado | type: TABLE --
-- DROP TABLE IF EXISTS public.estado CASCADE;
CREATE TABLE public.estado (
	uf varchar(2) NOT NULL,
	nome varchar(30) NOT NULL,
	CONSTRAINT estado_pk PRIMARY KEY (uf)

);
-- ddl-end --
-- ALTER TABLE public.estado OWNER TO postgres;
-- ddl-end --

-- object: estado_fk | type: CONSTRAINT --
-- ALTER TABLE public.cidade DROP CONSTRAINT IF EXISTS estado_fk CASCADE;
ALTER TABLE public.cidade ADD CONSTRAINT estado_fk FOREIGN KEY (uf_estado)
REFERENCES public.estado (uf) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: cidade_fk | type: CONSTRAINT --
-- ALTER TABLE public.endereco DROP CONSTRAINT IF EXISTS cidade_fk CASCADE;
ALTER TABLE public.endereco ADD CONSTRAINT cidade_fk FOREIGN KEY (cod_cidade)
REFERENCES public.cidade (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: endereco_fk | type: CONSTRAINT --
-- ALTER TABLE public.fornecedor DROP CONSTRAINT IF EXISTS endereco_fk CASCADE;
ALTER TABLE public.fornecedor ADD CONSTRAINT endereco_fk FOREIGN KEY (cod_endereco)
REFERENCES public.endereco (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.status | type: TABLE --
-- DROP TABLE IF EXISTS public.status CASCADE;
CREATE TABLE public.status (
	cod serial NOT NULL,
	descricao varchar(20) NOT NULL,
	CONSTRAINT status_pk PRIMARY KEY (cod)

);
-- ddl-end --
-- ALTER TABLE public.status OWNER TO postgres;
-- ddl-end --

-- object: status_fk | type: CONSTRAINT --
-- ALTER TABLE public.obra DROP CONSTRAINT IF EXISTS status_fk CASCADE;
ALTER TABLE public.obra ADD CONSTRAINT status_fk FOREIGN KEY (cod_status)
REFERENCES public.status (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public.parametro | type: TABLE --
-- DROP TABLE IF EXISTS public.parametro CASCADE;
CREATE TABLE public.parametro (
	cnpj varchar(20) NOT NULL,
	razao varchar(50) NOT NULL,
	fantasia varchar(50) NOT NULL,
	inscricao_estadual varchar(20) NOT NULL,
	cod_contato integer NOT NULL,
	cod_endereco integer,
	logo_menor varchar(100) NOT NULL,
	logo_maior varchar(100) NOT NULL,
	email varchar(50) NOT NULL,
	site varchar(50) NOT NULL,
	CONSTRAINT parametrizacao_pk PRIMARY KEY (cnpj)

);
-- ddl-end --
-- ALTER TABLE public.parametro OWNER TO postgres;
-- ddl-end --

-- object: contato_fk | type: CONSTRAINT --
-- ALTER TABLE public.parametro DROP CONSTRAINT IF EXISTS contato_fk CASCADE;
ALTER TABLE public.parametro ADD CONSTRAINT contato_fk FOREIGN KEY (cod_contato)
REFERENCES public.contato (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: endereco_fk | type: CONSTRAINT --
-- ALTER TABLE public.parametro DROP CONSTRAINT IF EXISTS endereco_fk CASCADE;
ALTER TABLE public.parametro ADD CONSTRAINT endereco_fk FOREIGN KEY (cod_endereco)
REFERENCES public.endereco (cod) MATCH FULL
ON DELETE SET NULL ON UPDATE CASCADE;
-- ddl-end --

-- object: contato_fk | type: CONSTRAINT --
-- ALTER TABLE public.fornecedor DROP CONSTRAINT IF EXISTS contato_fk CASCADE;
ALTER TABLE public.fornecedor ADD CONSTRAINT contato_fk FOREIGN KEY (cod_contato)
REFERENCES public.contato (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: contato_fk | type: CONSTRAINT --
-- ALTER TABLE public.pessoa DROP CONSTRAINT IF EXISTS contato_fk CASCADE;
ALTER TABLE public.pessoa ADD CONSTRAINT contato_fk FOREIGN KEY (cod_contato)
REFERENCES public.contato (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: tarefa_fk | type: CONSTRAINT --
-- ALTER TABLE public.tarefa_obra DROP CONSTRAINT IF EXISTS tarefa_fk CASCADE;
ALTER TABLE public.tarefa_obra ADD CONSTRAINT tarefa_fk FOREIGN KEY (cod_tarefa)
REFERENCES public.tarefa (cod) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: tarefa_obra_fk | type: CONSTRAINT --
-- ALTER TABLE public.consumo_mat_serv DROP CONSTRAINT IF EXISTS tarefa_obra_fk CASCADE;
ALTER TABLE public.consumo_mat_serv ADD CONSTRAINT tarefa_obra_fk FOREIGN KEY (cod_obra_tarefa_obra,cod_tarefa_tarefa_obra)
REFERENCES public.tarefa_obra (cod_obra,cod_tarefa) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: endereco_fk | type: CONSTRAINT --
-- ALTER TABLE public.obra DROP CONSTRAINT IF EXISTS endereco_fk CASCADE;
ALTER TABLE public.obra ADD CONSTRAINT endereco_fk FOREIGN KEY (cod_endereco)
REFERENCES public.endereco (cod) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --


