using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQueryableApplication
{
    class EMPIQUERYABLE
    {
        [Key]
        public int EMPNO { get; set; }
        public string ENAME { get; set; }
        public string JOB { get; set; }
        public string MGR { get; set; }
        public DateTime HIREDATE { get; set; }
        [Column(TypeName="money")]
        public decimal SAL { get; set; }
        [Column(TypeName = "money")]
        public decimal COMM { get; set; }
        public int DEPTNO { get; set; }
    }
}
