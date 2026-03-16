# Guild Management System V3 (WinForms + SQL Server)

Sebuah project latihan **C# WinForms Desktop + SQL Server** yang mensimulasikan sistem manajemen guild pemburu monster.
Project ini dibuat untuk melatih konsep **MDI Forms, relational database design, LINQ, event & delegate, serta pengelolaan data antar form**.

Sistem ini terinspirasi dari mekanik guild dalam game seperti **Monster Hunter**, di mana hunter dapat menyelesaikan quest secara solo atau dalam party.

---

# Tujuan Project

Project ini dibuat sebagai **latihan eksplorasi konsep desktop development** dan bukan sebagai aplikasi production.

Fokus latihan:

* MDI Form architecture
* Event & Delegate communication antar form
* LINQ untuk analisis data
* SQL relational design
* Foreign Key & Data Integrity
* Sistem ekonomi sederhana (guild tax)
* Aggregation query (leaderboard & contribution)

---

# Core Features

## 1. Hunter Management

Mengelola data hunter dalam guild.

Fitur:

* Tambah hunter
* Edit hunter
* Hapus hunter
* Melihat daftar hunter

Data disimpan pada tabel `Hunters`.

---

## 2. Monster Database

Database monster yang dapat diburu oleh hunter.

Fitur:

* Menambah monster
* Melihat daftar monster
* Digunakan sebagai target quest

Data disimpan pada tabel `Monsters`.

---

## 3. Solo Quest System

Hunter dapat menyelesaikan quest secara individu.

Fitur:

* Hunter memilih monster
* Sistem mencatat reward yang diperoleh
* Riwayat quest tersimpan

Data disimpan pada tabel:

```
Quests
```

Kolom penting:

* QuestCode
* HunterID
* MonsterID
* RewardEarned
* HuntDate

---

## 4. Party Quest System

Hunter dapat berburu bersama dalam sebuah party.

Satu quest dapat diikuti oleh beberapa hunter.

Struktur database:

```
PartyQuests
PartyMembers
```

Relasi:

```
PartyQuest (1) ---- (N) PartyMembers
Hunter     (1) ---- (N) PartyMembers
```

Alur sistem:

1. Party quest dibuat
2. Beberapa hunter ditambahkan sebagai member
3. Total reward quest dihitung
4. Reward dibagi ke semua hunter dalam party

Reward per hunter disimpan di:

```
PartyMembers.RewardEarned
```

---

## 5. Guild Tax & Treasury

Guild mengenakan **20% tax** dari reward quest party.

Perhitungan:

```
Tax = TotalReward * 20%
```

Pajak tersebut masuk ke **Guild Treasury**.

Database:

```
TreasuryTransactions
```

Relasi:

```
PartyQuest → TreasuryTransaction
```

---

## 6. Guild Leaderboard

Sistem menghitung kontribusi hunter terhadap guild.

Kontribusi dihitung dari total reward yang diperoleh hunter dari:

* Solo quest
* Party quest

Leaderboard diurutkan berdasarkan total gold yang dihasilkan.

---

## 7. Quest History

Form Quest History menampilkan **seluruh riwayat berburu hunter**, baik:

* Solo Quest
* Party Quest

Data diambil dari dua sumber dan digabung menggunakan query.

---

# Database Structure

Tabel utama:

```
Hunters
Monsters
Quests
PartyQuests
PartyMembers
TreasuryTransactions
```

Relasi utama:

```
Hunters 1 ─── N Quests
Monsters 1 ─── N Quests

PartyQuests 1 ─── N PartyMembers
Hunters     1 ─── N PartyMembers

PartyQuests 1 ─── N TreasuryTransactions
```

---

# Technical Concepts Practiced

Project ini secara khusus digunakan untuk melatih konsep berikut:

### MDI Forms

Main form bertindak sebagai container yang membuka child forms seperti:

* Hunter Management
* Monster Management
* Quest History
* Party Quest
* Dashboard

---

### Event & Delegate

Ketika quest selesai:

* Treasury langsung diperbarui
* Leaderboard di-refresh
* Dashboard statistik ikut berubah

Form tidak saling memanggil secara langsung tetapi menggunakan **event-based communication**.

---

### LINQ

Digunakan untuk:

* Menghitung total contribution hunter
* Menyusun leaderboard
* Analisis data quest

---

### SQL Relational Integrity

Database menggunakan:

* Primary Key
* Foreign Key
* Junction Table (`PartyMembers`)

untuk menjaga konsistensi data.

---

# Tech Stack

* C#
* WinForms
* SQL Server
* LINQ

---

# Purpose of This Repository

Repository ini digunakan sebagai:

* latihan desain sistem desktop
* latihan database relational modeling
* eksperimen fitur WinForms

Project ini akan terus berkembang sebagai **series latihan Guild Management System**.

---

# Future Improvements

Ide pengembangan selanjutnya:

* Equipment & Item System
* Guild Shop
* Quest Difficulty Scaling
* Party Role System
* Damage Contribution Tracking
