﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6

{
    public class Account
    {
        private String accName;
        private String acId;
        private int balance;

        public String AccName { get { return accName; } set { accName = value; } }
        public String AcId { get { return acId; } set { acId = value; } }
        public int Balance { get { return balance; } set { balance = value; } }

        public Account()
        {
        }

        public Account(String accName, String acId, int balance)
        {
            this.accName = accName;
            this.acId = acId;
            this.balance = balance;
        }

        public void deposit(int amount)
        {
            this.balance += amount;
        }

        public Boolean withdraw(int amount)
        {
            if (this.balance < amount)
            {
                return false;
            }
            else
            {
                this.balance -= amount;
                return true;
            }
        }

        public Boolean transfer(int amount, Account receiver)
        {
            if (this.balance < amount)
            {
                return false;
            }
            else
            {
                if (receiver != null)
                {
                    receiver.balance += amount;
                    this.balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
