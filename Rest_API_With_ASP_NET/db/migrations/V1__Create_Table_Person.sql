if not exists (select * from sysobjects where name = 'person' and xtype = 'U') 
CREATE TABLE person (
  id bigint NOT NULL identity,
  address varchar(100) NOT NULL,
  first_name varchar(80) NOT NULL,
  gender varchar(6) NOT NULL,
  last_name varchar(80) NOT NULL,
  enabled bit not null
  PRIMARY KEY (id)
) 
