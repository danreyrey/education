using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2025_12_09_OOP
{
    public class SmallBusiness : BusinessAccount
    {
        private bool ProofOfSmallBusiness;
        public SmallBusiness(string customerNumber, string accountNumber, string bankCode, bool proofOfSmallBusiness) :  base (customerNumber, accountNumber, bankCode)
        {
            ProofOfSmallBusiness = proofOfSmallBusiness;
        }

        public bool GetProofOfSmallBusiness() => this.ProofOfSmallBusiness;

        public void SetProofOfSmallBusiness(bool newProofOfSmallBusiness) => this.ProofOfSmallBusiness = newProofOfSmallBusiness;
    }
}
