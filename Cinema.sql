Use Cinema;

CREATE TABLE Должность
(
  Код_должности INT NOT NULL,
  Наименование_должности VARCHAR(50) NOT NULL,
  Оклад FLOAT NOT NULL,
  Обязанности VARCHAR(50) NOT NULL,
  Требования VARCHAR(50) NOT NULL,
  PRIMARY KEY (Код_должности)
);

CREATE TABLE Жанры
(
  Код_жанра INT NOT NULL,
  Наименование VARCHAR(50) NOT NULL,
  Описание VARCHAR(100) NOT NULL,
  PRIMARY KEY (Код_жанра)
);

CREATE TABLE Фильмы
(
  Код_фильма INT NOT NULL,
  Наименование VARCHAR(50) NOT NULL,
  Длительность FLOAT NOT NULL,
  Фирма_производитель VARCHAR(50) NOT NULL,
  Страна_производитель VARCHAR(50) NOT NULL,
  Актёры VARCHAR(50) NOT NULL,
  Возрастные_ограничения CHAR(3) NOT NULL,
  Описание VARCHAR(100) NOT NULL,
  Код_жанра INT NOT NULL,
  PRIMARY KEY (Код_фильма),
  FOREIGN KEY (Код_жанра) REFERENCES Жанры(Код_жанра)
);

CREATE TABLE Репертуар
(
  Код_сеанса INT NOT NULL,
  Дата DATE NOT NULL,
  Время_начала DATE NOT NULL,
  Время_окончания DATE NOT NULL,
  Цена_билета FLOAT NOT NULL,
  PRIMARY KEY (Код_сеанса)
);

CREATE TABLE Сотрудники
(
  Адрес VARCHAR(50) NOT NULL,
  Телефон VARCHAR(20) NOT NULL,
  Паспортные_данные VARCHAR(20) NOT NULL,
  Пол CHAR(3) NOT NULL,
  Код_сотрудника INT NOT NULL,
  ФИО VARCHAR(50) NOT NULL,
  Возраст INT NOT NULL,
  Код_должности INT NOT NULL,
  PRIMARY KEY (Код_сотрудника),
  FOREIGN KEY (Код_должности) REFERENCES Должность(Код_должности)
);

CREATE TABLE Места
(
  Номер_места INT NOT NULL,
  Занятость CHAR(1) NOT NULL,
  Код_сотрудника INT NOT NULL,
  Код_сеанса INT NOT NULL,
  PRIMARY KEY (Номер_места),
  FOREIGN KEY (Код_сотрудника) REFERENCES Сотрудники(Код_сотрудника),
  FOREIGN KEY (Код_сеанса) REFERENCES Репертуар(Код_сеанса)
);
