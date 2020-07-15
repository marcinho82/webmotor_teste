using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste_webmotors.Models
{
    public class WebMotorsModel
    {
        public int ID { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string versao { get; set; }
        public int ano { get; set; }
        public int quilometragem { get; set; }
        public string observacao { get; set; }
    }
}
