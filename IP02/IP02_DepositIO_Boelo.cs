﻿[DelimitedRecord(";")]
public class IP02_DepositIO_Boelo : IP02_TransactionsIO_Boelo
{
    public string checkType = "DEPOSIT";

    public override string ToString()
    {
        return "Deposit: \n" + transDate + " , " + checkType + " , " + amount + " , " + checkType + " , " + memo + " , " + newBalance + " \n ";
    }
}