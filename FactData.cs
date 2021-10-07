using System.Collections.Generic;

namespace sampleFactCsharp
{
    public class FactData
    {
        /// <summary>
        /// Holds locale based arrays of space facts and other information
        /// </summary>
        /// <param name="locale"></param>
        /// <returns>factdata for the locale</returns>
        public FactData(string locale)
        {
            this.Locale = locale;
            this.Facts = new List<string>();
            this.Jokes = new List<string>();
            this.Vehicles = new Dictionary<string, Vehicle>();
            this.Planets = new Dictionary<string, Planet>();
         }

        public string Locale { get; set; }
        public string SkillName { get; set; }
        public List<string> Facts { get; set; }
        public List<string> Jokes { get; set; }
        public Dictionary<string, Vehicle> Vehicles { get; set; }
        public Dictionary<string, Planet> Planets { get; set; }
        public string GetFactMessage { get; set; }
        public string HelpMessage { get; set; }
        public string HelpReprompt { get; set; }
        public string StopMessage { get; set; }
        public string LaunchMessage { get; set; }
        public string LaunchMessageReprompt { get; set; }
        public string AskMessage { get; set; }

        /// <summary>
        ///  Load the resources into the resourse array for processing
        /// </summary>
        /// <returns>void</returns>
        public static List<FactData> LoadFacts()
        {
            List<FactData> facts = new List<FactData>();


            /* ITA */

            FactData factIT = new FactData("it-IT");

            factIT.SkillName = "Spacey Annalisa Test";
            factIT.GetFactMessage = "C'è una cosa interessante: ";
            factIT.HelpMessage = "come ti posso aiutare?? mi puoi chiedere space fact,travel time between two planets," +
                "the weather on a planet, oppure, chiedimi di raccontarti un  joke, o, puoi dire exit...come ti posso aiutare?";
            factIT.HelpReprompt = "come ti posso aiutare?";
            factIT.StopMessage = "ciao ciao!";
            factIT.LaunchMessage = "Benvenuto a Spacey. conosco fatti riguardo lo spazio,quanto è lungo il viaggio tra due pianeti how long it takes to travel between " +
                "il meteo di dove vuoi andare, e conosco persino un joke.  cosa vuoi sapere?";
            factIT.LaunchMessageReprompt = " prova a chiedermi di raccontarti qualcosa sullo spazio";
            factIT.AskMessage = " cos'altro vuoi sapere?";

            factIT.Facts.Add(" un anno si Mercurio è lungo 88 giorni");
            factIT.Facts.Add(" nonostante sia lontano dal sole Venere ha una temperatura più alta di mercurio");
            factIT.Facts.Add(" Venere ruota in senso antiorario, forse a causa di una collisione avvenuta in passato con un asteroide.");
            factIT.Facts.Add(" Su Marte, il sole appare per metà della grandezza che vediamo sulla terra");
            factIT.Facts.Add("La Terra è l'unico pianeta non nominato da un Dio");
            factIT.Facts.Add("Giove ha il giorno più corto di tutti i pianeti");
            factIT.Facts.Add("La Galassia della Via Lattea colliderà con la galassia Andromeda tra cinque bilioni di anni");
            factIT.Facts.Add("Il Sole contiene 99.86%  di massa di tutto il sistema solare.");
            factIT.Facts.Add("Il sole è circa una sfera perfetta");
            factIT.Facts.Add("Un'eclisse totale di sole avviene circa ogni 1 o 2 anni. Questo la rende un evento raro");
            factIT.Facts.Add("Saturno irradia due volte e mezzo più energia nello spazio rispetto a quella che riceve da sole.");
            factIT.Facts.Add("La temperatura all'interno del solepuò raggiungere 15 milioni di gradi celsius");
            factIT.Facts.Add("La luna si muove approssimativamente 3.8cm dal nostro pianeta ogni anno");

            factIT.Jokes.Add(" qual'è il cioccolato preferito di un uomo dello spazio? <break time=\"1s\"/>A marsbar!");
            factIT.Jokes.Add(" Quale tipo di musica cantano i pianeti? <break time=\"1s\"/>Neptunes!'");
            
            factIT.Vehicles.Add("auto", new Vehicle("65", "in mauto"));
            factIT.Vehicles.Add("jet", new Vehicle("500", "in jetliner"));
            factIT.Vehicles.Add("concorde", new Vehicle("1350", "in Concorde"));
            factIT.Vehicles.Add("rocket", new Vehicle("11250", "da rocket"));
            factIT.Vehicles.Add("light", new Vehicle("670616629", " alla velocità della luce"));

            factIT.Planets.Add("Mercurio", new Planet("36", " high of 840 and massimo 275 gradi fahrenheit. Nothing but sun.", "Mercury"));
            factIT.Planets.Add("Venere", new Planet("67.2", " high and low of 870 gradi fahrenheit. Expect thick cloud cover <break time=\"1s\"/> forever.", "Venus"));
            factIT.Planets.Add("Terra", new Planet("93", " high of 136 and massimo 129 gradi fahrenheit. Anything can happen on this planet.", "Earth"));
            factIT.Planets.Add("Marte", new Planet("141.6", " high of 70 and massimo 195 gradi fahrenheit. Sunny with a chance of sandstorms later in the day.", "Mars"));
            factIT.Planets.Add("Giove", new Planet("483.6", " minimo 148 and massimo 234 gradi fahrenheit. Storms are highly likely, bringing heavy rain and high winds.", "Jupiter"));
            factIT.Planets.Add("Saturno", new Planet("886.7", " high of 134 and massimo 288 gradi fahrenheit. Cloudy with a chance of super storm.", "Saturn"));
            factIT.Planets.Add("Urano", new Planet("1784", " high and massimo 357 gradi fahrenheit. Cloudy with a chance of storms.", "Uranus"));
            factIT.Planets.Add("Nettuno", new Planet("2794.4", " minimo 328 and massimo 360 gradi fahrenheit. Extreme wind and a change of storms.", "Neptune"));
            factIT.Planets.Add("Plutone", new Planet("3674.5", " minimo 387 and massimo 396 gradi fahrenheit. Snow is expected.", "Pluto"));


            facts.Add(factIT);


            /*EN-US*/
            FactData factUS = new FactData("en-US");

     
            factUS.SkillName = "Spacey";
            factUS.GetFactMessage = "Here's an interesting one: ";
            factUS.HelpMessage = "You can say tell me a space fact, ask me for the travel time between two planets,"+ 
                "the weather on a planet, or, ask me to tell a joke, or, you can say exit...What can I help you with ?";
            factUS.HelpReprompt = "What can I help you with?";
            factUS.StopMessage = "Goodbye!";
            factUS.LaunchMessage = "Welcome to Spacey. I know facts about space, how long it takes to travel between "+
                "two planets, the weather when you get there, and I even know a joke. What would you like to know?";
            factUS.LaunchMessageReprompt = "Try asking me to tell you something about space.";
            factUS.AskMessage = " what else would you like to know?";

            factUS.Facts.Add("A year on Mercury is just 88 days long.");
            factUS.Facts.Add("Despite being farther from the Sun, Venus experiences higher temperatures than Mercury.");
            factUS.Facts.Add("Venus rotates counter-clockwise, possibly because of a collision in the past with an asteroid.");
            factUS.Facts.Add("On Mars, the Sun appears about half the size as it does on Earth.");
            factUS.Facts.Add("Earth is the only planet not named after a god.");
            factUS.Facts.Add("Jupiter has the shortest day of all the planets.");
            factUS.Facts.Add("The Milky Way galaxy will collide with the Andromeda Galaxy in about 5 billion years.");
            factUS.Facts.Add("The Sun contains 99.86% of the mass in the Solar System.");
            factUS.Facts.Add("The Sun is an almost perfect sphere.");
            factUS.Facts.Add("A total solar eclipse can happen once every 1 to 2 years. This makes them a rare event.");
            factUS.Facts.Add("Saturn radiates two and a half times more energy into space than it receives from the sun.");
            factUS.Facts.Add("The temperature inside the Sun can reach 15 million degrees Celsius.");
            factUS.Facts.Add("The Moon is moving approximately 3.8 cm away from our planet every year.");
         
            factUS.Jokes.Add("What is a spaceman’s favorite chocolate? <break time=\"1s\"/>A marsbar!");
            factUS.Jokes.Add("What kind of music do planets sing? <break time=\"1s\"/>Neptunes!'");
            factUS.Jokes.Add("What do aliens on the metric system say? <break time=\"1s\"/>Take me to your liter."); 
            factUS.Jokes.Add("Why did the people not like the restaurant on the moon? <break time=\"1s\"/>Because there was no atmosphere."); 
            factUS.Jokes.Add("I’m reading a book about anti-gravity. <break time=\"1s\"/>It’s impossible to put down!"); 
            factUS.Jokes.Add("How many ears does Captain Kirk have? <break time=\"1s\"/>Three. A left ear, a right ear, and a final frontier!"); 
            factUS.Jokes.Add("What did Mars say to Saturn? <break time=\"1s\"/>Give me a ring sometime!'");

            factUS.Vehicles.Add("car", new Vehicle("65", "in a car"));
            factUS.Vehicles.Add("jet", new Vehicle("500", "in a jetliner"));
            factUS.Vehicles.Add("concorde", new Vehicle("1350", "in a Concorde"));
            factUS.Vehicles.Add("rocket", new Vehicle("11250", "by rocket"));
            factUS.Vehicles.Add("light", new Vehicle("670616629", "at the speed of light"));

            factUS.Planets.Add("mercury", new Planet("36", "high of 840 and low of minus 275 fahrenheit. Nothing but sun.", "Mercury"));
            factUS.Planets.Add("venus", new Planet("67.2", "high and low of 870 fahrenheit. Expect thick cloud cover <break time=\"1s\"/> forever.", "Venus"));
            factUS.Planets.Add("earth", new Planet("93", "high of 136 and low of minus 129 fahrenheit. Anything can happen on this planet.","Earth"));
            factUS.Planets.Add("mars", new Planet("141.6", "high of 70 and low of minus 195 fahrenheit. Sunny with a chance of sandstorms later in the day.", "Mars"));
            factUS.Planets.Add("jupiter", new Planet("483.6", "high of minus 148 and low of minus 234 fahrenheit. Storms are highly likely, bringing heavy rain and high winds.", "Jupiter"));
            factUS.Planets.Add("saturn", new Planet("886.7", "high of 134 and low of minus 288 fahrenheit. Cloudy with a chance of super storm.", "Saturn"));
            factUS.Planets.Add("uranus", new Planet("1784", "high and low of minus 357 fahrenheit. Cloudy with a chance of storms.", "Uranus"));
            factUS.Planets.Add("neptune", new Planet("2794.4", "high of minus 328 and low of minus 360 fahrenheit. Extreme wind and a change of storms.", "Neptune"));
            factUS.Planets.Add("pluto", new Planet("3674.5", "high of minus 387 and low of minus 396 fahrenheit. Snow is expected.", "Pluto"));
            
            facts.Add(factUS);
            
            /*en-GB*/
            FactData factGB = new FactData("en-GB");

            factGB.SkillName = "Spacey";
            factGB.GetFactMessage = "Here's an interesting one: ";
            factGB.HelpMessage = "You can say tell me a space fact, ask me for the travel time between two planets," +
              "the weather on a planet, or, ask me to tell a joke, or, you can say exit...What can I help you with ?";
            factGB.HelpReprompt = "What can I help you with?";
            factGB.StopMessage = "Goodbye!";
            factGB.LaunchMessage = "Welcome to Spacey. I know facts about space, how long it takes to travel between two planets, "+
                "their weather, and I even know a joke. What would you like to know?";
            factGB.LaunchMessageReprompt = "Try asking me to tell you something about space.";
            factGB.AskMessage = " what else would you like to know?";

            factGB.Facts.Add("A year on Mercury is just 88 days long.");
            factGB.Facts.Add("Despite being farther from the Sun, Venus experiences higher temperatures than Mercury.");
            factGB.Facts.Add("Venus rotates counter-clockwise, possibly because of a collision in the past with an asteroid.");
            factGB.Facts.Add("On Mars, the Sun appears about half the size as it does on Earth.");
            factGB.Facts.Add("Earth is the only planet not named after a god.");
            factGB.Facts.Add("Jupiter has the shortest day of all the planets.");
            factGB.Facts.Add("The Milky Way galaxy will collide with the Andromeda Galaxy in about 5 billion years.");
            factGB.Facts.Add("The Sun contains 99.86% of the mass in the Solar System.");
            factGB.Facts.Add("The Sun is an almost perfect sphere.");
            factGB.Facts.Add("A total solar eclipse can happen once every 1 to 2 years. This makes them a rare event.");
            factGB.Facts.Add("Saturn radiates two and a half times more energy into space than it receives from the sun.");
            factGB.Facts.Add("The temperature inside the Sun can reach 15 million degrees Celsius.");
            factGB.Facts.Add("The Moon is moving approximately 3.8 cm away from our planet every year.");

            factGB.Jokes.Add("What is a spaceman’s favorite chocolate? <break time=\"1s\"/>A marsbar!");
            factGB.Jokes.Add("What kind of music do planets sing? <break time=\"1s\"/>Neptunes!'");
            factGB.Jokes.Add("What do aliens on the metric system say? <break time=\"1s\"/>Take me to your liter.");
            factGB.Jokes.Add("Why did the people not like the restaurant on the moon? <break time=\"1s\"/>Because there was no atmosphere.");
            factGB.Jokes.Add("I’m reading a book about anti-gravity. <break time=\"1s\"/>It’s impossible to put down!");
            factGB.Jokes.Add("How many ears does Captain Kirk have? <break time=\"1s\"/>Three. A left ear, a right ear, and a final frontier!");
            factGB.Jokes.Add("What did Mars say to Saturn? <break time=\"1s\"/>Give me a ring sometime!'");

            factGB.Vehicles.Add("car", new Vehicle("65", "in a car"));
            factGB.Vehicles.Add("jet", new Vehicle("500", "in a jetliner"));
            factGB.Vehicles.Add("concorde", new Vehicle("1350", "in a Concorde"));
            factGB.Vehicles.Add("rocket", new Vehicle("11250", "by rocket"));
            factGB.Vehicles.Add("light", new Vehicle("670616629", "at the speed of light"));

            factGB.Planets.Add("mercury", new Planet("36", "high of 840 and low of minus 275 fahrenheit. Nothing but sun.", "Mercury"));
            factGB.Planets.Add("venus", new Planet("67.2", "high and low of 870 fahrenheit. Expect thick cloud cover <break time=\"1s\"/> forever.", "Venus"));
            factGB.Planets.Add("earth", new Planet("93", "high of 136 and low of minus 129 fahrenheit. Anything can happen on this planet.", "Earth"));
            factGB.Planets.Add("mars", new Planet("141.6", "high of 70 and low of minus 195 fahrenheit. Sunny with a chance of sandstorms later in the day.", "Mars"));
            factGB.Planets.Add("jupiter", new Planet("483.6", "high of minus 148 and low of minus 234 fahrenheit. Storms are highly likely, bringing heavy rain and high winds.", "Jupiter"));
            factGB.Planets.Add("saturn", new Planet("886.7", "high of 134 and low of minus 288 fahrenheit. Cloudy with a chance of super storm.", "Saturn"));
            factGB.Planets.Add("uranus", new Planet("1784", "high and low of minus 357 fahrenheit. Cloudy with a chance of storms.", "Uranus"));
            factGB.Planets.Add("neptune", new Planet("2794.4", "high of minus 328 and low of minus 360 fahrenheit. Extreme wind and a change of storms.", "Neptune"));
            factGB.Planets.Add("pluto", new Planet("3674.5", "high of minus 387 and low of minus 396 fahrenheit. Snow is expected.", "Pluto"));

            facts.Add(factGB);
            return facts;
        }
    }

    //Classes included here for readablity  
    public class Vehicle
    {
        public Vehicle(string _speed, string _type)
        {
            Speed = _speed;
            VehicleType = _type;
        }
        public string Speed {get;set;}
        public string VehicleType { get;set;}
        public float ftSpeed { get { return float.Parse(Speed); } }
    }

    public class Planet
    {
        public Planet(string _distance, string _weather, string _printname)
        {
            DistanceFromSun = _distance;
            Weather = _weather;
            PrintName = _printname;
        }

        public string DistanceFromSun {get;set;}
        public string Weather { get;set; }
        public string PrintName {get;set;}
        public float ftDistanceFromSun { get { return float.Parse(DistanceFromSun); }  }
        }
    }
