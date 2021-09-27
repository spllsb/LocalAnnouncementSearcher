--liquibase formatted sql

--changeset lukbuj:1
CREATE TABLE public.announcement (
	id uuid NOT NULL,
	title varchar NOT NULL,
	description varchar NULL,
	last_refresh_time timestamp NOT NULL,
	add_at timestamp NOT NULL,
	CONSTRAINT announcement_pk PRIMARY KEY (id)
);
