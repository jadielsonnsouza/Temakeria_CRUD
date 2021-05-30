-- Criar DataBase Temakeria_CRUD
CREATE DATABASE Temakeria_CRUD;

-- Seleciona a DataBase Temakeria_CRUD
USE Temakeria_CRUD;

-- Cria a tabela Pessoa com id, nome, data_nascimento, rg, cpf, id_endereco, id_contato, tipo_pessoa
CREATE TABLE Pessoa(
	id INT PRIMARY KEY IDENTITY NOT NULL,
	nome VARCHAR(50) NOT NULL,
	data_nascimento  date,
	rg VARCHAR(9) NOT NULL,
	cpf VARCHAR(11) NOT NULL,
	id_endereco INT NOT NULL,
	id_contato INT NOT NULL,
	tipo_pessoa VARCHAR(20) NOT NULL
);

-- Cria a tabela Endereco com id, rua, numero, complemento, bairro, cidade, estado 
CREATE TABLE Endereco(
	id INT PRIMARY KEY IDENTITY NOT NULL,
	rua	VARCHAR(50) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	complemento VARCHAR(20),
	bairro VARCHAR(50) NOT NULL,
	cidade VARCHAR(50) NOT NULL,
	estado VARCHAR(50) NOT NULL
);

-- Cria a tabela Contato com id, celular, telefone, email 
CREATE TABLE Contato(
	id INT PRIMARY KEY IDENTITY NOT NULL,
	celular VARCHAR(11) NOT NULL,
	telefone VARCHAR(11),
	email VARCHAR(100) NOT NULL
);

-- Adiciona chave estrangeira da tabela Endereco na tabela Pessoa
ALTER TABLE Pessoa
ADD CONSTRAINT fk_endereco FOREIGN KEY (id_endereco) REFERENCES Endereco (id);

-- Consulta de todas as colunas da tabela Pessoa
select * from Pessoa;