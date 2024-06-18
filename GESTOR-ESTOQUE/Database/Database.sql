create database estoque;
use estoque;


CREATE TABLE produto (
id_produto INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
preco int not null
);

CREATE TABLE MovimentacaoEstoque (
    ID_Movimentacao INT PRIMARY KEY, 
    ID_Produto INT,
    TipoMovimentacao NVARCHAR(50),
    QuantidadeMovimentada INT,
    DataMovimentacao DATETIME,
    Observacoes NVARCHAR(255),
    FOREIGN KEY (ID_Produto) REFERENCES Produtos(ID_Produto)
);

CREATE TABLE Fornecedores (
    ID_Fornecedor INT PRIMARY KEY,
    nomeFantasia VARCHAR(100), NOT NULL,
    razaoSocial VARCHAR(100) NOT NULL,
    inscricaoEstadual INT(14) NOT NULL,
    CNPJ INT(14) NOT NULL
);

CREATE TABLE Clientes (
    ID_Cliente INT PRIMARY KEY,
    ID_Pessoa INT NOT NULL,
    FOREIGN KEY (ID_Pessoa) REFERENCES Pessoa(ID_Pessoa) 
);

CREATE TABLE Pessoa(
    ID_Pessoa INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    e_mail VARCHAR(50) NULL,
    telefone VARCHAR(20) NULL, 
    endereco VARCHAR(30) NULL

    );

CREATE TABLE Vendas (
    ID_Venda INT PRIMARY KEY,
    DataVenda DATETIME,
    ID-Produto INT,
    QuantidadeVendida INT,
    PrecoVenda DECIMAL(10, 2),
    ID_Cliente INT,
    FOREIGN KEY (ID_Produto) REFERENCES Produtos(ID_Produto),
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);

CREATE TABLE Compras (
    ID_Compra INT PRIMARY KEY,
    DataCompra DATETIME,
    ID_Produto INT,
    QuantidadeComprada INT,
    PrecoCompra DECIMAL(10, 2),
    ID_Fornecedor INT,
    ID_Cliente INT,
    FOREIGN KEY (ID_Produto) REFERENCES Produtos(ID_Produto),
    FOREIGN KEY (ID_Fornecedor) REFERENCES Fornecedores(ID_Fornecedor),
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);