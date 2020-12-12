CREATE TABLE "EmailAddresses" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"PersonId"	INTEGER NOT NULL,
	"EmailAddress"	TEXT NOT NULL,
	"IsPrimary"	INTEGER NOT NULL CHECK("IsPrimary" IN (0, 1)),
	FOREIGN KEY("PersonId") REFERENCES "People"("Id") ON DELETE CASCADE,
	PRIMARY KEY("Id" AUTOINCREMENT)
)