-- Table: maininfo

CREATE OR REPLACE FUNCTION mainfo_create

'DROP TABLE maininfo;

CREATE TABLE maininfo
(
  id integer NOT NULL,
  name text NOT NULL,
  CONSTRAINT maininfo_pkey PRIMARY KEY (id)
)
WITH (OIDS=FALSE);
ALTER TABLE maininfo OWNER TO "Dale";
GRANT ALL ON TABLE maininfo TO "Dale";
GRANT SELECT, UPDATE, INSERT, REFERENCES, TRIGGER ON TABLE maininfo TO public;
END;'
LANGUAGE plpgsql;