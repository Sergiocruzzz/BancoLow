// See https://aka.ms/new-console-template for more information
using bancoLow;


//Classes
Cliente c = new Cliente();
NewUserdin n = new NewUserdin();





// Tela de cadastro
string action = "";
  Console.WriteLine("Bem Vindo ao banco low");
    System.Console.WriteLine("--------------------------");
    Console.ReadLine();

  System.Console.WriteLine("Ja tem cadastro conosco? (s) para sim (n) para não e (f) para sair");
    action = Console.ReadLine();

switch (action)
{
//caso cliente seja novo
    case "n":
      System.Console.WriteLine("Vamos criar seu cadastro!");
        Console.ReadLine();
      
      System.Console.WriteLine("Como voce quer ser chamado?");
        c.Usuario = Console.ReadLine();

      System.Console.WriteLine("Qual seu CPF?");
        c.NewCpf = Console.ReadLine();

      System.Console.WriteLine("Agora sua senha");
        c.Senha = Console.ReadLine();
      
      break;


    case "s":
//caso cliente seja antigo
      System.Console.WriteLine("por favor digite seu usuario para prosseguirmos: ");
        c.Nome = Console.ReadLine();

      if (c.Nome == "Sergio")
    {
        c.Cpf = "08752934468";
    }
      System.Console.WriteLine("agora sua senha: ");
        Console.ReadLine();
      System.Console.WriteLine( "Boa tarde "+c.Nome+" portador do cpf "+c.Cpf+" seu saldo é de "+c.dinheiro+"!!");
        Console.ReadLine();

        break;

    default:
      System.Console.WriteLine("Ate a proxima");
      break;
}


//Tela de deposito inicial se for um novo cliente
if (action == "n")
{
  System.Console.WriteLine("Bem vindo "+c.Usuario+" como novo usuario voce precisa fazer um deposito, quanto quer depositar? ");
    c.Din =Int32.Parse(Console.ReadLine());
  

  string acao = "";

  System.Console.WriteLine( "Deseja depositar(d), sacar(s), ou sair(f)");
    acao = Console.ReadLine();


int sacar=0 , saque=0;
switch (acao)
{  

//caso novo cliente queira sacar
    case "s":
    System.Console.WriteLine("Seu saldo é de "+c.din+" quanto deseja sacar?" );
      sacar = Convert.ToInt32 (Console.ReadLine());
        if (sacar > c.din)
        {
          System.Console.WriteLine("Saldo insuficiente para saque, por favor reveja os dados");
          break;
        }  
        
        else {
          saque = c.din - sacar;
      }
//fim da operação    
    System.Console.WriteLine("Seu novo saldo é de "+saque+" obrigado por usar o banco Low!!"); 
      Console.ReadLine();
    
    break;

//tela de saida    
  default:
    System.Console.WriteLine("Obrigado pela preferencia ate a proxima!");
    break;
}
}
//caso seja cliente antigo
else
{

string acao = "";

System.Console.WriteLine( "Deseja depositar(d), sacar(s), ou sair(f)");
  acao = Console.ReadLine();
int sacar=0 , saque=0, novoSaldo=0, depositou;

switch (acao)
{
//caso o cliente queira depositar
    case "d":
      System.Console.WriteLine("Quanto deseja depositar?");
        depositou = Convert.ToInt32 (Console.ReadLine());
    
    novoSaldo = c.dinheiro+depositou;
    
      System.Console.WriteLine("Seu novo saldo é de: "+novoSaldo+" Obrigado por usar o banco Low!! até a proxima");
    break;
//caso cliente queira sacar
    case "s":
      System.Console.WriteLine("Seu saldo é de "+c.dinheiro+" quanto deseja sacar?" );
    sacar = Convert.ToInt32 (Console.ReadLine());
      if (sacar > c.dinheiro)
        {
        System.Console.WriteLine("Saldo insuficiente para saque, por favor reveja os dados");
        break;
        }  
        
      else {
        saque = c.dinheiro - sacar;
      }
//tela de saida    
    System.Console.WriteLine("Seu novo saldo é de "+saque+" obrigado por usar o banco Low!!"); 
      Console.ReadLine();
    
    break;

    default:
      System.Console.WriteLine("Obrigado pela preferencia ate a proxima!");
    break;
}
}
//FIM
