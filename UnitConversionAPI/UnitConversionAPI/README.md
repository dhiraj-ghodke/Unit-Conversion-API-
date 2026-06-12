# Unit Conversion API

## 📌 Overview

This project is an ASP.NET Core Web API that converts values between different units such as length, temperature, and weight.

---

## 🚀 Features

* Convert between units:

  * Length (meter ↔ feet)
  * Temperature (Celsius ↔ Fahrenheit)
  * Weight (kg ↔ pound)
* Clean architecture using Service Layer
* Dependency Injection used
* Swagger UI enabled

---

## 🛠️ Tech Stack

* ASP.NET Core Web API
* C#
* .NET 8

---

## ▶️ How to Run

1. Clone repository:

```
git clone <your-repo-link>
```

2. Navigate to project:

```
cd UnitConversionAPI
```

3. Run project:

```
dotnet run
```

4. Open Swagger:

```
https://localhost:5001/swagger
```

---

## 📡 API Endpoint

### POST /api/conversion

### Request:

```json
{
  "type": "Length",
  "fromUnit": "meter",
  "toUnit": "feet",
  "value": 10
}
```

### Response:

```json
{
  "from": "meter",
  "to": "feet",
  "input": 10,
  "result": 32.8084
}
```

---

## ⚙️ Design Decisions

* Used **Service Layer** for scalability
* Used **Enum** for conversion types
* Used **switch-based logic** for simplicity
* Base unit conversion approach used for flexibility

---

## ⚠️ Future Improvements

* Add database for dynamic unit management
* Add more unit categories
* Add caching for performance
* Add unit validation & better error handling
* Add authentication & logging

---

## 👨‍💻 Author

Dhiraj Ghodke
