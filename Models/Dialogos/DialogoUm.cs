using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models.Menu;
using RPG.Models.Monstros;

namespace RPG.Models.Dialogos;

public class DialogoUm
{

    public static void DialogoComerciante()
    {
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("\nO comerciante é um Ferreiro da cidade. Ele está espantado com suas vestimentas. Diz que nunca viu nada tão esfarrapado e que hoje é seu dia de sorte, pois nos fundos da loja há uma bota em melhores condições, diz que pode lhe arrumar de graça e pede para você ir buscá-la.");
        Thread.Sleep(1200);
        Console.WriteLine("No caminho, você encontra uma aranha um tanto quanto exótica. Ela tem mais de 1 metro de tamanho! Você está completamente paralisado.\n");
        Thread.Sleep(1200);
        Console.WriteLine("1. Enfrentar a Aranha Gigante com muita coragem e fé.");
        Console.WriteLine("2. Gritar por ajuda ao velho Ferreiro.");
        Console.WriteLine("3. Sair correndo como um covarde.\n");
        string opcao = Console.ReadLine()!;
        int opcaoEscolhida = int.Parse(opcao);
        Thread.Sleep(2300);
        Console.Clear();

        switch (opcaoEscolhida)
        {
            case 1: OpcaoUmLutar();
                break;
            case 2: OpcaoDoisAjuda();
                break;
            case 3: OpcaoTresFugir();
                break;
        }
    }

