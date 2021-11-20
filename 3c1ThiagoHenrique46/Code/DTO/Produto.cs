using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1ThiagoHenrique46.Code.DTO
{
    class Produto
    {
        private int _id;
        private string _nome;
        private int _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Preco { get => _preco; set => _preco = value; }
    }
}
