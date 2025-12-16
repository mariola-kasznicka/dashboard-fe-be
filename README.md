# Next.js Starter

Modern **fullstack starter** with feature-based architecture, internationalization and JWT authentication.

---

## Stack

**Frontend**

* Next.js (App Router) + React
* TypeScript
* Feature-based architecture
* CSS Modules + SCSS (global mixins)
* Tailwind CSS v3
* shadcn/ui
* Zustand
* next-intl (i18n)

**Backend**

* ASP.NET Core Web API (.NET 8)
* JWT Authentication
* Swagger

**CI**

* GitHub Actions (typecheck, lint, build)

---

## Project Structure

```
repo/
├─ app/            # Next.js app router
│  └─ features/    # dashboard / user / offer
├─ styles/         # SCSS + mixins
├─ lib/            # api, stores
├─ messages/       # i18n translations
├─ backend/        # .NET 8 API
└─ middleware.ts   # i18n routing
```

---

## Running locally

### Frontend

```bash
npm install
npm run dev
```

### Backend

```bash
cd backend
dotnet restore
dotnet run
```

* Frontend: [http://localhost:3000](http://localhost:3000)
* Backend: [http://localhost:5000](http://localhost:5000)
* Swagger: [http://localhost:5000/swagger](http://localhost:5000/swagger)

---

## Auth

* JWT-based authentication
* `/api/auth/login` issues access token
* Token stored in Zustand
* Axios adds `Authorization: Bearer`

---

## i18n

* Locales: `pl`, `en`
* Routes: `/pl`, `/en`
* Configured via `next-intl`

---

This starter is a solid foundation for production-ready SaaS and web applications.
