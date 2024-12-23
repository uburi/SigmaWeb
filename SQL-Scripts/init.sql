USE master;
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SigmaDB')
    BEGIN
        CREATE DATABASE SigmaDB;
END
GO

USE SigmaDB;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PESSOA')
BEGIN
    CREATE TABLE PESSOA (
        PESSOA_ID INT PRIMARY KEY IDENTITY(1,1),
        NOME_FANTASIA VARCHAR(255),
        CNPJ_CPF VARCHAR(20)
    );

        
    INSERT INTO PESSOA (NOME_FANTASIA, CNPJ_CPF)
    VALUES ('Gerson da Silva', '22180094558'),
        ('Maria Fernandes', '07704761552'),
        ('Maria Clara', '93288390507'),
        ('Alex Poatan', '06941561599'),
        ('Carlos Silva', '13970565502'),
        ('Shelby LTDA', '59057982000109'),
        ('Forbes', '85646032000111'),
        ('Mansão Maromba', '50779210000106'),
        ('Murilo Benicio', '07704761552'),
        ('Carlos Prates', '81757555200');
END
GO
