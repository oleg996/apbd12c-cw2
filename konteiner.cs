using System; 
public class konteiner{

   protected double mass = 0;
   protected double height = 0;

   protected double mass_netto = 0;

   protected double max_load = 0;

   protected double depth = 0;

   protected string S_number= "KON";


   public static int S_number_g = 0;


    public konteiner(double height,double depth,double mass_netto){
       this.height = height;
       this.depth = depth;
       this.mass_netto = mass_netto;
        
    }

    public virtual void empty(){
        mass = 0;
    }

    public virtual void fill(double am,string product){

        if(mass + am > max_load){
            throw new OverfillException();
        }
    }
    public double getMass(){
        return mass;
    }


}