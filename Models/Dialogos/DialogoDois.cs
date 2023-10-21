using RPG.Models.Monstros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Dialogos;

internal class DialogoDois
{
    public static void Dormir()
    {
        Thread.Sleep(3000);
        Console.Clear();
        Menu.Menu.TituloMenu("Ruas de Yguäbä Ghrande");
        Thread.Sleep(1000);
        Console.WriteLine("\n\nComo você não tem pra onde ir, decide dormir em qualquer canto fedorento da cidade.");
        Thread.Sleep(1500);
        Console.WriteLine("Apesar do lugar insalubre, das pessoas passando, depois dessa batalha você está muito cansado e pega no sono rapidamente.");
        Thread.Sleep(1500);
        Console.WriteLine("\nPressione alguma tecla para prosseguir...\n");
        Console.ReadKey();
        Personagem.HealarVida();
        Thread.Sleep(2500);
        Console.Clear();
        Menu.Menu.TituloMenu("Ruas de Yguäbä Ghrande");
        Personagem.InformacoesDoPersonagem();
        Console.WriteLine("Ah... você se sente renovado da última batalha e pronto para outra aventura!");
        Thread.Sleep(1500);
        Console.WriteLine("\nPressione alguma tecla para continuar...\n");
        Console.ReadKey();
        Console.Clear();
        Menu.Menu.TituloMenu("Ruas de Yguäbä Ghrande");
        Console.WriteLine("\n\nMuito bem, você sente que agora está apto a falar com ele e pedir alguma ajuda.\n");
        Console.WriteLine("Então é isso que você decide fazer!\n");
        Thread.Sleep(2000);
        Console.WriteLine("\nAperte qualquer tecla para prosseguir...\n");
        Console.ReadKey();
        FalarComReiFraco();
    }

    public static void FalarComReiFraco()
    {
        Thread.Sleep(3000);
        Console.Clear();
        Menu.Menu.TituloMenu("Castelo Gótico do Rei Kharafèiä");
        Console.WriteLine("\n\nBom, você teve a audácia de subir até o Castelo do Rei Kharafèiä.");
        Thread.Sleep(1500);
        Console.WriteLine("Óbviamente os guardas reais não deixaram você adentrar o castelo.");
        Thread.Sleep(1500);
        Console.WriteLine("Olha que surpresa, o cachorro do rei é muito mais limpo que você!");
        Thread.Sleep(1500);
        Console.WriteLine("Mas você não desiste fácil... faz um verdadeiro auê só para tentar falar com o Rei.");
        Thread.Sleep(1500);
        Console.WriteLine("Quando você menos esperava, os guardas já estavam te dando um surra...");
        Thread.Sleep(1500);
        Console.WriteLine("De repente, o rei, o próprio Rei Kharafèiä aparece para entender do que se tratava aquela confusão que formava na porta do castelo...");
        Thread.Sleep(1500);
        Console.WriteLine("E... para a supresa de todos, o Rei Kharafèiä ordena para que os guardas o deixem em paz imediatamente!");
        Thread.Sleep(1500);
        Console.WriteLine("Para o espanto de todos, os guardas obedecem a ordem e o deixam sossegado, até lhe ajudam a levantar do chão.");
        Thread.Sleep(1500);
        Console.WriteLine($"Como é engraçado o destino! O rei diz que viu sua luta com {Monstros.Monstros.Nome} e adorou!");
        Thread.Sleep(1500);
        Console.WriteLine("Ele riu bastante mas reconheceu sua força...");
        Thread.Sleep(1500);
        Console.WriteLine("Diz que gostou de você e teria até uma missão especial para você, mas você está muito fraco ainda...");
        Thread.Sleep(1500);
        Console.WriteLine("Ele ordena que você treine mais e volte para encontrá-lo e saber que missão é essa...");
        Thread.Sleep(1500);
        Console.WriteLine("Antes de sair, pergunta seu nome...");
        Thread.Sleep(1500);
        Console.WriteLine($"Você responde: {Personagem.Nick}, vossa Majestade! Vou treinar como nunca e você ainda ouvirá muito esse nome!");
        Thread.Sleep(1500);
        Console.WriteLine("\nPressione algum botão para continuar...\n");
        Console.ReadKey();
        Treinamento();
    }

