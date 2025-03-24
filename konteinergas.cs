using System;
using System.ComponentModel;

public class gaskonteiner: konteiner ,notification_int { 
    
    Boolean dang  = false;

    double presure = 0;

    public gaskonteiner (double height,double depth,double mass_netto,Boolean dang,double max_load):base(height,depth,mass_netto){
        this.dang = dang;
        this.max_load = max_load;
        S_number += "-G-";
        S_number += konteiner.S_number_g++;
    }


    public override void fill(double am,string product){
        if(mass + am > max_load){
            throw new OverfillException();
        }

        mass += am;
    }

    public override void empty()
    {
        mass = mass * 0.05;
    }

    public void send_msg(string msg,string product)
    {
        Console.WriteLine("WARNING THE CONTEINER "+ S_number + " HAS "+ msg);
    }

    public override string ToString()
    {
        return base.ToString()+(dang?"Dangerows!!":"");
    }
}