using System;
using System.ComponentModel;

public class liquidkonteiner: konteiner ,notification_int { 
    
    Boolean dang  = false;

    public liquidkonteiner (double height,double depth,double mass_netto,Boolean dang,double max_load):base(height,depth,mass_netto){
        this.dang = dang;
        this.max_load = max_load;
        S_number += "-L-";
        S_number += konteiner.S_number_g++;
    }


    public override void fill(double am,string product){
        if(dang && mass + am > max_load*0.5){
            throw new OverfillException();
        }


        if(mass + am > max_load*0.9){
            throw new OverfillException();
        }

        mass += am;
    }

    public void send_msg(string msg)
    {
        Console.WriteLine("WARNING THE CONTEINER "+ S_number + " HAS "+ msg);
    }
    public override string ToString()
    {
        return base.ToString()+(dang?"Dangerows!!":"");
    }
}