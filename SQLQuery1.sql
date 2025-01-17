﻿CREATE TABLE EVENTO(
ID             UNIQUEIDENTIFIER  NOT NULL,--UNIQUEIDENTIFIER(GUID) = IDENTIFICADOR ÚNICO-- 
NOME           NVARCHAR(150)     NOT NULL,-- NOT NULL = Ñ ACEITA CAMPO VAZIO--
DATA           DATE              NOT NULL,--
HORA           TIME              NOT NULL,
DESCRICAO      NVARCHAR(500)     NOT NULL,
PRIORIDADE     INTEGER           NOT NULL,-- INTERGER = TIPO INTEIRO
DATAINCLUSAO   DATETIME          NOT NULL, -- DATA E HORA--
DATAALTERACAO  DATETIME          NOT NULL,
ATIVO          INTEGER           NOT NULL  DEFAULT (1), -- EXCLUSÃO LOGICA,P/ NÃO DELETAR O REGISTRO--
PRIMARY KEY(ID))
GO
DROP TABLE EVENTO
select * from evento