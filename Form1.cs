using Microsoft.VisualBasic.ApplicationServices;

namespace Aula06Streaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic_O_Menu_Click(object sender, EventArgs e)
        {
            string titulo = "O Menu";
            string descricao = "Um jovem casal visita um restaurante exclusivo em uma ilha remota onde o aclamado chef prepara um delicioso menu e algumas surpresas chocantes.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/OMenu.jpg";
            string link_video = "https://www.youtube.com/embed/lfbYsIIFYaw"; 

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;

            tela_info.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string titulo = "X - A Marca Da Morte";
            string descricao = "Um grupo de atores se propõe a fazer um filme adulto na zona rural do Texas, sob o nariz de seus anfitriões reclusos. Quando os donos do local pegam seus jovens convidados no ato, o elenco se vê em uma luta desesperada por suas vidas.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/AMarcaDaMorte.jpg";
            string link_video = "https://www.youtube.com/embed/1cOp7UpeXUk";

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.Show();
        }

        private void picChihiro_Click(object sender, EventArgs e)
        {
            string titulo = "A Viagem De Chihiro";
            string descricao = "Chihiro e seus pais estão se mudando para uma cidade diferente. A caminho da nova casa, o pai decide pegar um atalho. Eles se deparam com uma mesa repleta de comida, embora ninguém esteja por perto. Chihiro sente o perigo, mas seus pais começam a comer. Quando anoitece, eles se transformam em porcos. Agora, apenas Chihiro pode salvá-los.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/Chihiro.jpg";
            string link_video = "https://www.youtube.com/embed/ByXuk9QqQkk";

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.Show();
        }

        private void picBlackMirror_Click(object sender, EventArgs e)
        {
            string titulo = "Black Mirror";
            string descricao = "Em uma era na qual a tecnologia está em todos os lugares, Black Mirror propõe uma discussão sobre como ela aprisiona e domina os usuários.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/BlackMirror.jpg";
            string link_video = "https://www.youtube.com/embed/V0XOApF5nLU";

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.Show();

        }

        private void picBlueExorcist_Click(object sender, EventArgs e)
        {
            string titulo = "Blue Exorcist";
            string descricao = "Determinado a se livrar da maldição de ser filho ilegítimo de Satã, Okumura Rin segue os passos de seu mentor e se alista na Academia Vera Cruz para se tornar um exorcista.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/BlueExorcist.jpg";
            string link_video = "https://www.youtube.com/embed/0HHNeeXrysA";

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.Show();
        }

        private void picChainsawMan_Click(object sender, EventArgs e)
        {
            string titulo = "Chainsaw Man";
            string descricao = "Chainsaw Man acompanha a história do jovem Denji, que ficou endividado após a morte do pai. Por um acaso do destino, o protagonista salva um cão-Demônio chamado Pochita, ele passa a receber dinheiro para matar demônios para a Yakuza.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/ChainsawMan.jpg";
            string link_video = "https://www.youtube.com/embed/l96zmDlWCBk";

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.Show();
        }

        private void picAttackOnTitan_Click(object sender, EventArgs e)
        {
            string titulo = "Attack On Titan";
            string descricao = "Para escapar dos titãs, gigantes devoradores de homens, a humanidade se refugiou em cidades cercadas por enormes muralhas. Quando eles voltam a atacar, Eren Yeager se junta à luta para combater as criaturas.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/AttackOnTitan.jpg";
            string link_video = "https://www.youtube.com/embed/LV-nazLVmgo";

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.Show();
        }

        private void picSpyFamily_Click(object sender, EventArgs e)
        {
            string titulo = "Spy X Family";
            string descricao = "A história de Spy x Family segue a vida de Twilight, um espião que precisa formar uma família de forma repentina para executar uma missão.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/SpyFamily.jpg";
            string link_video = "https://www.youtube.com/embed/ofXigq9aIpo";

            Form2 tela_info = new Form2();
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.link_video = link_video;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.Show();

        }

        private void picCasteloAnimado_Click(object sender, EventArgs e)
        {
            string titulo = "O Castelo Animado";
            string descricao = "Uma bruxa lança uma terrível maldição sobre a jovem Sophie transformando-a numa velha de 90 anos. Desesperada, ela embarca numa odisseia em busca do Castelo Andante, onde reside um misterioso feiticeiro que poderá ajudá-la a reverter o feitiço.";
            string caminho_imagem = "C:/Users/mirela.jsalmeida/source/repos/Aula06Streaming/Aula06Streaming/ImagensFundo/CasteloAnimado.jpg";
            string link_video = "https://www.youtube.com/embed/iwROgK94zcM";

            Form2 tela_info = new Form2();

            
            tela_info.titulo = titulo;
            tela_info.descricao = descricao;
            tela_info.caminho_imagem = caminho_imagem;
            tela_info.link_video = link_video;
            tela_info.Show();
        }
    }
}