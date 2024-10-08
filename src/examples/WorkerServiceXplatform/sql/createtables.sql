CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

-- DROP TABLE "WorkerServiceLogs";

CREATE TABLE IF NOT EXISTS "WorkerServiceLogs" (
    "Id" bigint NOT NULL GENERATED BY DEFAULT AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    "Uid" text NOT NULL DEFAULT uuid_generate_v4(),
    "MessageType" text NOT NULL DEFAULT 'DBG',
    "Message" text NOT NULL,
    "StackTrace" text,
    "ModuleName" text,
    "DateCreated" timestamp with time zone DEFAULT NOW()
);