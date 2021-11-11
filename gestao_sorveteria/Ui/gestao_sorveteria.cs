using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestao_sorveteria.CODE.BLL;
using gestao_sorveteria.CODE.DTO;


namespace gestao_sorveteria
{
    public partial class gestao_sorveteria : Form
    {
        SorveteriaBLL sorvbll = new SorveteriaBLL();
        SorveterioDTO sorvdto = new SorveteriaDTO();
        public gestao_sorveteria()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            sorvdto.Nome = txt_nome.Text;
            sorvdto.Endereco = txt_endereco.Text;

            sorvbll.inserir(sorvdto);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
