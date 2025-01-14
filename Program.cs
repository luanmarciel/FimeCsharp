Colecao colecaoDaMarvel = new Colecao();
colecaoDaMarvel.Nome = "Universo cinematográfico";

Filme filme1 = new Filme();
filme1.Nome = "Os vingadores";
filme1.Duracao = 5600;

Filme filme2 = new Filme();
filme2.Nome = "Spider Man";
filme2.Duracao = 3600;

colecaoDaMarvel.AdcionarFilme(filme1);
colecaoDaMarvel.AdcionarFilme(filme2);

colecaoDaMarvel.ExibirFilmesDaColecao();