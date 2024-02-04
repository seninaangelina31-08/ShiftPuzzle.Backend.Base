namespace Practice_A;



    public class CoindeskResponse // основной класс для десериализации
    {
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public Bpi bpi { get; set; }
    }

     public class Bpi // ниже второстепенные классы, объекты которых вложенны в основной CoindeskResponse (а также друг в друга)
    {
        public USD USD { get; set; }
        public GBP GBP { get; set; }
        public EUR EUR { get; set; }
    }

    public class EUR
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

    public class GBP
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

   

    public class Time
    {
        public string updated { get; set; }
        public DateTime updatedISO { get; set; }
        public string updateduk { get; set; }
    }

    public class USD
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }


    public class RandomCatFact
    {
        public string fact { get; set; }
        public int length {get; set;}

        public RandomCatFact() {}
    }

    public class FunnyJoke
    {
        public string type {get; set;}
        public string setup {get; set;}
        public string punchline {get; set;}
        public int id {get; set;}
        public FunnyJoke() {}
    }
 
    public class World_University
    {
        public string name { get; set; }
        public string country { get; set; }
        public World_University() {}
    }
