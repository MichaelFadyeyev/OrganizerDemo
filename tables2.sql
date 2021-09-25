--CREATE TABLE [Passwords] (
--	Id int NOT NULL identity,
--	Password nvarchar(100) NOT NULL UNIQUE,
--  CONSTRAINT [PK_PASSWORDS] PRIMARY KEY CLUSTERED
--  (
--  [Id] ASC
--  ) WITH (IGNORE_DUP_KEY = OFF)

--)
--GO
--CREATE TABLE [Tasks] (
--	Id int NOT NULL identity,
--	Name nvarchar(100) NOT NULL,
--	Info nvarchar(500) NOT NULL,
--	Date date NOT NULL,
--	Time time NOT NULL,
--	IsDone bit NOT NULL,
--	Flagged bit NOT NULL,
--	CategoryId int NOT NULL,
--  CONSTRAINT [PK_TASKS] PRIMARY KEY CLUSTERED
--  (
--  [Id] ASC
--  ) WITH (IGNORE_DUP_KEY = OFF)

--)
--GO
--CREATE TABLE [Reminders] (
--	Id int NOT NULL identity,
--	TasksId int NOT NULL,
--  CONSTRAINT [PK_REMINDERS] PRIMARY KEY CLUSTERED
--  (
--  [Id] ASC
--  ) WITH (IGNORE_DUP_KEY = OFF)

--)
--GO
--CREATE TABLE [Categories] (
--	Id int NOT NULL identity,
--	Name nvarchar(100) NOT NULL,
--  CONSTRAINT [PK_CATEGORIES] PRIMARY KEY CLUSTERED
--  (
--  [Id] ASC
--  ) WITH (IGNORE_DUP_KEY = OFF)

--)
--GO

--ALTER TABLE [Tasks] WITH CHECK ADD CONSTRAINT [Tasks_fk0] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
--ON UPDATE CASCADE
--GO
--ALTER TABLE [Tasks] CHECK CONSTRAINT [Tasks_fk0]
--GO

--ALTER TABLE [Reminders] WITH CHECK ADD CONSTRAINT [Reminders_fk0] FOREIGN KEY ([TasksId]) REFERENCES [Tasks]([Id])
--ON UPDATE CASCADE
--GO
--ALTER TABLE [Reminders] CHECK CONSTRAINT [Reminders_fk0]
--GO

