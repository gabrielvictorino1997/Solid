﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Payments
{
    class DebitCard : NubankCard
    {
        public override void Validade()
        {
            Console.WriteLine("Validando saldo da conta...");
            Console.WriteLine("Saldo disponível");
        }
    }
}
