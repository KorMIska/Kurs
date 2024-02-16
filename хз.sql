--SELECT Account.Account_ID ,Account.Account_Number, Account.Account_Balance FROM Account JOIN Client ON Account.Client_ID = Client.Client_ID WHERE Client_Name = 'Лёха'
--SELECT  Deposit_ID , Deposit_Type ,Interest_Rate ,Deposit_Term FROM Deposit JOIN Client ON Deposit.Client_ID = Client.Client_ID --WHERE Client_Name = {0}
--SELECT  Internet_Banking_ID , Login, Password, Available_Operations FROM Internet_Banking JOIN Client ON Internet_Banking.Client_ID = Client.Client_ID WHERE Client_Name = {0},
--SELECT Card_ID , Card_Number, Card_Type FROM Payment_Card JOIN Client ON Payment_Card.Client_ID = Client.Client_ID  WHERE Client_Name = {0}
--SELECT  Operation_ID,Operation_Type,Operation_Amount ,Operation_Date  FROM Bank_Operations JOIN Client ON Bank_Operationsb.Client_ID = Client.Client_ID  WHERE Client_Name = {0}
--SELECT Currency_ID , Currency_Name FROM Currency JOIN Client ON Currency.Client_ID = Client.Client_ID  WHERE Client_Name = {0}
SELECT DISTINCT  Client_Name FROM Client

