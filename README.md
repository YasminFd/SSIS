# Data Injection ETL Project

## Overview

This project demonstrates an efficient ETL (Extract, Transform, Load) process that consolidates scattered data from TXT files into a centralized SQL Server database. The solution combines multiple components including database creation scripts, a management application, and an SSIS project to extract, transform, and load data.

## Project Structure

The project is organized into five main directories:

1. **Source**  
   - Contains TXT files with the required data.
  
2. **SQL Scripts**
   - SQL scripts to create the database schema.
  
3. **The StockManagementSystem**
   - ASP.NET MVC application for managing the database.

4. **Destination**  
   - Contains TXT files used to store the exported data after processing.

5. **IntegrationServices**  
   - Contains the SSIS project which handles the ETL process (extracting, transforming, and loading data). Also task to export relative data back to txt file in destination


## How It Works

1. **Database Creation and Management**  
   - Run the SQL scripts found in the **Source** directory to create and configure your local SQL Server database.

2. **ETL Process**  
   - The SSIS project in the **IntegrationServices** directory manages the ETL process.
   - Data is extracted from the TXT files in the **Source** directory, transformed to meet the database schema, and then loaded into the SQL Server database.

3. **Data Export**  
   - After processing, data is exported into TXT files located in the **Destination** directory.

4. **Data Management**
   - Use the StockManagementSystem ASP.NET MVC application to manage the database and perform CRUD operations.

## Setup Instructions

1. **Database Setup**  
   - Execute the SQL scripts from the **Source** directory using SQL Server Management Studio (SSMS) to create the necessary database schema.

2. **ETL Process Execution**  
   - Open the SSIS project in the **IntegrationServices** directory using SQL Server Data Tools (SSDT).
   - Verify the connection managers and package configurations.
   - Run the ETL packages to inject data into the database.

3. **Application Setup**  
   - Open the StockManagementSystem ASP.NET MVC application in Visual Studio.
   - Update the connection string in the configuration file (`web.config` or `appsettings.json`) to point to your local SQL Server instance.
   - Build and run the application to manage the database.

## Future Enhancements

- **Automation**: Schedule the ETL process to run automatically.
- **Error Handling**: Enhance logging and error handling for improved reliability.
- **Data Validation**: Strengthen data transformation rules to ensure higher data quality.
  
## Acknowledgments

- [Microsoft SSIS](https://docs.microsoft.com/en-us/sql/integration-services/ssis-overview)
- [ASP.NET MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
