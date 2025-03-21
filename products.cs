public static class products{
    static Dictionary<string,double> temperature = new Dictionary<string, double>();

    public static void init(){
        temperature.Add("bananas",13.3);

        temperature.Add("liquid N2",-197);


    }

    public static double find(string prod){


        return temperature[prod];
    }



}