    public static void Treinamento()
    {
        Console.Clear();
        Menu.Menu.TituloMenu("Ruas de Yguäbä Ghrande");
        Thread.Sleep(3000);
        Console.WriteLine($"\n\nVocê decide treinar... percebe que essa é a sua chance!");
        Thread.Sleep(1500);
        Console.WriteLine("Sua chance de dar a volta por cima... mostrar o seu valor!");
        Thread.Sleep(1500);
        Console.WriteLine("Parar de se sentir um mendigo.");
        Thread.Sleep(1500);
        Console.WriteLine("Uma pessoa te avista e vem ao seu encontro...");
        Thread.Sleep(1500);
        Console.WriteLine($"Olá, {Personagem.Nick}, me chamo Khäga Thronkö, e vim a mando do Rei Kharafèiä.");
        Thread.Sleep(1500);
        Console.WriteLine("Ele me pediu para te treinar... e estou aqui pra isso!");
        Thread.Sleep(1500);
        Console.WriteLine($"Então, vamos logo com isso! Pegue seu equipamento, {Equips.Sword}, e só pare quando desmaiar!");
        Thread.Sleep(3500);
        Console.WriteLine("\n...\n");
        Thread.Sleep(2500);
        Console.WriteLine("Passa dia, passa noite, e você está se dedicando o máximo!");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Thread.Sleep(3500);
        Console.WriteLine("\nTreinamento em andamento...\n");
        Personagem.UparLevelAvancado();
        Thread.Sleep(3500);
        Console.WriteLine("\nUfa... parece que o treinamento foi concluído e você está pronto para falar com o rei de novo!");
        Thread.Sleep(1500);
        Console.WriteLine("Khäga Thronkö vem até sua direção...");
        Thread.Sleep(1500);
        Console.WriteLine($"Parabéns, {Personagem.Nick}, seu treinamento foi concluído!");
        Thread.Sleep(1500);
        Console.WriteLine("Você parece ter evoluído bastante... Parabéns!\n\n");
        Thread.Sleep(1500);
        Personagem.InformacoesDoPersonagem();
        Thread.Sleep(1500);
        Console.WriteLine("\nO Rei Kharafèiä também ordenou que lhe entregasse novas vestimentas!");
        Thread.Sleep(1500);
        Console.WriteLine("Elas irão te ajudar na sua nova missão!");
        Thread.Sleep(3500);
        Console.WriteLine("\nPressione alguma tecla para prosseguir ao Castelo.");
        Console.ReadKey();
        FalarComReiForte();
    }

