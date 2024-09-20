public class TelaInicial : ITela
{
 public void Exibir(){
Console.WriteLine("===== Tela Inicial =====");
Console.WriteLine("1. Logar");
Console.WriteLine("2. Cadastrar-se\n");
Console.Write("Escolha uma opção: ");
        
var opcao = Console.ReadLine();
switch (opcao)
{
 case "1":
   var telaLogin = new TelaLogin();
   telaLogin.Exibir();
 break;
 case "2":
   var telaCadastro = new TelaCadastro();
   telaCadastro.Exibir();
 break;
 default:
   Console.WriteLine("Opção inválida. Tente novamente.");
 Exibir();
 break;
}
}
}