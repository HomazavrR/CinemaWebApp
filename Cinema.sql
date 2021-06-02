Use Cinema;

CREATE TABLE ���������
(
  ���_��������� INT NOT NULL,
  ������������_��������� VARCHAR(50) NOT NULL,
  ����� FLOAT NOT NULL,
  ����������� VARCHAR(50) NOT NULL,
  ���������� VARCHAR(50) NOT NULL,
  PRIMARY KEY (���_���������)
);

CREATE TABLE �����
(
  ���_����� INT NOT NULL,
  ������������ VARCHAR(50) NOT NULL,
  �������� VARCHAR(100) NOT NULL,
  PRIMARY KEY (���_�����)
);

CREATE TABLE ������
(
  ���_������ INT NOT NULL,
  ������������ VARCHAR(50) NOT NULL,
  ������������ FLOAT NOT NULL,
  �����_������������� VARCHAR(50) NOT NULL,
  ������_������������� VARCHAR(50) NOT NULL,
  ����� VARCHAR(50) NOT NULL,
  ����������_����������� CHAR(3) NOT NULL,
  �������� VARCHAR(100) NOT NULL,
  ���_����� INT NOT NULL,
  PRIMARY KEY (���_������),
  FOREIGN KEY (���_�����) REFERENCES �����(���_�����)
);

CREATE TABLE ���������
(
  ���_������ INT NOT NULL,
  ���� DATE NOT NULL,
  �����_������ DATE NOT NULL,
  �����_��������� DATE NOT NULL,
  ����_������ FLOAT NOT NULL,
  PRIMARY KEY (���_������)
);

CREATE TABLE ����������
(
  ����� VARCHAR(50) NOT NULL,
  ������� VARCHAR(20) NOT NULL,
  ����������_������ VARCHAR(20) NOT NULL,
  ��� CHAR(3) NOT NULL,
  ���_���������� INT NOT NULL,
  ��� VARCHAR(50) NOT NULL,
  ������� INT NOT NULL,
  ���_��������� INT NOT NULL,
  PRIMARY KEY (���_����������),
  FOREIGN KEY (���_���������) REFERENCES ���������(���_���������)
);

CREATE TABLE �����
(
  �����_����� INT NOT NULL,
  ��������� CHAR(1) NOT NULL,
  ���_���������� INT NOT NULL,
  ���_������ INT NOT NULL,
  PRIMARY KEY (�����_�����),
  FOREIGN KEY (���_����������) REFERENCES ����������(���_����������),
  FOREIGN KEY (���_������) REFERENCES ���������(���_������)
);
