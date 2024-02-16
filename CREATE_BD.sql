CREATE  TABLE Client (
    Client_ID INT PRIMARY KEY,
    Client_Name NVARCHAR(255)  NULL,
    Phone_Number INT  NULL
);

-- Creating the Bank table
CREATE TABLE Bank (
    Bank_ID INT PRIMARY KEY,
    Bank_Name NVARCHAR(255)  NULL,
    Bank_Address NVARCHAR(255)  NULL
);

-- Creating the Account table
CREATE TABLE Account (
    Account_ID INT PRIMARY KEY,
    Account_Number NVARCHAR(50)  NULL,
    Account_Balance INT NULL,
    Client_ID INT,
    FOREIGN KEY (Client_ID) REFERENCES Client(Client_ID) ON DELETE CASCADE
);

-- Creating the Deposit table
CREATE TABLE Deposit (
    Deposit_ID INT PRIMARY KEY,
    Deposit_Type NVARCHAR(255)  NULL,
    Interest_Rate INT NULL,
    Deposit_Term TIME  NULL,
    Client_ID INT,
    FOREIGN KEY (Client_ID) REFERENCES Client(Client_ID) ON DELETE CASCADE
);

-- Creating the Internet_Banking table
CREATE TABLE Internet_Banking (
    Internet_Banking_ID INT PRIMARY KEY,
    Login NVARCHAR(255) NULL,
    Password NVARCHAR(255)  NULL,
    Available_Operations NVARCHAR(255) NULL,
    Client_ID INT,
    FOREIGN KEY (Client_ID) REFERENCES Client(Client_ID) ON DELETE CASCADE
);

-- Creating the Payment_Card table
CREATE TABLE Payment_Card (
    Card_ID INT PRIMARY KEY,
    Card_Number INT  NULL,
    Card_Type NVARCHAR(255)  NULL,
    Client_ID INT,
    FOREIGN KEY (Client_ID) REFERENCES Client(Client_ID) ON DELETE CASCADE
);

-- Creating the Bank_Operations table
CREATE TABLE Bank_Operations (
    Operation_ID INT PRIMARY KEY,
    Operation_Type NVARCHAR(255)  NULL,
    Operation_Amount INT  NULL,
    Operation_Date DATETIME  NULL,
    Client_ID INT,
    Bank_ID INT,
    FOREIGN KEY (Client_ID) REFERENCES Client(Client_ID) ON DELETE CASCADE,
    FOREIGN KEY (Bank_ID) REFERENCES Bank(Bank_ID) ON DELETE CASCADE
);

-- Creating the Currency table
CREATE TABLE Currency (
    Currency_ID INT PRIMARY KEY,
    Currency_Name NVARCHAR(255)  NULL,
    Client_ID INT,
    Bank_ID INT,
    FOREIGN KEY (Client_ID) REFERENCES Client(Client_ID) ON DELETE CASCADE,
    FOREIGN KEY (Bank_ID) REFERENCES Bank(Bank_ID) ON DELETE CASCADE
);