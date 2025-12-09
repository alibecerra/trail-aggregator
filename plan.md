# 🏞️ 24-Week Data & Web Development Capstone Project

This project aims to build a comprehensive **Trail Condition Tracker** by integrating data from multiple sources, storing it in a robust database, and presenting it via a polished web interface.

---

## 📅 PHASE 1: Foundation & Data Exploration (Weeks 1-3)

### Goal
Understand what data exists and start pulling it.

### Tasks
* **Research Available APIs/Data Sources:**
    * Weather APIs (OpenWeatherMap, Weather.gov)
    * National Park Service API
    * USDA Forest Service data
    * California State Parks (might need scraping)
    * Recreation.gov API (if available)
* **Site Selection:** Pick 3-5 specific trails/sites to focus on initially (start small!).
* **Write Python Scripts to Pull Data (2-3 Sources):**
    * *Learn:* API authentication, handling rate limits, error handling.
    * *Tool:* `requests` library.
* **Explore & Clean Data:**
    * *Learn:* Data cleaning with `pandas`. What's useful? What's messy?
* **Save Raw Data:** Save raw data to CSV files for now.

### Deliverable
Python scripts that successfully pull and display data from at least 2 different sources.

---

## 💾 PHASE 2: Database Setup (Weeks 4-5)

### Goal
Learn to design and use a real database.

### Tasks
* **Install PostgreSQL Locally:**
    * *Learn:* Basic database concepts, SQL queries.
* **Design Your Database Schema:**
    * What tables do you need? (e.g., `sites`, `weather_data`, `trail_reports`, etc.)
    * What relationships between them?
    * *Learn:* Database normalization, primary/foreign keys.
* **Modify Python Scripts:** Write data to PostgreSQL instead of CSV.
    * *Learn:* `psycopg2` or `SQLAlchemy` library, connection management, parameterized queries.
* **Write Retrieval Queries:** Write queries to retrieve and aggregate data.
    * *Learn:* `JOIN`s, `WHERE` clauses, time-based queries.

### Deliverable
Working PostgreSQL database with data from your sources, and Python scripts that can read/write to it.

---

## ⚙️ PHASE 3: Data Pipeline & Automation (Weeks 6-8)

### Goal
Make it run automatically and handle updates.

### Tasks
* **Structure Your Code Properly:**
    * Separate files for different data sources/functions.
    * Configuration file (e.g., API keys, database credentials).
    * *Learn:* Python project structure, environment variables.
* **Schedule Automatic Data Collection:**
    * Start simple: `cron` job or Windows Task Scheduler.
    * Later: Learn about `schedule` library or `celery` for more control.
    * *Learn:* How to handle failures, logging.
* **Implement Data Freshness Tracking:**
    * Use timestamps to track when data was last updated.
    * Handle stale data.
    * *Learn:* Timestamps, data validation.
* **Add Error Handling and Logging:**
    * What happens when an API is down?
    * *Learn:* Python `logging` module, `try/except` best practices.

### Deliverable
System that automatically updates data every X hours without you manually running it.

---

## 💻 PHASE 4: Web Interface - Backend (Weeks 9-12)

### Goal
Build an API that serves your data.

### Tasks
* **Learn Flask Basics:** (Start here, it's simpler than Django)
    * Routes, request handling, returning JSON data.
    * *Learn:* REST API concepts.
* **Create API Endpoints:**
    * `GET /sites` (list all sites)
    * `GET /sites/{id}/conditions` (get current conditions)
    * `GET /sites/{id}/history` (historical data)
    * *Learn:* URL parameters, query parameters.
* **Connect Flask to PostgreSQL:**
    * Query the database from your routes.
    * Return formatted data as JSON.
    * *Learn:* Serialization, API design patterns.
* **Test Your API:**
    * Use Postman or `curl`.
    * *Learn:* API testing, debugging.

### Deliverable
Working REST API that serves your trail data via multiple endpoints.

---

## 🎨 PHASE 5: Web Interface - Frontend (Weeks 13-16)

### Goal
Make it visual and usable.

### Options
* **Option A - Easier:** Use **Streamlit** or **Dash**.
    * Much faster to build, Python-based.
    * *Learn:* UI components, data visualization with `plotly`.
* **Option B - More Impressive:** **React** or basic **HTML/CSS/JavaScript**.
    * More marketable skill, better for portfolio.
    * Steeper learning curve.
    * *Learn:* Frontend basics, fetching from your API.

### Tasks (Either Option)
* **Create Pages:**
    * Simple landing page showing a list of sites.
    * Individual site pages showing: Current weather, trail status, recent conditions, historical trends (graphs!).
* **Data Visualization:**
    * *Learn:* Data visualization libraries (`matplotlib`, `plotly`, or `D3.js`).
* **Polish the Design:**
    * Clean layout, responsive (works on mobile).
    * *Learn:* Basic UI/UX principles.

### Deliverable
Functional website you can navigate and view data clearly.

---

## 🚀 PHASE 6: Deployment & Polish (Weeks 17-20)

### Goal
Make it live and production-ready.

### Tasks
* **Containerize with Docker:**
    * Create `Dockerfile` for your application.
    * Use `Docker Compose` for the app + database.
    * *Learn:* Containers, why they matter.
* **Deploy to Cloud:**
    * Start with free tier: Railway, Render, or AWS Free Tier.
    * Set up environment variables properly.
    * *Learn:* Cloud deployment, environment management.
* **Set Up a Domain (Optional but Nice):**
    * Use a registrar like Namecheap (~$10/year).
    * Connect to your deployment.
    * *Learn:* DNS, domain management.
* **Documentation:**
    * Create a `README` with screenshots and architecture diagram.
    * Include instructions on how to run it locally.
    * *Learn:* Technical writing, documentation best practices.
* **Add Monitoring:**
    * Ensure the site is up and data sources are working.
    * *Learn:* Basic DevOps concepts.

### Deliverable
Live website with a URL you can share, and complete documentation.

---

## 💼 PHASE 7: Resume & Interview Prep (Weeks 21-24)

### Goal
Turn this into job offers.

### Tasks
* **Create Compelling Project Description for Resume:**
    * Focus on technical skills used (Python, PostgreSQL, Flask, Docker, etc.).
    * Quantify if possible (X data sources, Y API calls/day, Z locations).
* **Prepare to Talk About It:**
    * What challenges did you face?
    * What would you do differently?
    * How would you scale it?
* **Write Blog Post or Case Study (HUGE Plus):**
    * Document your process and what you learned.
    * Shows communication skills; employers love this.
* **Add "What's Next" Features:**
    * Shows you think beyond minimum requirements.
    * *Ideas:* user accounts, favorite trails, alerts, mobile app.

### Deliverable
Resume-ready project description, interview talking points, and a published case study/blog post.