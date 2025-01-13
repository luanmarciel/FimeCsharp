Filme filme1 = new Filme();
filme1.Nome = "Avangers";
filme1.Artista = "Marvel";
filme1.Duracao = 1895;
filme1.Disponivel = true;
System.Console.WriteLine(filme1.DescricaoResumida);

Filme filme2 = new Filme();
filme2.Nome = "Spider Man";
filme2.Artista = "Marvel";
filme2.Duracao = 2019;
filme2.Disponivel = false;

filme1.ExibirFichaTecnica();
filme2.ExibirFichaTecnica();