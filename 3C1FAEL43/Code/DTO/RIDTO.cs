using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1FAEL43.Code.DTO
{
    class RIDTO
    {
        private int _id;
        private string _produto, _Quantidade;

        public int Id { get => _id; set => _id = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public string Quantidade { get => _Quantidade; set => _Quantidade = value; }
    }
}