    public static void OpcaoUmLutar()
    {
        Menu.Menu.TituloMenu("Covil da Aranha Demoníaca");
        Console.WriteLine("\nVocê, em um ato de coragem, decidiu enfrentar esta aberração. Lembre-se que ela pode te atacar e quanto maior a velocidade dela, mais chance tem de desviar dos seus golpes!");
        Thread.Sleep(1200);
        Console.WriteLine($"Sem perder tempo, você pega {Equips.Sword} e parte pra cima da aranha demoníaca!\n\n");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Spider aranhaGigante = new Spider();
        Batalha.Luta(aranhaGigante);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void OpcaoDoisAjuda()
    {
        Menu.Menu.TituloMenu("Covil da Aranha Demoníaca");
        Console.WriteLine("O velho e barrigudo comerciante ri alto de ver você gritando por ajuda como uma hyena medrosa!");
        Thread.Sleep(1200);
        Console.WriteLine($"Ele diz que não vai ajudar alguém que se entitula um {Personagem.Vocacao} a matar uma aranha de banheiro!");
        Thread.Sleep(1200);
        Console.WriteLine("Ele grita pra você fazer o trabalho sozinho!");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Spider aranhaGigante = new Spider();
        Batalha.Luta(aranhaGigante);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void OpcaoTresFugir()
    {
        Menu.Menu.TituloMenu("Covil da Aranha Demoníaca");
        Console.WriteLine("Você como um terrível estabanado, estava com tanto medo que ao correr tropeçou nas próprias pernas!");
        Thread.Sleep(1200);
        Console.WriteLine("Não tem mais jeito... você olha pra trás e ela já está no seu cangote com as presas pra fora!");
        Thread.Sleep(1200);
        Console.WriteLine("O jeito vai ser tentar se levantar e partir pra porrada!");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Spider aranhaGigante = new Spider();
        Batalha.Luta(aranhaGigante);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void DialogoEsmola()
    {
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("\nSentado, que nem um morador de rua, esfarrapado, fedendo. As pessoas estão até com nojo de chegar perto de você para lhe dar esmola.");
        Thread.Sleep(1200);
        Console.WriteLine("Um guarda da cidade passa por você e fica enfurecido, alegando que estás a importunar os transuintes da cidade.");
        Thread.Sleep(1200);
        Console.WriteLine("Ele te enche de bicudas como se você fosse uma bola. Só para quando você cai em cima de um bueiro, e diz que lá é o seu lugar.");
        Thread.Sleep(1200);
        Console.WriteLine("Pela ironia do destino você dá de cara com um rato velho e gigantesco. Esse rato parece ter o tamanho de uma carroça!");
        Thread.Sleep(1200);
        Console.WriteLine("Ele está muito furioso por você ter o acordado. Ele está disposto a arrancar fora a alma do seu corpo e te contrair raiva!");
        Thread.Sleep(1200);
        Console.WriteLine("\nVocê tem essas opções:\n");
        Console.WriteLine("1. Enfrentar o Rato Velho com muita coragem e fé.");
        Console.WriteLine("2. Gritar por ajuda a algum guarda passando.");
        Console.WriteLine("3. Sair correndo como um covarde.\n");
        string opcao = Console.ReadLine()!;
        int opcaoEscolhida = int.Parse(opcao);
        Thread.Sleep(2300);
        Console.Clear();

        switch (opcaoEscolhida)
        {
            case 1:
                OpcaoQuatroLutar();
                break;
            case 2:
                OpcaoCincoAjuda();
                break;
            case 3:
                OpcaoSeisFugir();
                break;
        }
    }

    public static void OpcaoQuatroLutar()
    {
        Menu.Menu.TituloMenu("Bueiro do Rato Véio Raivoso");
        Console.WriteLine("\nVocê, em um ato de coragem, decidiu enfrentar esta aberração. Lembre-se que ele pode te atacar e quanto maior a velocidade dele, mais chance tem de desviar dos seus golpes!");
        Thread.Sleep(1200);
        Console.WriteLine($"Sem perder tempo, você pega {Equips.Sword} e parte pra cima desse rato asqueroso!\n\n");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Rato ratoGigante = new Rato();
        Batalha.Luta(ratoGigante);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void OpcaoCincoAjuda()
    {
        Menu.Menu.TituloMenu("Bueiro do Rato Véio Raivoso");
        Console.WriteLine($"Os guardas riem de se babar ouvindo você pedindo ajuda. Uma figura tão patética, que se diz um {Personagem.Vocacao}... digno de pena!");
        Thread.Sleep(1200);
        Console.WriteLine($"Alguns deles até se aproximam pra ver a surra que este Rato Véio Raivoso vai te dar!");
        Thread.Sleep(1200);
        Console.WriteLine("E olha que surpresa, todos eles estão torcendo para o Rato!");
        Thread.Sleep(1200);
        Console.WriteLine("É, não vai ter jeito... agora é você e esse maldito Rato!");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Rato ratoGigante = new Rato();
        Batalha.Luta(ratoGigante);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void OpcaoSeisFugir()
    {
        Menu.Menu.TituloMenu("Bueiro do Rato Véio Raivoso");
        Console.WriteLine("Você como um terrível estabanado, estava com tanto medo que ao correr tropeçou nas próprias pernas!");
        Thread.Sleep(1200);
        Console.WriteLine("Não tem mais jeito... você olha pra trás e ele já está no seu cangote com seus dentes afiados e amarelados pra fora!");
        Thread.Sleep(1200);
        Console.WriteLine("O jeito vai ser tentar se levantar e partir pra porrada!");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Rato ratoGigante = new Rato();
        Batalha.Luta(ratoGigante);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void DialogoSairCidade()
    {
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("\nOk. Mesmo fraco como um graveto e despreparado como uma criança, você teve a brilhante ideia de sair para explorar por si só.");
        Thread.Sleep(1200);
        Console.WriteLine("Pra sua sorte ou azar, em outro canto da praça onde você está, um bêbado com muito vinho e hidromel na cabeça começa a berrar em sua direção.");
        Thread.Sleep(1200);
        Console.WriteLine("Acho que ele está te chamando e parece que não foi muito com a sua cara...");
        Thread.Sleep(1200);
        Console.WriteLine("Ele vem até sua direção e começa a te insultar sem motivo algum. Pergunta de onde veio alguém tão esfarrapado.");
        Thread.Sleep(1200);
        Console.WriteLine("Ele acha que você quer roubar o posto dele de bêbado/mendigo/pedinte e está babando de raiva por isso.");
        Thread.Sleep(1200);
        Console.WriteLine("Sem titubear muito, ele tenta te acertar um soco, que por sorte sua, pegou apenas de raspão...");
        Thread.Sleep(1200);
        Console.WriteLine("\nVocê tem essas opções:\n");
        Console.WriteLine("1. Enfrentar o Bêbado Raivoso com muita coragem e fé.");
        Console.WriteLine("2. Gritar por ajuda a algum guarda passando.");
        Console.WriteLine("3. Sair correndo como um covarde.\n");
        string opcao = Console.ReadLine()!;
        int opcaoEscolhida = int.Parse(opcao);
        Thread.Sleep(2300);
        Console.Clear();

        switch (opcaoEscolhida)
        {
            case 1:
                OpcaoSeteLutar();
                break;
            case 2:
                OpcaoOitoAjuda();
                break;
            case 3:
                OpcaoNoveFugir();
                break;
        }
    }

    public static void OpcaoSeteLutar()
    {
        Menu.Menu.TituloMenu("Bar do Beiçola");
        Console.WriteLine("\nVocê, em um raro ato de coragem, decidiu enfrentar este bêbado maluco. Lembre-se que ele pode te atacar e quanto maior a velocidade dele, mais chance tem de desviar dos seus golpes!");
        Thread.Sleep(1200);
        Console.WriteLine($"Sem perder tempo, você pega {Equips.Sword} e parte pra cima desse vagabundo de marca maior!\n\n");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Bebado bebadoRaivoso = new Bebado();
        Batalha.Luta(bebadoRaivoso);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void OpcaoOitoAjuda()
    {
        Menu.Menu.TituloMenu("Bar do Beiçola");
        Console.WriteLine($"Os guardas riem de se babar ouvindo você pedindo ajuda. Uma figura tão patética, que se diz um {Personagem.Vocacao}... digno de pena!");
        Thread.Sleep(1200);
        Console.WriteLine($"Alguns deles até se aproximam pra ver a surra que este bêbado vai te dar!");
        Thread.Sleep(1200);
        Console.WriteLine("E olha que surpresa, todos eles estão torcendo para o bêbado!");
        Thread.Sleep(1200);
        Console.WriteLine("É, não vai ter jeito... agora é você e esse maldito embriagado!");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Bebado bebadoRaivoso = new Bebado();
        Batalha.Luta(bebadoRaivoso);
        Console.Clear();
        MenuJornada.JornadaDois();
    }

    public static void OpcaoNoveFugir()
    {
        Menu.Menu.TituloMenu("Bar do Beiçola");
        Console.WriteLine("Você como um terrível estabanado, estava com tanto medo que ao correr tropeçou nas próprias pernas!");
        Thread.Sleep(1200);
        Console.WriteLine("Não tem mais jeito... você olha pra trás e ele já está no seu cangote, com um bafo mortal de cachaça e olhos vermelhos.");
        Thread.Sleep(1200);
        Console.WriteLine("O jeito vai ser tentar se levantar e partir pra porrada!");
        Console.WriteLine("\nAperte alguma tecla para prosseguir.");
        Console.ReadKey();
        Thread.Sleep(1500);
        Bebado bebadoRaivoso = new Bebado();
        Batalha.Luta(bebadoRaivoso);
        Console.Clear();
        MenuJornada.JornadaDois();
    }
}
