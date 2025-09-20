# DVLD: Driving & Vehicle License Department

> نظام اصدار وادارة رخص السائقين - Driving License Management System
## Project Overview

The Driving & Vehicle License Department (DVLD) system is designed to manage and issue driving licenses. This system handles various services related to driving licenses including new applications, renewals, replacements, and more.

## Usage

### Main Menu Options

## 🗃️ Database Structure

### Core Tables

1. ***Geographical Data Table***
 
  - Countries: Stores country information
  
  - Governorates: Stores governorate/province information linked to countries
  
  - Cities: Stores city information linked to governorates

2. **Person and User Tables**
 
  - Persons: Stores personal information of individuals
  
  - PersonAddresses: Stores person addresses
  
  - Users: Stores system user data

3. **Process Tables**

  - Applications: Manages license applications
  
  - DrivingLicenseApplications: Specific driver's license applications
  
  - TestTypes: Required test types
  
  - TestAppointments: Test schedules
  
  - Tests: Test results

5. **License and Driver Tables**

  - LicenseClasses: Different driver's license classes
  
  - Drivers: Driver information
  
  - Licenses: Issued driver's license information
  
  - DetainedLicenses: Confiscated licenses

7. **Support Tables**

  - AuditLogs: Change tracking log

## 🔗 Table Relationships
```
  Countries (1) ← (N) Governorates (1) ← (N) Cities
  Persons (1) ← (N) PersonAddresses
  Persons (1) ← (1) Users
  Persons (1) ← (N) Applications
  Applications (1) ← (1) DrivingLicenseApplications
  DrivingLicenseApplications (1) ← (N) TestAppointments
  TestAppointments (1) ← (1) Tests
  Drivers (1) ← (N) Licenses
  Licenses (1) ← (N) DetainedLicenses
```
## 🎯 Key Features

1. **Comprehensive License Management**

  - Track application status (New, In Progress, Completed, Canceled)
  
  - Manage different license classes
  
  - Track issue and expiration dates

2. **Testing System**
 
  - Manage test types (Theory, Practical, Vision)
  
  - Schedule test appointments
  
  - Record results and performance evaluation

3. **Record Management**
 
  - Complete record of detained and released licenses
  
  - Track fines and violations
  
  - Audit trail for system changes

4. **Performance Optimized**
 
  - Enhanced indexes for faster queries
  
  - Computed fields for automatic tracking numbers
  
  - Improved data types for better storage


## Project Structure
```
  DVLD-Project/
  ├── DVLD.BLL/              # Business Logic Layer
  ├── DVLD.DAL/              # Data Access Layer
  ├── DVLD.Entities/         # Entity classes
  ├── DVLD.WindowsForms/     # Windows Forms UI
  ├── DVLD.Reports/          # Crystal Reports
  ├── Database/              # SQL scripts
  └── Tests/                 # Unit tests
```
