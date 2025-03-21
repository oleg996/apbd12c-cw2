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

}