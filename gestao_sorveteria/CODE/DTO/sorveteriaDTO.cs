using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_sorveteria.CODE.DTO
{
    class sorveteriaDTO
    {
        private int _id;
        private string _nome;
        private string _endereco;

        public int id { get => id; set => _id = value; }
        public string nome { get => nome; set => _nome = value; }
        public string endereco { get => endereco; set => _endereco = value; }

    }
}
