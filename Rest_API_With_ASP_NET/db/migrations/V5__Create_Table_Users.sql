﻿CREATE TABLE users (
	id BIGINT NOT NULL IDENTITY,
	user_name VARCHAR(50) NOT NULL DEFAULT '0',
	password VARCHAR(130) NOT NULL DEFAULT '0',
	full_name VARCHAR(120) NOT NULL,
	refresh_token VARCHAR(500) NULL DEFAULT '0',
	refresh_token_expiry_time DATETIME NULL DEFAULT NULL,
	PRIMARY KEY (id)
)