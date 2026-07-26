<div align="center">

# 🖤 L'Essence Noire

### Nền tảng thương mại điện tử nước hoa cao cấp — *Fullstack TypeScript*

[![CI](https://img.shields.io/badge/CI-GitHub_Actions-2088FF?style=for-the-badge&logo=githubactions&logoColor=white)](.github/workflows/ci.yml)
![React](https://img.shields.io/badge/React-18-61DAFB?style=for-the-badge&logo=react&logoColor=black)
![TypeScript](https://img.shields.io/badge/TypeScript-5.5-3178C6?style=for-the-badge&logo=typescript&logoColor=white)
![Node](https://img.shields.io/badge/Node-%E2%89%A520-339933?style=for-the-badge&logo=nodedotjs&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-7-47A248?style=for-the-badge&logo=mongodb&logoColor=white)
![Redis](https://img.shields.io/badge/Redis-7-DC382D?style=for-the-badge&logo=redis&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-Compose-2496ED?style=for-the-badge&logo=docker&logoColor=white)

*Cửa hàng nước hoa chính hãng: catalog & biến thể, giỏ hàng, khuyến mãi 3 tầng (Flash Sale / Discount / Voucher), thanh toán VietQR, SEO prerender và khu quản trị đầy đủ.*

[Tổng quan](#-tổng-quan) · [Kiến trúc](#-kiến-trúc) · [Bắt đầu nhanh](#-bắt-đầu-nhanh) · [API](#-tài-liệu-api) · [Roadmap](#-roadmap)

</div>

---

## 📑 Mục lục

- [🌸 Tổng quan](#-tổng-quan)
- [📖 Giới thiệu đồ án](#-giới-thiệu-đồ-án)
- [🌟 Chức năng chính](#-chức-năng-chính)
- [🏗 Kiến trúc](#-kiến-trúc)
- [🧰 Công nghệ](#-công-nghệ)
- [🔐 Bảo mật](#-bảo-mật)
- [📁 Cấu trúc thư mục](#-cấu-trúc-thư-mục)
- [🚀 Bắt đầu nhanh](#-bắt-đầu-nhanh)
- [🔧 Biến môi trường](#-biến-môi-trường)
- [📜 Scripts thường dùng](#-scripts-thường-dùng)
- [📚 Tài liệu API](#-tài-liệu-api)
- [🔎 SEO & Prerender](#-seo--prerender-ssr)
- [💾 Sao lưu & Migration DB](#-sao-lưu--migration-db)
- [🐳 Docker](#-docker)
- [🔄 CI/CD](#-cicd)
- [🧪 Kiểm thử & Chất lượng](#-kiểm-thử--chất-lượng)
- [🛠 Workflow phát triển](#-workflow-phát-triển)
- [📊 Thống kê dự án](#-thống-kê-dự-án)
- [🗺 Roadmap](#-roadmap)
- [🤝 Đóng góp](#-đóng-góp)
- [📜 License](#-license)

---

## 🌸 Tổng quan

**L'Essence Noire** là một ứng dụng thương mại điện tử fullstack cho cửa hàng nước hoa cao cấp, viết hoàn toàn bằng **TypeScript** theo mô hình **monorepo** (npm workspaces):

- **`client/`** — Ứng dụng React (Vite) cho khách hàng + khu quản trị (admin).
- **`server/`** — REST API bằng Express + MongoDB (Mongoose) theo kiến trúc phân lớp.

Hệ thống hỗ trợ toàn bộ vòng đời mua hàng: duyệt sản phẩm → giỏ hàng → áp khuyến mãi → đặt hàng → thanh toán VietQR → theo dõi đơn; kèm khu quản trị để quản lý sản phẩm, tồn kho, khuyến mãi, đơn hàng, người dùng, nội dung blog và báo cáo doanh thu.

> 🖤 *Every scent has souls.*

---

## 📖 Giới thiệu đồ án

Đây là đồ án môn học phát triển một website thương mại điện tử nước hoa hoàn chỉnh, áp dụng kiến trúc **Client–Server**, quy trình **Agile/SCRUM**, CI/CD và triển khai container hóa.

### 👥 Thông tin nhóm

| Vai trò | Thành viên | MSSV | Mã lớp |
|--------|-----------|------|--------|
| Team Lead / Fullstack | Cao Á Châu | 110123206 | DA223TTA |
| Frontend Developer | Trần Vũ Ngọc Huỳnh | 110123012 | DA223TTA |
| Backend Developer | Trần Hoàng Oanh | 110123037 | DA223TTA |

- **Đại học Trà Vinh**
- **Trường:** Kỹ Thuật và Công Nghệ
- **Học phần:** Công nghệ phần mềm
- **Giảng viên hướng dẫn:** Nguyễn Bảo Ân
- **Năm học:** 2026 - 2027

### 🎯 Mục tiêu đồ án

- Xây dựng ứng dụng web fullstack hoàn chỉnh với kiến trúc Client–Server.
- Thiết kế bộ máy giá & khuyến mãi 3 tầng minh bạch, tuân thủ pháp luật khuyến mại (Nghị định 81).
- Áp dụng React, Node.js/Express, MongoDB trong một dự án quy mô thật.
- Bảo mật nhiều lớp (JWT, CSRF, Helmet, rate-limit, sanitize).
- Container hóa bằng Docker, thiết lập CI/CD với GitHub Actions và triển khai cloud.
- Tối ưu SEO cho SPA bằng prerender.

---

## 🌟 Chức năng chính

### 🛍️ Khách hàng

- **Catalog & biến thể:** danh sách sản phẩm, biến thể theo dung tích/nồng độ, tìm kiếm & lọc theo họ hương/thương hiệu/giá; trang chi tiết có **JSON-LD**.
- **Giỏ hàng lai:** giỏ hàng cho khách vãng lai (localStorage) + đồng bộ khi đăng nhập.
- **Khuyến mãi 3 tầng:** **Flash Sale > Discount (theo độ ưu tiên) > Voucher**.
- **Thanh toán VietQR** + tra cứu đơn theo mã.
- **Tài khoản:** hồ sơ, sổ địa chỉ, wishlist, hồ sơ mùi hương, lịch sử đơn.
- **Nội dung:** Blog/Journal thương hiệu, trang giới thiệu, liên hệ.

### 🛠️ Quản trị (`/admin`)

- Quản lý **sản phẩm, biến thể, thương hiệu, danh mục, media**.
- Quản lý **đơn hàng, người dùng, đánh giá, blog**.
- Quản lý **khuyến mãi** (Flash Sale / Discount / Voucher) + email thông báo có công tắc tổng.
- **Báo cáo** doanh thu, tồn kho, lợi nhuận.

---

## 🏗 Kiến trúc

### 1️⃣ Tổng thể hệ thống (bird's-eye view)

Mọi truy cập đi qua **Nginx** (phục vụ SPA đã prerender + reverse-proxy `/api`). Backend là một **Express API** duy nhất, nói chuyện với **MongoDB** (dữ liệu) và **Redis** (rate-limit/cache, tùy chọn), tích hợp các dịch vụ ngoài: Cloudinary (ảnh), SePay/VietQR (thanh toán), SMTP (email).

<div align="center">
  <img src="docs/images/architecture-overview.png" alt="Kiến trúc tổng thể hệ thống" width="860" />
</div>

### 2️⃣ Kiến trúc phân lớp của Backend (layered architecture)

Backend tuân theo nguyên tắc **mỗi tầng chỉ gọi xuống tầng ngay dưới nó** — giúp tách bạch trách nhiệm, dễ test và dễ bảo trì. Một request đi từ trên xuống, response đi ngược lên:

<div align="center">
  <img src="docs/images/backend-layers.png" alt="Kiến trúc phân lớp Backend" width="480" />
</div>

**Vì sao phân lớp như vậy?**

- **Tách bạch trách nhiệm (SoC):** controller chỉ lo HTTP, service lo nghiệp vụ, model lo dữ liệu → sửa 1 tầng ít ảnh hưởng tầng khác.
- **Dễ kiểm thử:** có thể unit-test service mà không cần dựng HTTP; mock model dễ dàng.
- **Tái sử dụng:** nhiều controller có thể dùng chung 1 service (ví dụ `pricing-engine` dùng ở cả trang sản phẩm lẫn khi đặt đơn).

### 3️⃣ Bảng ánh xạ: Tầng ↔ Thư mục ↔ Trách nhiệm

| Tầng | Thư mục | Trách nhiệm | Được phép gọi |
|------|---------|-----------|--------------|
| Middlewares | `middlewares/` | Xác thực, CSRF, rate-limit, sanitize, xử lý lỗi tập trung | → next() |
| Routes | `routes/` | Ánh xạ URL + method → controller; gắn validator | → Controllers |
| Controllers | `controllers/` | Đọc `req`, gọi service, định dạng `res` (KHÔNG chứa nghiệp vụ) | → Services |
| Services | `services/` | **Logic nghiệp vụ**: giá, khuyến mãi, đơn hàng, giao dịch | → Models |
| Models | `models/` | Schema Mongoose, ràng buộc dữ liệu, index | → MongoDB |
| Config | `config/` | Nạp env, kết nối DB/Redis | (hạ tầng) |

### 4️⃣ Lần theo một request thật — `POST /api/v1/orders`

Để thấy các tầng phối hợp ra sao, hãy theo dõi một lần **đặt hàng**:

<div align="center">
  <img src="docs/images/order-sequence.png" alt="Luồng xử lý POST /api/v1/orders" width="900" />
</div>

**Giải thích điểm mấu chốt — chống "bán quá tồn" (race condition):**
Khi hai khách mua cùng lúc sản phẩm sắp hết, `order.service` dùng **giao dịch MongoDB** (`session.withTransaction`) với 3 lớp khóa nguyên tử:

1. **Trừ tồn có điều kiện** `stock >= qty` — nếu không đủ, giao dịch hủy.
2. **Trừ suất Flash Sale** theo `soldCount + qty <= stockAllocated`.
3. **Giới hạn mỗi khách** qua unique index (chống mua vượt định mức).

Có sẵn cơ chế *fallback* khi MongoDB không bật transaction (single-node không phải replica set).

### 5️⃣ Bộ máy resolve giá (pricing-engine)

Giá hiển thị của mỗi biến thể luôn được tính qua **một điểm duy nhất** là `pricing-engine`, theo thứ tự ưu tiên dưới đây (voucher được áp riêng ở **cấp đơn hàng**, không ở cấp sản phẩm):

<div align="center">
  <img src="docs/images/pricing-engine.png" alt="Bộ máy resolve giá (pricing-engine)" width="860" />
</div>

> 💡 **Tại sao snapshot giá vào đơn?** Để khi giá/khuyến mãi thay đổi về sau, đơn cũ vẫn giữ đúng giá & tên sản phẩm tại thời điểm mua — đảm bảo tính lịch sử và đối soát kế toán.

### 6️⃣ Phía Frontend (client)

SPA React tổ chức theo trách nhiệm, trạng thái toàn cục dùng **Zustand**, gọi API qua **Axios interceptor** có cơ chế *silent refresh* token:

```
  pages/         → Màn hình (khách + admin), lazy-load theo route
  components/    → UI dùng chung, khối Shop, khối admin
  store/         → Zustand: auth, cart, language, ...
  hooks/         → useSeo (meta/OG động), ...
  lib/           → api (axios + interceptor), token, adminApi
  router.tsx     → Định tuyến (React Router 6, lazy + Suspense)
  main.tsx       → Entry: tự hydrate khi phát hiện HTML prerender
```

**Luồng xác thực phía client:** access token giữ **trong bộ nhớ** (chống XSS), refresh token nằm trong **httpOnly cookie**. Khi access token hết hạn (HTTP 401), interceptor tự gọi `/auth/refresh` để lấy token mới rồi **phát lại request cũ** mà người dùng không hề hay biết.

---

## 🧰 Công nghệ

| Lớp | Công nghệ |
|-----|-----------|
| **Frontend** | React 18, TypeScript, Vite 5, React Router 6, Zustand, Tailwind CSS 3, Axios |
| **Backend** | Node ≥20, Express, TypeScript, Mongoose 7, JWT, bcryptjs, Zod/validators |
| **Database** | MongoDB 7 (giao dịch/replica set), Redis 7 (rate-limit phân tán, tùy chọn) |
| **Bảo mật** | Helmet (CSP/HSTS), CORS allowlist, CSRF double-submit, express-mongo-sanitize, rate-limit |
| **Thanh toán** | VietQR + webhook HMAC-SHA256 (SePay) |
| **Ảnh** | Cloudinary |
| **Test** | Vitest (client + server) |
| **DevOps** | Docker (multi-stage), Docker Compose, Nginx, GitHub Actions, Render |
| **Chất lượng** | ESLint, Prettier, Husky + lint-staged |
| **SEO** | Prerender (react-snap), meta/OG động, robots.txt, sitemap.xml, JSON-LD |

---

## 🔐 Bảo mật

- **Xác thực:** JWT access token (15 phút, giữ trong bộ nhớ — chống XSS) + refresh token trong **httpOnly cookie**; *silent refresh* qua interceptor.
- **CSRF:** double-submit token (`X-CSRF-Token`) trên `/auth/refresh` và `/auth/logout`.
- **Mật khẩu:** bcrypt cost 12.
- **HTTP headers:** Helmet với CSP + HSTS.
- **CORS allowlist** cấu hình qua `CORS_ORIGINS`.
- **Chống NoSQL injection:** express-mongo-sanitize; body giới hạn 100kb.
- **Rate limiting** (Redis khi chạy nhiều instance).
- **Webhook thanh toán:** xác thực HMAC-SHA256, chống replay (±300s), so sánh hằng thời gian.
- **trust proxy** đúng để `req.ip` chính xác + secure cookie sau Nginx.
- Giám sát lỗi tùy chọn qua **Sentry**.

> ⚠️ Không commit secret. Dùng `.env.example` làm mẫu; xoay (rotate) mọi khóa đã từng lộ.

---

## 📁 Cấu trúc thư mục

```text
lessence-noire/
│
├── client/                     # 🎨 FRONTEND — React 18 + Vite (SPA + prerender SEO)
│   ├── public/                 # robots.txt · sitemap.xml · favicon
│   ├── src/
│   │   ├── pages/              # Trang khách + trang admin
│   │   ├── components/         # UI dùng chung · khối Shop · khối admin
│   │   ├── store/              # Zustand: auth, cart, language, ...
│   │   ├── hooks/              # useSeo, ...
│   │   ├── lib/                # api (axios) · token · adminApi
│   │   ├── router.tsx          # Định tuyến (lazy + Suspense)
│   │   └── main.tsx            # Entry — tự hydrate khi có prerender
│   ├── Dockerfile              # Image multi-stage cho client
│   ├── nginx.conf              # SPA fallback + proxy /api
│   └── vite.config.ts          # Cấu hình Vite
│
├── server/                     # ⚙️ BACKEND — Express API (TypeScript)
│   └── src/
│       ├── config/             # Nạp env · kết nối DB/Redis
│       ├── models/             # Mongoose schema (~22 models)
│       ├── routes/             # Định tuyến /api/v1
│       ├── controllers/        # Điều phối HTTP (không chứa nghiệp vụ)
│       ├── services/           # ⭐ Nghiệp vụ: order · pricing-engine · promotion
│       ├── middlewares/        # auth · csrf · error · rate-limit · sanitize
│       ├── migrations/         # ⭐ Migration DB (theo dõi trong _migrations)
│       ├── scripts/            # seed · backup · restore · migrate · create-admin
│       ├── app.ts              # Khởi tạo Express app + gắn middleware
│       └── index.ts            # Điểm khởi chạy server
│
├── docs/                       # 📚 Tài liệu (SEO-PRERENDER · BACKUP-MIGRATION)
├── .github/workflows/          # 🔄 CI (GitHub Actions)
├── docker-compose.yml          # 🐳 mongo + redis + server + client
├── render.yaml                 # ☁️ Cấu hình deploy Render
├── .env.example                # 🔑 Mẫu biến môi trường
└── README.md                   # 📖 Tài liệu dự án
```

---

## 🚀 Bắt đầu nhanh

### 📋 Yêu cầu hệ thống

- **Node.js** ≥ 20
- **MongoDB 7** (khuyến nghị **replica set 1 node** để bật transaction) hoặc MongoDB Atlas
- **Redis 7** (tùy chọn — rate-limit phân tán/cache)
- **npm** ≥ 9 (dùng npm workspaces)

### 🛠️ Các bước cài đặt

```bash
# 1. Clone dự án
git clone <repo-url> lessence-noire && cd lessence-noire

# 2. Cài dependency (npm workspaces, chạy ở thư mục gốc)
npm install

# 3. Tạo file .env cho server từ mẫu rồi điền giá trị
cp .env.example server/.env    # sửa MONGO_URI, JWT_*, CLOUDINARY_*, VIETQR_*, ...

# 4. (Tùy chọn) seed dữ liệu mẫu + tạo tài khoản admin
npm run seed         --workspace server
npm run create-admin --workspace server

# 5. Chạy song song server + client
npm run dev --workspace server   # API  http://localhost:5000
npm run dev --workspace client   # Web  http://localhost:5173
```

Truy cập:

- **Web (khách + admin):** http://localhost:5173
- **API:** http://localhost:5000/api/v1

---

## 🔧 Biến môi trường

Xem đầy đủ trong `.env.example`. Các biến quan trọng:

| Biến | Ý nghĩa |
|------|---------|
| `MONGO_URI` | Chuỗi kết nối MongoDB (bắt buộc) |
| `JWT_ACCESS_SECRET` / `JWT_REFRESH_SECRET` | Khóa ký JWT (bắt buộc) |
| `CLIENT_URL` / `CORS_ORIGINS` | Origin được phép (CORS) |
| `CLOUDINARY_*` | Upload ảnh |
| `VIETQR_*` / `SEPAY_WEBHOOK_SECRET` | Thanh toán VietQR + webhook |
| `REDIS_URL` | Rate-limit phân tán (tùy chọn) |
| `SENTRY_DSN` | Giám sát lỗi (tùy chọn) |
| `CSRF_ENABLED` | Bật/tắt CSRF (mặc định bật) |
| `TRUST_PROXY` | Số proxy tin cậy trước app |

---

## 📜 Scripts thường dùng

**Client** (`npm run <script> --workspace client`)

| Script | Mô tả |
|--------|-------|
| `dev` / `build` / `preview` | Phát triển / build / xem thử |
| `prerender` | Prerender HTML tĩnh cho SEO (react-snap) |
| `build:seo` | `build` + `prerender` |
| `lint` · `typecheck` · `test` · `format` | Chất lượng mã |

**Server** (`npm run <script> --workspace server`)

| Script | Mô tả |
|--------|-------|
| `dev` / `build` / `start` | Phát triển / build / chạy production |
| `seed` · `create-admin` | Seed dữ liệu / tạo admin |
| `backup` · `restore` | ⭐ Sao lưu / khôi phục DB |
| `migrate` · `migrate:down` · `migrate:create` | ⭐ Migration DB |
| `lint` · `typecheck` · `test` · `format` | Chất lượng mã |

---

## 📚 Tài liệu API

API theo chuẩn **REST**, versioned dưới tiền tố **`/api/v1`**. Trả về JSON theo mẫu `{ success, data, message }`; lỗi theo mẫu `{ success: false, message, errors? }`.

**Chú thích quyền truy cập:**

| Ký hiệu | Ý nghĩa |
|--------|---------|
| 🌐 | Công khai — không cần đăng nhập |
| 👤 | Yêu cầu đăng nhập (JWT) |
| 🔑 | Chỉ **admin** |
| 🤖 | Server-to-server (webhook, ký HMAC) |

### 🔐 Authentication — `/auth`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `POST` | `/auth/register` | 🌐 | Đăng ký tài khoản |
| `POST` | `/auth/login` | 🌐 | Đăng nhập (trả access token + set refresh cookie) |
| `POST` | `/auth/refresh` | 🌐 | Làm mới access token (yêu cầu CSRF token) |
| `POST` | `/auth/logout` | 👤 | Đăng xuất, thu hồi refresh token |
| `GET`  | `/auth/me` | 👤 | Thông tin phiên hiện tại |
| `POST` | `/auth/verify-email` | 🌐 | Xác minh email qua token |
| `POST` | `/auth/resend-verification` | 🌐 | Gửi lại email xác minh |
| `POST` | `/auth/forgot-password` | 🌐 | Yêu cầu đặt lại mật khẩu |
| `POST` | `/auth/reset-password` | 🌐 | Đặt lại mật khẩu qua token |
| `POST` | `/auth/change-password` | 👤 | Đổi mật khẩu |
| `GET`  | `/csrf-token` | 🌐 | Lấy CSRF token (double-submit) |

### 👤 Tài khoản người dùng — `/users/me`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/users/me/profile` | 👤 | Xem hồ sơ |
| `PUT`   | `/users/me/profile` | 👤 | Cập nhật hồ sơ |
| `GET`   | `/users/me/addresses` | 👤 | Danh sách địa chỉ |
| `POST`  | `/users/me/addresses` | 👤 | Thêm địa chỉ |
| `PUT`   | `/users/me/addresses/:id` | 👤 | Sửa địa chỉ |
| `DELETE`| `/users/me/addresses/:id` | 👤 | Xoá địa chỉ |
| `PUT`   | `/users/me/addresses/:id/default` | 👤 | Đặt địa chỉ mặc định |
| `GET`   | `/users/me/scent-profile` | 👤 | Xem hồ sơ mùi hương |
| `PUT`   | `/users/me/scent-profile` | 👤 | Cập nhật hồ sơ mùi hương |
| `GET`   | `/users/me/wishlist` | 👤 | Danh sách yêu thích |
| `POST`  | `/users/me/wishlist/:productId` | 👤 | Thêm vào wishlist |
| `DELETE`| `/users/me/wishlist/:productId` | 👤 | Bớ khỏi wishlist |

### 🧴 Sản phẩm & biến thể — `/products`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/products` | 🌐 | Danh sách + lọc (`?scentFamily=&brand=&category=&minPrice=&maxPrice=&sort=&page=&limit=`) |
| `GET`   | `/products/search?q=` | 🌐 | Tìm kiếm theo từ khoá |
| `GET`   | `/products/featured` | 🌐 | Sản phẩm nổi bật |
| `GET`   | `/products/:slug` | 🌐 | Chi tiết (kèm biến thể, giá đã resolve, JSON-LD) |
| `GET`   | `/products/:slug/related` | 🌐 | Sản phẩm liên quan |
| `POST`  | `/admin/products` | 🔑 | Tạo sản phẩm |
| `PUT`   | `/admin/products/:id` | 🔑 | Cập nhật sản phẩm |
| `DELETE`| `/admin/products/:id` | 🔑 | Xoá sản phẩm |
| `POST`  | `/admin/products/:id/variants` | 🔑 | Thêm biến thể |
| `PUT`   | `/admin/variants/:id` | 🔑 | Cập nhật biến thể (giá, tồn kho) |
| `DELETE`| `/admin/variants/:id` | 🔑 | Xoá biến thể |

### 🏷️ Danh mục & thương hiệu — `/categories`, `/brands`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/categories` | 🌐 | Cây danh mục |
| `GET`   | `/categories/:slug` | 🌐 | Chi tiết danh mục |
| `POST`/`PUT`/`DELETE` | `/admin/categories/:id?` | 🔑 | Quản trị danh mục |
| `GET`   | `/brands` | 🌐 | Danh sách thương hiệu |
| `GET`   | `/brands/:slug` | 🌐 | Chi tiết thương hiệu |
| `POST`/`PUT`/`DELETE` | `/admin/brands/:id?` | 🔑 | Quản trị thương hiệu |

### ⭐ Đánh giá — `/reviews`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/products/:slug/reviews` | 🌐 | Danh sách đánh giá của sản phẩm |
| `POST`  | `/products/:slug/reviews` | 👤 | Viết đánh giá (chỉ khi đã mua) |
| `PUT`   | `/reviews/:id` | 👤 | Sửa đánh giá của mình |
| `DELETE`| `/reviews/:id` | 👤 | Xoá đánh giá của mình |
| `GET`   | `/admin/reviews` | 🔑 | Duyệt/ẩn đánh giá |
| `PUT`   | `/admin/reviews/:id/status` | 🔑 | Duyệt hoặc từ chối |

### 🛒 Giỏ hàng — `/cart`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/cart` | 👤 | Lấy giỏ hàng hiện tại |
| `POST`  | `/cart/items` | 👤 | Thêm biến thể vào giỏ |
| `PUT`   | `/cart/items/:variantId` | 👤 | Đổi số lượng |
| `DELETE`| `/cart/items/:variantId` | 👤 | Xoá khỏi giỏ |
| `POST`  | `/cart/sync` | 👤 | Đồng bộ giỏ khách vãng lai khi đăng nhập |
| `POST`  | `/cart/apply-voucher` | 👤 | Áp voucher (trả về tổng đã giảm) |
| `DELETE`| `/cart/voucher` | 👤 | Gỡ voucher |
| `POST`  | `/cart/quote` | 👤 | Tính thử tổng tiền (giá + ưu đãi + phí) |

### 🧾 Đơn hàng — `/orders`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `POST`  | `/orders` | 👤 | Tạo đơn (giao dịch tồn kho + snapshot giá/ưu đãi) |
| `GET`   | `/orders` | 👤 | Lịch sử đơn của tôi |
| `GET`   | `/orders/:code` | 🌐 | Tra cứu đơn theo mã (khách vãng lai dùng mã + email) |
| `POST`  | `/orders/:code/cancel` | 👤 | Huỷ đơn (khi chưa thanh toán) |
| `GET`   | `/admin/orders` | 🔑 | Danh sách tất cả đơn (lọc theo trạng thái) |
| `GET`   | `/admin/orders/:id` | 🔑 | Chi tiết đơn |
| `PUT`   | `/admin/orders/:id/status` | 🔑 | Cập nhật trạng thái (đóng gói, giao, hoàn thành...) |

### 🎁 Khuyến mãi — `/admin/flash-sales`, `/discounts`, `/vouchers`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/flash-sales/active` | 🌐 | Flash Sale đang diễn ra |
| `GET/POST/PUT/DELETE` | `/admin/flash-sales/:id?` | 🔑 | Quản trị Flash Sale |
| `GET/POST/PUT/DELETE` | `/admin/discounts/:id?` | 🔑 | Quản trị Discount (kèm `priority`) |
| `GET/POST/PUT/DELETE` | `/admin/vouchers/:id?` | 🔑 | Quản trị Voucher |
| `POST`  | `/vouchers/validate` | 👤 | Kiểm tra voucher hợp lệ |
| `GET`   | `/admin/price-history` | 🔑 | Lịch sử thay đổi giá |

> Quy tắc ưu tiên giá: **Flash Sale > Discount (theo `priority`) > giá niêm yết**; voucher áp ở cấp đơn hàng. Mọi thay đổi giá tuân thủ Nghị định 81 (`assertLegalDiscount`).

### 💳 Thanh toán & Webhook — `/payments`, `/webhooks`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/payments/vietqr/:orderCode` | 🌐 | Sinh mã VietQR cho đơn |
| `GET`   | `/payments/:orderCode/status` | 🌐 | Kiểm tra trạng thái thanh toán |
| `POST`  | `/webhooks/sepay` | 🤖 | Webhook xác nhận chuyển khoản (HMAC-SHA256, chống replay ±300s) |

### 📝 Blog / Journal — `/blog`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/blog` | 🌐 | Danh sách bài viết |
| `GET`   | `/blog/:slug` | 🌐 | Chi tiết bài viết |
| `GET/POST/PUT/DELETE` | `/admin/blog/:id?` | 🔑 | Quản trị bài viết |

### 🖼️ Media / Upload — `/admin/media`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `POST`  | `/admin/media/upload` | 🔑 | Upload ảnh lên Cloudinary (multipart) |
| `DELETE`| `/admin/media/:publicId` | 🔑 | Xoá ảnh trên Cloudinary |

### 👥 Quản lý người dùng (admin) — `/admin/users`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/admin/users` | 🔑 | Danh sách người dùng (lọc, phân trang) |
| `GET`   | `/admin/users/:id` | 🔑 | Chi tiết người dùng |
| `PUT`   | `/admin/users/:id/role` | 🔑 | Đổi vai trò (user/admin) |
| `PUT`   | `/admin/users/:id/status` | 🔑 | Khoá/mở khoá tài khoản |

### 📊 Báo cáo (admin) — `/admin/reports`

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/admin/reports/revenue?from=&to=&groupBy=` | 🔑 | Doanh thu theo thời gian |
| `GET`   | `/admin/reports/inventory` | 🔑 | Tồn kho theo biến thể |
| `GET`   | `/admin/reports/profit?from=&to=` | 🔑 | Lợi nhuận |
| `GET`   | `/admin/reports/best-sellers` | 🔑 | Sản phẩm bán chạy |
| `GET`   | `/admin/dashboard/summary` | 🔑 | Số liệu tổng quan dashboard |

### 🧩 Tiện ích & Hệ thống

| Method | Endpoint | Quyền | Mô tả |
|--------|----------|:----:|-------|
| `GET`   | `/health` | 🌐 | Health check (dùng cho Docker/CI) |
| `GET`/`POST` | `/contact` | 🌐 | Thông tin & gửi form liên hệ |
| `GET`   | `/sitemap.xml` · `/robots.txt` | 🌐 | Phục vụ SEO |

> 💡 Đây là tập endpoint đầy đủ theo thiết kế; nguồn sự thật cuối cùng là các file trong `server/src/routes/`. Mọi route `/admin/*` đều qua middleware `auth` + `requireRole('admin')`.

---

## 🔎 SEO & Prerender (SSR)

SPA thuần render phía client nên bất lợi cho SEO. Dự án bổ sung **prerender tại thời điểm build** bằng [`react-snap`](https://github.com/stereobooster/react-snap): sau khi build, một trình duyệt headless sẽ chụp HTML tĩnh của các trang tĩnh (Trang chủ, Shop, Giới thiệu, Thương hiệu, Blog, Liên hệ, Chính sách), giúp bot đọc được nội dung + thẻ meta ngay trong HTML.

```bash
npm install
npm run build:seo --workspace client
```

- `main.tsx` tự **hydrate** khi phát hiện HTML đã prerender, ngược lại render bình thường.
- Danh sách route prerender cấu hình trong `client/package.json` → `reactSnap.include`.
- Chi tiết: xem **`docs/SEO-PRERENDER.md`**.

---

## 💾 Sao lưu & Migration DB

**Sao lưu / khôi phục** (Extended JSON + gzip, giữ nguyên kiểu ObjectId/Date):

```bash
npm run backup  --workspace server                           # -> server/backups/<timestamp>/
npm run restore --workspace server -- backups/<timestamp>         # upsert theo _id
npm run restore --workspace server -- backups/<timestamp> --drop  # xóa rồi nạp lại
```

**Migration** (theo dõi trong collection `_migrations`):

```bash
npm run migrate:create --workspace server -- them-truong-xyz   # tạo file mới
npm run migrate        --workspace server                      # chạy migration đang chờ
npm run migrate:down   --workspace server                      # revert cái mới nhất
```

Đã kèm 2 migration mẫu: backfill `basePrice` và đồng bộ index. Chi tiết: **`docs/BACKUP-MIGRATION.md`**.

---

## 🐳 Docker

```bash
docker compose up -d --build
# client: http://localhost:8080   ·   server: http://localhost:5000
```

- **`server/Dockerfile`** & **`client/Dockerfile`**: multi-stage, chạy bằng user `node`, có `HEALTHCHECK`.
- **`client/nginx.conf`**: SPA fallback, cache `/assets/` 1 năm, proxy `/api/` → `server:5000`.
- **`docker-compose.yml`**: `mongo:7` + `redis:7` + `server` + `client`.

> Để bật giao dịch MongoDB trong compose, chạy Mongo dạng **single-node replica set** (`--replSet rs0` + `rs.initiate()`) hoặc dùng MongoDB Atlas.

---

## 🔄 CI/CD

`.github/workflows/ci.yml` gồm 3 job: **server**, **client**, **docker** — chạy `npm ci`, lint, typecheck, test và build image (buildx, không push). Deploy mẫu qua **`render.yaml`**.

**Chiến lược nhánh:**

- **`main`** — môi trường development, build image tag `dev-latest`.
- **`production`** — môi trường production, build tag `latest`, deploy qua webhook.

---

## 🧪 Kiểm thử & Chất lượng

Dự án dùng **Vitest** cho cả client và server.

```bash
# Client
npm run test --workspace client        # watch mode
npm run test --workspace client -- run # chạy 1 lần (CI)

# Server
npm run test --workspace server
```

**Công cụ chất lượng:**

- **ESLint + Prettier** — lint & format tự động.
- **TypeScript strict** — `npm run typecheck` ở mỗi workspace.
- **Husky + lint-staged** — pre-commit hook tự format/lint file staged.
- **Trivy** (tùy chọn) — quét lỗ hổng cho Docker image trong CI.

---

## 🛠 Workflow phát triển

1. Nhánh mới từ `main`: `feat/...`, `fix/...`.
2. Code → `npm run lint && npm run typecheck && npm test` (mỗi workspace).
3. Commit: **Husky + lint-staged** tự format/lint file staged (`.husky/pre-commit`).
4. Mở Pull Request → CI xanh → review → merge.
5. Trước khi đổi schema quan trọng: viết **migration** + chạy **backup**.

---

## 📊 Thống kê dự án

### ✅ Tính năng đã hoàn thành

- ✅ **Xác thực & phân quyền** — JWT access/refresh, httpOnly cookie, CSRF
- ✅ **Catalog & biến thể** — lọc theo họ hương/thương hiệu/giá, JSON-LD
- ✅ **Giỏ hàng lai** — localStorage + đồng bộ khi đăng nhập
- ✅ **Khuyến mãi 3 tầng** — Flash Sale > Discount > Voucher
- ✅ **Đặt hàng an toàn** — giao dịch MongoDB chống race condition tồn kho
- ✅ **Thanh toán VietQR** — webhook HMAC-SHA256, chống replay
- ✅ **Khu quản trị** — sản phẩm, đơn, người dùng, khuyến mãi, blog, báo cáo
- ✅ **SEO Prerender** — react-snap, meta/OG động, sitemap, robots
- ✅ **Backup & Migration DB** — script chuyên dụng
- ✅ **Docker hóa** — multi-stage, Nginx, healthcheck
- ✅ **CI/CD** — GitHub Actions (lint/typecheck/test/build)

### 📈 Quy mô (ước tính)

- **Ngôn ngữ chính:** TypeScript (client + server)
- **Mongoose schema:** ~22 models
- **Kiến trúc:** monorepo 2 workspaces (`client`, `server`)
- **Bảo mật:** 8+ lớp middleware

---

## 🗺 Roadmap

- 🔄 Tích hợp thêm cổng thanh toán (VNPay / Momo)
- 🔄 Gợi ý mùi hương cá nhân hóa bằng AI
- 🔄 Đa ngôn ngữ (i18n) đầy đủ
- 🔄 Ứng dụng di động (React Native)
- 🔄 Tách một số nghiệp vụ thành microservices, triển khai Kubernetes
- 🔄 PWA / hỗ trợ offline

---

## 🤝 Đóng góp

1. **Fork** repository về tài khoản cá nhân.
2. Tạo branch mới: `git checkout -b feat/ten-tinh-nang`.
3. Commit theo **Conventional Commits**: `git commit -m "feat: them tinh nang X"`.
4. Push và mở **Pull Request** để review.

**Coding standards:**

- **TypeScript strict**, async/await.
- **React:** functional components + hooks.
- **CSS:** Tailwind utility-first.
- **API:** RESTful, đặt tên rõ ràng, versioned.
- **Naming:** camelCase cho biến, PascalCase cho component.

---

## 📜 License

Dự án phát hành dưới **MIT License** — xem file [LICENSE](LICENSE) để biết chi tiết.

✅ Được phép: sử dụng, sao chép, chỉnh sửa, phân phối · ✅ Yêu cầu: giữ copyright notice · ❌ Không đảm bảo: warranty/liability.

---

<div align="center">

**L'Essence Noire** — *Every scent has souls.* 🖤

Được phát triển với ❤️ bằng TypeScript.

</div>
