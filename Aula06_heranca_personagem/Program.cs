using Aula06_heranca_personagem;

Heroi homemDeFerro = new Heroi();
homemDeFerro.Nome = "Homem de Ferro";
homemDeFerro.Forca = 10;
homemDeFerro.Inteligencia = 90;
homemDeFerro.Lutar();

Vilao thanos = new Vilao();
thanos.Nome = "Thanos";
thanos.Forca = 100;
thanos.Inteligencia = 80;
thanos.Lutar();

SuperHeroi homemAranha = new SuperHeroi();
homemAranha.Nome = "Homem-Aranha";
homemAranha.Forca = 5;
homemAranha.Inteligencia = 70;
homemAranha.Poderes = new string[] { "Agilidade", "Sentido de Aranha" };
homemAranha.Lutar();
homemAranha.SuperPoder();

SuperVilao coringa = new SuperVilao();
coringa.Nome = "Coringa";
coringa.Forca = 1;
coringa.Inteligencia = 90;
coringa.Poderes = new string[] { "Inteligência", "Habilidade em Artes Marciais" };
coringa.Lutar();
coringa.SuperPoder();
