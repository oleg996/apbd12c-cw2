using Microsoft.VisualBasic;

products.init();



List<conteiner_ship> ships = new List<conteiner_ship>();
List<konteiner> konteiners = new List<konteiner>();

Boolean run = true;

while (run){
    try{
    Console.WriteLine("E to exit");
    Console.WriteLine("S to print ship");
    Console.WriteLine("C to print conteiners");

    Console.WriteLine("AC to add conteiner");
    Console.WriteLine("DC to remove conteiner");

    Console.WriteLine("AS to add ship");
    Console.WriteLine("DS to remove ship");

    Console.WriteLine("F to fill conteiner");
    Console.WriteLine("EM to empty conteiner");


    Console.WriteLine("L to load conteiner");
    Console.WriteLine("U to unload conteiner");



    String input = Console.ReadLine();

    switch (input)
    {
        case "E":
            run = false;
        break;

        case "S":
            foreach (conteiner_ship item in ships)
            {
                Console.WriteLine(item);
            }
        break;

        case "C":
            foreach (konteiner item in konteiners)
            {
                Console.WriteLine(item);
            }
        break;

        case "AC":
            Console.WriteLine("L G C");
            switch(Console.ReadLine()){
               case"L":{
               Console.WriteLine("height"); 
               double h = Double.Parse(Console.ReadLine());

               Console.WriteLine("depth"); 
               double d = Double.Parse(Console.ReadLine());

               Console.WriteLine("mass_netto"); 
               double m = Double.Parse(Console.ReadLine());

               Console.WriteLine("is dangerows (Y/N)"); 
               Boolean dang = Console.ReadLine().Equals("Y");

               Console.WriteLine("max_load"); 
               double ml = Double.Parse(Console.ReadLine());


               konteiners.Add(new liquidkonteiner(h,d,m,dang,ml));
               }
               break;     

               case"G":
               {
               Console.WriteLine("height"); 
               double h = Double.Parse(Console.ReadLine());

               Console.WriteLine("depth"); 
               double d = Double.Parse(Console.ReadLine());

               Console.WriteLine("mass_netto"); 
               double m = Double.Parse(Console.ReadLine());

               Console.WriteLine("is dangerows (Y/N)"); 
               Boolean dang = Console.ReadLine().Equals("Y");

               Console.WriteLine("max_load"); 
               double ml = Double.Parse(Console.ReadLine());


               konteiners.Add(new gaskonteiner(h,d,m,dang,ml));
               }
               break; 

               case"C":
               {
               Console.WriteLine("height"); 
               double h = Double.Parse(Console.ReadLine());

               Console.WriteLine("depth"); 
               double d = Double.Parse(Console.ReadLine());

               Console.WriteLine("mass_netto"); 
               double m = Double.Parse(Console.ReadLine());


               Console.WriteLine("max_load"); 
               double ml = Double.Parse(Console.ReadLine());


               Console.WriteLine("product"); 
               string pr = Console.ReadLine();


               Console.WriteLine("temp"); 
               double t = Double.Parse(Console.ReadLine());


               konteiners.Add(new cooledkonteiner(h,d,m,ml,pr,t));
               }
               break; 






               default:
               throw new Exception("Incorect command");
            }
        break;


        case "DC":
                foreach (konteiner item in konteiners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("choose contiener to remove");
            konteiners.RemoveAt(int.Parse(Console.ReadLine()));

        break;
        
        case "AS":
               {
               Console.WriteLine("speed"); 
               double s = Double.Parse(Console.ReadLine());

               Console.WriteLine("max conteiners"); 
               int mc = int.Parse(Console.ReadLine());

               Console.WriteLine("max load"); 
               double ml = Double.Parse(Console.ReadLine());


               ships.Add(new conteiner_ship(s,mc,ml));
               }

        break;

        case "DS":
                foreach (conteiner_ship item in ships)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("choose ship to remove");
            ships.RemoveAt(int.Parse(Console.ReadLine()));

        break;

         case "F":
            {
                 foreach (konteiner item in konteiners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("choose contiener to fill");
            int k =int.Parse(Console.ReadLine());

            if(konteiners[k].GetType().Equals(typeof(cooledkonteiner))){
                Console.WriteLine("product");
                string pr = Console.ReadLine();
                Console.WriteLine("ammount");
                double am = Double.Parse(Console.ReadLine());

                konteiners[k].fill(am,pr);
            }else{
                Console.WriteLine("ammount");
                double am = Double.Parse(Console.ReadLine());

                konteiners[k].fill(am,"");

            }
            }   
        break;

        case "EM":
            {
                 foreach (konteiner item in konteiners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("choose contiener to fill");
            int k =int.Parse(Console.ReadLine());

            konteiners[k].empty();
            }
        break;

        case "L":
            {
                 foreach (konteiner item in konteiners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("choose contiener to load");
            int k =int.Parse(Console.ReadLine());

                foreach (conteiner_ship item in ships)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("choose ship to load onto");
            ships[int.Parse(Console.ReadLine())].load(konteiners[k]);    

            konteiners.RemoveAt(k);


            
            }
        break;


        case "U":
            {
                Console.WriteLine("choose contiener to unload from");
            foreach (conteiner_ship item in ships)
            {
                Console.WriteLine(item);
            }
            conteiner_ship ship = ships[int.Parse(Console.ReadLine())];

            Console.WriteLine(ship);

            Console.WriteLine("choose contiener to uload");
            foreach (konteiner item in konteiners)
            {
                Console.WriteLine(item);
            }
            
            int k =int.Parse(Console.ReadLine());
            konteiners.Add(ship.unload(k));


            
            }
        break;






        
        default:
        throw new Exception("Incorect command");
        break;
    }

    }
    catch (Exception e){

        Console.WriteLine("error:"+e.Message);
    }











}













