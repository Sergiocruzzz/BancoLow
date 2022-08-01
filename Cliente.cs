using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bancoLow
{
    public class Cliente
    {
        
        private String nome;
        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    
        
        public int dinheiro;
        
       public Cliente (){
        dinheiro = 4000;
       }
       public string Cpf;
       
       //fazer no BD junto com o banco LOW cadastrando usuarios!!
       
        
        //usar um construtor para classe Cliente!!
        
        
        
    }
}
