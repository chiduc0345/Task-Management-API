# 📌 Task Management API

A backend RESTful API built with **ASP.NET Core** for managing tasks with JWT authentication and role-based access control.

---

## 🚀 Tech Stack

- ASP.NET Core Web API  
- ADO.NET (SQL Server)  
- SQL Server  
- JWT Authentication  
- Swagger (OpenAPI)  
- C#  

---

## ✨ Features

### 🔐 Authentication
- User registration  
- User login  
- JWT token-based authentication  

### 👤 Authorization
- Secure endpoints using JWT  
- Role-based access control (User / Admin)  

### 📋 Task Management
- Create task  
- Get all tasks  
- Get task by ID  
- Update task  
- Delete task  
- Search tasks  
- Filter tasks  

---

## 🧱 Architecture

Controller → DAO → Database  

Lightweight layered architecture for learning and maintainability.

---

## ⚙️ Setup Instructions

### 1. Clone repository

```bash
git clone https://github.com/chiduc0345/Task-Management-API.git
cd Task-Management-API
```

---

### 2. Configure database (SQL Server)

Update `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=quanlycongviec;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

### 3. Configure JWT

```json
"Jwt": {
  "Key": "your_secret_key_here",
  "Issuer": "TaskAPI"
}
```

---

### 4. Run project

```bash
dotnet restore
dotnet run
```

---

### 5. Swagger UI

Open in browser:

```
https://localhost:5001/swagger
```

---

## 📌 Notes

- Project dùng ADO.NET (không dùng Entity Framework)
- Phù hợp luyện backend cơ bản + JWT
- Có thể nâng cấp lên:
  - Service layer
  - Repository pattern
  - Refresh token

---

## 👨‍💻 Author

- GitHub: https://github.com/chiduc0345
