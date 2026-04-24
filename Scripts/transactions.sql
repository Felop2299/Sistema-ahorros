-- Deposits
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (1, 500, 'Deposit', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (2, 300, 'Deposit', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (3, 700, 'Deposit', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (4, 200, 'Deposit', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (5, 1000, 'Deposit', GETDATE());

-- Withdraws
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (1, 200, 'Withdraw', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (2, 100, 'Withdraw', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (3, 300, 'Withdraw', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (4, 150, 'Withdraw', GETDATE());
INSERT INTO Transactions (AccountId, Amount, Type, Date) VALUES (5, 400, 'Withdraw', GETDATE());