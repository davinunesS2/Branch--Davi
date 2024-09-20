public class TelaLogin : ITela
{
    public void Exibir()
    {
    Console.Clear();
    Console.WriteLine("===== Tela de Login =====");
    Console.Write("Usuário: ");
    string usuario = Console.ReadLine();
    Console.Write("Senha: ");
    string senha = Console.ReadLine();
        
    Console.WriteLine($"Usuário {usuario} logado com sucesso!");
    
    DarFeedback();
    void DarFeedback()
{

Console.WriteLine("===== Dar Feedback =====");
Console.WriteLine("Digite seu feedback:");
string feedback = Console.ReadLine();
Console.WriteLine("Obrigado pelo seu feedback!");

}
        
 var telaInicial = new TelaInicial();
telaInicial.Exibir();
}
}