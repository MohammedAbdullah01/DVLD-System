# DVLD: Driving & Vehicle License Department

> نظام اصدار وادارة رخص السائقين - Driving License Management System
## Project Overview

The Driving & Vehicle License Department (DVLD) system is designed to manage and issue driving licenses. This system handles various services related to driving licenses including new applications, renewals, replacements, and more.

## 🗃️ Database Structure

The system provides the following services, each with a base application fee of $5:

1. **New License Issuance** - Issue a new driving license
2. **Re-examination Service** - Schedule and conduct re-examinations
3. **License Renewal** - Renew existing licenses
4. **Lost License Replacement** - Issue replacement for lost licenses
5. **Damaged License Replacement** - Issue replacement for damaged licenses
6. **License Hold Release** - Release a held/suspended license
7. **International License Issuance** - Issue international driving licenses

## Application Process

To receive any service, applicants must submit an application and pay the required fees.

### Application Information:
- Application Number
- Application Date
- Person ID (Applicant): Searched by National ID; if not found in the system, the user must add this person first
- Application Type (from the list above)
- Application Status (New, Cancelled, Completed)
- Application Fees Paid
- For new license applications:
  - License class must be specified
  - System verifies the applicant doesn't already have a license of the same class
- System verifies the applicant doesn't have a previous incomplete application of the same type

Each application is linked to a person in the system, and each person can have multiple applications.

## Applicant Information

The system stores the following information for each applicant:
- National ID
- Full Name (4 parts)
- Date of Birth
- Address
- Phone Number
- Email
- Nationality
- Personal Photo

## License Classes

The system supports the following license classes:

1. **Class 1: Small Motorcycles**
   - For small capacity and limited power motorcycles
   - Minimum age: 18 years
   - License fee: $15 (plus application fee)
   - Validity: 5 years

2. **Class 2: Heavy Motorcycles**
   - For large and powerful motorcycles
   - Minimum age: 21 years
   - License fee: $30 (plus application fee)
   - Validity: 5 years

3. **Class 3: Standard Driving License (Car)**
   - For light vehicles and personal cars
   - Minimum age: 18 years
   - License fee: $20 (plus application fee)
   - Validity: 10 years

4. **Class 4: Commercial License (Taxi/Limousine)**
   - For taxi or limousine driving
   - Minimum age: 21 years
   - License fee: $200 (plus application fee)
   - Validity: 10 years

5. **Class 5: Agricultural Vehicle License**
   - For agricultural vehicles like tractors
   - Minimum age: 21 years
   - License fee: $50 (plus application fee)
   - Validity: 10 years

6. **Class 6: Small and Medium Buses**
   - For small and medium-sized buses
   - Minimum age: 21 years
   - License fee: $250 (plus application fee)
   - Validity: 10 years

7. **Class 7: Trucks and Heavy Vehicles**
   - For trucks and heavy vehicles like large buses and trucks
   - Minimum age: 21 years
   - License fee: $300 (plus application fee)
   - Validity: 10 years

### License Class Information:
- LicenseClassID
- ClassName
- ClassDescription
- MinimumAllowedAge
- ValidityLength (years)
- ClassFees

## Application Requirements

To apply for a driving license:

1. **Age Requirement**: Applicant must meet the minimum age for the requested license class
2. **Existing License Check**: Applicant must not already have the same class of license
3. **Multiple Licenses**: Applicants can obtain multiple licenses of different classes
4. **Personal Documents**: Valid personal identity documents such as passport or national ID
5. **Education and Training**: Certificate of completion of driving training courses
6. **Tests**: Must pass all of the following tests in sequence:

   a. **Vision Test**:
   - Schedule an appointment and pay the fee ($10)
   - Record results (pass/fail) in the system
   - If failed, applicant must correct vision and schedule another test

   b. **Theoretical Test**:
   - Schedule after passing vision test and pay fee ($20)
   - Paper-based test outside the system
   - Record results and score out of 100 in the system
   - If failed, applicant must schedule another test and pay again

   c. **Practical Driving Test**:
   - Schedule after passing theoretical test and pay fee (varies by license class)
   - If failed, applicant must schedule another test and pay again

