﻿using MMBankAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MMBankAPI.Controllers
{
    public class BankAppController : ApiController
    {
        static List<Bank> accounts = new ArrayList<Bank>() {

            new Bank{AccountNumber=101,AccHoldersName="shailaja",AccountType="Savings",Address="Mumbai",
                Amount =12,Contact=1234567,CreationDate=DateTime.Now,DOB=DateTime.Parse("1997-03-11"),EmailId="shail@gmail.com"},
             new Bank{AccountNumber=102,AccHoldersName="deepika",AccountType="Savings",Address="Mumbai",
                Amount =12,Contact=9738574,CreationDate=DateTime.Now,DOB=DateTime.Parse("1996-08-21"),EmailId="deepika@gmail.com"},
              new Bank{AccountNumber=103,AccHoldersName="naati",AccountType="Savings",Address="Mumbai",
                Amount =12,Contact=93726373,CreationDate=DateTime.Now,DOB=DateTime.Parse("1997-03-14"),EmailId="naatti@gmail.com"},
        };
        // GET: api/BankApp
        [ResponseType(typeof(IEnumerable<Bank>))]
        public IEnumerable<Bank> Get()
        {
            return accounts;
        }

        // GET: api/BankApp/5
        public IHttpActionResult Get(int id)
        {
            var account = accounts.FirstOrDefault((p) => p.AccountNumber == id);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        // POST: api/BankApp
        public IHttpActionResult Post([FromBody]Bank account)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            else
            {
                accounts.Add(new Bank
                {
                    AccHoldersName = account.AccHoldersName,
                    AccountNumber = account.AccountNumber,
                    AccountType = account.AccountType,
                    Address = account.Address,
                    Amount = account.Amount,
                    Contact = account.Contact,
                    CreationDate = account.CreationDate,
                    DOB = account.DOB,
                    EmailId = account.EmailId
                });
            }
            return Ok(account);
        }

        // PUT: api/BankApp/5
        public IHttpActionResult Put(int id, [FromBody]Bank account)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");


            var existingAccount = accounts.FirstOrDefault<Bank>(s => s.AccountNumber == id);


            if (existingAccount != null)
            {
                existingAccount.AccHoldersName = account.AccHoldersName;
                existingAccount.Amount = account.Amount;
                existingAccount.Contact = account.Contact;
                existingAccount.EmailId = account.EmailId;
                existingAccount.DOB = account.DOB;
                existingAccount.Address = account.Address;
                existingAccount.AccountType = account.AccountType;
            }
            else
            {
                return NotFound();
            }

            return Ok(existingAccount);
        }

        // DELETE: api/BankApp/5
        public IHttpActionResult Delete(int id)
        {
            var existingAccount = accounts.FirstOrDefault<Bank>(s => s.AccountNumber == id);


            if (existingAccount != null)
            {
                accounts.Remove(existingAccount);
            }
            else
            {
                return NotFound();
            }

            return Ok(existingAccount);
        }

    }
    }