    public static void FalarComReiForte()
    {
        Thread.Sleep(1500);
        Console.Clear();
        Menu.Menu.TituloMenu("Castelo Gótico do Rei Kharafèiä");
        Console.WriteLine("\n\nVocê chegou ao Castelo e foi recebido bem por todos, bem diferente da primeira vez que esteve aqui.");
        Thread.Sleep(1500);
        Console.WriteLine("O Rei vem em sua direção e o parabeniza, pois você nitidamente parece mais forte!");
        Thread.Sleep(1500);
        Console.WriteLine("Apesar do elogio, o Rei Kharafèiä continua com uma expressão bem séria...");
        Thread.Sleep(1500);
        Console.WriteLine("Ele te diz em tom melancólico que a missão que ele tem pra te passar é quase suicída...");
        Thread.Sleep(1500);
        Console.WriteLine("Vários outros guerreiros já tentaram a sorte antes de você, e infelizmente, não voltaram pra casa...");
        Thread.Sleep(4500);
        Console.WriteLine("\nHá algum tempo, um dragão vem aterrorizando a cidade...");
        Thread.Sleep(1500);
        Console.WriteLine("Ele está destruindo plantações, gado e até mesmo ceifando vidas de fazendeiros...");
        Thread.Sleep(1500);
        Console.WriteLine("A população de Yguäbä Ghrande está completamente aterrorizada e muitos nem de casa saem mais!");
        Thread.Sleep(1500);
        Console.WriteLine("Já perdi muitos guerreiros indo enfrentar esse terrível dragão...");
        Thread.Sleep(1500);
        Console.WriteLine($"Nossa última alternativa é você, {Personagem.Nick}!");
        Thread.Sleep(4500);
        Console.WriteLine("\nMais forte que nunca e com novos equipamentos, acho que você tem a plena chance de vencer essa batalha!");
        Thread.Sleep(1500);
        Console.WriteLine("Os guardas o acompanharão até as muralhas do castelo e te indicarão onde você poderá encontrar a fera...");
        Thread.Sleep(1500);
        Console.WriteLine($"Que os Deuses estejam com você, {Personagem.Nick}, e que possa nos salvar!");
        Thread.Sleep(1500);
        Console.WriteLine("\nAperte qualquer tecla para continuar...");
        Console.ReadKey();
        BatalhaFinal();
    }

    public static void BatalhaFinal()
    {
        Thread.Sleep(3000);
        Console.Clear();
        Menu.Menu.TituloMenu("Além das muralhas de Yguäbä Ghrande");
        Console.WriteLine("\n\nOs guardas te levam até o portão e dizem que agora você deve continuar por conta própria...");
        Thread.Sleep(1500);
        Console.WriteLine("Eles apontam a direção que você deve seguir e que ali você encontrará o terrível Dragão.");
        Thread.Sleep(1500);
        Console.WriteLine("Que Deus lhe guie, dizem os guardas ao se despedirem... o olhar deles entrega que provavelmente nunca mais o verão.");
        Thread.Sleep(1500);
        Console.WriteLine("O lugar é além das colinas... e você começa sua jornada.");
        Thread.Sleep(4500);
        Console.WriteLine("\nCaminhando...");
        Thread.Sleep(1500);
        Console.WriteLine("Caminhando...");
        Thread.Sleep(1500);
        Console.WriteLine("...\n");
        Thread.Sleep(4500);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Thread.Sleep(2500);
        Console.Clear();
        Menu.Menu.TituloMenu("Covil do Dragão Ancestral das Neves");
        Console.WriteLine("\n\nSó de chegar perto, você já consegue sentir o clima mais pesado...");
        Thread.Sleep(1500);
        Console.WriteLine("O lugar é quente como o próprio inferno!");
        Thread.Sleep(1500);
        Console.WriteLine("Um cheiro de enxofre horrível... você começa a sentir calafrios...");
        Thread.Sleep(1500);
        Console.WriteLine("Você não percebeu ainda, mas o lugar está lotado de esqueletos humanos!");
        Thread.Sleep(1500);
        Console.WriteLine("E o Dragão Ancestral das Neves já te viu de longe e voa até perto de você.");
        Thread.Sleep(1500);
        Console.WriteLine("Ele é simplesmente enorme... gigantesco! Você está totalmente petrificado de medo...");
        Thread.Sleep(1500);
        Console.WriteLine("Você sabe que não vai conseguir simplesmente ir embora agora... o jeito vai ser ir para batalha com honra!");
        Thread.Sleep(1500);
        Console.WriteLine("Aliás, você se lembra de todo o treinamento pesado que passou e o quanto está forte...");
        Thread.Sleep(1500);
        Console.WriteLine("Aos poucos você vai se acalmando e se lembra de que todos os moradores de Yguäbä Ghrande contam com você...");
        Thread.Sleep(1500);
        Console.WriteLine("O jeito vai ser ir pra cima!!!");
        Thread.Sleep(4500);
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
        Dragao dragao = new Dragao();
        Thread.Sleep(1500);
        Batalha.Luta(dragao);
    }
}
