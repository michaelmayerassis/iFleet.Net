INSERT INTO empresa (Nome,Cnpj,Telefone,Email,Endereco,Numero,Cidade,Bairro,senha)
VALUES('ControlCar', '65939349000139', '1600000000', 'controcal@gmail.com', 'Rua dos Alfaiates', '123', 'Ribeirão Preto', 'Nova Alfaiate', '12345');

INSERT INTO motorista (Cpf,Nome,Cnh,Categoria_Cnh,Dt_Nascimento,Exame_Medico,Email,Endereco,Numero,Cidade,Bairro,Cep)
VALUES('48214525020','Moase Blanco','85517799087', 'C','1980-01-25','S','moase@live.com','Rua dos Pinos', '90','Pitanguariba', 'SEM', '08660236'),
('95882258847','Sorandir Nunes','98900522072', 'C','1970-11-06','S','sorandir@live.com','Avenida Manoel dos Santos', '9090','Jaboticabal', 'Jardim Bela Vista', '14883214');


INSERT INTO veiculo (Empresa_Id,Nome,Marca,Modelo,Cor,Renavan,Placa,Ano)
VALUES(1, 'Deville', 'Cadillac', 'Deville/Eldorado 4.9', 'Prata', '61764599412', 'EOI0711', '1991'),
(1, 'C-280', 'Mercedes-Benz', 'C-280 Classic/Sport', 'Laranja', '93077578660', 'DYD6641', '2015');

INSERT INTO peca (Nome,Descricao,Prateleira,Quantidade,valor,EstoqueMinimo)
VALUES('Parafuso', 'Um parafuso usado para parafusar uma porta', 'A12', 500, 12.50, 100),
('Porta', 'Porta para carro', 'Z223', 200,500.00,10)
('Roda', 'Roda para carros da marca BMW', 'D009', 330, 120.90, 20);