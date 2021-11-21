using _3C1FAEL43.Code.DAL;
using _3C1FAEL43.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1FAEL43.Code.BLL
{
    class RIBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "Estoque";
        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(RIDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Produto}','{medDto.Quantidade}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(RIDTO medDto)
        {
            string editar = $"update {tabela} set Produto = '{medDto.Produto}', Quantidade = '{medDto.Quantidade}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(RIDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
