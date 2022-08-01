// See https://aka.ms/new-console-template for more information
using bancoLow;

Console.WriteLine("Bem Vindo ao banco low");
System.Console.WriteLine("--------------------------");
Console.ReadLine();

Cliente c = new Cliente();



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
//---------------------------------------------------------------------------------------------------------------//
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
    
    System.Console.WriteLine("Seu novo saldo é de "+saque+" obrigado por usar o banco Low!!"); 
    Console.ReadLine();
    
    break;

    default:
    System.Console.WriteLine("Obrigado pela preferencia ate a proxima!");
    break;
}

