# Dot Net Core Web API Boilerplate

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [License](#license)

## Introduction

The **Dot Net Core Web API Boilerplate** is a starter template for building RESTful Web APIs using .NET Core. It provides a basic project structure with essential features and best practices to help you kickstart your API development.


## Features

- authentication and authorization.
- Sample controllers, models, and services.
- Logging setup.
- Dependency injection.
- Swagger for API documentation.
- Docker support.
- Unit testing using MSTest or NUnit.
- Full integration testing using Selenium

## Production System Architecture

![Project Logo](.\project_plan\architecture.drawio.png)

## Database
Following is the example of the one table that we currently are trying to expose via the API endpoint.
Ideally, when we add user authentication and permission level related tables, we would like to update this table to also include the ID of the user inserting or updating the entries in this table, too.
```postgresql
CREATE TABLE public.global_settings
(
	id SERIAL NOT NULL,
        group_name TEXT NOT NULL CONSTRAINT group_length CHECK (char_length(group_name) > 0),
        key_name TEXT NOT NULL CONSTRAINT key_length CHECK (char_length(key_name) > 0),
        key_value TEXT,
        timestamp TIMESTAMPTZ,
        comments TEXT,
    PRIMARY KEY (id)
)
WITH ( OIDS = FALSE );
ALTER TABLE public.global_settings OWNER TO postgres;
CREATE INDEX global_settings_group_key_time_index ON global_settings(group_name, key_name, timestamp);

-- This row indictes the schema version of the database.
INSERT INTO global_settings (group_name, key_name, key_value, timestamp, comments)
VALUES ('registry','schema_version','1.6.2023',NOW(),'Database created using Init script');
```
## API Endpoints

getDatabaseVersion()
```postgresql
SELECT * FROM global_settings
WHERE group_name = 'registry' AND key_name = 'schema_version'
ORDER BY timestamp DESC
```
getTimezone()
```postgresql
SELECT * FROM global_settings
WHERE group_name = 'registry' AND key_name = 'site_time_zone'
ORDER BY timestamp DESC
```
setTimezone()
```postgresql
INSERT INTO global_settings (group_name, key_name, key_value, timestamp, comments)
VALUES ('registry','site_time_zone',NewTimeZone,NOW(),CommentMessage);
```
### License

This project is open-source and is available under the **MIT License**. You are free to use, modify, and distribute this boilerplate for your projects. For full details, please read the [LICENSE](LICENSE) file.