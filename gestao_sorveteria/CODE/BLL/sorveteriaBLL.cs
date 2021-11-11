using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestao_sorveteria.CODE.DTO;
using gestao_sorveteria.CODE.DAL;
namespace gestao_sorveteria.CODE.DTO
{
    class sorveteriaBLL
    {
        Acessobanco conexao = new Acessobanco();
        string tabela = "tbl_sorveteria";
        public void inserir(SorveteriaDTO sorvdto)
        {
            private void btn_cadastrar_Click(sorveteriaBLL sorvbll)
            {
                string inserir = $"insert into {tabela} values (null, '{sorvdto.nome}', '{sorvdto.endereco}')";
                conexao.ExecutaInserir(inserir);
            }

            private void btn_editar_Click(sorveteriaBLL sorvbll)
            {

            }

            private void btn_excluir_Click(sorveteriaBLL sorvbll)
            {


            }
        }
}
