using System;
using System.ComponentModel;

public class cooledkonteiner: konteiner { 
    
    String product;

    double temperature = 0;


    public cooledkonteiner (double height,double depth,double mass_netto,double max_load,string product,double temperature):base(height,depth,mass_netto){
        if(temperature > products.find(product))
        throw new Exception ("too low temp");
        
        
        this.max_load = max_load;
        S_number += "-CA-";
        S_number += konteiner.S_number_g++;

        this.product = product;

        this.temperature = temperature;


    }


    public override void fill(double am,string product){
        if(!product.Equals(this.product))
        throw new Exception("Not same product");


        if(mass + am > max_load){
            throw new OverfillException();
        }

        mass += am;
    }

    public override string ToString()
    {
        return base.ToString()+" product:"+product+"temp:"+temperature;
    }
}