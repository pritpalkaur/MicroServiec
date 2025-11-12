# MicroServiec
.net core microService with ocelot getway and jwt auth
for ocelot getway ........repo is https://github.com/pritpalkaur/APIGateway

# ⚙️ Microservices Architecture

This repository contains a suite of microservices built using .NET Core, designed to work together as part of a scalable backend system. The solution includes an API Gateway and multiple domain-specific services.

---

## 🌐 Overview

This solution follows a microservices architecture pattern, where each service is independently deployable and responsible for a specific business domain. The services communicate via HTTP APIs and are orchestrated through an API Gateway.

---

## 🏗️ Projects

- **ApiGateWay**  
  Central routing service that forwards requests to appropriate microservices. Handles authentication, logging, and request aggregation.

- **ProductMicroservice**  
  Manages product catalog, inventory, and related operations. Connects to SQL Server for data persistence.

- **UserService**  
  Handles user registration, authentication, and profile management. Integrates with Oracle DB.

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/pritpalkaur/nodejsMicroservice.git
cd nodejsMicroservice
