using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projecteuler.Models
{
    public abstract class Solver
    {
        public string Solution; //put solution here

        public abstract void Solve();
    }
}