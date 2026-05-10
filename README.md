# 🛍️ سوقنا — Souqna Marketplace

<div align="center">

![Souqna Banner](https://img.shields.io/badge/سوقنا-Local%20Marketplace-e94560?style=for-the-badge&logo=shopify&logoColor=white)

**منصة التسوق المحلي الأولى — Local E-Commerce Platform**

[![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![Angular](https://img.shields.io/badge/Angular_17-DD0031?style=flat-square&logo=angular&logoColor=white)](https://angular.io)
[![SignalR](https://img.shields.io/badge/SignalR-Real--Time-0078d4?style=flat-square&logo=microsoft&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/signalr)
[![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![JWT](https://img.shields.io/badge/JWT-Auth-000000?style=flat-square&logo=jsonwebtokens&logoColor=white)](https://jwt.io)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)

</div>

---

## 📌 نبذة عن المشروع

**سوقنا** هي منصة تجارة إلكترونية محلية تهدف إلى ربط التجار بالعملاء داخل المحافظة الواحدة، مع نظام إدارة متكامل يتيح للأدمن الإشراف على جميع العمليات.

تتيح المنصة للتجار عرض منتجاتهم، واستقبال الطلبات، وتتبع مبيعاتهم — بينما يستطيع العملاء تصفح المنتجات وإضافتها للسلة وإتمام عملية الشراء بسهولة، مع تحديثات فورية بالـ Real-Time عبر SignalR.

> 💡 نموذج الربح: تأخذ المنصة **10%** عمولة من كل طلب، و**90%** تذهب للتاجر مباشرة.

---

## ✨ المميزات الرئيسية

### 👤 نظام المستخدمين
- **3 أدوار** مختلفة: Admin — Seller — Customer
- تسجيل وتسجيل دخول بـ JWT Authentication
- حماية كاملة للمسارات بـ Route Guards
- التاجر ينتظر موافقة الأدمن قبل التفعيل

### 🛒 رحلة العميل
- تصفح المنتجات مع البحث والفلترة والـ Pagination
- إضافة للسلة (محفوظة في Local Storage)
- إتمام الشراء مع بيانات الشحن
- دفع عند الاستلام (COD)
- تتبع حالة الطلب في الوقت الفعلي

### 🏪 لوحة التاجر
- Dashboard بإحصائيات المبيعات والأرباح
- إدارة المنتجات (إضافة / تعديل / حذف)
- استقبال الطلبات وتحديث حالتها
- تنبيهات فورية عند وصول طلب جديد
- تنبيه للمنتجات منخفضة المخزون

### 👨‍💼 لوحة الأدمن
- Dashboard كامل بكل إحصائيات المنصة
- إدارة التجار (موافقة / إيقاف)
- مراقبة جميع الطلبات
- تقارير الأرباح الشهرية
- عرض أعلى التجار مبيعاً

### ⚡ Real-Time بـ SignalR
| الحدث | من | إلى |
|-------|-----|-----|
| طلب جديد | العميل | التاجر + الأدمن |
| تغيير حالة الطلب | التاجر | العميل |
| موافقة على التاجر | الأدمن | التاجر |
| تحديث Dashboard | النظام | الأدمن |

---

## 🛠️ التقنيات المستخدمة

### Backend
| التقنية | الاستخدام |
|---------|-----------|
| ASP.NET Core 10 Web API | الـ Backend الرئيسي |
| Entity Framework Core 10 | ORM وإدارة قاعدة البيانات |
| SQL Server | قاعدة البيانات |
| ASP.NET Core SignalR | Real-Time Communication |
| JWT Bearer Authentication | المصادقة والتفويض |
| BCrypt.Net | تشفير كلمات المرور |
| Onion Architecture | هيكل المشروع |
| Repository + Unit of Work | نمط الوصول للبيانات |

### Frontend
| التقنية | الاستخدام |
|---------|-----------|
| Angular 17 (Standalone) | الـ Frontend |
| TypeScript | لغة البرمجة |
| SCSS | التصميم |
| @microsoft/signalr | Real-Time Client |
| RxJS | البرمجة التفاعلية |
| Bootstrap Icons | الأيقونات |
| Cairo & Tajawal Fonts | الخطوط العربية |

---

## 🏗️ هيكل المشروع

```
Souqna/
├── SouqnaAPI.Domain/              # Entities + Interfaces
│   ├── Entities/
│   ├── Enums/
│   └── Interfaces/
│       ├── Repositories/
│       └── IUnitOfWork.cs
│
├── SouqnaAPI.Application/         # Business Logic
│   ├── DTOs/
│   ├── Interfaces/
│   └── Services/
│
├── SouqnaAPI.Infrastructure/      # EF Core + SignalR
│   ├── Data/
│   ├── Repositories/
│   ├── UnitOfWork/
│   ├── Hubs/
│   └── Services/
│
├── SouqnaAPI/                     # Presentation Layer
│   ├── Controllers/
│   ├── Middlewares/
│   ├── Program.cs
│   └── appsettings.json
│
└── souqna-app/                    # Angular Frontend
    └── src/app/
        ├── core/
        │   ├── guards/
        │   ├── interceptors/
        │   ├── models/
        │   └── services/
        ├── features/
        │   ├── auth/
        │   ├── public/
        │   ├── customer/
        │   ├── seller/
        │   └── admin/
        └── shared/
```

---

## 🗄️ قاعدة البيانات

```
Users ──────────────── Sellers
  │                       │
  │                       │
  └──── Orders            └──── Products
           │                        │
           └──── OrderItems ────────┘
                    │
                    └──── Categories
```

| الجدول | الوصف |
|--------|-------|
| Users | بيانات جميع المستخدمين |
| Sellers | بيانات المتاجر والتجار |
| Categories | فئات المنتجات |
| Products | المنتجات مع الصور والمخزون |
| Orders | الطلبات مع حساب العمولة |
| OrderItems | تفاصيل كل طلب |

---

## 🔌 API Endpoints

### 🔐 Auth
```
POST   /api/auth/register             تسجيل عميل
POST   /api/auth/register-seller      تسجيل تاجر
POST   /api/auth/login                تسجيل دخول
```

### 📦 Products
```
GET    /api/products                  جلب المنتجات (بحث + فلتر + pagination)
GET    /api/products/{id}             تفاصيل منتج
GET    /api/products/my-products      منتجاتي [Seller]
POST   /api/products                  إضافة منتج [Seller]
PUT    /api/products/{id}             تعديل منتج [Seller]
DELETE /api/products/{id}             حذف منتج [Seller]
```

### 🛒 Orders
```
POST   /api/orders                    إنشاء طلب [Customer]
GET    /api/orders/my-orders          طلباتي [Customer]
GET    /api/orders/seller-orders      طلبات التاجر [Seller]
GET    /api/orders/{id}               تفاصيل طلب
PUT    /api/orders/{id}/status        تحديث الحالة [Seller/Admin]
```

### 🏪 Sellers
```
GET    /api/sellers/{id}              بروفايل متجر
GET    /api/sellers/dashboard         إحصائياتي [Seller]
```

### 👨‍💼 Admin
```
GET    /api/admin/dashboard           إحصائيات المنصة
GET    /api/admin/sellers             كل التجار
PUT    /api/admin/sellers/{id}/approve موافقة على تاجر
PUT    /api/admin/sellers/{id}/suspend إيقاف تاجر
GET    /api/admin/orders              كل الطلبات
GET    /api/admin/revenue             تقرير الأرباح
```

---

## 🚀 تشغيل المشروع

### المتطلبات
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Node.js 20+](https://nodejs.org)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Angular CLI](https://angular.io/cli)

### Backend

```bash
# استنساخ المشروع
git clone https://github.com/your-username/souqna.git
cd souqna

# تعديل Connection String في appsettings.json
# "Server=.;Database=SouqnaDB;Trusted_Connection=True;TrustServerCertificate=True"

# تطبيق الـ Migration
dotnet ef database update \
  --project SouqnaAPI.Infrastructure \
  --startup-project SouqnaAPI

# تشغيل الـ API
cd SouqnaAPI
dotnet run
```

### Frontend

```bash
cd souqna-app

# تثبيت الـ Dependencies
npm install

# تشغيل
ng serve

# افتح المتصفح على
# http://localhost:4200
```

---

## 🔑 حسابات تجريبية

| الدور | الإيميل | الباسورد |
|-------|---------|---------|
| 👨‍💼 Admin | admin@souqna.com | Admin@123 |
| 🏪 Seller | seller@test.com | Test@123 |
| 🛒 Customer | customer@test.com | Test@123 |

---

## 💰 نموذج العمولة

```
قيمة الطلب: 1,000 ج.م
├── التاجر يستلم:   900 ج.م  (90%)
└── المنصة تكسب:   100 ج.م  (10%)
```

العمولة تُحسب تلقائياً عند كل طلب وتُسجَّل في قاعدة البيانات.

---

## 🗺️ خطة التطوير

- [x] Backend — Onion Architecture
- [x] JWT Authentication (3 Roles)
- [x] Products CRUD
- [x] Orders + 10% Commission
- [x] SignalR Real-Time
- [x] Angular Standalone Setup
- [x] Auth (Login + Register)
- [ ] Home + Product Detail
- [ ] Cart + Checkout
- [ ] Seller Dashboard
- [ ] Admin Dashboard
- [ ] Image Upload (Cloudinary)
- [ ] Push Notifications
- [ ] Mobile App (MAUI)

---

## 📸 Screenshots

> قريباً بعد اكتمال الـ Frontend

---

## 🤝 المساهمة

المشروع مفتوح للمساهمات. إذا أردت المساهمة:

1. Fork المشروع
2. أنشئ Branch جديد (`git checkout -b feature/amazing-feature`)
3. Commit التغييرات (`git commit -m 'Add amazing feature'`)
4. Push للـ Branch (`git push origin feature/amazing-feature`)
5. افتح Pull Request

---

## 📄 الرخصة

هذا المشروع مرخص تحت رخصة MIT — انظر ملف [LICENSE](LICENSE) للتفاصيل.

---

## 👨‍💻 المطور

<div align="center">

**Ahmed** — Full Stack Developer

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=flat-square&logo=github&logoColor=white)](https://github.com/your-username)

*بُني بـ ❤️ باستخدام ASP.NET Core 10 + Angular 17*

</div>
