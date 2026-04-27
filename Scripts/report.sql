SELECT
A.OwnerName,
A.AccountNumber,
A.Balance,
A.InitialAmount,

--total deposits

SUM (CASE WHEN T.Type = 'Deposit' THEN T.Amount ELSE 0 END) AS TotalDeposits,

--total withdraws

SUM (CASE WHEN T.Type = 'Withdraw' THEN T.Amount ELSE 0 END) AS TotalWithdraws

FROM Accounts A
LEFT JOIN Transactions T ON A.Id = T.AccountId

GROUP BY 

A.OWnerName,
A.AccountNumber,
A.InitialAmount,
A.Balance