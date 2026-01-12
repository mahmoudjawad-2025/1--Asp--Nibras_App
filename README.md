# 🎓 Nibras Learning Platform — ASP.NET Core API

A clean, scalable **3-layer architecture** (DAL → BLL → PL) with generic CRUD, JWT authentication, student progress tracking, and file upload services.

![.NET](https://img.shields.io/badge/.NET-9.0-blue)
![Build](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-green)


<hr>
<br>


## 📌 Table of Contents
- [🚀 Overview](#-overview)
- [📐 Architecture](#-architecture)
- [🧩 Key Features](#-key-features)
- [🚀 Tech Stack](#-tech-stack)
- [📁 Project Structure](#-project-structure)
- [🔑 Authentication Flow](#-authentication-flow)
- [📦 API Modules](#-api-modules)
- [❌ Error Handling](#-error-handling)
- [⚙️ Getting Started](#-getting-started)
- [🔐 Environment Variables](#-environment-variables)
- [📘 API Documentation](#-api-documentation)
- [📞 Contact](#-contact)





















<br>
<hr>
<br>






















## 🚀 Overview
The **Nibras API** powers a modern learning platform with:
- Student progress tracking  
- Courses and lesson management  
- Secure JWT login  
- Generic repository & service pattern  
- File uploading module
- And other features ...

<br>

## 🧩 Key Features
* ✨ Secure JWT authentication 
* ✨ Generic CRUD for all entities
* ✨ Track student progress
* ✨ Upload files
* ✨ Clean and scalable 3-layer architecture

<br>

## 🚀 Tech Stack
* ASP.NET Core 9
* Entity Framework Core
* SQL Server
* JWT Authentication
* Dependency Injection
* Swagger / OpenAPI

<br>

## 📐 Architecture
This project follows a **3-Layer Architecture**:
```
PL  → Controllers / API
BLL → Business Logic & Services
DAL → Data Access (EF Core + Repositories)
```
Each layer is **fully isolated** and communicates via **interfaces only**.

<br>

## 📁 Project Structure
```plaintext
Nibras.API
│
├── DAL
│   ├── Data_Base
│   │   ├── Migrations
│   │   ├── ApplicationDbContext.cs
│   ├── Models
│   │   ├── DTO
│   │   ├── Entities
│   │   ├── Enums
│   │   ├── JsonModels
│   ├── Utils
│   └── Repositories
│       ├── Interfaces
│       └── Classes
│
├── BLL
│   └── Services
│       ├── Interfaces
│       └── Classes
│
└── PL
    ├── Areas (Controllers)
    │   ├── Admin
    │   ├── Identity
    |   └── Student
    ├── PL_Utils
    ├── appsettings.json
    └── Program.cs

```






















<br>
<hr>
<br>





















## 🔑 Authentication Flow

Authentication is implemented using **JWT Bearer Tokens**.

```
Authorization: Bearer <token>
```

Login → JWT access token  
Revoked tokens stored in-memory  
Custom middleware blocks revoked tokens  
Token validation handled via JWT Bearer middleware  

<br>

## 📦 API Modules

* Authentication
* Hadith
* Thlkr
* Category
* Course
* Lesson
* Quiz
* Quran
* User
* UserProgress

<br>

## ❌ Error Handling

* Centralized exception handling
* Standard HTTP status codes
* Consistent response format

```json
{
  "message": "Validation failed"
}
```




















<br>
<hr>
<br>




















## ⚙️ Getting Started

### Prerequisites
- .NET SDK 9.0
- SQL Server
- Visual Studio 2022+

### Installation
git clone ...
dotnet restore

### Database Setup
update-database

### Run Application
dotnet run

### API Access
https://localhost:{port}/swagger

<br>

## 🔐 Environment Variables

Configure the following in `appsettings.json` or environment variables:

| Key                                   | Description                  |
|--------------------------------------|------------------------------|
| ConnectionStrings:DefaultConnection  | SQL Server connection string |
| jwtOptions:SecretKey                 | JWT signing secret key       |




















<br>
<hr>
<br>



















## 📘 API Documentation
[To see the api document of this project click here](./Docs/Api_Document.md)

<br>

## 📞 Contact

📧 mahmoudjawad02025@gmail.com

🔗 GitHub: [mahmoudjawad-2025](https://github.com/mahmoudjawad-2025/)
