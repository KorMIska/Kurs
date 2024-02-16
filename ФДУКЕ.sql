-- For the Client table
ALTER TABLE Client
ALTER COLUMN Client_Name NVARCHAR(255) NULL;

ALTER TABLE Client
ALTER COLUMN Phone_Number INT NULL;

-- For the Bank table
ALTER TABLE Bank
ALTER COLUMN Bank_Name NVARCHAR(255) NULL;

ALTER TABLE Bank
ALTER COLUMN Bank_Address NVARCHAR(255) NULL;

-- For the Account table
ALTER TABLE Account
ALTER COLUMN Account_Number NVARCHAR(50) NULL;

ALTER TABLE Account
ALTER COLUMN Account_Balance INT NULL;

-- For the Deposit table
ALTER TABLE Deposit
ALTER COLUMN Deposit_Type NVARCHAR(255) NULL;

ALTER TABLE Deposit
ALTER COLUMN Interest_Rate INT NULL;

ALTER TABLE Deposit
ALTER COLUMN Deposit_Term TIME NULL;

-- For the Internet_Banking table
ALTER TABLE Internet_Banking
ALTER COLUMN Login NVARCHAR(255) NULL;

ALTER TABLE Internet_Banking
ALTER COLUMN Password NVARCHAR(255) NULL;

ALTER TABLE Internet_Banking
ALTER COLUMN Available_Operations NVARCHAR(255) NULL;

-- For the Payment_Card table
ALTER TABLE Payment_Card
ALTER COLUMN Card_Number INT NULL;

ALTER TABLE Payment_Card
ALTER COLUMN Card_Type NVARCHAR(255) NULL;

-- For the Bank_Operations table
ALTER TABLE Bank_Operations
ALTER COLUMN Operation_Type NVARCHAR(255) NULL;

ALTER TABLE Bank_Operations
ALTER COLUMN Operation_Amount INT NULL;

ALTER TABLE Bank_Operations
ALTER COLUMN Operation_Date DATETIME NULL;

-- For the Currency table
ALTER TABLE Currency
ALTER COLUMN Currency_Name NVARCHAR(255) NULL;