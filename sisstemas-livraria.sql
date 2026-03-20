CREATE TABLE Clientes (
    ID INT PRIMARY KEY,
    nomeCliente VARCHAR(255),
    emailCliente VARCHAR(255)
);

CREATE TABLE Compras (
    CompraID INT PRIMARY KEY,
    ClienteID INT,
    NomeLivro VARCHAR(255),
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ID)
);

SELECT * FROM Clientes;
-- Inserindo dados na tabela Clientes
INSERT INTO Clientes (ID, nomeCliente, emailCliente)
VALUES 
(1, 'Ana Silva', 'ana.silva@email.com'),
(2, 'Carlos Souza', 'carlos.souza@email.com'),
(3, 'Mariana Oliveira', 'mariana.oliveira@email.com');

-- Inserindo dados na tabela Compras
INSERT INTO Compras (CompraID, ClienteID, NomeLivro)
VALUES
(101, 1, 'Dom Casmurro'),
(102, 2, 'O Pequeno Príncipe'),
(103, 3, '1984'),
(104, 1, 'Memórias Póstumas de Brás Cubas');
