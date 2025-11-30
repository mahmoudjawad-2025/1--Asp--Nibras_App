# 🎓 Nibras Learning Platform — ASP.NET Core API

A clean, scalable **3-layer architecture** (DAL → BLL → PL) with generic CRUD, JWT authentication, student progress tracking, and file upload services.

---


## 📌 Table of Contents
- [🚀 Overview](#-overview)
- [📐 Architecture](#-architecture)
- [📁 Project-Structure](#-project-structure)
- [🔑 Authentication Flow](#-authentication-flow)
- [🧩 Key Features](#-key-features)
- [🛠 Technologies](#-technologies)
- [📦 How to Run](#-how-to-run)
- [🗂 Services](#-services)
- [📘 API Documentation](#-api-documentation)
- [📞 Contact](#-contact)


---




## 🚀 Overview
The **Nibras API** powers a modern learning platform with:
- Student progress tracking  
- Courses and lesson management  
- Secure JWT login  
- Generic repository & service pattern  
- File uploading module  

---




## 📐 Architecture


### **1️⃣ DAL — Data Access Layer**
- EF Core models  
- DbContext  
- Generic & specific repositories  


### **2️⃣ BLL — Business Logic Layer**
- AuthenticationService  
- GenericService  
- FileService  
- UserProgressService  
- DTOs  


### **3️⃣ PL — Presentation Layer**
- Controllers  
- Routing  
- Response models  

---




## 📁 Project Structure

```plaintext
Nibras.API
│
├── DAL
│   ├── Entities
│   ├── Repositories
│   └── NibrasDbContext.cs
│
├── BLL
│   ├── Services
│   │   ├── AuthenticationService.cs
│   │   ├── GenericService.cs
│   │   ├── UserProgressService.cs
│   │   └── FileService.cs
│   ├── DTOs
│
├── PL
│   └── Controllers
│
├── Program.cs
└── appsettings.json

```




## 🔑 Authentication Flow

Login → access token + refresh token
Refresh token stored in DB
Revoked tokens stored in-memory
Token validation handled by middleware




## 🧩 Key Features

✨ Secure JWT authentication
✨ Generic CRUD for all entities
✨ Track student progress
✨ Upload files
✨ Clean and scalable 3-layer architecture




## 🛠 Technologies

ASP.NET Core 8
Entity Framework Core
MS SQL Server
AutoMapper
Dependency Injection




## 📦 How to Run
1️⃣ Update Connection String
"ConnectionStrings": {
  "DefaultConnection": "your-connection"
}

2️⃣ Apply migrations
update-database

3️⃣ Run the API
dotnet run

4️⃣ Open Swagger
https://localhost:{port}/swagger/index.html




## 🗂 Services
Service	Description
AuthenticationService	Login, refresh, revoke
GenericService	CRUD operations
UserProgressService	Track lessons
FileService	Upload files




## 📘 API Documentation
[To see the api document of this project click here](./docs/Api_Document.md)






## 📞 Contact

📧 mahmoudjawad02025@gmail.com

🔗 GitHub: [mahmoudjawad-2025](https://github.com/mahmoudjawad-2025/)
