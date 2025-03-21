products.init();

cooledkonteiner cooledkonteiner = new cooledkonteiner(100,100,100,100,"liquid N2",-200);


cooledkonteiner.fill(100,"liquid N2");


conteiner_ship conteiner_Ship = new conteiner_ship(1,2,1000);

conteiner_Ship.load(cooledkonteiner);


conteiner_Ship.load(new liquidkonteiner(100,100,1,true,100));


Console.WriteLine(conteiner_Ship);

Console.WriteLine(conteiner_Ship.unload(1));

Console.WriteLine(conteiner_Ship);













