public class TelaCadastro : ITela
{
public void Exibir()
{
Console.WriteLine("===== Tela de Cadastro =====");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("E-mail: ");
string email = Console.ReadLine();
Console.Write("Senha: ");
string senha = Console.ReadLine();

Console.WriteLine($"Usuário {nome} cadastrado com sucesso!");
Console.WriteLine("==========================");
Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
Console.ReadKey();
        
var telaInicial = new TelaInicial();
telaInicial.Exibir();
}
}