## License Issuance

After passing all tests and meeting all requirements, a driving license is issued with:

- License Number
- License Holder's Photo
- License Holder's National ID
- License Holder's Name
- License Holder's Date of Birth
- License Class
- Issue Date
- Expiry Date
- License Conditions (notes)
- License Issue Status (New, Lost Replacement, Damaged Replacement, Renewal)

The system allows querying licenses held by a person via their national ID or license number.

Once a license is issued to a person, they become an official driver in the system with an assigned number. This is added once, and all future licenses are linked to this driver record.

## Detailed Service Descriptions

### 1. New License Issuance
- Applicant applies for a specific license class
- Must meet age requirements for the class
- Must not already have the same license class
- Can have multiple licenses of different classes
- Must pass vision, theoretical, and practical tests

### 2. Re-examination Service
- Allows scheduling a new test appointment for a failed test
- Applicant must have failed the test to be eligible for retaking
- Fee: $5 plus the test fee for the license class
- Appointments are scheduled manually in the system
- New application number linked to the original application
- Cannot schedule two appointments for the same test

### 3. License Renewal
- Fee: $10 for application
- Must pass vision test (appointment required, fee applies)
- Must surrender expired license to renew

### 4. Lost License Replacement
- System verifies the license is not on hold
- Fee: $20 for application

### 5. Damaged License Replacement
- Applicant must surrender damaged license
- Fee: $20 for application
- System records the date of damaged license replacement

### 6. License Hold Release
- Allows releasing a license hold after paying fines
- Returns license to the holder
- Records release date in the system

### 7. International License Issuance
- Issues international license with system-defined validity period
- Only available for Class 3 (standard car) license holders
- License must not be expired or on hold
- Fee: $20
- Cannot issue if valid international license exists; old one is canceled, and new one issued
- System stores all previously issued licenses

## System Administration

### 1. User Management
The system allows management of system users:
- Add user (linked to a person in the system)
- View user information
- Edit user information
- Delete user
- Freeze user account
- Assign permissions to users

User information includes:
- National ID
- Full Name (4 parts)
- Date of Birth
- Address
- Phone Number
- Email
- Nationality
- Personal Photo
- Username
- Password

### 2. People Management
The system allows:
- Search for a person by national ID
- View person information
- Add new person
- Edit person information
- Delete person
- No duplicate entries with the same national ID

Person information includes:
- National ID
- Full Name (4 parts)
- Date of Birth
- Address
- Phone Number
- Email
- Nationality
- Personal Photo

### 3. Application Management
The system allows:
- Search for application by application number
- Search for applications by person's national ID
- View application list
- View application details including prices
- Edit application information
- Filter applications by status

### 4. Test Management
Tests are fixed in the system, but the system allows editing of prices.

### 5. License Class Management
License classes are fixed in the system, but the system allows editing of:
- Age requirements
- License validity period
- License fees

### 6. License Hold
This feature allows:
- Placing a hold on licenses
- Specifying license number, fine amount, hold reason, and hold date

In all system activities, the system must record the user who performed the action and the date of the action.

---

## Technology Stack

### Frontend
- Windows Forms (.NET Framework)
- C# for application logic
- Crystal Reports for reporting

### Backend
- Microsoft SQL Server for database management
- ADO.NET for data access layer
- Entity Framework (optional) for ORM capabilities

### Development Tools
- Visual Studio 2022
- SQL Server Management Studio
- Git for version control

### Architecture
- 3-tier architecture:
  - Presentation Layer (Windows Forms)
  - Business Logic Layer (C# classes)
  - Data Access Layer (SQL Server)

## Getting Started

### Prerequisites
- Windows 10 or higher
- .NET Framework 4.8 or higher
- SQL Server 2019 or higher
- Visual Studio 2019/2022 with the following workloads:
  - .NET desktop development
  - Data storage and processing

### Installation
1. Clone the repository
```
git clone https://github.com/yourusername/DVLD-Project.git
```

2. Open the solution file in Visual Studio

3. Restore NuGet packages

4. Set up the database:
   - Run the SQL scripts in the `Database` folder
   - Update the connection string in `App.config`

5. Build and run the application

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
