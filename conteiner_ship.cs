using System.Collections;

public class conteiner_ship{

    private List<konteiner> konteiners = new List<konteiner>();

    double speed = 0;
    int max_conteiners = 0;

    double max_load = 0;


    public conteiner_ship(double speed,int max_conteiners, double max_load){
        this.speed = speed;
        this.max_conteiners = max_conteiners;
        this.max_load = max_load;

    }
    

    public void load (konteiner k ){
        if(konteiners.Count + 1 > max_conteiners)
            throw new Exception("not enough free space");
        
        double kmass = k.getMass();
        foreach(konteiner lk in konteiners){
            kmass += lk.getMass();
        }
        if(kmass > max_load)
            throw new Exception("overload");
        
        konteiners.Add(k);

    }

    public konteiner unload(int i){
        konteiner k = konteiners[i];
        konteiners.RemoveAt(i);
        return k;
    }




    public override string ToString()
    {
        string str = "ship max conteiners:"+max_conteiners+"spped:"+speed+"max load:"+max_load+'\n';

        foreach (konteiner k in konteiners)
        {
            str += k.ToString();
            str+= "\n";
        }
        return str;
    }






}