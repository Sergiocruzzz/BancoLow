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
       
    //novo cadastro de CPF


    private String newCpf;
    public String NewCpf
    {
        get { return newCpf; }
        set { newCpf = value; }
    }
    

    public int din;
    public int Din
    {
        get { return din; }
        set { din = value; }
    }
    



       private String usuario;
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        
        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
       //fazer no BD junto com o banco LOW cadastrando usuarios!!
       
        
        //usar um construtor para classe Cliente!!
        
        
        
    }
}
