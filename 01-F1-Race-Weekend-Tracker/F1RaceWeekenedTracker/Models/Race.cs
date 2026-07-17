using System;
public class Race
{
    public enum RaceType
        {
            Sprint,
            Main
        }
    public enum SessionType {
        Practice,
        Qualifying,
        Sprint,
        Main

    }

    
    public int RoundNumber { get; set; }
    public Circuit Circuit { get; set; } = new Circuit();// refence to Circuit
    //property use peoperties over fields for more flexibility
    public RaceType raceType { get; set; }
    public SessionType[] Sessions { get; set; }
    public int NumberOfLaps { get; set; }
    public DateTime RaceDate { get; set; }



}
