using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projecteuler.Models;

namespace projecteuler.Controllers
{
    public class ProblemsController : ApiController
    {
        //GET api/problems/
        public IEnumerable<string> Get()
        {
            return new string[] { "nothing here, try using api/problems/1" };
        }

        // GET api/problem/1
        public string Get(int id)
        {
            string result = "";
            Solver problem = new Problem1();
            if (id == 1)            
                problem = new Problem1();
            if (id == 2)            
                problem = new Problem2();
            if (id == 3)            
                problem = new Problem3();
            if (id == 4)            
                problem = new Problem4();
            if (id == 5)            
                problem = new Problem5();

            problem.Solve();
            return problem.Solution;




            return result;
        }
}
}
