# South African Registration System

A full-stack web application built using **Blazor WebAssembly** for the frontend and **ASP.NET Core Web API** for the backend. This system facilitates secure user registration and is designed following best practices for maintainable enterprise applications.

## 🧩 Key Features

- 📝 **User Registration** – capture and persist user data via a clean registration interface
- 🖥️ **Blazor WebAssembly Frontend** – modern, single-page experience using C# and Razor
- 🔐 **Entity Framework Core** – code-first database schema with migration support
- 📦 **Clean Architecture** – layered backend with services and controllers
- 🌐 **RESTful API** – interacts with frontend through HTTP requests

## 🧰 Tech Stack

- **Frontend:** Blazor WebAssembly (.NET)
- **Backend:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Project Type:** Multi-project solution (`Client`, `Server`, `Shared`)
- **IDE:** Visual Studio 2022 or later

## 📁 Solution Structure

- `SouthAfricanRegistration.Client/` – Blazor WebAssembly frontend
- `SouthAfricanRegistration.Server/` – ASP.NET Core backend
- `Shared/` – shared DTOs and models between Client and Server

## 🛠️ Setting Up the Database

1. Update your connection string in `appsettings.json` inside the `SouthAfricanRegistration.Server` project.
2. Run the following command to apply the database migration:
    ```bash
    dotnet ef database update --project SouthAfricanRegistration.Server
    ```

> **Note:** Ensure the Entity Framework tools are installed (`dotnet tool install --global dotnet-ef`).

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/SphiweNdou/SouthAfricanRegistration.git
   cd SouthAfricanRegistration
   ```

2. **Open the solution in Visual Studio**
   - File → Open → Project/Solution → Select `SouthAfricanRegistration.sln`

3. **Run the solution**
   - Start the solution with IIS Express or `dotnet run` from both Server and Client folders.

4. **Access the app**
   - Navigate to `https://localhost:5001` or the assigned port.

## 🖼️ User Interface

- **Registration Page:** Found at `/Register`
- **Functionality:** Form inputs for user details → submit → sends data to backend API → saves to database

## 👨‍💻 Author

**Sphiwe Ndou**  
Software Developer 
GitHub: [@SphiweNdou](https://github.com/SphiweNdou)  

