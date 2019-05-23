using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployController : ApiController
    {
        
             Employ[] arrEmploy = new Employ[]
        {

        new Employ{ Empno=1, Name="PPP",Dept="fgfgdsfg",Design="sdfgvs",Basic=5633},
        new Employ{ Empno=2, Name="PP",Dept="fgdsfg",Design="sdgvsfg",Basic=5623},
        new Employ{ Empno=3, Name="P",Dept="fgfgdg",Design="sdfgvsg",Basic=5632},
        new Employ{ Empno=4, Name="PPPP",Dept="fgdsfg",Design="sfgvsfg",Basic=5323},
        new Employ{ Empno=5, Name="PPPPP",Dept="fgfg",Design="vsfg",Basic=6323},
        };

    }
}