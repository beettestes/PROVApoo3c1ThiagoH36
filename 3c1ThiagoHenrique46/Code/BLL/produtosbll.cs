using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3c1ThiagoHenrique46.Code.DTO;
using _3c1ThiagoHenrique46.Code.DAL;
using System.Data;

namespace _3c1ThiagoHenrique46.Code.BLL
{
    class produtosbll
    {
        conexao conect = new conexao();

        public void ADD(Produto vardto)
        {
            string comand = $"insert into colunas values(null, '{vardto.Nome}', '{vardto.Preco}')";
            conect.Exe(comand);
        }

        public void EDIT(Produto vardto)
        {
            string comand = $@"update colunas set nome = '{vardto.Nome}',
                                Preco ='{vardto.Preco}' where id ='{vardto.Id}';";
            conect.Exe(comand);
        }

        public void DELETE(Produto vardto)
        {
            string comand = $"delete from colunas where id = {vardto.Id}";
            conect.Exe(comand);
        }

        public DataTable LIST()
        {
            string comand = $"select * from colunas order by id";
            return conect.consulta(comand);
        }
    }
}
