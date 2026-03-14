// robo de atendimento

int opcao;
float saldo = 1200F;

Console.WriteLine("                          Digite a Opção desejada:                                      ");
Console.WriteLine("                          1 - Desbloqueio de Cartão                                     ");
Console.WriteLine("                          2 - Bloqueio de Cartão                                        ");
Console.WriteLine("                          3 - Ver saldo da conta                                        ");
Console.WriteLine("                          4 - Fazer Transferencia                                       ");
Console.WriteLine("                          5 - Ver extrato                                               ");
Console.WriteLine("                        ============================                                    ");

opcao = int.Parse(Console.ReadLine());

switch(opcao)
{
    case 1:
        {
            Console.WriteLine(" Cartão desbloqueado com sucesso! ");
            break;
        }
    case 2:
        {
            Console.WriteLine(" Cartão Bloqueado com sucesso! (para desbloquear reinicie o programa e acesse opção 1.) ");
            break;
        }
    case 3:
        {
            Console.WriteLine("O saldo da sua conta é: " + "R$" + saldo);
            break;
        }
    case 4:
        {
            Console.WriteLine("Digite a chave PIX para realizar a transferencia: ");
            Console.WriteLine("Este é o saldo disponivel: " + saldo);
            break;
        }
    case 5:
        {
            Console.WriteLine("Aqui você pode conferir seu extrato: ");
            List <string> extrato = new List<string>();
            extrato.Add("Transferência de 500 para João em 17/02");
            extrato.Add("Depósito de 1.700 em 14/02");
            extrato.Add("Saque de 100 em 12/02");
            
            foreach (string item in extrato)
            {
                Console.WriteLine(item);
            }
            break;
        }
    default:
        {
            Console.WriteLine("Nenhuma Opção selecionada, encerrando o sistema...");
            break;
        }
}

